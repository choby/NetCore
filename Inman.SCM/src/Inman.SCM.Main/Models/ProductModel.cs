using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Inman.SCM.Main.Models
{
    public class ProductModel
    {
        
        public int Id { get; set; }
        [DisplayName("大货款号")]
        public string ProductSN { get; set; }
        public int ColorId { get; set; }
        public int GoodsId { get; set; }
        [DisplayName("图片路径")]
        public string PicturePath { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        [DisplayName("创建日期")]
        public string CreatedOn { get; set; }
        [DisplayName("创建人")]
        public string CreatedBy { get; set; }
        [DisplayName("设计款ID")]
        public string DesignID { get; set; }
        
        public double BatchPrice { get; set; }
        [DisplayName("品牌")]
        public string Brand { get; set; }
        public string CategoryClass { get; set; }
        public string Component { get; set; }
        [DisplayName("开发价格")]
        public double DevCost { get; set; }
        [DisplayName("执行标准")]
        public string ExecStandard { get; set; }
        public string Filler { get; set; }
        public float FillFeatherPercent { get; set; }
        public string FirstOnsaleShelveDate { get; set; }
        public double FOBCost { get; set; }
        public double InternalPrice { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsUploadK3 { get; set; }
        public double ProcessingCost { get; set; }
        [DisplayName("大货名称")]
        public string ProductName { get; set; }
        public string ProductTitle { get; set; }
        [DisplayName("年份")]
        public int ProductYear { get; set; }
        [DisplayName("品质等级")]
        public string QualityGrade { get; set; }
        public double RADCost { get; set; }
        public string SafetyCass { get; set; }
        [DisplayName("一口价")]
        public double SalesPrice { get; set; }
        [DisplayName("季节")]
        public string Season { get; set; }
        [DisplayName("性别")]
        public string Sex { get; set; }
        [DisplayName("吊牌价")]
        public double TagPrice { get; set; }
        [DisplayName("上传K3日期")]
        public string UploadK3Date { get; set; }
        [DisplayName("洗水方式图片")]
        public string WashingMethodPicture { get; set; }
        [DisplayName("溪水方式图片代码")]
        public int WashingMethodPictureCode { get; set; }
    }
}
