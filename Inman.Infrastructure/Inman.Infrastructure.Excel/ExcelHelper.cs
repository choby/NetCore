using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

using ImageResizer;
using Inman.Infrastructure.Common.Extensions;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using System.Data;
using System.Reflection;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Microsoft.AspNetCore.Http;
using Inman.Infrastructure.IOC;

namespace Inman.Infrastructure.Excel
{
    public partial class ExcelHelper
    {

        /// <summary>
        /// 初始化
        /// </summary>
        public static XSSFWorkbook InitializeWorkbook()
        {
            XSSFWorkbook _XSSFWorkbook = new XSSFWorkbook();

            //  DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            //  dsi.Company = "";
            //((HSSFWorkbook) _XSSFWorkbook).DocumentSummaryInformation = dsi;

            //  SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            //  si.Subject = "";
            //  _XSSFWorkbook.SummaryInformation = si;

            return _XSSFWorkbook;
        }

        /// <summary>
        /// DataTable写入Excel
        /// </summary>
        /// <param name="fileName">要保存的文件名称 eg:test.xls</param>
        /// <param name="sheetName">工作薄名称</param>
        /// <param name="dt">要写入的DataTable </param>
        public static void WriteToDownLoad(string fileName, string sheetName, DataTable dt)
        {
            if (fileName == null) throw new ArgumentNullException("fileName");
            string filename = fileName;
            var httpContextAccessor = EngineContext.Current.GetService<IHttpContextAccessor>();
            var httpContext = httpContextAccessor.HttpContext;
            httpContext.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            httpContext.Response.Headers.Add("Content-Disposition", string.Format("attachment;filename={0}", filename));
            httpContext.Response.Clear();

            //初始化Excel信息
            XSSFWorkbook workbook = InitializeWorkbook();

            //填充数据
            DTExcel(sheetName, dt, null, workbook);
            var excelFile = WriteToStream(workbook);
            //httpContext.Response.BinaryWrite(excelFile.ToArray());
            //if (HttpContext.Current.Response.IsClientConnected)
            //{
            //    httpContext.Response.Flush();
            //    httpContext.Response.End();
            //}
            httpContext.Response.Body = excelFile;
            httpContext.Response.Headers.Add("Content-Length", excelFile.ToArray().Length.ToString());
            httpContext.Response.SendFileAsync(filename);
            
        }

        /// <summary>
        /// List写入Excel
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="fileName">要保存的文件名称 eg:test.xls</param>
        /// <param name="sheetName">工作薄名称</param>
        /// <param name="lst">要写入的List</param>
        /// <param name="listTile">实体中需要的列名（默认为所有）</param>
        public static void WriteToDownLoad<T>(string fileName, string sheetName, List<T> lst, List<string> listTile = null)
        {
            string filename = fileName;
            var httpContextAccessor = EngineContext.Current.GetService<IHttpContextAccessor>();
            var httpContext = httpContextAccessor.HttpContext;
            httpContext.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            httpContext.Response.Headers.Add("Content-Disposition", string.Format("attachment;filename={0}", filename));
            httpContext.Response.Clear();

            //初始化Excel信息
            XSSFWorkbook workbook = InitializeWorkbook();

            //填充数据
            if (sheetName != null) ListExcel(sheetName, lst, listTile, workbook);

            //httpContext.Response.BinaryWrite(WriteToStream(workbook).ToArray());
            //if (HttpContext.Current.Response.IsClientConnected)
            //{
            //    httpContext.Response.Flush();
            //    httpContext.Response.End();
            //}
            var excelFile = WriteToStream(workbook);
            httpContext.Response.Body = excelFile;
            httpContext.Response.Headers.Add("Content-Length", excelFile.ToArray().Length.ToString());
            httpContext.Response.SendFileAsync(filename);
        }

        public static DataTable ReadToDataTable(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                return ReadToDataTable(stream);
            }
        }

        public static DataTable ReadToDataTable(Stream stream)
        {
            DataTable dtResult = new DataTable();

            XSSFWorkbook workbook = new XSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheetAt(0);
            //获取sheet的首行
            IRow headerRow = sheet.GetRow(0);
            for (int i = headerRow.FirstCellNum; i < headerRow.LastCellNum; i++)
            {
                DataColumn column = new DataColumn(headerRow.GetCell(i).StringCellValue);
                dtResult.Columns.Add(column);
            }
            for (int i = (sheet.FirstRowNum + 1); i < (sheet.LastRowNum + 1); i++)
            {

                IRow row = sheet.GetRow(i);
                if (row == null) throw new Exception("读取excel出错了没有获取到数据");
                DataRow dataRow = dtResult.NewRow();
                bool allColumnIsNull = true;
                string strTamp = string.Empty;
                for (int j = row.FirstCellNum; j < headerRow.LastCellNum; j++)
                {
                    var cell = row.GetCell(j);
                    if (cell != null)
                    {
                        switch (cell.CellType)
                        {
                            case CellType.Blank: //空数据类型处理
                                dataRow[j] = "";
                                break;
                            case CellType.String: //字符串类型
                                strTamp = cell.StringCellValue.Trim();
                                dataRow[j] = strTamp;
                                allColumnIsNull = string.IsNullOrEmpty(strTamp);
                                break;
                            case CellType.Numeric: //数字类型                                   
                                if (HSSFDateUtil.IsCellDateFormatted(cell))
                                {
                                    dataRow[j] = cell.DateCellValue;
                                }
                                else
                                {
                                    dataRow[j] = cell.NumericCellValue;
                                }
                                allColumnIsNull = false;
                                break;
                            case CellType.Formula:
                                HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(sheet.Workbook);
                                dataRow[j] = e.Evaluate(cell).StringValue;
                                allColumnIsNull = false;
                                break;
                            default:
                                dataRow[j] = "";
                                break;
                        }
                    }
                }
                if (!allColumnIsNull)
                    dtResult.Rows.Add(dataRow);
            }

            return dtResult;
        }

        public static DataTable ReadToDataTable(Stream stream,
                                         int sheetIndex,
                                         int firstRowNum = 0,
                                         int firstCellNum = 0,
                                         int lastCellNum = 0)
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("序号");

            ISheet sheet = new XSSFWorkbook(stream).GetSheetAt(sheetIndex);
            firstRowNum = firstRowNum == 0 ? sheet.FirstRowNum : firstRowNum;
            int lastRowRum = sheet.LastRowNum;
            //获取sheet的首行
            IRow headerRow = sheet.GetRow(firstRowNum);
            firstCellNum = firstCellNum == 0 ? headerRow.FirstCellNum : firstCellNum;
            lastCellNum = lastCellNum == 0 ? headerRow.LastCellNum : lastCellNum;
            for (int i = firstCellNum; i <= lastCellNum; i++)
            {
                dtResult.Columns.Add(headerRow.GetCell(i).StringCellValue);
            }

            for (int i = (firstRowNum + 1); i <= lastRowRum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null)
                    throw new Exception(string.Format("读取第[{0}]行数据出错.", i));

                DataRow dataRow = dtResult.NewRow();
                bool allColumnIsNull = true;
                string strTamp = string.Empty;
                dataRow[0] = row.RowNum.ToString(CultureInfo.InvariantCulture);
                for (int j = firstCellNum; j <= lastCellNum; j++)
                {
                   
                    var cell = row.GetCell(j);
                    if (cell != null)
                    {
                        switch (cell.CellType)
                        {
                            case CellType.Blank: //空数据类型处理
                                dataRow[j+1] = "";
                                break;
                            case CellType.String: //字符串类型
                                strTamp = cell.StringCellValue.Trim();
                                dataRow[j + 1] = strTamp;
                                allColumnIsNull = string.IsNullOrEmpty(strTamp);
                                break;
                            case CellType.Numeric: //数字类型                                   
                                if (HSSFDateUtil.IsCellDateFormatted(cell))
                                {
                                    dataRow[j + 1] = cell.DateCellValue;
                                }
                                else
                                {
                                    dataRow[j + 1] = cell.NumericCellValue;
                                }
                                allColumnIsNull = false;
                                break;
                            case CellType.Formula:
                                HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(sheet.Workbook);
                                dataRow[j + 1] = e.Evaluate(cell).StringValue;
                                allColumnIsNull = false;
                                break;
                            default:
                                dataRow[j + 1] = "";
                                break;
                        }
                    }
                }
                if (!allColumnIsNull)
                    dtResult.Rows.Add(dataRow);
            }
            return dtResult;
        }

        public static byte[] ConvertToExcelByte<T>(string sheetName, IList<T> data, List<ExcelColumnBase<T>> columns)
        {
            XSSFWorkbook workbook = InitializeWorkbook();
            if (sheetName != null)
            { ListExcel(sheetName, data, columns, workbook); }

            return WriteToStream(workbook).ToArray();
        }

        public static byte[] ConvertToExcelByte<T>(string sheetName, IList<T> data, Action<ExcelBuilder<T>> excelBuilder)
        {
            var excel = new Excel<T>();
            excelBuilder(new ExcelBuilder<T>(excel));

            var config = excel.Columns.Where(p => p.Visible).ToList();
            return ConvertToExcelByte(sheetName, data, config);
        }

        public static MemoryStream WriteToStream(XSSFWorkbook workbook)
        {
            var file = new MemoryStream();
            workbook.Write(file);
            file.Flush();
            return file;
        }

        /// <summary>
        /// DataTable写入Excel
        /// </summary>
        /// <param name="sheetName">工作薄名称</param>
        /// <param name="data"></param>
        public static byte[] ConvertToExcelByte(string sheetName, DataTable data)
        {
            //初始化Excel信息
            XSSFWorkbook workbook = InitializeWorkbook();

            //填充数据
            DTExcel(sheetName, data, null, workbook);

            return WriteToStream(workbook).ToArray();
        }

        #region 数据填充部分

        /// <summary>
        /// 将DataTable数据写入到Excel
        /// </summary>
        /// <param name="sheetName"></param>
        /// <param name="dt"></param>
        /// <param name="lstTitle"></param>
        /// <param name="workbook"></param>
        static void DTExcel(string sheetName, DataTable dt, IList<string> lstTitle, XSSFWorkbook workbook)
        {
            XSSFWorkbook _XSSFWorkbook = workbook;

            ISheet sheet1 = _XSSFWorkbook.CreateSheet(sheetName);
            int y = dt.Columns.Count;
            int x = dt.Rows.Count;

            //给定的标题为空,赋值datatable默认的列名
            if (lstTitle == null)
            {
                lstTitle = new List<string>();
                for (int ycount = 0; ycount < y; ycount++)
                { lstTitle.Add(dt.Columns[ycount].Caption); }
            }

            IRow hsTitleRow = sheet1.CreateRow(0);
            //标题赋值
            for (int yt = 0; yt < lstTitle.Count; yt++)
            { hsTitleRow.CreateCell(yt).SetCellValue(lstTitle[yt]); }

            ICellStyle dateStyle = workbook.CreateCellStyle();
            IDataFormat format = workbook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            //填充数据项
            for (int xcount = 0; xcount < x; xcount++)
            {
                IRow hsBodyRow = sheet1.CreateRow(xcount + 1);

                for (int ycBody = 0; ycBody < y; ycBody++)
                {
                    var newCell = hsBodyRow.CreateCell(ycBody);//.SetCellValue(dt.DefaultView[xcount][ycBody].ToString());
                    switch (dt.Columns[ycBody].DataType.ToString())
                    {
                        case "System.String"://字符串类型
                            newCell.SetCellValue(dt.DefaultView[xcount][ycBody]?.ToString());
                            break;
                        case "System.DateTime"://日期类型
                            DateTime dateV;
                            DateTime.TryParse(dt.DefaultView[xcount][ycBody]?.ToString(), out dateV);
                            if ((new DateTime()).Date == dateV)
                            {
                                newCell.SetCellValue("");
                            }
                            else
                            {
                                newCell.SetCellValue(dateV);
                                newCell.CellStyle = dateStyle;
                            }
                            break;
                        case "System.Boolean"://布尔型
                            bool boolV = false;
                            bool.TryParse(dt.DefaultView[xcount][ycBody]?.ToString(), out boolV);
                            newCell.SetCellValue(boolV);
                            break;
                        case "System.Int16"://整型
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intV = 0;
                            int.TryParse(dt.DefaultView[xcount][ycBody]?.ToString(), out intV);
                            newCell.SetCellValue(intV);
                            break;
                        case "System.Decimal"://浮点型
                        case "System.Double":
                            double doubV = 0;
                            double.TryParse(dt.DefaultView[xcount][ycBody]?.ToString(), out doubV);
                            newCell.SetCellValue(doubV);
                            break;
                        case "System.DBNull"://空值处理
                            newCell.SetCellValue("");
                            break;
                        default:
                            newCell.SetCellValue("");
                            break;
                    }

                }
            }

        }

        static void ListExcel<T>(string sheetName, IList<T> lst, IList<string> lstTitle, XSSFWorkbook workbook)
        {
            XSSFWorkbook _XSSFWorkbook = workbook;

            ISheet sheet1 = _XSSFWorkbook.CreateSheet(sheetName);

            T _t = (T)Activator.CreateInstance(typeof(T));
            PropertyInfo[] propertys = _t.GetType().GetProperties();

            //给定的标题为空,赋值T默认的列名
            if (lstTitle == null)
            {
                lstTitle = propertys.Select(t => t.Name).ToList();
            }

            IRow hsTitleRow = sheet1.CreateRow(0);
            //标题赋值
            for (int yt = 0; yt < lstTitle.Count; yt++)
            {
                hsTitleRow.CreateCell(yt).SetCellValue(lstTitle[yt]);
            }

            //填充数据项
            for (int xcount = 0; xcount < lst.Count; xcount++)
            {
                IRow hsBodyRow = sheet1.CreateRow(xcount + 1);

                for (int ycBody = 0; ycBody < lstTitle.Count; ycBody++)
                {
                    PropertyInfo pi = propertys.First(p => p.Name == lstTitle[ycBody]);
                    if (!lstTitle.Any(t => t == pi.Name))
                        continue;
                    object obj = pi.GetValue(lst[xcount], null);
                    if (obj != null)
                    {
                        hsBodyRow.CreateCell(ycBody).SetCellValue(obj.ToString());
                    }
                    else
                    {
                        hsBodyRow.CreateCell(ycBody).SetCellValue("");

                    }
                }
            }

        }

        private static void ListExcel<T>(string sheetName, IList<T> data, IList<ExcelColumnBase<T>> columns,
            XSSFWorkbook workbook)
        {
            if (columns == null || columns.Count < 1)
            {
                throw new ArgumentNullException("columns", "必须配置导出的列");
            }

            var sheet = workbook.CreateSheet(sheetName);
            IList<int> imageColumns = new List<int>();
            #region 创建标题行

            IRow hsTitleRow = sheet.CreateRow(0);
            //标题赋值
            for (int i = 0; i < columns.Count; i++)
            {
                var cell = hsTitleRow.CreateCell(i);
                string strTitle = columns[i].Title;
                int intWidth = columns[i].Width > 0
                    ? Math.Min(columns[i].Width, 255)
                    : 10;
                sheet.SetColumnWidth(i, intWidth * 256);
                cell.SetCellValue(strTitle);

                if (columns[i].Metadata.Description == "Image")
                {
                    sheet.SetColumnWidth(i, 256 * 18);
                    imageColumns.Add(i);
                }
            }

            #endregion

            //填充数据项
            PropertyInfo[] arrProperty = Activator.CreateInstance(typeof(T)).GetType().GetProperties();
            try
            {
                ICellStyle shortDateStyle = workbook.CreateCellStyle();
                IDataFormat format = workbook.CreateDataFormat();
                shortDateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

                ICellStyle longDateStyle = workbook.CreateCellStyle();
                longDateStyle.DataFormat = format.GetFormat("yyyy-mm-dd HH:mm:ss");

                ICellStyle percentStyle = workbook.CreateCellStyle();
                percentStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.00%");

                for (int xcount = 0; xcount < data.Count; xcount++)
                {

                    #region 写一行数据

                    IRow hsBodyRow = sheet.CreateRow(xcount + 1);


                    for (int ycBody = 0; ycBody < columns.Count; ycBody++)
                    {


                        object obj = columns[ycBody].GetColumnValue(data[xcount]);
                        if (imageColumns.Contains(ycBody)) //如果是图片列
                        {
                            if (obj != null && obj.ToString().Trim() != "")
                            {
                                if (!File.Exists(obj.ToString().Trim()))
                                    continue;
                                hsBodyRow.Height = 20 * 80;
                                //HSSFCell cell=hsBodyRow.CreateCell(ycBody) as HSSFCell;
                                //AddPieChart(cell, obj.ToString(), 100, 100);
                                AddPieChart(sheet, workbook, obj.ToString(), xcount + 1, ycBody, 100, 100);
                            }

                        }
                        else
                        {
                            var createCell = hsBodyRow.CreateCell(ycBody);



                            if (columns[ycBody].MemberType.FullName == typeof(Int32?).FullName || columns[ycBody].MemberType.Name == typeof(Int32).Name)
                            {
                                int intValue;
                                Int32.TryParse(obj?.ToString(), out intValue);
                                createCell.SetCellValue(intValue);
                            }
                            else if (columns[ycBody].MemberType.FullName == typeof(double?).FullName || columns[ycBody].MemberType.Name == typeof(double).Name || columns[ycBody].MemberType.FullName == typeof(decimal?).FullName || columns[ycBody].MemberType.Name == typeof(decimal).Name)
                            {
                                double doubleValue;
                                if (obj?.ToString().Contains("%") == true)
                                {
                                    double.TryParse(obj.ToString().TrimEnd('%'), out doubleValue);
                                    createCell.SetCellValue(doubleValue / 100);
                                    createCell.CellStyle = percentStyle;
                                }
                                else if (obj?.ToString().Contains("¥") == true)
                                {
                                    double.TryParse(obj.ToString().TrimStart('¥'), out doubleValue);
                                    createCell.SetCellValue(doubleValue);
                                }
                                else
                                {
                                    double.TryParse(obj?.ToString(), out doubleValue);
                                    createCell.SetCellValue(doubleValue);
                                }
                            }
                            else if (columns[ycBody].MemberType.Name == "System.DBNull")
                            {
                                createCell.SetCellValue("");
                            }
                            else if (columns[ycBody].MemberType.FullName == typeof(DateTime?).FullName || columns[ycBody].MemberType.Name == typeof(DateTime).Name)
                            {
                                DateTime dateV;
                                DateTime.TryParse(obj?.ToString(), out dateV);
                                if ((new DateTime()).Date == dateV)
                                {
                                    createCell.SetCellValue("");
                                }
                                else
                                {
                                    createCell.SetCellValue(dateV);

                                    #region 设置数据显示格式
                                    var attributes = Activator.CreateInstance(typeof(T))
                                      .GetType()
                                      .GetProperty(columns[ycBody].Member)
                                      .GetCustomAttributes(typeof(DisplayFormatAttribute));

                                    var displayFormatAttribute = attributes.FirstOrDefault() as DisplayFormatAttribute;
                                    if (displayFormatAttribute?.DataFormatString == "{0:yyyy-MM-dd HH:mm:ss}")
                                    {

                                        createCell.CellStyle = longDateStyle;
                                    }
                                    else
                                    {
                                        createCell.CellStyle = shortDateStyle;
                                    }

                                    #endregion

                                }
                            }
                            else
                            {
                                createCell.SetCellValue(obj?.ToString());
                            }

                        }

                    }

                    #endregion
                }
            }
            catch //(Exception ex)
            {
            }
        }

        #endregion

        #region 向sheet插入图片
        ///
        /// 向sheet插入图片
        ///
        private static void AddPieChart(ISheet sheet, XSSFWorkbook workbook, string picpath, int row, int col, int imageWidth = 0, int imageHeight = 0)
        {
            try
            {
                string FileName = picpath;
                if (!File.Exists(FileName))
                    return;

                //分配内存流
                var stream = new MemoryStream(4096);
                //裁剪图片
                var resizeSetting = new ResizeSettings { Width = 100, Height = 100, Scale = ScaleMode.Both };
                stream.Seek(0, SeekOrigin.Begin);
                byte[] bytes = System.IO.File.ReadAllBytes(FileName);

                //裁剪图片
                new ImageJob(new MemoryStream(bytes), stream, resizeSetting).Build();
                stream.Seek(0, SeekOrigin.Begin);

                if (!string.IsNullOrEmpty(FileName))
                {
                    int pictureIdx = workbook.AddPicture(stream.GetAllBytes(), PictureType.JPEG);

                    XSSFDrawing patriarch = (XSSFDrawing)sheet.CreateDrawingPatriarch();
                    XSSFClientAnchor anchor = new XSSFClientAnchor(0, 0, imageWidth, imageHeight, col, row, col + 1, row + 1);

                    //##处理照片位置，【图片左上角为（col, row）第row+1行col+1列，右下角为（ col +1, row +1）第 col +1+1行row +1+1列，宽为100，高为50
                    XSSFPicture pict = (XSSFPicture)patriarch.CreatePicture(anchor, pictureIdx);

                    //缩略图已经是最终符合单元格的尺寸，把整个缩略图完全显示出来，不需要再做缩放
                    pict.Resize();
                }

            }
            catch //(Exception ex)
            {
            }
        }
        #endregion

        #region 向sheet插入图片
        /// <summary>
        /// 向sheet插入图片
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="picpath"></param>
        /// <param name="imageWidth"></param>
        /// <param name="imageHeight"></param>
        public static void AddPieChart(XSSFCell cell, string picpath, int imageWidth = 0, int imageHeight = 0)
        {
            try
            {
                string FileName = picpath;
                if (!File.Exists(FileName))
                    return;
                byte[] bytes = File.ReadAllBytes(FileName);

                if (!string.IsNullOrEmpty(FileName))
                {
                    //分配内存流
                    var stream = new MemoryStream(4096);
                    //裁剪图片
                    var resizeSetting = new ResizeSettings { Width = imageWidth, Height = imageHeight, Scale = ScaleMode.Both };
                    //if(!(width > 0 && height > 0))
                    //    resizeSetting.Mode = FitMode.Carve;
                    //裁剪图片
                    new ImageJob(new MemoryStream(bytes), stream, resizeSetting).Build();
                    stream.Seek(0, SeekOrigin.Begin);

                    int pictureIdx = cell.Sheet.Workbook.AddPicture(stream.GetAllBytes(), PictureType.JPEG);
                    HSSFPatriarch patriarch = (HSSFPatriarch)cell.Sheet.CreateDrawingPatriarch();
                    HSSFClientAnchor anchor = new HSSFClientAnchor(0, 0, 0, 0, cell.ColumnIndex, cell.RowIndex, cell.ColumnIndex + 1, cell.RowIndex + 1);
                    //##处理照片位置，【图片左上角为（col, row）第row+1行col+1列，右下角为（ col +1, row +1）第 col +1+1行row +1+1列，宽为100，高为50

                    HSSFPicture pict = (HSSFPicture)patriarch.CreatePicture(anchor, pictureIdx);
                    //缩略图已经是最终符合单元格的尺寸，把整个缩略图完全显示出来，不需要再做缩放
                    pict.Resize();

                }
            }
            catch //(Exception ex)
            {
            }
        }
        #endregion
    }

}
