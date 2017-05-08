using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Web.Routing;
using System.Web;

using Kendo.Mvc.UI;
using Kendo.Mvc.UI.Fluent;

using Inman.Infrastructure.Common.Extensions;
using Inman.Infrastructure.Common;
using Inman.Infrastructure.Web;
using Inman.Infrastructure.IOC;
using Inman.SCM.Core;
using Inman.SCM.Services;
using Inman.SCM.Web;
using Inman.SCM.Web.Framework;
using Inman.SCM.Web.Infrastructure;
using Inman.SCM.Web.Models;
using System.ComponentModel;

namespace System.Web.Mvc.Html
{
    /// <summary>
    /// 继续扩展HTML
    /// </summary>
    public static class KendoUIExtensions
    {
        #region

        private static IPermissionService GetPerssmissionSrv()
        {
            return EngineContext.Current.Resolve<IPermissionService>();
        }


        private static readonly MvcHtmlString EmptyHtml = new MvcHtmlString("");

        private static CommonSettings GetCommonSettings()
        {
            return EngineContext.Current.Resolve<CommonSettings>();
        }


        #endregion

        #region 获取权限的私有方法

        private static bool Authorize(string perssmissionCode)
        {
            return string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().Authorize(perssmissionCode);
        }

        private static bool AuthorizeInLoginAccount(string perssmissionCode)
        {
            return string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode);
        }
        private static int GetCurrentAccountId()
        {
            return EngineContext.Current.Resolve<IWorkContext>().GetSingleAccount();
        }

        private static string GetDataUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
                return string.Empty;
            if (url.IndexOf("?") > 0)
                return $"{url}&AccountId={GetCurrentAccountId()}";
            return $"{url}?AccountId={GetCurrentAccountId()}";
        }
        #endregion

        #region 仅用于显示的文本框，在非编辑状态下，用以替换比较耗费前端性能的复杂空间
        private static MvcHtmlString Inman_TextBoxForComplex(HtmlHelper htmlHelper,string name,string value,string text)
        {
            var componentHtmlString = $"<input type=\"hidden\" name={name} value=\"{value}\" />";
            var uiComponentHtmlString = htmlHelper.Kendo().TextBox().Name($"{name}_UIText").Value(text).ReadOnly().ToHtmlString();
            return new MvcHtmlString($"{uiComponentHtmlString}{componentHtmlString}");
        }

        private static  MvcHtmlString Inman_TextBoxForComplex<TModel, TProperty>(HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>>
                                                                                       expression)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = modelMetadata.Model.ToString();

            var componentHtmlString = $"<input type=\"hidden\" name={name} value=\"{value}\" />";
            var uiComponentHtmlString = htmlHelper.Kendo().TextBox().Name($"{name}_UIText").Value(value).ReadOnly().ToHtmlString();
            return new MvcHtmlString($"{uiComponentHtmlString}{componentHtmlString}");
        }
        #endregion

        #region 选择供应商

        public static MvcHtmlString Inman_SelectSupplier(this HtmlHelper htmlHelper, string name,
                                                         string dataTextField = "Name",
                                                         string dataValueField = "Id",
                                                         string selectedValue = null,
                                                         string selectedText = null,
                                                         int? gridWidth = 650,
                                                         int gridPageSize = 8,
                                                         string perssmissionCode = null,
                                                         string optionLabel = " ",
                                                         object htmlAttributes = null,
                                                         string changeEvent = null,
                                                         string selectEvent = null,
                                                         string clearEvent = null,
                                                         bool disable = false,
                                                         SelectSupplierBussiness bussiness =
                                                             SelectSupplierBussiness.Default)
        {

            return Inman_DropDownGrid<SupplierModel>(htmlHelper, name,
                                                     string.Format("/Selector/Suppliers?bussiness={0}", bussiness),
                                                     c =>
                                                     {
                                                         /***  请不要再这里删除列，如果必须要用单列，请考虑用用kendo原生DropDownList扩展 ***/
                                                         c.Bound(f => f.Code).Width(120);
                                                         c.Bound(f => f.Name).Width(120);
                                                         c.Bound(f => f.SupplyProducts).Width(120);
                                                         c.Bound(f => f.Contact).Width(80);
                                                         c.Bound(f => f.Telphone).Width(80);
                                                     },
                                                     dataTextField: dataTextField,
                                                     dataValueField: dataValueField,
                                                     selectedText: selectedText,
                                                     gridWidth: gridWidth,
                                                     selectedValue: selectedValue,
                                                     gridPageSize: gridPageSize,
                                                     optionLabel: optionLabel,
                                                     perssmissionCode: perssmissionCode,
                                                     changeEvent: changeEvent,
                                                     selectEvent: selectEvent,
                                                     clearEvent: clearEvent,
                                                     disable: disable
                );

        }

        public static MvcHtmlString Inman_SelectSupplierFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               string dataTextField = "Name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               int gridPageSize = 8,
                                                                               int? gridWidth = 650,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               object htmlAttributes = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               bool disable = false,
                                                                               SelectSupplierBussiness bussiness =
                                                                                   SelectSupplierBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectSupplier(htmlHelper,
                                        name,
                                        dataTextField: dataTextField,
                                        dataValueField: dataValueField,
                                        selectedValue: value,
                                        selectedText: selectedText,
                                        gridWidth: gridWidth,
                                        gridPageSize: gridPageSize,
                                        perssmissionCode: perssmissionCode,
                                        optionLabel: optionLabel,
                                        htmlAttributes: htmlAttributes,
                                        changeEvent: changeEvent,
                                        selectEvent: selectEvent,
                                        clearEvent: clearEvent,
                                        disable: disable,
                                        bussiness: bussiness);
        }

        #endregion

        #region 选择员工

        //public static DropDownListBuilder Inman_SelectCustomer(this HtmlHelper htmlHelper,
        //                                                       string name,
        //                                                       string dataTextField = "NickName",
        //                                                       string dataValueField = "Id",
        //                                                       string selectedValue = null,
        //                                                       string selectedText = null,
        //                                                       string perssmissionCode = null,
        //                                                       string optionLabel = " ",
        //                                                       object htmlAttributes = null,
        //                                                       SelectCustomerBussiness bussiness =
        //                                                           SelectCustomerBussiness.Default)
        //{

        //    return Inman_DropDownList(htmlHelper
        //                              , name
        //                              , string.Format("/Selector/Customers?bussiness={0}", bussiness)
        //                              , dataTextField
        //                              , dataTextField
        //                              , null
        //                              , selectedValue
        //                              , selectedText
        //                              , null
        //                              , optionLabel
        //                              , htmlAttributes);

        //}

        public static DropDownListBuilder Inman_SelectCustomerFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                     Expression<Func<TModel, TProperty>>
                                                                                         expression,
                                                                                     string dataTextField = "NickName",
                                                                                     string dataValueField = "Id",
                                                                                     string selectedText = null,
                                                                                     string perssmissionCode = null,
                                                                                     string optionLabel = " ",
                                                                                     object htmlAttributes = null,
                                                                                     SelectCustomerBussiness bussiness =
                                                                                         SelectCustomerBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_DropDownListFor(htmlHelper, expression,
                                         string.Format("/Selector/Customers?bussiness={0}", bussiness), dataTextField,
                                         dataValueField, selectedText ?? "", null, perssmissionCode, optionLabel,
                                         htmlAttributes);
        }

        public static MvcHtmlString Inman_SelectCustomer(this HtmlHelper htmlHelper,
                                                         string name,
                                                         string dataTextField = "NickName",
                                                         string dataValueField = "Id",
                                                         string selectedValue = null,
                                                         string selectedText = null,
                                                         string perssmissionCode = null,
                                                         string optionLabel = " ",
                                                         int gridPageSize = 8,
                                                         int? gridWidth = 380,
                                                         int? gridHeight = null,
                                                         string changeEvent = null,
                                                         string selectEvent = null,
                                                         string clearEvent = null,
                                                         bool disable = false,
                                                         SelectCustomerBussiness bussiness = SelectCustomerBussiness.Default)
        {
            return Inman_DropDownGrid<CustomerModel>(htmlHelper, name,
                                                         string.Format(
                                                             string.Format("/Selector/Customers?bussiness={0}", bussiness),
                                                             bussiness),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.NickName).Width(120).Title("用户昵称");
                                                             c.Bound(f => f.DepartmentName).Width(140).Title("部门");
                                                         },
                                                         dataTextField: dataTextField,
                                                         dataValueField: dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         perssmissionCode: perssmissionCode,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        #endregion

        #region 选择角色

        public static MvcHtmlString Inman_SelectRole(this HtmlHelper htmlHelper,
                                                     string name,
                                                     string dataTextField = "name",
                                                     string dataValueField = "Id",
                                                     string selectedValue = null,
                                                     string selectedText = null,
                                                     string perssmissionCode = null,
                                                     string optionLabel = " ",
                                                     int gridPageSize = 8,
                                                     int? gridWidth = 380,
                                                     int? gridHeight = null,
                                                     string changeEvent = null,
                                                     string selectEvent = null,
                                                     string clearEvent = null,
                                                     bool disable = false,
                                                     SelectRoleBusiness bussiness = SelectRoleBusiness.Default)
        {
            return Inman_DropDownGrid<BaseRoleModel>(htmlHelper, name,
                                                         string.Format(
                                                             string.Format("/Selector/Roles?bussiness={0}", bussiness),
                                                             bussiness),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.name).Width(120).Title("角色名称");
                                                             c.Bound(typeof(RoleTypeEnum), "RoleType").Width(140).Title("角色类型");
                                                         },
                                                         dataTextField: dataTextField,
                                                         dataValueField: dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         perssmissionCode: perssmissionCode,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        #endregion

        #region 大货制单号

        /// <summary>
        /// 大货生产单
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="DataValueField"></param>
        /// <param name="selectedValue"></param>
        /// <param name="selectedText"></param>
        /// <param name="pageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="disable"></param>
        /// <param name="bussiness"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProduceOrderForShipment(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataTextField = "ProduceOrderDocNum",
                                                                string DataValueField = "Id",
                                                                string selectedValue = null,
                                                                string selectedText = null,
                                                                int pageSize = 15,
                                                                int? gridWidth = null,
                                                                int? gridHeight = null,
                                                                string changeEvent = null,
                                                                string selectEvent = null,
                                                                string clearEvent = null,
                                                                string perssmissionCode = null,
                                                                string optionLabel = " ",
                                                                object htmlAttributes = null,
                                                                bool disable = false,
                                                                SelectProduceProduceScheduleBussiness bussiness =
                                                                    SelectProduceProduceScheduleBussiness.Default)
        {
            return Inman_DropDownGrid<ShipmentSampleTransferProduceScheduleModel>(htmlHelper, name,
                                                            string.Format("/Selector/ProduceOrderForShipment?bussiness={0}",
                                                                          bussiness),
                                                            c =>
                                                            {
                                                                c.Bound(f => f.ProduceOrderDocNum);
                                                                c.Bound(f => f.ProductSN);
                                                                c.Bound(f => f.Color);
                                                            },
                                                            dataTextField: dataTextField,
                                                            dataValueField: DataValueField,
                                                            selectedText: selectedText,
                                                            selectedValue: selectedValue,
                                                            optionLabel: optionLabel,
                                                            gridPageSize: pageSize,
                                                            gridWidth: gridWidth,
                                                            gridHeight: gridHeight,
                                                            changeEvent: changeEvent,
                                                            selectEvent: selectEvent,
                                                            clearEvent: clearEvent,
                                                            perssmissionCode: perssmissionCode,
                                                            disable: disable
                );
        }


        /// <summary>
        /// 大货制单号
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="dataValueField"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProduceOrder(this HtmlHelper htmlHelper,
                                                             string name,
                                                             string dataTextField = "DocNum",
                                                             string dataValueField = "Id",
                                                             int? ProductId = null,
                                                             string selectedValue = null,
                                                             string selectedText = null,
                                                             string cascadeFrom = null,
                                                             string dataFilter = null,
                                                             string perssmissionCode = null,
                                                             string optionLabel = " ",
                                                             int gridPageSize = 8,
                                                             int? gridWidth = 600,
                                                             int? gridHeight = null,
                                                             string changeEvent = null,
                                                             string selectEvent = null,
                                                             string clearEvent = null,
                                                             bool disable = false,
                                                             SelectProduceOrderBussiness bussiness =
                                                                 SelectProduceOrderBussiness.Default)
        {
            return Inman_DropDownGrid<ProduceOrderModel>(htmlHelper, name,
                                                         string.Format(
                                                             "/Selector/ProduceOrders?bussiness={0}&ProductId={1}",
                                                             bussiness, ProductId),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.DocNum).Width(140);
                                                             c.Bound(f => f.ProductSN).Width(140);
                                                             c.Bound(f => f.Color).Width(100);
                                                             c.Bound(f => f.CateName3).Width(100);
                                                             c.Bound(f => f.OrderYear).Title("年份").Width(80);
                                                             c.Bound(f => f.OrderSeason).Title("季节").Width(80);
                                                         },
                                                         dataTextField: dataTextField,
                                                         dataValueField: dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         perssmissionCode: perssmissionCode,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        /// <summary>
        /// 大货制单号
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataTextField"></param>
        /// <param name="DataValueField"></param>
        /// <param name="dependsPlanPurchaseOrder"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProduceOrderFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>>
                                                                                       expression,
                                                                                   string dataTextField = "DocNum",
                                                                                   string dataValueField = "Id",
                                                                                   string selectedText = null,
                                                                                   string perssmissionCode = null,
                                                                                   string optionLabel = " ",
                                                                                   int gridPageSize = 8,
                                                                                   int? gridWidth = 600,
                                                                                   int? gridHeight = null,
                                                                                   string changeEvent = null,
                                                                                   string selectEvent = null,
                                                                                   string clearEvent = null,
                                                                                   bool disable = false,
                                                                                   SelectProduceOrderBussiness bussiness
                                                                                       =
                                                                                       SelectProduceOrderBussiness
                                                                                       .Default)
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProduceOrderModel>(htmlHelper, expression,
                                                                               string.Format(
                                                                                   "/Selector/ProduceOrders?bussiness={0}",
                                                                                   bussiness),
                                                                               c =>
                                                                               {
                                                                                   c.Bound(f => f.DocNum).Width(140);
                                                                                   c.Bound(f => f.ProductSN)
                                                                                    .Width(140);
                                                                                   c.Bound(f => f.Color).Width(100);
                                                                                   c.Bound(f => f.CateName3)
                                                                                    .Width(100);
                                                                                   c.Bound(f => f.OrderYear)
                                                                                    .Width(100);
                                                                                   c.Bound(f => f.OrderSeason)
                                                                                    .Width(100);
                                                                               },
                                                                               dataTextField: dataTextField,
                                                                               dataValueField: dataValueField,
                                                                               selectedText: selectedText,
                                                                               optionLabel: optionLabel,
                                                                               perssmissionCode: perssmissionCode,
                                                                               gridPageSize: gridPageSize,
                                                                               gridWidth: gridWidth,
                                                                               gridHeight: gridHeight,
                                                                               changeEvent: changeEvent,
                                                                               selectEvent: selectEvent,
                                                                               clearEvent: clearEvent,
                                                                               disable: disable
                );
        }


        #endregion

        #region 大货生产进度表

        /// <summary>
        /// 大货生产进度表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="DataValueField"></param>
        /// <param name="selectedValue"></param>
        /// <param name="selectedText"></param>
        /// <param name="pageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="disable"></param>
        /// <param name="bussiness"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProduceSchedule(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataTextField = "ProduceOrderDocNum",
                                                                string DataValueField = "Id",
                                                                string selectedValue = null,
                                                                string selectedText = null,
                                                                int pageSize = 15,
                                                                int? gridWidth = null,
                                                                int? gridHeight = null,
                                                                string changeEvent = null,
                                                                string selectEvent = null,
                                                                string clearEvent = null,
                                                                string perssmissionCode = null,
                                                                string optionLabel = " ",
                                                                object htmlAttributes = null,
                                                                bool disable = false,
                                                                SelectProduceProduceScheduleBussiness bussiness =
                                                                    SelectProduceProduceScheduleBussiness.Default)
        {
            return Inman_DropDownGrid<ProduceScheduleModel>(htmlHelper, name,
                                                            string.Format("/Selector/ProduceSchedule",
                                                                          bussiness),
                                                            c =>
                                                            {
                                                                c.Bound(f => f.ProduceOrderDocNum);
                                                                c.Bound(f => f.ProductSN);
                                                                c.Bound(f => f.Color);
                                                            },
                                                            dataTextField: dataTextField,
                                                            dataValueField: DataValueField,
                                                            selectedText: selectedText,
                                                            selectedValue: selectedValue,
                                                            optionLabel: optionLabel,
                                                            gridPageSize: pageSize,
                                                            gridWidth: gridWidth,
                                                            gridHeight: gridHeight,
                                                            changeEvent: changeEvent,
                                                            selectEvent: selectEvent,
                                                            clearEvent: clearEvent,
                                                            perssmissionCode: perssmissionCode,
                                                            disable: disable
                );
        }

        /// <summary>
        /// 大货生产进度表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="DataValueField"></param>
        /// <param name="selectedValue"></param>
        /// <param name="selectedText"></param>
        /// <param name="pageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="disable"></param>
        /// <param name="bussiness"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProduceScheduleFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ProduceOrderDocNum",
            string dataValueField = "Id",
            string selectedText = null,
            int pageSize = 15,
            int? gridWidth = null,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            object htmlAttributes = null,
            bool disable = false,
            SelectProduceProduceScheduleBussiness bussiness = SelectProduceProduceScheduleBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();
            return Inman_SelectProduceSchedule(htmlHelper, name,
                                               dataTextField: dataTextField,
                                               DataValueField: dataValueField,
                                               selectedValue: value,
                                               selectedText: selectedText,
                                               pageSize: pageSize,
                                               gridWidth: gridWidth,
                                               gridHeight: gridHeight,
                                               changeEvent: changeEvent,
                                               selectEvent: selectEvent,
                                               clearEvent: clearEvent,
                                               perssmissionCode: perssmissionCode,
                                               optionLabel: optionLabel,
                                               htmlAttributes: htmlAttributes,
                                               disable: disable,
                                               bussiness: bussiness);

        }

        #endregion

        #region 颜色选择树

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="selectedText"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="multiple"></param>
        /// <param name="selectEvent"></param>
        /// <param name="changeEvent"></param>
        /// <param name="confirmEvent">确认按钮事件,该事件必须返回bool类型,否则弹窗不会关闭</param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectColorTreeFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                Expression<Func<TModel, TProperty>>
                                                                                    expression,
                                                                                string selectedText = null,
                                                                                string dataTextField = "name",
                                                                                string dataValueField = "id",
                                                                                bool multiple = false,
                                                                                string selectEvent = null,
                                                                                string changeEvent = null,
                                                                                string confirmEvent = null,
            bool disable = false)
        {
            return Inman_WindowTreeFor(htmlHelper,
                                       expression,
                                       "/selector/GetColor_Tree",
                                       dataTextField,
                                       dataValueField,
                                       selectedText,
                                       multiple,
                                       selectEvent,
                                       changeEvent,
                                       confirmEvent,
                                       disable);
        }

        #endregion

        #region 商品分类选择树

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="selectedText"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="multiple"></param>
        /// <param name="selectEvent"></param>
        /// <param name="changeEvent"></param>
        /// <param name="confirmEvent">确认按钮事件,该事件必须返回bool类型,否则弹窗不会关闭</param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectProductCateTreeFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string selectedText = null,
            string dataTextField = "name",
            string dataValueField = "id",
            bool multiple = false,
            string selectEvent = null,
            string changeEvent = null,
            string confirmEvent = null,
            bool disable = false)
        {
            return Inman_WindowTreeFor(htmlHelper,
                                       expression,
                                       "/selector/GetProductCate_Tree",
                                       dataTextField,
                                       dataValueField,
                                       selectedText,
                                       multiple,
                                       selectEvent,
                                       changeEvent,
                                       confirmEvent,
                                       disable);
        }

        public static MvcHtmlString Inman_SelectCategory<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                 string name,
                                                                 string dataTextField = "Name",
                                                                 string dataValueField = "Id",
                                                                 string selectedText = null,
                                                                 string perssmissionCode = null,
                                                                 string optionLabel = " ",
                                                                 int gridPageSize = 8,
                                                                 int? gridWidth = null,
                                                                 int? gridHeight = null,
                                                                 string changeEvent = null,
                                                                 string selectEvent = null,
                                                                 string clearEvent = null,
                                                                 SelectCategoryBussiness business =
                                                                     SelectCategoryBussiness.Default)
        {
            return Inman_DropDownGrid<ProductCategoryModel>(htmlHelper,
                                                            name,
                                                            string.Format("/Selector/SelectCategory?business={0}",
                                                                          business),
                                                            c =>
                                                            {
                                                                //                    c.Bound(f => f.Id);3
                                                                //                    c.Bound(f => f.Code);
                                                                c.Bound(f => f.Name);
                                                                //                    c.Bound(f => f.Type);
                                                            },
                                                            dataTextField,
                                                            dataValueField,
                                                            selectedText: selectedText,
                                                            optionLabel: optionLabel,
                                                            gridPageSize: gridPageSize,
                                                            gridWidth: gridWidth,
                                                            gridHeight: gridHeight,
                                                            changeEvent: changeEvent,
                                                            selectEvent: selectEvent,
                                                            clearEvent: clearEvent
                );
        }

        public static MvcHtmlString Inman_SelectCategoryFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>> func,
                                                                               string dataTextField = "Name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               int gridPageSize = 8,
                                                                               int? gridWidth = null,
                                                                               int? gridHeight = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               SelectCategoryBussiness business =
                                                                                   SelectCategoryBussiness.Default)
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductCategoryModel>(htmlHelper,
                                                                                  func,
                                                                                  string.Format(
                                                                                      "/Selector/SelectCategory?bussiness={0}",
                                                                                      business),
                                                                                  c =>
                                                                                  {
                                                                                      c.Bound(f => f.Name);
                                                                                      //                   c.Bound(f => f.Type);
                                                                                  },
                                                                                  dataTextField,
                                                                                  dataValueField,
                                                                                  selectedText: selectedText,
                                                                                  optionLabel: optionLabel,
                                                                                  gridPageSize: gridPageSize,
                                                                                  gridWidth: gridWidth,
                                                                                  gridHeight: gridHeight,
                                                                                  changeEvent: changeEvent,
                                                                                  selectEvent: selectEvent,
                                                                                  clearEvent: clearEvent
                );
        }

        #endregion

        #region 面辅料分类选择数

        public static MvcHtmlString Inman_SelectStockItemCateTreeFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string selectedText = null,
            string dataTextField = "name",
            string dataValueField = "id",
            bool multiple = false,
            string selectEvent = null,
                                                                                string changeEvent = null,
                                                                                string confirmEvent = null,
            bool disable = false)
        {


            return Inman_WindowTreeFor(htmlHelper,
                                       expression,
                                       "/selector/GetStockitemCate_Tree",
                                       dataTextField,
                                       dataValueField,
                                       selectedText,
                                       multiple,
                                       selectEvent,
                                       changeEvent,
                                       confirmEvent,
                                       disable);


            //string name = ExpressionHelper.GetExpressionText(expression);
            //ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //string value = (modelMetadata.Model ?? "").ToString();

            //htmlHelper.ViewData["Sys_Name"] = name;
            //htmlHelper.ViewData["Sys_Value"] = value;
            //htmlHelper.ViewData["Sys_Multiple"] = multiple;
            //htmlHelper.ViewData["Sys_DataTextField"] = dataTextField;
            //htmlHelper.ViewData["Sys_DataValueField"] = dataValueField;
            //htmlHelper.ViewData["Sys_SelectedText"] = selectedText ?? value;
            //return htmlHelper.Partial("~/Views/Shared/Selector/SelectTree.cshtml", multiple, htmlHelper.ViewData);
        }

        #endregion

        #region 颜色

        public static MvcHtmlString Inman_SelectColorFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                            Expression<Func<TModel, TProperty>>
                                                                                expression,
                                                                            string dataTextField = "Name",
                                                                            string dataValueField = "Id",
                                                                            string selectedText = null,
                                                                            string perssmissionCode = null,
                                                                            string optionLabel = " ",
                                                                            int gridPageSize = 8,
                                                                            int? gridWidth = null,
                                                                            int? gridHeight = null,
                                                                            string changeEvent = null,
                                                                            string selectEvent = null,
                                                                            string clearEvent = null,
                                                                            bool disable = false,
                                                                            SelectColorBusiness business =
                                                                                SelectColorBusiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, ColorModel>(htmlHelper,
                                                                        expression,
                                                                        string.Format(
                                                                            "/Selector/GetColor?business={0}", business),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.Name).Width(80);
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectColor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                              string name,
                                                              string dataTextField = "Name",
                                                              string dataValueField = "Id",
                                                              string selectedText = null,
                                                              string perssmissionCode = null,
                                                              string optionLabel = " ",
                                                              int gridPageSize = 8,
                                                              int? gridWidth = null,
                                                              int? gridHeight = null,
                                                              string changeEvent = null,
                                                              string selectEvent = null,
                                                              string clearEvent = null,
                                                              SelectColorBusiness business = SelectColorBusiness.Default
            )
        {

            return Inman_DropDownGrid<ColorModel>(htmlHelper,
                                                  name,
                                                  string.Format("/Selector/GetColor?business={0}", business),
                                                  c =>
                                                  {
                                                      c.Bound(f => f.Id);
                                                      c.Bound(f => f.Code);
                                                      c.Bound(f => f.Name);
                                                  },
                                                  dataTextField,
                                                  dataValueField,
                                                  selectedText: selectedText,
                                                  optionLabel: optionLabel,
                                                  gridPageSize: gridPageSize,
                                                  gridWidth: gridWidth,
                                                  gridHeight: gridHeight,
                                                  changeEvent: changeEvent,
                                                  selectEvent: selectEvent,
                                                  clearEvent: clearEvent
                );
        }

        #endregion

        #region 大货款号

        public static MvcHtmlString Inman_SelectProductSNFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                Expression<Func<TModel, TProperty>>
                                                                                    expression,
                                                                                string dataTextField,
                                                                                string dataValueField,
                                                                                int? SupplierId = null,
                                                                                string selectedText = null,
                                                                                string perssmissionCode = null,
                                                                                string optionLabel = " ",
                                                                                int gridPageSize = 8,
                                                                                int? gridWidth = null,
                                                                                int? gridHeight = null,
                                                                                string changeEvent = null,
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false,
                                                                                SelectProductSNBussiness bussiness =
                                                                                    SelectProductSNBussiness.Default
            )
        {


            return Inman_DropDownGridFor<TModel, TProperty, ProductModel>(htmlHelper,
                                                                          expression,
                                                                          string.Format(
                                                                              "/Selector/ProductSN?bussiness={0}&SupplierId={1}",
                                                                              bussiness, SupplierId),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.ProductSN).Width(140);
                                                                            c.Bound(f => f.DesignProductSN).Width(140);


                                                                            if (bussiness !=
                                                                               SelectProductSNBussiness.ProductProcess &&
                                                                               bussiness !=
                                                                               SelectProductSNBussiness.ProductProcessWoollen &&
                                                                               bussiness != SelectProductSNBussiness.ProductPriceExamination)
                                                                            {
                                                                                c.Bound(f => f.Color).Width(80);

                                                                                c.Bound(f => f.ProductYear)
                                                                                    .Title("年份")
                                                                                    .Width(80);
                                                                                c.Bound(f => f.Season).Width(80);
                                                                            }
                                                                        },
                                                                          dataTextField,
                                                                          dataValueField,
                                                                          selectedText: selectedText,
                                                                          optionLabel: optionLabel,
                                                                          gridPageSize: gridPageSize,
                                                                          gridWidth: gridWidth,
                                                                          gridHeight: gridHeight,
                                                                          changeEvent: changeEvent,
                                                                          selectEvent: selectEvent,
                                                                          clearEvent: clearEvent,
                                                                          disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductSN(this HtmlHelper htmlHelper,
                                                          string name,
                                                          string dataTextField = "ProductSN",
                                                          string dataValueField = "Id",
                                                          string selectedValue = null,
                                                          string selectedText = null,
                                                          string perssmissionCode = null,
                                                          string optionLabel = " ",
                                                          int gridPageSize = 8,
                                                          int? gridWidth = null,
                                                          int? gridHeight = null,
                                                          string changeEvent = null,
                                                          string selectEvent = null,
                                                          string clearEvent = null,
                                                          SelectProductSNBussiness bussiness = SelectProductSNBussiness.Default)
        {
            switch (bussiness)
            {
                case SelectProductSNBussiness.ProduceFixedPriceExamination:
                case SelectProductSNBussiness.ActivitiePriceExamination:
                    return Inman_DropDownGrid<ProductModel>(htmlHelper,
                                                    name,
                                                    string.Format("/Selector/ProductSN?bussiness={0}", bussiness),
                                                    c =>
                                                    {
                                                        c.Bound(f => f.ProductSN).Width(160);
                                                        c.Bound(f => f.Brand).Width(80);

                                                        c.Bound(f => f.ProductYear).Width(80);
                                                        c.Bound(f => f.Season).Width(80);
                                                    },
                                                    dataTextField,
                                                    dataValueField,
                                                    selectedText: selectedText,
                                                    selectedValue: selectedValue,
                                                    optionLabel: optionLabel,
                                                    gridPageSize: gridPageSize,
                                                    gridWidth: gridWidth,
                                                    gridHeight: gridHeight,
                                                    changeEvent: changeEvent,
                                                    selectEvent: selectEvent,
                                                    clearEvent: clearEvent);
                    break;
                default:
                    return Inman_DropDownGrid<ProductModel>(htmlHelper,
                                  name,
                                  string.Format("/Selector/ProductSN?bussiness={0}", bussiness),
                                  c =>
                                  {
                                      c.Bound(f => f.ProductSN);
                                      c.Bound(f => f.ProductCategory2).Width(80);
                                      c.Bound(f => f.DesignProductSN);
                                  },
                                  dataTextField,
                                  dataValueField,
                                  selectedText: selectedText,
                                  selectedValue: selectedValue,
                                  optionLabel: optionLabel,
                                  gridPageSize: gridPageSize,
                                  gridWidth: gridWidth,
                                  gridHeight: gridHeight,
                                  changeEvent: changeEvent,
                                  selectEvent: selectEvent,
                                  clearEvent: clearEvent);
            }

        }

        #endregion

        #region 洗涤方式

        /// <summary>
        /// 洗涤方式
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectWatchMethodFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                  Expression<Func<TModel, TProperty>>
                                                                                      expression,
                                                                                  string selectedText = null,
                                                                                  string perssmissionCode = null,
                                                                                  string optionLabel = " ",
                                                                                  string selectEvent = null,
                                                                                  bool disable = false)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_DropDownGridFor<TModel, TProperty, OptionItemModel>(
                htmlHelper: htmlHelper,
                expression: expression,
                dataUrl: "/Selector/WashingMethods",
                configurator: c =>
                    {
                        c.Bound(f => f.ItemName).Width(200);
                        c.Bound(f => f.ItemValue)
                         .ClientTemplate(
                             "<img height='25' src='/File/ShowPicture?pictureName=#: ItemValue#&bussiness=WashingMethods' />")
                         .Width(320);
                    },
                dataTextField: "ItemName",
                dataValueField: "ItemCode",
                selectedText: selectedText,
                optionLabel: optionLabel,
                gridWidth: 450,
                selectEvent: selectEvent,
                gridPageSize: 5, disable: disable);
            //            var selector = Inman_SelectOptionFor(htmlHelper, expression, "WashingMethod",perssmissionCode,optionLabel,htmlAttributes);
            //            if (selector != null)
            //            {
            //                
            //                string name = ExpressionHelper.GetExpressionText(expression);
            //                selector = selector.Template("<div style='width:400px'>#: ItemName #<img src=\"#: '" + GetCommonSettings().HttpWashingMethodImgFolder + "'+ ItemValue#\"/></div>")
            //                    .Events(t => t.Open("function(e){$('#" + name + "-list').css('width','auto').css('overflow','visible'); }"));
            //            }
            //            return selector.DataValueField("ItemCode");
        }

        #endregion

        #region 设计款号

        /// <summary>
        /// 设计款号
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectDesignFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                             Expression<Func<TModel, TProperty>>
                                                                                 expression,
                                                                             string dataTextField = "DesignProductSN",
                                                                             string dataValueField = "Id",
                                                                             string selectedText = null,
                                                                             int gridPageSize = 8,
                                                                             int? gridWidth = null,
                                                                             int? gridHeight = null,
                                                                             string perssmissionCode = null,
                                                                             string optionLabel = " ",
                                                                             string changeEvent = null,
                                                                             string selectEvent = null,
                                                                             string clearEvent = null,
                                                                             bool disable = false,
                                                                             SelectDesignsBussiness bussiness = SelectDesignsBussiness.Default)
        {
            return Inman_DropDownGridFor<TModel, TProperty, DesignModel>(htmlHelper,
                                                                         expression, string.Format("/Selector/Designs?bussiness={0}", bussiness),
                                                                         c =>
                                                                         {
                                                                             c.Bound(t => t.DesignProductSN)
                                                                              .Width(100);
                                                                             c.Bound(t => t.Brand).Width(80);
                                                                             c.Bound(t => t.DevYear).Width(100);
                                                                             c.Bound(t => t.DesignGroup).Width(100);
                                                                             c.Bound(t => t.DesignSeason).Width(100);
                                                                             c.Bound(t => t.Collection).Width(120);
                                                                             c.Bound(t => t.Type)
                                                                              .Width(80)
                                                                              .Title("分类");
                                                                             c.Bound(t => t.DesignerName).Width(120);
                                                                         },
                                                                         dataTextField: dataTextField,
                                                                         dataValueField: dataValueField,
                                                                         selectedText: selectedText,
                                                                         optionLabel: optionLabel,
                                                                         perssmissionCode: perssmissionCode,
                                                                         gridPageSize: gridPageSize,
                                                                         gridWidth: gridWidth,
                                                                         gridHeight: gridHeight,
                                                                         changeEvent: changeEvent,
                                                                         selectEvent: selectEvent,
                                                                         clearEvent: clearEvent,
                                                                         disable: disable
                );
        }

        /// <summary>
        /// 设计款号
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="selectedValue"></param>
        /// <param name="gridPageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectDesign(this HtmlHelper htmlHelper,
                                                       string name,
                                                       string dataTextField = "DesignProductSN",
                                                       string dataValueField = "Id",
                                                       string selectedText = null,
                                                       string selectedValue = null,
                                                       int gridPageSize = 8,
                                                       int? gridWidth = null,
                                                       int? gridHeight = null,
                                                       string perssmissionCode = null,
                                                       string optionLabel = " ",
                                                       string changeEvent = null,
                                                       string selectEvent = null,
                                                       string clearEvent = null,
                                                       bool disable = false,
                                                       SelectDesignsBussiness bussiness = SelectDesignsBussiness.Default)
        {
            return Inman_DropDownGrid<DesignModel>(htmlHelper,
                                                   name,
                                                  string.Format("/Selector/Designs?bussiness={0}", bussiness),
                                                   c =>
                                                   {
                                                       c.Bound(t => t.DesignProductSN).Width(100);
                                                       c.Bound(t => t.Brand).Width(80);
                                                       c.Bound(t => t.DevYear).Width(100);
                                                       c.Bound(t => t.DesignGroup).Width(100);
                                                       c.Bound(t => t.DesignSeason).Width(100);
                                                       c.Bound(t => t.Collection).Width(120);
                                                       c.Bound(t => t.Type).Width(80).Title("分类");
                                                       c.Bound(t => t.DesignerName).Width(120);

                                                   },
                                                   dataTextField: dataTextField,
                                                   dataValueField: dataValueField,
                                                   selectedText: selectedText,
                                                   optionLabel: optionLabel,
                                                   perssmissionCode: perssmissionCode,
                                                   gridPageSize: gridPageSize,
                                                   gridWidth: gridWidth,
                                                   gridHeight: gridHeight,
                                                   changeEvent: changeEvent,
                                                   selectEvent: selectEvent,
                                                   clearEvent: clearEvent,
                                                   disable: disable
                );
        }

        #endregion

        #region 面辅料

        /// <summary>
        /// 选择面辅料
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="selectedValue"></param>
        /// <param name="gridPageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectStockItem(this HtmlHelper htmlHelper,
                                                          string name,
                                                          string dataTextField = "ItemCategory3",
                                                          string dataValueField = "Id",
                                                          string selectedText = null,
                                                          string selectedValue = null,
                                                          int gridPageSize = 8,
                                                          int? gridWidth = null,
                                                          int? gridHeight = null,
                                                          string perssmissionCode = null,
                                                          string optionLabel = " ",
                                                          string changeEvent = null,
                                                          string selectEvent = null,
                                                          string clearEvent = null,
                                                          string selectstockitemType = null,
                                                          bool disable = false)
        {
            return Inman_DropDownGrid<StockItemModel>(htmlHelper,
                                                          name,
                                                          "/Selector/StockItemType",
                                                          d =>
                                                          {
                                                              d.Bound(f => f.ItemCode2).Width("30px").Title("物料编号");
                                                              d.Bound(f => f.ItemName).Width("30px").Title("物料名称");
                                                              d.Bound(f => f.ItemSpec).Width("30px").Title("物料规格");
                                                              d.Bound(f => f.ColorID).Width("30px").Title("颜色");
                                                              d.Bound(f => f.Component).Width("30px").Title("成分");
                                                              d.Bound(f => f.ItemWidth)
                                                               .Width("30px")
                                                               .Title("有效幅宽(CM)");
                                                              d.Bound(f => f.Weight).Width("30px").Title("克重(g/㎡)");
                                                          },
                                                          dataTextField: dataTextField,
                                                          dataValueField: dataValueField,
                                                          selectedText: selectedText,
                                                          optionLabel: optionLabel,
                                                          perssmissionCode: perssmissionCode,
                                                          gridPageSize: gridPageSize,
                                                          gridWidth: gridWidth,
                                                          gridHeight: gridHeight,
                                                          changeEvent: changeEvent,
                                                          selectEvent: selectEvent,
                                                          clearEvent: clearEvent,
                                                          disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectStockItemFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                Expression<Func<TModel, TProperty>>
                                                                                    expression,
                                                                                string dataTextField = "ItemCode",
                                                                                string dataValueField = "Id",
                                                                                string selectedText = null,
                                                                                string perssmissionCode = null,
                                                                                string optionLabel = " ",
                                                                                int gridPageSize = 6,
                                                                                int? gridWidth = null,
                                                                                int? gridHeight = null,
                                                                                string changeEvent = null,
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false,
                                                                                SelectStockItemBussiness bussiness =
                                                                                    SelectStockItemBussiness.Default
            )
        {


            return Inman_DropDownGridFor<TModel, TProperty, StockItemModel>(htmlHelper,
                                                                            expression,
                                                                            string.Format(
                                                                                "/Selector/StockItemSelect?bussiness={0}",
                                                                                bussiness),
                                                                            d =>
                                                                            {
                                                                                d.Bound(f => f.ItemCode)
                                                                                 .Width(100)
                                                                                 .Title("物料SKU");
                                                                                //d.Bound(f => f.BanLiaoKuCun).Width(100).Title("办料仓库存");
                                                                                d.Bound(f => f.ItemCode2)
                                                                                 .Width(100)
                                                                                 .Title("物料编号");
                                                                                d.Bound(f => f.ItemName)
                                                                                 .Width(100)
                                                                                 .Title("物料名称");
                                                                                d.Bound(f => f.ItemSpec)
                                                                                 .Width(100)
                                                                                 .Title("规格");
                                                                                d.Bound(f => f.Color)
                                                                                 .Width(80)
                                                                                 .Title("颜色");
                                                                                d.Bound(f => f.Component)
                                                                                 .Width(80)
                                                                                 .Title("成分");
                                                                                d.Bound(f => f.ItemWidth)
                                                                                 .Width(80)
                                                                                 .Title("幅宽");
                                                                            },
                                                                            dataTextField,
                                                                            dataValueField,
                                                                            selectedText: selectedText,
                                                                            optionLabel: optionLabel,
                                                                            gridPageSize: gridPageSize,
                                                                            gridWidth: gridWidth,
                                                                            gridHeight: gridHeight,
                                                                            changeEvent: changeEvent,
                                                                            selectEvent: selectEvent,
                                                                            clearEvent: clearEvent,
                                                                            disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectStockItemForLapDip<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                         Expression<Func<TModel, TProperty>> expression,
                                                                         string dataTextField = "ItemCode",
                                                                         string dataValueField = "Id",
                                                                         string selectedText = null,
                                                                         string perssmissionCode = null,
                                                                         string optionLabel = " ",
                                                                         int gridPageSize = 6,
                                                                         int? gridWidth = null,
                                                                         int? gridHeight = null,
                                                                         string changeEvent = null,
                                                                         string selectEvent = null,
                                                                         string clearEvent = null,
                                                                         bool disable = false,
                                                                         SelectStockItemBussiness bussiness = SelectStockItemBussiness.LapDip)
        {
            return Inman_DropDownGridFor<TModel, TProperty, StockItemModel>(htmlHelper,
                                                                            expression,
                                                                            string.Format(
                                                                                "/Selector/StockItemSelectForLapDip?bussiness={0}",
                                                                                bussiness),
                                                                            d =>
                                                                            {
                                                                                d.Bound(f => f.ItemCode2)
                                                                                 .Width(140)
                                                                                 .Title("物料编号");
                                                                                d.Bound(f => f.SupplierName)
                                                                                 .Width(100)
                                                                                 .Title("供应商");
                                                                            },
                                                                            dataTextField,
                                                                            dataValueField,
                                                                            selectedText: selectedText,
                                                                            optionLabel: optionLabel,
                                                                            gridPageSize: gridPageSize,
                                                                            gridWidth: gridWidth,
                                                                            gridHeight: gridHeight,
                                                                            changeEvent: changeEvent,
                                                                            selectEvent: selectEvent,
                                                                            clearEvent: clearEvent,
                                                                            disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectStockItem<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                  string Name,
                                                                  int? SupplierId = 0,
                                                                  string dataTextField = "ItemCode",
                                                                  string dataValueField = "Id",
                                                                  string selectedText = null,
                                                                  string selectedValue = null,
                                                                  string perssmissionCode = null,
                                                                  string optionLabel = " ",
                                                                  int gridPageSize = 6,
                                                                  int? gridWidth = null,
                                                                  int? gridHeight = null,
                                                                  string changeEvent = null,
                                                                  string selectEvent = null,
                                                                  string clearEvent = null,
                                                                  bool disable = false,
                                                                  SelectStockItemBussiness bussiness = SelectStockItemBussiness.Default,
                                                                  int? produceId = null)
        {
            return Inman_DropDownGrid<StockItemModel>(htmlHelper, Name,
                                                      string.Format(
                                                          "/Selector/StockItemSelect?bussiness={0}&supplierId={1}&produceId={2}",
                                                          bussiness, SupplierId, produceId),
                                                      c =>
                                                      {
                                                          /***  请不要再这里删除列，如果必须要用单列，请考虑用用kendo原生DropDownList扩展 ***/
                                                          c.Bound(f => f.ItemCode).Width(140).Title("物料SKU");
                                                          //d.Bound(f => f.BanLiaoKuCun).Width(100).Title("办料仓库存");
                                                          c.Bound(f => f.ItemCode2).Width(100).Title("物料编号");
                                                          c.Bound(f => f.ItemName).Width(100).Title("物料名称");
                                                          c.Bound(f => f.ItemSpec).Width(100).Title("规格");
                                                          c.Bound(f => f.Color).Width(80).Title("颜色");
                                                          c.Bound(f => f.Component).Width(80).Title("成分");
                                                          c.Bound(f => f.ItemWidth).Width(80).Title("幅宽");
                                                      },
                                                      dataTextField: dataTextField,
                                                      dataValueField: dataValueField,
                                                      selectedText: selectedText,
                                                      selectedValue: selectedValue,
                                                      optionLabel: optionLabel,
                                                      perssmissionCode: perssmissionCode,
                                                      gridPageSize: gridPageSize,
                                                      gridWidth: gridWidth,
                                                      gridHeight: gridHeight,
                                                      changeEvent: changeEvent,
                                                      selectEvent: selectEvent,
                                                      clearEvent: clearEvent,
                                                      disable: disable
                );

        }

        #endregion

        #region 设计师选择器

        /// <summary>
        /// 设计师选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_SelectDesignerFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               string dataTextField = "Name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               string optionLabel = " ",
                                                                               int gridPageSize = 10,
                                                                               int? gridWidth = null,
                                                                               int? gridHeight = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               string perssmissionCode = null,
                                                                               bool disable = false)
        {
            return Inman_DropDownGridFor<TModel, TProperty, DesignerModel>(htmlHelper,
                                                                           expression,
                                                                           "/Selector/Designers",
                                                                           c =>
                                                                           {
                                                                               c.Bound(f => f.Name).Width(100);
                                                                               c.Bound(f => f.NameCode).Width(100);
                                                                               c.Bound(f => f.Mobile).Width(100);
                                                                               c.Bound(f => f.Groups).Width(100);
                                                                           },
                                                                           dataTextField: dataTextField,
                                                                           dataValueField: dataValueField,
                                                                           selectedText: selectedText,
                                                                           optionLabel: optionLabel,
                                                                           gridPageSize: gridPageSize,
                                                                           gridWidth: gridWidth,
                                                                           gridHeight: gridHeight,
                                                                           changeEvent: changeEvent,
                                                                           selectEvent: selectEvent,
                                                                           clearEvent: clearEvent,
                                                                           perssmissionCode: perssmissionCode,
                                                                           disable: disable
                );
        }

        #endregion

        #region  行政区域选择器

        /// <summary>
        /// 省/直辖市选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectProvince(this HtmlHelper htmlHelper, string name,
                                                               string dataTextField = "Name",
                                                               string dataValueField = "Name",
                                                               string selectedValue = null,
                                                               string perssmissionCode = null,
                                                               string optionLabel = " ", object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {

                var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                                .DataSource(
                                                    t => t.Read(r => r.Url("/Selector/Provinces")).ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .AutoBind(true);

                if (!string.IsNullOrEmpty(selectedValue))
                    dropDownBuilder = dropDownBuilder.Value(selectedValue);
                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;
        }

        /// <summary>
        /// 省/直辖市选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectProvinceFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                     Expression<Func<TModel, TProperty>>
                                                                                         expression,
                                                                                     string dataTextField = "Name",
                                                                                     string dataValueField = "Name",
                                                                                     string perssmissionCode = null,
                                                                                     string optionLabel = " ",
                                                                                     object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {

                var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                                .DataSource(
                                                    ds =>
                                                    ds.Read(r => r.Url("/Selector/Provinces")).ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .AutoBind(true);

                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;
        }

        /// <summary>
        /// 市/直辖市辖区选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectCity(this HtmlHelper htmlHelper, string name, string cascadeFrom,
                                                           string dataTextField = "Name", string dataValueField = "Name",
                                                           string selectedValue = null, string perssmissionCode = null,
                                                           string optionLabel = " ", object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {province: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                                .DataSource(
                                                    t =>
                                                    t.Read(r => r.Url("/Selector/Citys").Data(script))
                                                     .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true);

                if (!string.IsNullOrEmpty(selectedValue))
                    dropDownBuilder = dropDownBuilder.Value(selectedValue);
                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;

        }

        /// <summary>
        /// 市/直辖市辖区选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectCityFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                 Expression<Func<TModel, TProperty>>
                                                                                     expression, string cascadeFrom,
                                                                                 string dataTextField = "Name",
                                                                                 string dataValueField = "Name",
                                                                                 string perssmissionCode = null,
                                                                                 string optionLabel = " ",
                                                                                 object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {province: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                                .DataSource(
                                                    ds =>
                                                    ds.Read(r => r.Url("/Selector/Citys").Data(script))
                                                      .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true);

                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;
        }



        /// <summary>
        /// 区/县/县级市选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectCounty(this HtmlHelper htmlHelper, string name, string cascadeFrom,
                                                             string dataTextField = "Name",
                                                             string dataValueField = "Name", string selectedValue = null,
                                                             string perssmissionCode = null, string optionLabel = " ",
                                                             object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {city: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                                .DataSource(
                                                    t =>
                                                    t.Read(r => r.Url("/Selector/Countys").Data(script))
                                                     .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true);

                if (!string.IsNullOrEmpty(selectedValue))
                    dropDownBuilder = dropDownBuilder.Value(selectedValue);
                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);
                return dropDownBuilder;
            }
            return null;

        }

        /// <summary>
        /// 区/县/县级市选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectCountyFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>>
                                                                                       expression, string cascadeFrom,
                                                                                   string dataTextField = "Name",
                                                                                   string dataValueField = "Name",
                                                                                   string perssmissionCode = null,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {city: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                                .DataSource(
                                                    ds =>
                                                    ds.Read(r => r.Url("/Selector/Countys").Data(script))
                                                      .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true);

                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);
                return dropDownBuilder;
            }
            return null;
        }
        
        #endregion

        #region 选项选择器

        /// <summary>
        /// 选项选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="optionCode"></param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectOption(this HtmlHelper htmlHelper
                                                             , string name
                                                             , string optionCode
                                                             , string selectedValue = null
                                                             , string selectedText = null
                                                             , string optionLabel = " "
                                                             , object htmlAttributes = null)
        {
            return Inman_DropDownList(htmlHelper
                                      , name
                                      , "/Selector/OptionItems?type=" + optionCode
                                      , "ItemName"
                                      , "ItemValue"
                                      , null
                                      , selectedValue
                                      , selectedText
                                      , null
                                      , optionLabel
                                      , htmlAttributes);
        }

        /// <summary>
        /// 选项选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="optionCode"></param>

        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectOptionFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>>
                                                                                       expression,
                                                                                   string optionCode,
                                                                                   string selectedText = null,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null,
                                                                                   FilterMode filterMode =
                                                                                       FilterMode.Server)
        {
            // string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);

            object value = modelMetadata.Model;
            return Inman_DropDownListFor(htmlHelper, expression,
                                         "/Selector/OptionItems?type=" + optionCode,
                                         "ItemName",
                                         "ItemValue",
                                        string.IsNullOrEmpty(selectedText) ? (value != null ? value.ToString() : "") : selectedText,
                                         null,
                                         null,
                                         optionLabel,
                                         htmlAttributes,
                                         filterMode: filterMode);
            //return Inman_SelectOption(htmlHelper,
            //    name,
            //    optionCode,
            //    value != null ? value.ToString() : "",
            //    selectedText,
            //    optionLabel,
            //    htmlAttributes
            //    );
        }


        /// <summary>
        /// 选项选择器(多选)
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="optionCode"></param>
        /// <param name="maxItems"></param>
        /// <param name="selectedValues"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_SelectOptionMulti(this HtmlHelper htmlHelper
                                                             , string name
                                                             , string optionCode
                                                             , int maxItems
                                                             , IEnumerable selectedValues = null

                                                             , string optionLabel = " "
                                                             , object htmlAttributes = null)
        {
            return Inman_MultiSelect(htmlHelper
                                      , name
                                      , "/Selector/OptionItems?type=" + optionCode
                                      , maxItems
                                      , "ItemName"
                                      , "ItemValue"
                                      , null
                                      , optionLabel
                                      , selectedValues
                                      , htmlAttributes);
        }

        /// <summary>
        /// 选项选择器(多选)
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="optionCode"></param>
        /// <param name="maxItems"></param>
        /// <param name="selectedValues"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_SelectOptionMultiFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string optionCode,
            int maxItems,
            IEnumerable selectedValues = null,
            string optionLabel = " ",
            object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            return Inman_MultiSelect(htmlHelper
                , name
                , "/Selector/OptionItems?type=" + optionCode
                , maxItems
                , "ItemName"
                , "ItemValue"
                , null
                , optionLabel
                , selectedValues
                , htmlAttributes);




        }

        /// <summary>
        /// 办料付款单月份选择
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="optionCode"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectMonthlyFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                    Expression<Func<TModel, TProperty>>
                                                                                        expression,
                                                                                    string perssmissionCode = null,
                                                                                    string optionLabel = " ",
                                                                                    string action = null,
                                                                                    object htmlAttributes = null,
                                                                                    FilterMode filterMode =
                                                                                        FilterMode.Server)
        {
            //string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_DropDownListFor(htmlHelper, expression,
                                         string.Format("/Selector/{0}", action),
                                         "Text",
                                         "Value",
                                         value != null ? value.ToString() : "",
                                         null,
                                         perssmissionCode,
                                         optionLabel,
                                         htmlAttributes,
                                         filterMode: filterMode);
        }

        #endregion

        #region 主列表

        /// <summary>
        /// grid主列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_MainGrid<TModel>(this HtmlHelper htmlHelper) where TModel : BaseModel
        {
            return htmlHelper.Inman_MainGrid<TModel>(new GridConfiguration
            {
                Selectable = true,
                DeleteRowable = true,
                Createable = true,
                Pageable = true,
                GridEditMode = GridEditMode.PopUp,
                Printable = true,
                Filterable = true,
                Sortable = true,
                ColumnMenuable = true,
                Scrollable = true,
                Exportable = true,
                Viewable = true,
                Editable = true
                //HtmlAttributes = new { style = "overflow-y:visible" }
            });
        }

        /// <summary>
        /// grid主列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="permission">权限配置</param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_MainGrid<TModel>(this HtmlHelper htmlHelper, GridPermission permission)
            where TModel : BaseModel
        {
            return htmlHelper.Inman_MainGrid<TModel>(new GridConfiguration
            {
                Selectable = true,
                DeleteRowable = true,
                Createable = true,
                Pageable = true,
                GridEditMode = GridEditMode.PopUp,
                Printable = true,
                Filterable = true,
                Sortable = true,
                ColumnMenuable = true,
                Scrollable = false,
                Editable = true,
                Reorderable = true
            }, permission);
       } 

        /// <summary>
        /// grid主列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="config">grid配置</param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_MainGrid<TModel>(this HtmlHelper htmlHelper, GridConfiguration config)
            where TModel : BaseModel
        {
            
            return htmlHelper.Inman_MainGrid<TModel>(config, new GridPermission());

        }

        /// <summary>
        /// grid主列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="config">grid配置</param>
        /// <param name="permission">权限配置</param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_MainGrid<TModel>(this HtmlHelper htmlHelper, GridConfiguration config,
                                                                 GridPermission permission) where TModel : BaseModel
        {
            var routeData = htmlHelper.ViewContext.RouteData.Values;

            #region grid body

            var grid = htmlHelper.Kendo()
                .Grid<TModel>()
                //Grid中如果直接放可枚举对象,那么该对象的所有数据将在第一次加载时全部被加载到页面发送到客户端,无论是否启用分页,页面都已经在客户端页面中了,此时如果启用分页,由KENDOUI在客户端内存中进行分页操作,而不是请求服务器分页
                .Name("grid").Selectable(s => s.Mode(GridSelectionMode.Single))//.Type(GridSelectionType.Cell)
                .Events(t =>
                {
                    t.DataBinding("gridBinding").DataBound("gridBound");
                    if (config.GridEditMode == GridEditMode.InCell)
                    {
                        t.Save("gridDataChanges");
                    }
                }) //.Change("gridSelectedChange"))
                 .AllowCopy(true)
                .Navigatable(t => t.Enabled(true))
                .Excel(excel => excel.AllPages(true).FileName(config.KendoExportExcelFileName))//.ProxyURL("File/ExportExcel")  //原生导出excel hack 支持IE和苹果浏览器

                .Reorderable(t => t.Columns(config.Reorderable))
                .Scrollable(s => s.Enabled(config.Scrollable)) //.Scrollable(s => { s.Virtual(true); })//利用滚动条翻页
                .Groupable(t => t.Enabled(config.Groupable))
                .Resizable(r => r.Columns(config.Resizable))
                .Sortable(s => s.Enabled(config.Sortable))

                .HtmlAttributes(new { style = "height:685px;" });
            #endregion

            #region normal config

            //这里方法是分页条开关,如果不开启,即使在datasource中定义了pagesize也不会显示分页,页面只会显示第一页的数据,并且没有分页条.
            if (config.Pageable)
                grid.Pageable(t => t.Input(true)
                    .Refresh(true)
                    .PageSizes(new int[] { 15, 30, 45 })
                    .Messages(m => m.ItemsPerPage("条每页")
                        .Empty("没有查询到数据")
                        .Display("当前显示第{0}-{1}条,共{2}条")
                        .First("第一页")
                        .Last("最后一页")
                        .Previous("上一页")
                        .Next("下一页")
                    ));



            grid.Filterable(configurator =>
                    configurator.Enabled(config.Filterable)
                    .Mode(GridFilterMode.Row)
                        .Extra(true)
                        .Operators(o => o.ForString(s => s.Clear().Contains("包含"))));
            //grid.Filterable(configurator => configurator.Mode(GridFilterMode.Row));
            //Extra方法标识是否打开多条件  默认为开启 如果字段不需要多条件筛选即可在字段上关闭



            if (config.ColumnMenuable)
                grid.ColumnMenu(menu => menu.Filterable(true).Sortable(true).Messages(m => m.Lock("冻结").Unlock("解冻")));


            if (config.HtmlAttributes != null)
                grid.HtmlAttributes(config.HtmlAttributes);


            #endregion

            #region op config
            var workContext = EngineContext.Current.Resolve<IWorkContext>();
            var hasOnlyOneAccount = workContext.EnsureSingleAccount(false);

            var createPermission = config.Createable && AuthorizeInLoginAccount(permission.CreateCode); // !hasMultiAccount;
            var editPermission = config.Editable && AuthorizeInLoginAccount(permission.EditCode); //!hasMultiAccount;
            var deletePermission = config.DeleteRowable && AuthorizeInLoginAccount(permission.DeleteCode); // !hasMultiAccount;
            var printPermission = config.Printable && AuthorizeInLoginAccount(permission.PrintCode); //!hasMultiAccount;
            var exportPermission = config.Exportable && AuthorizeInLoginAccount(permission.ExportCode); // !hasMultiAccount;

            string toolBarHtml = "";
            if (createPermission)
            {
                //新增账套选择
                if (config.DiscriminateAccount)
                    toolBarHtml += Inman_OperateAccounts(htmlHelper, permission.CreateCode).ToHtmlString();

                toolBarHtml +=
                    htmlHelper.Kendo()
                        .Button()
                        .Name("btn_main_grid_add")
                        .Content("<span class=\"k-icon Add\"></span>添加")
                        .HtmlAttributes(new { ajax  = false})
                        .ToHtmlString();
            }

            if (deletePermission && config.Selectable)
            {
                toolBarHtml += htmlHelper.Kendo().Button().Name(
                    config.GridEditMode == GridEditMode.InCell
                        ? "btn_main_grid_remove"
                        : "btn_main_grid_delete"
                    )
                                         .Content("<span class=\"k-icon Cancel\"></span>删除选中行")
                                         .HtmlAttributes(new { ajax = false })
                                         .ToHtmlString();

            }

            if (exportPermission)
            {
                if (config.KendoExportExcelEnable)
                    toolBarHtml += htmlHelper.Kendo()
                                  .Button()
                                  .Name("btn_main_grid_export_original")
                                  .Content("<span class=\"k-icon k-i-excel\"></span>导出列表")
                                  .HtmlAttributes(new { ajax = false ,@class= "k-button k-grid-excel" })
                                  .ToHtmlString();
                else
                    toolBarHtml +=
                            htmlHelper.Kendo()
                                      .Button()
                                      .Name("btn_main_grid_export")
                                      .Content("<span class=\"k-icon Pageexcel\"></span>导出列表")
                                      .HtmlAttributes(new { ajax = false })
                                      .ToHtmlString();

            }

            if (hasOnlyOneAccount && editPermission &&  config.GridEditMode == GridEditMode.InCell)
            {
                grid.Editable(edit => edit.Mode(GridEditMode.InCell));
                //如果开始toolbar中的save,改按钮表示批量修改,则需要显示制定编辑模式为单元格编辑,即点击单元格时,单元格进入编辑状态

                toolBarHtml +=
                    htmlHelper.Kendo()
                        .Button()
                        .Name("btn_main_grid_update")
                        .Content("<span class=\"k-icon Accept\"></span>保存修改")
                        .HtmlAttributes(new { ajax = false })
                        .ToHtmlString();

                toolBarHtml +=
                    htmlHelper.Kendo()
                        .Button()
                        .Name("btn_main_grid_k-cancel")
                        .Content("<span class=\"k-icon Delete\"></span>取消修改")
                        .HtmlAttributes(new { ajax = false })
                        .ToHtmlString();
            }

            if (!hasOnlyOneAccount || config.GridEditMode != GridEditMode.InCell)
            {
                grid.Editable(t => t.Enabled(false));
            }


            //自定义按钮
            if (config.ToolBarButtons != null && config.ToolBarButtons.Any(t => t != null))
            {
                toolBarHtml = config.ToolBarButtons.Where(t => t != null).Aggregate(toolBarHtml,
                                                                                    (current, button) =>
                                                                                    current + button.ToHtmlString());
            }

            //帮助按钮
            if (config.ShowHelpButton)
            {
                toolBarHtml +=
                    htmlHelper.Kendo()
                              .Button()
                              .HtmlAttributes(new { style = "float:right" })
                              .Name("btn_main_grid_help")
                              .Content("<span class=\"k-icon Help\"></span>帮助说明")
                              .HtmlAttributes(new { ajax = false })
                              .ToHtmlString();
            }

            //手动载入统计信息按钮
            if (config.ManualAggregate)
            {
                toolBarHtml +=
                    htmlHelper.Kendo()
                              .Button()
                              .HtmlAttributes(new { style = "float:right" })
                              .Name("btn_main_grid_aggregate")
                              .Content("<span class=\"k-icon Sum\"></span>统计信息")
                              .HtmlAttributes(new { ajax = false })
                              .ToHtmlString();
            }

            if (!string.IsNullOrEmpty(toolBarHtml))
                grid.ToolBar(toolbar => toolbar.Template(toolBarHtml));


            grid.Columns(c =>
                {
                    //全选
                    if (deletePermission || config.Selectable)
                    {
                        c.Template(d => d.Id)
                         .ClientTemplate(
                             "<input name=\"selectRow\" type=\"checkbox\" title=\"选中行\" />")
                         .HeaderTemplate("<input name=\"chk_main_grid_check_all\" type=\"checkbox\" title=\"全选\"/>")
                         .Width(35).Locked(true);
                    }
                    bool hasOpColumn =
                        (config.Viewable) ||
                        deletePermission  ||
                        (config.Editable) || //editPermission && config.GridEditMode == GridEditMode.InCell &&&&  hasOnlyOneAccount
                        printPermission ||
                        (config.RowButtons != null && config.RowButtons.Any(t => t != null));
                    if (hasOpColumn)
                    {
                        int width = 1;
                        c.Command(d =>
                            {
                                //查看数据行
                                if (config.Viewable)
                                {
                                    d.Custom("ViewItem")
                                     .Text("<span class=\"k-icon Pagefind\"></span>")
                                     .Click("gridRowView")
                                     .HtmlAttributes(
                                         new
                                         {
                                             style = "min-width:20px;overflow:hidden",
                                             title = "查看",
                                             showloading = "true"
                                         });
                                    width += 25;
                                }
                                //单行删除
                                if (deletePermission)
                                {
                                    d.Custom("Delete")
                                            .Text("<span class=\"k-icon Pagecancel\"></span>")
                                            .Click("gridRowDelete")
                                            .HtmlAttributes(
                                                new
                                                {
                                                    style = "min-width:20px;overflow:hidden",
                                                    title = "删除",
                                                });
                                    width += 25;
                                    //d.Destroy()
                                    // .Text("<span class=\"k-icon Pagecancel\"></span>")
                                    // .HtmlAttributes(
                                    //     new { style = "min-width:20px;overflow:hidden", title = "删除" });
                                    //width += 25;
                                }
                                //单行编辑(跳转编辑)
                                if (config.Editable)//config.GridEditMode == GridEditMode.InCell &&  hasOnlyOneAccount
                                {
                                    if (editPermission)
                                    {
                                        d.Custom("Edit")
                                            .Text("<span class=\"k-icon Pageedit\"></span>")
                                            .Click("gridRowEdit")
                                            .HtmlAttributes(
                                                new
                                                {
                                                    style = "min-width:20px;overflow:hidden",
                                                    title = "编辑",
                                                   // showloading = "true"
                                                });
                                        width += 25;
                                    }
                                    else
                                    {
                                        d.Custom("Edit")
                                            .Text("<span class=\"k-icon Applicationviewdetail\"></span>")
                                            .Click("gridRowEdit")
                                            .HtmlAttributes(
                                                new
                                                {
                                                    style = "min-width:20px;overflow:hidden",
                                                    title = "查看",
                                                   // showloading = "true"
                                                });
                                        width += 25;
                                    }

                                }
                                //打印
                                if (printPermission)
                                {
                                    d.Custom("PrintItem")
                                     .Text("<span class=\"k-icon Printer\"></span>")
                                     .Click("gridRowPrint")
                                     .HtmlAttributes(new { style = "min-width:20px;overflow:hidden", title = "打印" });
                                    width += 25;
                                }
                                if (config.RowButtons != null && config.RowButtons.Any(t => t != null))
                                {

                                    foreach (var button in config.RowButtons.Where(t => t != null))
                                    {
                                        d.Custom("custom-row-button").Text(button.ToHtmlString());
                                        width += 76;
                                    }
                                }
                                if (width > 1 && width < 50)
                                    width = 50;
                            })
                         .Title("操作")
                         .Width(width)
                         .HtmlAttributes(new { @class = @"inman-opcell", style = "min-width:" + width + "px;" }).Locked(true);

                    }
                    c.BoundRowIndex().Locked(config.Lockable);
                });


            #endregion

            return grid;
        }


        #endregion

        #region 明细列表

        /// <summary>
        /// 单据明细列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_DetailGrid<TModel>(this HtmlHelper htmlHelper, IEnumerable<TModel> data)
            where TModel : BaseModel
        {
            return Inman_DetailGrid(htmlHelper, data, new GridConfiguration
            {
                DeleteRowable = true,
                Editable = true,
                GridEditMode = GridEditMode.InCell,
                Scrollable = true,
                Filterable = true
            });
        }

        /// <summary>
        /// 单据明细列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="data"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_DetailGrid<TModel>(this HtmlHelper htmlHelper, IEnumerable<TModel> data,
                                                                   GridConfiguration config)
            where TModel : BaseModel
        {
            return Inman_DetailGrid(htmlHelper, data, config, new GridPermission());
        }

        /// <summary>
        /// 单据明细列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static GridBuilder<TModel> Inman_DetailGrid<TModel>(this HtmlHelper htmlHelper, IEnumerable<TModel> data,
                                                                   GridConfiguration config, GridPermission permission)
            where TModel : BaseModel
        {


            //

            #region 权限控制

            var createPermission = AuthorizeInLoginAccount(permission.CreateCode);
            var editPermission = AuthorizeInLoginAccount(permission.EditCode);
            var deletePermission = AuthorizeInLoginAccount(permission.DeleteCode);

            #endregion

            var grid = htmlHelper.Kendo().Grid<TModel>(data).Name("detail")
                                 .Navigatable(t => t.Enabled(true))
                                 .AllowCopy(true)
                                 .Columns(c =>
                                     {
                                         var width = 51;
                                         if (config.DefaultRowWidth == 0)
                                             config.DefaultRowWidth = 51;
                                         bool hasOpColumn =
                                             (config.Viewable) ||
                                             (deletePermission && config.DeleteRowable) ||
                                             (editPermission && config.Editable &&
                                              config.GridEditMode == GridEditMode.PopUp) ||
                                             (config.RowButtons != null && config.RowButtons.Any(t => t != null));
                                         c.BoundRowIndex().Width(config.DefaultRowWidth).Locked(config.Lockable);
                                         if (hasOpColumn)
                                         {
                                             c.Command(f =>
                                                 {
                                                     if (deletePermission && config.DeleteRowable)
                                                     {
                                                         f
                                                             .Destroy()
                                                             .Text("<span class=\"k-icon Pagecancel\"></span>")
                                                             .HtmlAttributes(
                                                                 new
                                                                 {
                                                                     style = "min-width:20px;overflow:hidden",
                                                                     title = "删除"
                                                                 });
                                                     }
                                                     if (editPermission && config.Editable &&
                                                         config.GridEditMode == GridEditMode.InLine)
                                                     {
                                                         f.Edit()
                                                             .Text("<span class=\"k-icon Pageedit\" title='编辑'></span>")
                                                             .UpdateText(
                                                                 "<span class=\"k-icon Bullettick\"  title='确定'></span>")
                                                             .CancelText(
                                                                 "<span class=\"k-icon Bulletcross\" title='取消'></span>")
                                                             .HtmlAttributes(
                                                                 new
                                                                 {
                                                                     style =
                                                                     "margin-top:1px;min-width:20px;overflow:hidden"
                                                                 });
                                                     }
                                                     if (config.RowButtons != null && config.RowButtons.Any())
                                                         foreach (var button in config.RowButtons)
                                                         {
                                                             f.Custom("custom-row-button").Text(button.ToHtmlString());
                                                             config.DefaultRowWidth += config.DefaultRowWidth > 0 ? 76 : 32;
                                                         }
                                                 }).Title("操作").Locked(true)
                                              .Width(config.DefaultRowWidth)
                                              .HtmlAttributes(new { style = "min-width:" + config.DefaultRowWidth.ToString() + "px;" });
                                         }

                                     }
                );

            //自定义按钮
            string toolBarHtml = "";
            if (createPermission && config.Createable)
                toolBarHtml += Inman_LinkButton(htmlHelper, Guid.NewGuid().ToString(),
                                                "<span class=\"k-icon Add\"></span>添加", "#", @class: "k-grid-add");



            if (config.ToolBarButtons != null && config.ToolBarButtons.Any(t => t != null))
            {
                toolBarHtml = config.ToolBarButtons.Where(t => t != null).Aggregate(toolBarHtml,
                                                                                    (current, button) =>
                                                                                    current + button.ToHtmlString());
            }

            if (config.ColumnMenuable)
                grid.ColumnMenu(menu => menu.Filterable(true).Sortable(true));

            if (!string.IsNullOrEmpty(toolBarHtml))
                grid.ToolBar(toolbar => toolbar.Template(toolBarHtml));

            grid.Events(e => e.DataBinding("detailBinding").DataBound("detailBound").DetailExpand("gridDetailExpand"))//.Save("function(e){ e.sender.dataSource.fetch();}")
                .Editable(t => t.Enabled(config.Editable).Mode(config.GridEditMode))
                    .Reorderable(reorderable => reorderable.Columns(true))
    .Resizable(resizable => resizable.Columns(config.Resizable))
                .Scrollable(t => t.Enabled(config.Scrollable))
                .Selectable()
                .Sortable(t => t.Enabled(config.Sortable))
                .Filterable(t => t.Mode(GridFilterMode.Row))
                .DataSource(ds =>
                            ds.Custom()
                              .AutoSync(false)
                              .ServerFiltering(false)
                              .Schema(d => d.Model(m =>
                                  {
                                      m.Id(ff => ff.Id);
                                  })
                                )
                );
            if (config.HtmlAttributes != null)
                grid.HtmlAttributes(config.HtmlAttributes);
            return grid;
        }

        #endregion

        #region 复选框

        /// <summary>
        /// 复选框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="isChecked"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_CheckBox(this HtmlHelper htmlHelper, string name, bool isChecked, object htmlAttributes = null)
        {

            //            string checkbox = "<input type='checkbox' name='" + name + "' value='true' " + (isChecked
            //                ? "checked='checked'"
            //                : "") + "/>";
            return htmlHelper.CheckBox(name, isChecked, htmlAttributes: htmlAttributes);
        }

        /// <summary>
        /// 复选框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_CheckBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                         Expression<Func<TModel, TProperty>> expression, object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            bool isChecked = false;
            if (value != null)
            {
                if (!bool.TryParse(value.ToString(), out isChecked))
                {
                    int tm = 0;
                    int.TryParse(value.ToString(), out tm);
                    isChecked = tm > 0;
                }
            }
            return Inman_CheckBox(htmlHelper, name, isChecked, htmlAttributes);
        }

        /// <summary>
        /// 复选框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_CheckBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                         Expression<Func<TModel, TProperty>> expression,
                                                                         string perssmissionCode)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
                return Inman_CheckBoxFor(htmlHelper, expression);
            return EmptyHtml;
        }

        #endregion

        #region 普通文本框



        /// <summary>
        /// 普通文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static TextBoxBuilder<string> Inman_TextBox(this HtmlHelper htmlHelper, string name, string value,
                                                           string perssmissionCode = null, object htmlAttributes = null)
        {
            var textbox = htmlHelper.Kendo().TextBox().Name(name).Value(value);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 普通文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static TextBoxBuilder<TProperty> Inman_TextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                    Expression<Func<TModel, TProperty>>
                                                                                        expression,
                                                                                    string perssmissionCode = null,
                                                                                    object htmlAttributes = null, bool readOnly = false)
        {
            var textbox = htmlHelper.Kendo().TextBoxFor(expression);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            IDictionary<string, object> dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object> ?? new Dictionary<string, object>();

            if (readOnly)
            {
                return textbox.ReadOnly(readOnly);
            }
            return textbox.ReadOnly(!Authorize(perssmissionCode));
        }

        #endregion

        #region 密码输入框

        /// <summary>
        /// 密码输入框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static MvcHtmlString Inman_Password(this HtmlHelper htmlHelper, string name, object value)
        {
            return htmlHelper.Password(name, value, new { id = name, @class = "k-textbox" });
        }

        /// <summary>
        /// 密码输入框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Password(this HtmlHelper htmlHelper, string name, object value,
                                                   object htmlAttributes = null, string perssmissionCode = null)
        {
            var htmlAttributes1 = new Dictionary<string, object>
                {
                    {"id", name},
                    {"class", "k-textbox"}
                };

            if (!AuthorizeInLoginAccount(perssmissionCode))
                htmlAttributes1.Add("readonly", "readonly");

            if (htmlAttributes != null)
            {
                var dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;
                htmlAttributes1.Union(dic);
            }
            return htmlHelper.Password(name, value, htmlAttributes1);
        }

        /// <summary>
        /// 密码输入框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static MvcHtmlString Inman_PasswordFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                          Expression<Func<TModel, TProperty>> expression)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_Password(htmlHelper, name, value);
        }


        /// <summary>
        /// 密码输入框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_PasswordFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                         Expression<Func<TModel, TProperty>> expression,
                                                                         string perssmissionCode = null,
                                                                         object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_Password(htmlHelper, name, value, htmlAttributes, perssmissionCode);

        }

        #endregion

        #region 整数文本框

        /// <summary>
        /// 整数文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<int> Inman_TextBox_Integer(this HtmlHelper htmlHelper, string name,
                                                                       int? value, string perssmissionCode = null,
                                                                       object htmlAttributes = null, bool readOnly = false)
        {
            var textbox = htmlHelper.Kendo().IntegerTextBox().Name(name).Value(value).Step(0).Spinners(false);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            if (readOnly)
            {
                return textbox.ReadOnly(readOnly);
            }
            return textbox.ReadOnly(!Authorize(perssmissionCode));
        }


        /// <summary>
        /// 整数文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<int> Inman_TextBox_IntegerFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string perssmissionCode = null, object htmlAttributes = null, bool readOnly = false)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;

            IDictionary<string, object> dic =
                    HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object> ??
                    new Dictionary<string, object>();

            return Inman_TextBox_Integer(htmlHelper, name, value as int?, perssmissionCode, htmlAttributes, readOnly);

        }

        #endregion

        #region 小数文本框

        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static NumericTextBoxBuilder<double> Inman_TextBox_Double(this HtmlHelper htmlHelper, string name,
                                                                          double? value)
        {
            return htmlHelper.Kendo().NumericTextBox().Name(name).Value(value).Format("N4").Step(0).Spinners(false);
        }


        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<double> Inman_TextBox_Double(this HtmlHelper htmlHelper, string name,
                                                                         double? value, string perssmissionCode = null,
                                                                         object htmlAttributes = null)
        {
            var textbox = Inman_TextBox_Double(htmlHelper, name, value);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static NumericTextBoxBuilder<double> Inman_TextBox_DoubleFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_TextBox_Double(htmlHelper, name, value as double?);
        }


        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<double> Inman_TextBox_DoubleFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string perssmissionCode = null, object htmlAttributes = null)
        {
            var textbox = Inman_TextBox_DoubleFor(htmlHelper, expression);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        #endregion

        #region 小数文本框


        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<decimal> Inman_TextBox_Decimal(this HtmlHelper htmlHelper, string name,
                                                                           decimal? value, int decimals = 4,
                                                                           string perssmissionCode = null,
                                                                           object htmlAttributes = null)
        {
            var textbox =
                htmlHelper.Kendo()
                          .NumericTextBox<decimal>()
                          .Name(name)
                          .Value(value)
                          .Step(0)
                          .Spinners(false)
                          .Decimals(decimals)
                          .Format("N" + decimals);
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }


        /// <summary>
        /// 小数文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<decimal> Inman_TextBox_DecimalFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, int decimals = 4,
            string perssmissionCode = null, object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_TextBox_Decimal(htmlHelper, name, value as decimal?, decimals, perssmissionCode, htmlAttributes);

        }

        #endregion

        #region 百分数文本框

        /// <summary>
        /// 百分数文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<double> Inman_TextBox_Percent(this HtmlHelper htmlHelper, string name,
                                                                          double? value, string perssmissionCode = null,
                                                                          object htmlAttributes = null)
        {
            var textbox = htmlHelper.Kendo()
                                    .PercentTextBox()
                                    .Name(name)
                                    .Value(value)
                                    .Decimals(4)
                                    .Step(0)
                                    .Spinners(false)//小数精度
                ;
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }


        /// <summary>
        /// 百分数文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<double> Inman_TextBox_PercentFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string perssmissionCode = null, object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            var textbox = Inman_TextBox_Percent(htmlHelper, name, value as double?).Step(0).Spinners(false);

            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        #endregion

        #region 百分比文本框

        //        public static NumericTextBoxBuilder<int> Inman_NumericTextBox_Percent(this HtmlHelper htmlHepler,
        //            string name,
        //            int min = 0,
        //            int max = 100,
        //            string perssmissionCode = null)
        //        {
        //            var builder = htmlHepler.Kendo().NumericTextBox<int>()
        //                                    .Name(name)
        //                                    .Format("n0")
        //                                    .Min(min)
        //                                    .Max(max);
        //            string func = " var data = parseInt($('#"+ name +"').val());" +
        //                          " if(data >= 1) { " +
        //                          " $($('#" + name + "').data('kendoNumericTextBox')._form).find('#" + name+ "').val(data / 100);" +
        //                          " $($('#" + name + "').data('kendoNumericTextBox')._text[0]).val(data + '%');";
        //            builder.HtmlAttributes(new {onBlur = func});
        //
        //            return !AuthorizeInLoginAccount(perssmissionCode) ? null : builder;
        //        }
        //
        //        public static NumericTextBoxBuilder<double> Inman_NumericTextBox_PercentFor<TModel>(this HtmlHelper<TModel> htmlHepler,
        //           Expression<Func<TModel, double>> expression,
        //           int min = 0,
        //           int max = 100,
        //           string perssmissionCode = null) 
        //        {
        //            var builder = htmlHepler.Kendo().NumericTextBoxFor(expression)
        //                                    .Format("n0")
        //                                    .Min(min)
        //                                    .Max(max);
        //            string name = ExpressionHelper.GetExpressionText(expression);
        //            string func = " var data = parseInt($('#" + name + "').val());" +
        //                          " if(data >= 1) { " +
        //                          " $($('#" + name + "').data('kendoNumericTextBox')._form).find('#" + name + "').val(data / 100);" +
        //                          " $($('#" + name + "').data('kendoNumericTextBox')._text[0]).val(data + '%');";
        //            builder.HtmlAttributes(new { onBlur = func });
        //
        //            return !AuthorizeInLoginAccount(perssmissionCode) ? null : builder;
        //        }

        #endregion


        #region 货币文本框

        /// <summary>
        /// 货币文本框
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<decimal> Inman_TextBox_Currency(this HtmlHelper htmlHelper, string name,
                                                                            decimal? value,
                                                                            string perssmissionCode = null,
                                                                            object htmlAttributes = null)
        {
            var textbox = htmlHelper.Kendo()
                                    .CurrencyTextBox()
                                    .Name(name)
                                    .Value(value)
                                    .Decimals(4) //小数精度
                                    .Format("C4")
                                    .Step(0)
                                    .Spinners(false)
                ;
            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);
            return textbox.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 货币文本框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static NumericTextBoxBuilder<decimal> Inman_TextBox_CurrencyFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string perssmissionCode = null, object htmlAttributes = null, bool readOnly = false)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            var textbox = Inman_TextBox_Currency(htmlHelper, name, value as decimal?);

            if (htmlAttributes != null)
                textbox = textbox.HtmlAttributes(htmlAttributes);

            IDictionary<string, object> dic =
                    HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object> ??
                    new Dictionary<string, object>();
            if (readOnly)
            {
                return textbox.ReadOnly(readOnly);
            }

            return textbox.ReadOnly(!Authorize(perssmissionCode));
        }

        #endregion

        #region 日期选择器

        /// <summary>
        /// 日期选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DatePickerBuilder Inman_DatePicker(this HtmlHelper htmlHelper,
                                                         string name,
                                                         DateTime? value,
                                                         string perssmissionCode = null,
                                                         object htmlAttributes = null)
        {

            var picker = htmlHelper.Kendo()
                                   .DatePicker()
                                   .Name(name)
                                   .Value(value)
                                   .Format("yyyy-MM-dd")
                                   .Min(DateTime.Parse("2000-01-01"))
                                   .Max(DateTime.Parse("2020-01-01"))
                ;
            if (htmlAttributes != null)
                picker = picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));

        }

        /// <summary>
        /// 日期选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DatePickerBuilder Inman_DatePicker(this HtmlHelper htmlHelper,
                                                         string name,
                                                         string value,
                                                         string perssmissionCode = null,
                                                         object htmlAttributes = null)
        {

            var picker = htmlHelper.Kendo()
                                   .DatePicker()
                                   .Name(name)
                                   .Value(value)
                                   .Format("yyyy-MM-dd")
                                   .Min(DateTime.Parse("2000-01-01"))
                                   .Max(DateTime.Parse("2020-01-01"));
            if (htmlAttributes != null)
                picker = picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 日期选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DatePickerBuilder Inman_DatePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                    Expression<Func<TModel, DateTime>> expression,
                                                                    string perssmissionCode = null,
                                                                    object htmlAttributes = null)
        {

            var picker = htmlHelper.Kendo()
                                   .DatePickerFor(expression)
                                   .Format("yyyy-MM-dd")
                                   .Min(DateTime.Parse("2000-01-01"))
                                   .Max(DateTime.Parse("2020-01-01"));
            if (htmlAttributes != null)
                picker = picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));

        }

        /// <summary>
        /// 日期选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DatePickerBuilder Inman_DatePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                    Expression<Func<TModel, DateTime?>> expression,
                                                                    string perssmissionCode = null,
                                                                    object htmlAttributes = null)
        {
            var picker = htmlHelper.Kendo()
                                   .DatePickerFor(expression)
                                   .Format("yyyy-MM-dd")
                                   .Min(DateTime.Parse("2000-01-01"))
                                   .Max(DateTime.Parse("2020-01-01"));
            if (htmlAttributes != null)
                picker = picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }


        #endregion

        #region 日期时间选择器



        /// <summary>
        /// 日期时间选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DateTimePickerBuilder Inman_DateTimePicker(this HtmlHelper htmlHelper, string name,
                                                                 DateTime? value, string perssmissionCode = null,
                                                                 object htmlAttributes = null)
        {
            var picker = htmlHelper.Kendo().DateTimePicker().Name(name).Value(value).Format("yyyy-MM-dd HH:mm:ss");
            if (htmlAttributes != null)
                picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 日期时间选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DateTimePickerBuilder Inman_DateTimePicker(this HtmlHelper htmlHelper, string name, string value,
                                                                 string perssmissionCode = null,
                                                                 object htmlAttributes = null)
        {
            var picker = htmlHelper.Kendo().DateTimePicker().Name(name).Value(value).Format("yyyy-MM-dd HH:mm:ss");
            if (htmlAttributes != null)
                picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 日期时间选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DateTimePickerBuilder Inman_DateTimePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                            Expression<Func<TModel, DateTime?>>
                                                                                expression,
                                                                            string perssmissionCode = null,
                                                                            object htmlAttributes = null)
        {
            var picker = htmlHelper.Kendo().DateTimePickerFor(expression).Format("yyyy-MM-dd HH:mm:ss");
            if (htmlAttributes != null)
                picker.HtmlAttributes(htmlAttributes);
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        /// <summary>
        /// 日期时间选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DateTimePickerBuilder Inman_DateTimePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                            Expression<Func<TModel, DateTime>>
                                                                                expression,
                                                                            string perssmissionCode = null,
                                                                            object htmlAttributes = null)
        {            
            var picker = htmlHelper.Kendo().DateTimePickerFor(expression).Format("yyyy-MM-dd HH:mm:ss");
            if (htmlAttributes != null)
                picker.HtmlAttributes(htmlAttributes);
           
            return picker.ReadOnly(!AuthorizeInLoginAccount(perssmissionCode));
        }

        #endregion

        #region 时间选择器

        /// <summary>
        /// 时间选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static TimePickerBuilder Inman_TimePicker(this HtmlHelper htmlHelper, string name, DateTime? value,
                                                         string perssmissionCode = null, object htmlAttributes = null)
        {
            var builder = htmlHelper.Kendo().TimePicker().Name(name).Value(value);
            if (htmlAttributes != null)
                builder = builder.HtmlAttributes(htmlAttributes);
            return builder;
        }


        /// <summary>
        /// 时间选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static TimePickerBuilder Inman_TimePicker(this HtmlHelper htmlHelper, string name, string value,
                                                         string perssmissionCode = null, object htmlAttributes = null)
        {
            var builder = htmlHelper.Kendo().TimePicker().Name(name).Value(value);
            if (htmlAttributes != null)
                builder = builder.HtmlAttributes(htmlAttributes);
            return builder;
        }

        /// <summary>
        /// 时间选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static TimePickerBuilder Inman_TimePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                    Expression<Func<TModel, DateTime?>> expression,
                                                                    string perssmissionCode = null,
                                                                    object htmlAttributes = null)
        {
            var builder = htmlHelper.Kendo().TimePickerFor(expression);
            if (htmlAttributes != null)
                builder = builder.HtmlAttributes(htmlAttributes);
            return builder;
        }

        #endregion

        #region 文本域

        /// <summary>
        /// 文本域
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="readOnly"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_TextArea(this HtmlHelper htmlHelper, string name, string value, int rows,
                                                   int columns, string perssmissionCode = null,
                                                   object htmlAttributes = null, bool readOnly = false)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                IDictionary<string, object> dic =
                    HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object> ??
                    new Dictionary<string, object>();
                dic.Add("class", "inman-textarea");
                if (readOnly)
                {
                    dic.Add("readonly", "readonly");
                    dic.Add("style", "background:#efefef;");
                }
                return htmlHelper.TextArea(name, value, rows, columns, dic);
            }
            return EmptyHtml;
        }

        /// <summary>
        /// 文本域
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="readOnly"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_TextAreaFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                         Expression<Func<TModel, TProperty>> expression,
                                                                         int rows, int columns,
                                                                         string perssmissionCode = null,
                                                                         object htmlAttributes = null,
                                                                         bool readOnly = false)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                IDictionary<string, object> dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object> ??
                    new Dictionary<string, object>();
                dic.Add("class", "inman-textarea");
                if (readOnly)
                {
                    dic.Add("readonly", "readonly");
                    dic.Add("style", "background:#efefef;");
                }
                return htmlHelper.TextAreaFor(expression, rows, columns, dic);
            }
            return EmptyHtml;
        }

        #endregion

        #region 按钮

        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name">名称</param>
        /// <param name="text">显示文本</param>
        /// <param name="perssmissionCode">权限码</param>
        /// <param name="htmlAttributes">html属性</param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Button(this HtmlHelper htmlHelper, string name, string text,
                                                 string perssmissionCode = null, object htmlAttributes = null,
                                                 bool hidden = false)
        {
            if (hidden || !AuthorizeInLoginAccount(perssmissionCode))
                return null;
            var htmlAttributes1 = new Dictionary<string, object>
                {
                    {"type", "button"},
                    {"class", "k-button"}
                };

            if (htmlAttributes == null)
                return htmlHelper.TextBox(name, text, htmlAttributes1);
            var dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;
            htmlAttributes1.Union(dic);

            return htmlHelper.TextBox(name, text, htmlAttributes1);
        }

        #endregion

        #region 链接按钮

        /// <summary>
        /// 链接按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="url"></param>
        /// <param name="blank"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_LinkButton(this HtmlHelper htmlHelper, string id, string text, string url,
                                                     bool blank = false, string perssmissionCode = null,
                                                     string @class = "")
        {
            if (!AuthorizeInLoginAccount(perssmissionCode))
            {
                return new MvcHtmlString(string.Empty);
            }

            return
                new MvcHtmlString("<a id='" + id + "' href='" + url + "' class='k-button" +
                                  (!string.IsNullOrEmpty(@class) ? " " + @class : "") + "' " +
                                  (blank ? "target='_blank'" : "") + ">" + text + "</a>");
        }

        #endregion

        #region 表单通用提交按钮

        /// <summary>
        /// 表单通用提交按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_Submit(this HtmlHelper htmlHelper)
        {
            return
                htmlHelper.Kendo()
                          .Button()
                          .Name("btn_submit")
                          .Content("<span class='k-icon Tick'></span>保存")
                          .HtmlAttributes(new { name = "Submit", value = "Submit" });
        }



        /// <summary>
        /// 表单通用提交按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_Submit(this HtmlHelper htmlHelper, string perssmissionCode = null,
             string name = "submit", string text = "<span class='k-icon Tick'></span>保存",
                                                  object htmlAttributes = null, bool hidden = false)
        {
            if (hidden || !AuthorizeInLoginAccount(perssmissionCode))
            {
                return null;
            }
            RouteValueDictionary dic = new RouteValueDictionary();
            if (htmlAttributes != null)
            {
                dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            }
            dic.Add("name", name);
            dic.Add("value", name);
            var button = htmlHelper.Kendo()
                          .Button()
                          .Name("btn_" + name)
                          .Content(text).HtmlAttributes(dic);
            return button;
        }

        #endregion

        #region 表单通用重置按钮

        /// <summary>
        /// 表单通用重置按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_Reset(this HtmlHelper htmlHelper, bool hidden = false)
        {
            if (hidden)
                return null;
            return
                htmlHelper.Kendo()
                          .Button()
                          .Name("btn_reset")
                          .Content("<span class='k-icon Arrowrotateclockwise'></span>重置");
        }

        /// <summary>
        /// 表单通用重置按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_Reset(this HtmlHelper htmlHelper, string perssmissionCode, bool hidden = false)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
                return Inman_Reset(htmlHelper, hidden);
            return null;
        }

        #endregion

        #region 统一取消按钮

        /// <summary>
        /// 统一取消按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id">id</param>
        /// <param name="text">显示的文本</param>
        /// <returns></returns>
        public static IHtmlString Inman_Cancel(this HtmlHelper htmlHelper, string id, string text)
        {
            return
                htmlHelper.Raw("<a href=\"javascript:void(0);\"  id=\"" + id + "\" class=\"k-button\">" +
                               "<span class='k-icon Cancel'></span>" + text + "</a>");
        }

        /// <summary>
        /// 统一取消按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="id">id</param>
        /// <param name="text">显示的文本</param>
        /// <param name="perssmissionCode">权限码</param>
        /// <returns></returns>
        public static IHtmlString Inman_Cancel(this HtmlHelper htmlHelper, string id, string text,
                                               string perssmissionCode)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
                return Inman_Cancel(htmlHelper, id, text);
            return EmptyHtml;

        }

        #endregion

        #region 统一搜索面板的搜索按钮

        /// <summary>
        /// 统一搜索面板的搜索按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_SearchButton(this HtmlHelper htmlHelper)
        {
            return htmlHelper.Kendo().Button().Name("btn_search").Content("<span class='k-icon Zoom'></span>搜索");
        }

        /// <summary>
        /// 统一搜索面板的搜索按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_SearchButton(this HtmlHelper htmlHelper, string perssmissionCode)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
                return Inman_SearchButton(htmlHelper);
            return htmlHelper.Kendo().Button().Content("未授权按钮");
        }

        #endregion

        #region 统一搜索面板的清除条件按钮

        /// <summary>
        /// 统一搜索面板的清除条件按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_ClearSearchButton(this HtmlHelper htmlHelper)
        {
            return htmlHelper.Kendo()
                             .Button()
                             .Name("btn_clearSearch")
                             .Content("<span class='k-icon Reload'></span>清除条件");
        }

        /// <summary>
        /// 统一搜索面板的清除条件按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static ButtonBuilder Inman_ClearSearchButton(this HtmlHelper htmlHelper, string perssmissionCode)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
                return Inman_ClearSearchButton(htmlHelper);
            return htmlHelper.Kendo().Button().Content("未授权的按钮");
        }

        #endregion

        #region 添加到明细按钮

        /// <summary>
        /// 添加到明细按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_AddDetailButton(this HtmlHelper htmlHelper, string perssmissionCode = null)
        {
            bool disable = !AuthorizeInLoginAccount(perssmissionCode);
            var h1 = (object)new { type = "button", @class = "k-button" };
            var h2 = (object)new { type = "button", @class = "k-button", disabled = "disabled" };
            var buttonString = htmlHelper.TextBox("btn_add_detail", "添加明细", disable ? h2 : h1);
            var scriptString = "<script type='text/javascript'>$(function(){" +
                               "if(!inman.exitsFunction('func_create_row')){" +
                               "inman.info(\"本页面存在\'添加明细按钮\',需要在页面定义func_create_row方法,该方法返回结果为明细列表的数据项.\")" +
                               "}})</script>";

            return new MvcHtmlString(buttonString + scriptString);
        }

        #endregion

        #region 枚举类型的下拉列表

        /// <summary>
        /// 显示列表项是枚举类型的下拉列表
        /// </summary>
        /// <remarks>
        /// 支持可空枚举类型，通过在枚举项上加[Display(Name="")]的形式来为下拉列表添加列表项名称
        /// </remarks>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="optionLabel">空值对应的列表项名称（例如：“请选择”）</param>
        /// <param name="htmlAttributes">下拉列表Html属性集合</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_EnumDropDownListFor<TModel, TEnum>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TEnum>>
                                                                                       expression,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string name = ExpressionHelper.GetExpressionText(expression);
            string value = (metadata.Model ?? "").ToString();

            IEnumerable<SelectListItem> items = GetSelectListItems<TEnum>(value, optionLabel);

            return htmlHelper.Kendo().DropDownList().Name(name).BindTo(items).HtmlAttributes(htmlAttributes);
            //return htmlHelper.DropDownListFor(expression, items, htmlAttributes);
        }

        /// <summary>
        /// 显示列表项是枚举类型的下拉列表
        /// </summary>
        /// <remarks>
        /// 支持可空枚举类型，通过在枚举项上加[Display(Name="")]的形式来为下拉列表添加列表项名称
        /// </remarks>
        /// <param name="htmlHelper">被扩展对象</param>
        /// <param name="name">控件名</param>
        /// <param name="selectValue">被选中项的值</param>
        /// <param name="optionLabel">空值对应的列表项名称（例如：“请选择”）</param>
        /// <param name="htmlAttributes">下拉列表Html属性集合</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_EnumDropDownList<TEnum>(this HtmlHelper htmlHelper,
                                                                        string name,
                                                                        string selectedValue,
                                                                        string optionLabel = " ",
                                                                        object htmlAttributes = null)
        {
            IEnumerable<SelectListItem> items = null;
            try
            {
                var value = Enum.Parse(typeof(TEnum), selectedValue);
                items = GetSelectListItems<TEnum>(value, optionLabel);
            }
            catch
            {
                items = GetSelectListItems<TEnum>(optionLabel);
            }

            return htmlHelper.Kendo().DropDownList().Name(name).BindTo(items).HtmlAttributes(htmlAttributes);
        }

        /// <summary>
        /// 显示列表项是枚举类型的下拉列表
        /// </summary>
        /// <remarks>
        /// 支持可空枚举类型，通过在枚举项上加[Display(Name="")]的形式来为下拉列表添加列表项名称
        /// </remarks>
        /// <param name="htmlHelper">被扩展对象</param>
        /// <param name="name">控件名</param>
        /// <param name="selectValue">被选中项的值</param>
        /// <param name="optionLabel">空值对应的列表项名称（例如：“请选择”）</param>
        /// <param name="htmlAttributes">下拉列表Html属性集合</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_EnumDropDownList<TEnum>(this HtmlHelper htmlHelper,
                                                                        string name,
                                                                        TEnum selectedValue,
                                                                        string optionLabel = " ",
                                                                        object htmlAttributes = null)
        {

            IEnumerable<SelectListItem> items = GetSelectListItems<TEnum>(selectedValue, optionLabel);
            return htmlHelper.Kendo().DropDownList().Name(name).BindTo(items).HtmlAttributes(htmlAttributes);
        }

        /// <summary>
        /// 显示列表项是枚举类型的下拉列表
        /// </summary>
        /// <remarks>
        /// 支持可空枚举类型，通过在枚举项上加[Display(Name="")]的形式来为下拉列表添加列表项名称
        /// </remarks>
        /// <param name="htmlHelper">被扩展对象</param>
        /// <param name="name">控件名</param>
        /// <param name="selectValue">被选中项的值</param>
        /// <param name="exceptItem">排除项</param>
        /// <param name="optionLabel">空值对应的列表项名称（例如：“请选择”）</param>
        /// <param name="htmlAttributes">下拉列表Html属性集合</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_EnumDropDownList<TEnum>(this HtmlHelper htmlHelper,
                                                                        string name,
                                                                        TEnum selectedValue,
                                                                        TEnum exceptItem,
                                                                        string optionLabel = " ",
                                                                        object htmlAttributes = null)
        {

            IEnumerable<SelectListItem> items =
                GetSelectListItems<TEnum>(selectedValue, optionLabel).Where(n => !n.Value.Equals(exceptItem.ToString()));
            return htmlHelper.Kendo().DropDownList().Name(name).BindTo(items).HtmlAttributes(htmlAttributes);
        }

        public static string GetEnumText<TEnum>(this TEnum value) where TEnum : struct
        {
            return GetEnumDescription(value);
        }
        
        #region Help methods

        /// <summary>
        /// 获取列表项
        /// </summary>
        internal static IEnumerable<SelectListItem> GetSelectListItems<TEnum>(object selectedValue, string optionLabel)
        {
            Type enumType = typeof(TEnum);
            Type underlyingType = Nullable.GetUnderlyingType(enumType);
            if (underlyingType != null)
            {
                enumType = underlyingType;
            }
            IEnumerable<TEnum> values = Enum.GetValues(enumType).Cast<TEnum>();

            IEnumerable<SelectListItem> items = from value in values
                                                select new SelectListItem
                                                {
                                                    Text = GetEnumDescription(value),
                                                    Value = value.ToString(),
                                                    Selected = value.ToString().Equals(selectedValue)
                                                };

            if (!string.IsNullOrEmpty(optionLabel))
                items = (new List<SelectListItem> { new SelectListItem { Text = optionLabel, Value = "0" } }).Concat(items);
            return items;
        }
        /// <summary>
        /// 获取列表项
        /// </summary>
        internal static IEnumerable<SelectListItem> GetSelectListItems<TEnum>(string optionLabel)
        {
            Type enumType = typeof(TEnum);
            Type underlyingType = Nullable.GetUnderlyingType(enumType);
            if (underlyingType != null)
            {
                enumType = underlyingType;
            }
            IEnumerable<TEnum> values = Enum.GetValues(enumType).Cast<TEnum>();

            IEnumerable<SelectListItem> items = from value in values
                                                select new SelectListItem
                                                {
                                                    Text = GetEnumDescription(value),
                                                    Value = value.ToString(),

                                                };

            if (!string.IsNullOrEmpty(optionLabel))
                items = (new List<SelectListItem> { new SelectListItem { Text = optionLabel, Value = string.Empty } }).Concat(items);
            return items;
        }
        public static string GetEnumDescription<TEnum>(this TEnum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            if(fi == null)
                return string.Empty;
            var attribute = fi.GetCustomAttributes(
                typeof(ComponentModel.DataAnnotations.DisplayAttribute), false)
                              .Cast<ComponentModel.DataAnnotations.DisplayAttribute>()
                              .FirstOrDefault();
            if (attribute != null)
                return attribute.Name;
            return value.ToString();
        }


      
        #endregion

        #endregion

        #region 返回按钮

        /// <summary>
        /// 统一返回按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="text">按钮显示的文本</param>
        /// <param name="returnUrl">指定要返回的路径</param>
        /// <returns></returns>
        public static IHtmlString Inman_Goback(this HtmlHelper htmlHelper, string text, string returnUrl = null)
        {
            return
                htmlHelper.Raw("<a href=\"javascript:" +
                               (string.IsNullOrEmpty(returnUrl)
                                    ? "history.go(-1);"
                                    : ("location.href='" + returnUrl + "'")) +
                               "\"  id=\"inman_goback\" class=\"k-button\">" + "<span class='k-icon Arrowundo'></span>" +
                               text + "</a>");
        }

        #endregion

        #region 普通下拉列表

        /// <summary>
        /// 普通下拉列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name">名称或id</param>
        /// <param name="list">数据集合,不一定是SelectItem</param>
        /// <param name="dataTextField">显示文本字段</param>
        /// <param name="dataValueField">值字段</param>
        /// <param name="selectedValue">选中值</param>
        /// <param name="optionLabel">提示标签</param>
        /// <param name="htmlAttributes">html属性</param>
        /// <param name="perssmissionCode">权限码</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_DropDownList(this HtmlHelper htmlHelper,
                                                             string name,
                                                             IEnumerable list,
                                                             string dataTextField,
                                                             string dataValueField,
                                                             string selectedValue = null,
                                                             string selectedText = null,
                                                             string perssmissionCode = null,
                                                             string optionLabel = " ",
                                                             object htmlAttributes = null,
                                                             bool filter = false
            )
        {
            var dropDownBuilder =
                htmlHelper.Kendo()
                          .DropDownList()
                          .Name(name)
                          .BindTo(list)
                          .DataTextField(dataTextField)
                          .DataValueField(dataValueField).AutoBind(string.IsNullOrEmpty(selectedText));
            if (filter)
                dropDownBuilder = dropDownBuilder.Filter(FilterType.Contains);
            if (!string.IsNullOrEmpty(selectedValue))
                dropDownBuilder = dropDownBuilder.Value(selectedValue);
            if (!string.IsNullOrEmpty(selectedText))
                dropDownBuilder = dropDownBuilder.Text(selectedText);
            if (optionLabel != null)
                dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                dropDownBuilder = dropDownBuilder.ReadOnly();
            dropDownBuilder = dropDownBuilder.Events(e => e.DataBound("dropDownListBound"));
            return dropDownBuilder;
        }

        /// <summary>
        /// 普通下拉列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name">名称或id</param>
        /// <param name="dataUrl">数据路径</param>
        /// <param name="dataTextField">显示文本字段</param>
        /// <param name="dataValueField">值字段</param>
        /// <param name="dataFilter">过滤字典</param>
        /// <param name="selectedValue">选中值</param>
        /// <param name="selectedText">选中文本</param>
        /// <param name="optionLabel">提示标签</param>
        /// <param name="perssmissionCode">权限码</param>
        /// <param name="htmlAttributes">html属性</param>
        /// <param name="filterMode">过滤方式</param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_DropDownList(this HtmlHelper htmlHelper,
                                                             string name,
                                                             string dataUrl,
                                                             string dataTextField,
                                                             string dataValueField,
                                                             string dataFilter = null,
                                                             string selectedValue = null,
                                                             string selectedText = null,
                                                             string perssmissionCode = null,
                                                             string optionLabel = " ",
                                                             object htmlAttributes = null,
                                                             FilterMode filterMode = FilterMode.Server
            )
        {
            var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                            .DataSource(t =>
                                                {
                                                    t.Read(r =>
                                                        {
                                                            r.Url(GetDataUrl(dataUrl));
                                                            if (!string.IsNullOrEmpty(dataFilter))
                                                            {
                                                                r.Data(dataFilter);
                                                            }
                                                        }
                                                        ).Events(e => e.RequestEnd("kendoRequestEnd"));
                                                    if (filterMode == FilterMode.Server ||
                                                        !string.IsNullOrEmpty(dataFilter))
                                                        t.ServerFiltering(true);
                                                }).AutoBind(string.IsNullOrEmpty(selectedText));

            dropDownBuilder = dropDownBuilder.Filter(FilterType.Contains);
            dropDownBuilder = dropDownBuilder.DataTextField(dataTextField).DataValueField(dataValueField);
            if (!string.IsNullOrEmpty(selectedValue))
                dropDownBuilder = dropDownBuilder.Value(selectedValue);
            if (!string.IsNullOrEmpty(selectedText))
                dropDownBuilder = dropDownBuilder.Text(selectedText);
            if (optionLabel != null)
                dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                dropDownBuilder = dropDownBuilder.ReadOnly();
            dropDownBuilder = dropDownBuilder.Events(e => e.DataBound("dropDownListBound"));
            return dropDownBuilder;
        }



        /// <summary>
        /// 普通下拉列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="list"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>>
                                                                                       expression,
                                                                                   IEnumerable list,
                                                                                   string dataTextField = "Text",
                                                                                   string dataValueField = "Value",
                                                                                   string selectedText = null,
                                                                                   string perssmissionCode = null,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null,
                                                                                   bool filter = false
            )
        {


            var dropDownBuilder =
                htmlHelper.Kendo()
                          .DropDownListFor(expression)
                          .BindTo(list)
                          .DataTextField(dataTextField)
                          .DataValueField(dataValueField).AutoBind(string.IsNullOrEmpty(selectedText));
            if (filter)
                dropDownBuilder = dropDownBuilder.Filter(FilterType.Contains);
            if (!string.IsNullOrEmpty(selectedText))
                dropDownBuilder = dropDownBuilder.Text(selectedText);
            if (optionLabel != null)
                dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
            if (htmlAttributes != null)
            {
                dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);
            }
            if (!AuthorizeInLoginAccount(perssmissionCode))
                dropDownBuilder = dropDownBuilder.ReadOnly();
            dropDownBuilder = dropDownBuilder.Events(e => e.DataBound("dropDownListBound"));
            return dropDownBuilder;

        }

        /// <summary>
        /// 普通下拉列表
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataUrl"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_DropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>>
                                                                                       expression,
                                                                                   string dataUrl,
                                                                                   string dataTextField,
                                                                                   string dataValueField,
                                                                                   string selectedText = null,
                                                                                   string dataFilter = null,
                                                                                   string perssmissionCode = null,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null,
                                                                                   FilterMode filterMode =
                                                                                       FilterMode.Server,
                                                                                   bool canEdit = true
            )
        {
            var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                            .DataSource(ds =>
                                                {
                                                    ds.Read(r =>
                                                        {
                                                            r.Url(GetDataUrl(dataUrl));
                                                            if (!string.IsNullOrEmpty(dataFilter))
                                                            {
                                                                r.Data(dataFilter);
                                                            }
                                                        }
                                                        ).Events(e => e.RequestEnd("kendoRequestEnd"));
                                                    if (filterMode == FilterMode.Server ||
                                                        !string.IsNullOrEmpty(dataFilter))
                                                        ds.ServerFiltering(true);
                                                }).AutoBind(string.IsNullOrEmpty(selectedText));//2015 - 07-30  

            dropDownBuilder = dropDownBuilder.Filter(FilterType.Contains);

            dropDownBuilder.DataTextField(dataTextField).DataValueField(dataValueField);

            if (!string.IsNullOrEmpty(selectedText))
                dropDownBuilder = dropDownBuilder.Text(selectedText);

            if (optionLabel != null)
                dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

            dropDownBuilder = dropDownBuilder.Events(e => e.DataBound("dropDownListBound"));

            return dropDownBuilder;
        }


        #endregion

        #region 带过滤的下拉列表

        /// <summary>
        /// 带过滤的下拉列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="list"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="selectedValue"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static ComboBoxBuilder Inman_ComboBox(this HtmlHelper htmlHelper,
                                                     string name,
                                                     IEnumerable list,
                                                     string dataTextField,
                                                     string dataValueField,
                                                     string perssmissionCode = null,
                                                     string placeHolder = null,
                                                     string selectedValue = null,
                                                     object htmlAttributes = null,
                                                     bool filter = false)
        {
            var combobox = htmlHelper.Kendo().ComboBox().Name(name).BindTo(list).DataTextField(dataTextField)
                                     .DataValueField(dataValueField)
                                     .Placeholder(placeHolder)
                                     .Value(selectedValue)
                                     .HtmlAttributes(htmlAttributes);
            if (filter)
                combobox = combobox.Filter(FilterType.Contains);

            if (!AuthorizeInLoginAccount(perssmissionCode))
                combobox = combobox.ReadOnly();
            return combobox;
        }






        /// <summary>
        /// 带过滤的下拉列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataUrl"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="selectedValue"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static ComboBoxBuilder Inman_ComboBox(this HtmlHelper htmlHelper,
                                                     string name,
                                                     string dataUrl,
                                                     string dataTextField,
                                                     string dataValueField,
                                                     string perssmissionCode = null,
                                                     string placeHolder = null,
                                                     string selectedValue = null,
                                                     object htmlAttributes = null,
                                                     FilterMode filterMode = FilterMode.Server)
        {

            var comboBox = htmlHelper.Kendo()
                                     .ComboBox()

                                     .Name(name)
                                     .DataSource(ds =>
                                         {
                                             ds.Read(r => r.Url(GetDataUrl(dataUrl)));
                                             if (filterMode == FilterMode.Server)
                                                 ds.ServerFiltering(true);
                                         }
                ).AutoBind(false)
                                     .Suggest(true)
                                     .DataTextField(dataTextField).DataValueField(dataValueField);


            comboBox = comboBox.Filter(FilterType.StartsWith);

            if (!string.IsNullOrEmpty(placeHolder))
                comboBox = comboBox.Placeholder(placeHolder);
            if (!string.IsNullOrEmpty(selectedValue))
                comboBox = comboBox.Value(selectedValue);
            if (htmlAttributes != null)
                comboBox = comboBox.HtmlAttributes(htmlAttributes);

            if (!AuthorizeInLoginAccount(perssmissionCode))
                comboBox = comboBox.ReadOnly();

            return comboBox;
        }



        /// <summary>
        /// 带过滤的多选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="list"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static ComboBoxBuilder Inman_ComboBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                           Expression<Func<TModel, TProperty>>
                                                                               expression,
                                                                           IEnumerable list,
                                                                           string dataTextField,
                                                                           string dataValueField,
                                                                           string perssmissionCode = null,
                                                                           string placeHolder = null,
                                                                           object htmlAttributes = null,
                                                                           bool filter = false)
        {

            var comboBox = htmlHelper.Kendo().ComboBoxFor(expression).BindTo(list)
                                     .DataTextField(dataTextField)
                                     .DataValueField(dataValueField);
            if (!string.IsNullOrEmpty(placeHolder))
                comboBox = comboBox.Placeholder(placeHolder);
            if (htmlAttributes != null)
                comboBox = comboBox.HtmlAttributes(htmlAttributes);

            if (!AuthorizeInLoginAccount(perssmissionCode))
                comboBox = comboBox.ReadOnly();
            return comboBox;
        }



        /// <summary>
        /// 带过滤的单选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataUrl"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static ComboBoxBuilder Inman_ComboBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                           Expression<Func<TModel, TProperty>>
                                                                               expression,
                                                                           string dataUrl,
                                                                           string dataTextField,
                                                                           string dataValueField,
                                                                           string perssmissionCode = null,
                                                                           string placeHolder = null,
                                                                           object htmlAttributes = null,
                                                                           FilterMode filterMode = FilterMode.Server)
        {

            var comboBox = htmlHelper.Kendo().ComboBoxFor(expression).AutoBind(false)
                                     .DataSource(ds =>
                                         {
                                             ds.Read(r => r.Url(GetDataUrl(dataUrl)));
                                             if (filterMode == FilterMode.Server)
                                                 ds.ServerFiltering(true);
                                         })
                                     .Suggest(true)
                                     .DataTextField(dataTextField)
                                     .DataValueField(dataValueField);


            comboBox = comboBox.Filter(FilterType.Contains);

            if (!string.IsNullOrEmpty(placeHolder))
                comboBox = comboBox.Placeholder(placeHolder);
            if (htmlAttributes != null)
                comboBox = comboBox.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                comboBox = comboBox.ReadOnly();
            return comboBox;
        }

        #endregion

        #region 带过滤的多选列表

        /// <summary>
        /// 带过滤的多选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="list"></param>
        /// <param name="maxItems"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="selectedValues"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_MultiSelect(this HtmlHelper htmlHelper,
                                                           string name,
                                                           IEnumerable list,
                                                           int maxItems,
                                                           string dataTextField,
                                                           string dataValueField,
                                                           string perssmissionCode = null,
                                                           string placeHolder = null,
                                                           IEnumerable selectedValues = null,
                                                           object htmlAttributes = null)
        {

            var multiSelect = htmlHelper.Kendo().MultiSelect().Name(name).BindTo(list).MaxSelectedItems(maxItems)
                                        .DataTextField(dataTextField)
                                        .DataValueField(dataValueField)
                                        .AutoClose(false);
            if (!string.IsNullOrEmpty(placeHolder))
                multiSelect = multiSelect.Placeholder(placeHolder);
            if (selectedValues != null)
                multiSelect = multiSelect.Value(selectedValues);
            if (htmlAttributes != null)
                multiSelect = multiSelect.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                multiSelect = multiSelect.ReadOnly();
            return multiSelect;

        }


        /// <summary>
        /// 带过滤的多选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataUrl"></param>
        /// <param name="maxItems"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="selectedValues"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_MultiSelect(this HtmlHelper htmlHelper,
                                                           string name,
                                                           string dataUrl,
                                                           int maxItems,
                                                           string dataTextField,
                                                           string dataValueField,
                                                           string perssmissionCode = null,
                                                           string placeHolder = null,
                                                           IEnumerable selectedValues = null,
                                                           object htmlAttributes = null)
        {

            var multiSelect = htmlHelper.Kendo().MultiSelect().Name(name)
                                        .AutoBind(true)
                                        .DataSource(ds => ds.Read(r => r.Url(GetDataUrl(dataUrl))).ServerFiltering(true))
                                        .Filter(FilterType.Contains)
                                        .MaxSelectedItems(maxItems)
                                        .DataTextField(dataTextField)
                                        .DataValueField(dataValueField)
                                        .AutoClose(false);
            if (!string.IsNullOrEmpty(placeHolder))
                multiSelect = multiSelect.Placeholder(placeHolder);
            if (selectedValues != null)
                multiSelect = multiSelect.Value(selectedValues);
            if (htmlAttributes != null)
                multiSelect = multiSelect.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                multiSelect = multiSelect.ReadOnly();
            return multiSelect;

        }



        /// <summary>
        /// 带过滤的多选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="list"></param>
        /// <param name="maxItems"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_MultiSelectFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                 Expression<Func<TModel, TProperty>>
                                                                                     expression,
                                                                                 IEnumerable list,
                                                                                 int maxItems,
                                                                                 string dataTextField,
                                                                                 string dataValueField,
                                                                                 string perssmissionCode = null,
                                                                                 string placeHolder = null,
                                                                                 object htmlAttributes = null)
        {

            var multiSelect = htmlHelper.Kendo().MultiSelectFor(expression).BindTo(list).MaxSelectedItems(maxItems)
                                        .DataTextField(dataTextField)
                                        .DataValueField(dataValueField)
                                        .AutoClose(false).AutoBind(true);
            if (!string.IsNullOrEmpty(placeHolder))
                multiSelect = multiSelect.Placeholder(placeHolder);
            if (htmlAttributes != null)
                multiSelect = multiSelect.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                multiSelect = multiSelect.ReadOnly();
            return multiSelect;

        }




        /// <summary>
        /// 带过滤的多选列表
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataUrl"></param>
        /// <param name="maxItems"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="placeHolder"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MultiSelectBuilder Inman_MultiSelectFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                 Expression<Func<TModel, TProperty>>
                                                                                     expression,
                                                                                 string dataUrl,
                                                                                 int maxItems,
                                                                                 string dataTextField,
                                                                                 string dataValueField,
                                                                                 string perssmissionCode = null,
                                                                                 string placeHolder = null,
                                                                                 object htmlAttributes = null)
        {

            var multiSelect = htmlHelper.Kendo().MultiSelectFor(expression)
                                        .AutoBind(false)
                                        .DataSource(ds => ds.Read(r => r.Url(GetDataUrl(dataUrl))).ServerFiltering(true))
                                        .Filter(FilterType.Contains)
                                        .MaxSelectedItems(maxItems)
                                        .DataTextField(dataTextField)
                                        .DataValueField(dataValueField)
                                        .AutoClose(false);
            if (!string.IsNullOrEmpty(placeHolder))
                multiSelect = multiSelect.Placeholder(placeHolder);
            if (htmlAttributes != null)
                multiSelect = multiSelect.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                multiSelect = multiSelect.ReadOnly();
            return multiSelect;

        }



        #endregion

        #region 树

        public static MvcHtmlString Inman_TreeView(this HtmlHelper htmlHelper,
                                                   string name,
                                                   string dataUrl,
                                                   string textDataField,
                                                   string valueDataField = null,
                                                   bool multiSelect = false,
                                                   string selectEvent = null,
                                                   string changeEvent = null)
        {
            StringBuilder sb = new StringBuilder("<div id=\"");
            sb.Append(name);
            sb.Append("\"></div>");
            sb.Append("<script type=\"text/javascript\">");
            sb.Append("$(function(){");
            sb.Append("$(\"#"); //初始化树开始
            sb.Append(name);
            sb.Append("\").kendoTreeView({ loadOnDemand: false,");

            sb.Append("dataTextField: \"");
            sb.Append(textDataField);
            sb.Append("\",");
            if (!string.IsNullOrEmpty(valueDataField))
            {
                sb.Append("valueDataField: \"");
                sb.Append(valueDataField);
                sb.Append("\",");
            }
            if (multiSelect)
            {
                sb.Append("checkboxes:{name:'");
                sb.Append(name);
                sb.Append("',checkChildren:true,template:\"<input type='checkbox' name='" + name +
                          "' data-parentid='#: item.parentId#' value='#: item." +
                          (!string.IsNullOrEmpty(valueDataField) ? valueDataField : "id") + "#'>\"},");
            }
            sb.Append("schema: {");
            sb.Append("model: {");
            sb.Append("id: \"id\"");
            sb.Append("}");
            sb.Append("}");
            if (!string.IsNullOrEmpty(selectEvent))
            {
                sb.Append(",select:");
                sb.Append(selectEvent);
            }
            if (!string.IsNullOrEmpty(changeEvent))
            {
                sb.Append(",change:");
                sb.Append(changeEvent);
            }
            sb.Append(" });"); //初始化树结束

            sb.Append("$.get(\"");
            sb.Append(GetDataUrl(dataUrl));
            sb.Append("\", function(data){");
            sb.Append("var treeView=");
            sb.Append("$(\"#");
            sb.Append(name);
            sb.Append("\").data(\"kendoTreeView\");");


            sb.Append("treeView.setDataSource(data);"); //填充数据源

            sb.Append("});");

            sb.Append("});");
            sb.Append("</script>");
            return new MvcHtmlString(sb.ToString());
        }

        #endregion

        #region 上传控件

        /// <summary>
        /// 上传控件
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="bussiness"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="multiple"></param>
        /// <param name="showFileList"></param>
        /// <param name="autoUpload"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Upload(this HtmlHelper htmlHelper,
                                                 string name,
                                                 string value,
                                                 UploadBussiness bussiness,
                                                 string perssmissionCode = null,
                                                 bool multiple = false,
                                                 bool showFileList = false,
                                                 bool autoUpload = true,
                                                 object htmlAttributes = null)
        {
            var hidden = htmlHelper.Hidden(name, value);

            var uploadBuilder = htmlHelper.Kendo().Upload().Name(Guid.NewGuid().ToString())
                                          .Async(a => a.SaveUrl("/File/Save?bussiness=" + bussiness)
                                                       .SaveField("files") //.Batch(true)
                                                       .AutoUpload(autoUpload))
                                          .Multiple(multiple)
                                          .ShowFileList(showFileList)
                                          .Messages(m => m.StatusUploaded("完成"))

                ;

            if (!AuthorizeInLoginAccount(perssmissionCode))
                uploadBuilder.Enable(false);

            uploadBuilder.Events(
                e => e.Error("function(e){popupErrorNotification(e.files[0].name + '上传失败');}")
                      .Success(
                          "function(e){  if(e.response.IsSuccess){popupSuccessNotification(e.response.Message); $('#" +
                          name +
                          "').val($.map(e.response.Files, function(file) {return file;}).join(\", \"));}else{popupErrorNotification(e.response.Message);}}"));

            return new MvcHtmlString(uploadBuilder.ToHtmlString() + hidden.ToHtmlString());
        }

        public static UploadBuilder Inman_Upload(this HtmlHelper htmlHelper,
                                                 string name,
                                                 string templateId,
                                                 string controllername,
                                                 string actionname,
                                                 bool autoUpload = false)
        {
            var uploadBuilder = htmlHelper
                .Kendo()
                .Upload()
                .Name(name)
                .TemplateId(templateId)
                .Async(t =>
                       t.Save(actionname, controllername)
                        .AutoUpload(autoUpload));
            return uploadBuilder;
        }

        /// <summary>
        /// 上传控件
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="bussiness"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="multiple"></param>
        /// <param name="showFileList"></param>
        /// <param name="autoUpload"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_UploadFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                       Expression<Func<TModel, TProperty>> expression,
                                                                       UploadBussiness bussiness,
                                                                       string perssmissionCode = null,
                                                                       bool multiple = false,
                                                                       bool showFileList = false,
                                                                       bool autoUpload = true,
                                                                       object htmlAttributes = null)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            // ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            //string value = (modelMetadata.Model ?? "").ToString();

            var hidden = htmlHelper.HiddenFor(expression);

            var uploadBuilder = htmlHelper.Kendo().Upload().Name(Guid.NewGuid().ToString())
                                          .Async(a => a.SaveUrl("/File/Save?bussiness=" + bussiness)
                                                       .SaveField("files") //.Batch(true)
                                                       .AutoUpload(autoUpload))
                                          .Multiple(multiple)
                                          .ShowFileList(showFileList)
                                          .Messages(m => m.StatusUploaded("完成").StatusFailed(""));

            if (!AuthorizeInLoginAccount(perssmissionCode))
                uploadBuilder.Enable(false);

            uploadBuilder.Events(
                e => e.Error("function(e){popupErrorNotification(e.files[0].name + '上传失败');}")
                      .Success(
                          "function(e){  if(e.response.IsSuccess){popupSuccessNotification(e.response.Message); $('#" +
                          name +
                          "').val($.map(e.response.Files, function(file) {return file;}).join(\", \"));}else{popupErrorNotification(e.response.Message);}}"));

            return
                new MvcHtmlString("<span style=\"width: 100px;height:25px;display: inline-block\">" +
                                  uploadBuilder.ToHtmlString() + hidden.ToHtmlString() + "</span>");
        }

        /// <summary>
        /// 带图片预览的上传控件
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="bussiness"></param>
        /// <param name="value"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="previewWidth"></param>
        /// <param name="previewHeight"></param>
        /// <param name="buttonWidth"></param>
        /// <param name="buttonHeight"></param>
        /// <param name="autoUpload"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Upload_Preview(this HtmlHelper htmlHelper,
                                                         string name,
                                                         UploadBussiness bussiness,
                                                         string value = null,
                                                         string perssmissionCode = null,
                                                         int previewWidth = 100,
                                                         int previewHeight = 100,
                                                         int buttonWidth = 70,
                                                         int buttonHeight = 20,
                                                         bool autoUpload = true,
                                                         bool disable = false)
        {
            var setting = new CommonSettings();
            string previewServer = "";
            switch (bussiness)
            {
                case UploadBussiness.StockItem:
                    previewServer = "";
                    break;
                case UploadBussiness.WashingMethod:
                    previewServer = setting.HttpWashingMethodImgFolder;
                    break;
                case UploadBussiness.ProductProcess:
                    previewServer = setting.HttpProductProcessImgFolder;
                    break;
            }

            var hidden = htmlHelper.Hidden(name, value);
            var image =
                new MvcHtmlString("<div id='" + name + "_preview' style='background:url(\"" + previewServer + value +
                                  "\")  center 0 no-repeat ; background-size: contain; -webkit-background-size: contain;-moz-background-size: contain;-o-background-size: contain;width:" +
                                  previewWidth + "px;height:" + previewHeight + "px;'></div><br>");

            var uploadBuilder = htmlHelper.Kendo().Upload().Name(Guid.NewGuid().ToString())
                                          .Async(a => a.SaveUrl("/File/Save?bussiness=" + bussiness)
                                                       .SaveField("files") //.Batch(true)
                                                       .AutoUpload(autoUpload))
                                          .ShowFileList(false)
                                          .HtmlAttributes(
                                              new
                                              {
                                                  style =
                                                  "width:" + (buttonWidth - 16) + "px;height:" + buttonHeight + "px;"
                                              });

            if (!AuthorizeInLoginAccount(perssmissionCode) || disable)
                uploadBuilder.Enable(false);

            uploadBuilder.Events(
                e =>
                e.Error("function(e){ popupErrorNotification(e.files[0].name + '上传失败');}").Success(
                    "function(e){  if(e.response.IsSuccess == true) { popupSuccessNotification(e.response.Message); var file = $.map(e.response.Files, function(file) {return file;}).join(\", \"); $('#" +
                    name + "').val(file); $('#" + name + "_preview').css('background-image','url(\"" + previewServer +
                    "'+file+ '\")');}else{popupErrorNotification(e.response.Message);}}"));

            var style = "<style type=\"text/css\">.k-dropzone{width:" + buttonWidth + "px;height:" + buttonHeight +
                        "px;padding:0;}.k-upload-button{padding-left:0;padding-right:0;}</style>";

            return
                new MvcHtmlString(style + "<div style='width:" + previewWidth + "px;height:" +
                                  (previewHeight + buttonHeight) + "px'>" + image.ToHtmlString() +
                                  "<span style='display:inline-block;'>" + uploadBuilder.ToHtmlString() + "</span>" +
                                  hidden.ToHtmlString() + "</div>");
        }

        /// <summary>
        /// 带图片预览的上传控件
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="bussiness"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="previewWidth"></param>
        /// <param name="previewHeight"></param>
        /// <param name="buttonWidth"></param>
        /// <param name="buttonHeight"></param>
        /// <param name="autoUpload"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Upload_PreviewFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               UploadBussiness bussiness,
                                                                               string perssmissionCode = null,
                                                                               int previewWidth = 100,
                                                                               int previewHeight = 100,
                                                                               int buttonWidth = 70,
                                                                               int buttonHeight = 20,
                                                                               bool autoUpload = true,
                                                                               bool disable = false)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            var setting = EngineContext.Current.Resolve<CommonSettings>();
            string previewServer = "";
            switch (bussiness)
            {
                case UploadBussiness.StockItem:
                    previewServer = "";
                    break;
                case UploadBussiness.WashingMethod:
                    previewServer = setting.HttpWashingMethodImgFolder;
                    break;
                case UploadBussiness.ProductProcess:
                    previewServer = setting.HttpProductProcessImgFolder;
                    break;
                case UploadBussiness.ProductProcessWoollen:
                    previewServer = setting.HttpProductProcessWoollenImgFolder;
                    break;
            }

            var hidden = htmlHelper.Hidden(name, value);
            var image =
                new MvcHtmlString("<div id='" + name + "_preview' style='background:url(\"" + previewServer + value + "?" + new Random().NextDouble().ToString() +
                                  "\")  center 0 no-repeat ; background-size: contain; -webkit-background-size: contain;-moz-background-size: contain;-o-background-size: contain;width:" +
                                  previewWidth + "px;height:" + previewHeight + "px;'></div><br>");

            var uploadBuilder = htmlHelper.Kendo().Upload().Name(name + "_" + Guid.NewGuid().ToString())

                                          .Async(a => a.SaveUrl("/File/Save?bussiness=" + bussiness)
                                                       .SaveField("files") //.Batch(true)
                                                       .AutoUpload(autoUpload))
                                          .ShowFileList(false)
                                          .HtmlAttributes(
                                              new
                                              {
                                                  style =
                                                  "width:" + (buttonWidth - 16) + "px;height:" + buttonHeight + "px;"
                                              });

            if (!AuthorizeInLoginAccount(perssmissionCode) || disable)
                uploadBuilder.Enable(false);

            uploadBuilder.Events(
                e =>
                e.Error("function(e){ popupErrorNotification(e.files[0].name + '上传失败');}").Success(
                    "function(e){  if(e.response.IsSuccess == true) { popupSuccessNotification(e.response.Message); var file = $.map(e.response.Files, function(file) {return file;}).join(\", \"); $('#" +
                    name + "').val(file); $('#" + name + "_preview').css('background-image','url(\"" + previewServer +
                    "'+file+'?'+ Math.random() + '\")');}else{popupErrorNotification(e.response.Message);}}"));

            var style = "<style type=\"text/css\">.k-dropzone{width:" + buttonWidth + "px;height:" + buttonHeight +
                        "px;padding:0;}.k-upload-button{padding-left:0;padding-right:0;}</style>";

            return
                new MvcHtmlString(style + "<div style='width:" + previewWidth + "px;height:" +
                                  (previewHeight + buttonHeight) + "px'>" + image.ToHtmlString() +
                                  "<span style='display:inline-block;'>" + uploadBuilder.ToHtmlString() + "</span>" +
                                  hidden.ToHtmlString() + "</div>");
        }

        #endregion

        #region 物料选择列表

        public static DropDownListBuilder Inman_SelectStockItem(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataTextField,
                                                                string dataValueField,
                                                                string perssmissionCode = null,
                                                                string optionLabel = " ",
                                                                object htmlAttributes = null)
        {

            var selector = htmlHelper.Kendo().DropDownList()
                                     .Name(name)
                                     .DataTextField(dataTextField)
                                     .DataValueField(dataValueField)
                                     .Filter(FilterType.Contains)
                                     .DataSource(ds => ds.Read("StockItem", "Selector").ServerFiltering(true))
                                     .HeaderTemplate("<div style = 'width:600px'><table>" +
                                                     "<td style = 'width:50px'>物料ID</td>" +
                                                     "<td style = 'width:100px'>物料SKU</td>" +
                                                     "<td style = 'width:100px'>物料编号</td>" +
                                                     "<td style = 'width:100px'>颜色编号</td>" +
                                                     "<td style = 'width:100px'>供应商编号</td>" +
                                                     "<td style = 'width:100px'>供应商色号</td></table> </div>")
                                     .Template("<div style='width:600px'><table>" +
                                               "<td style = 'width:50px'>#: Id #</td>" +
                                               "<td style = 'width:100px'>#: ItemCode #</td>" +
                                               "<td style = 'width:100px'>#: ItemCode2 #</td>" +
                                               "<td style = 'width:100px'>#: ColorCode#</td>" +
                                               "<td style = 'width:100px'>#: SupplierItemCode#</td>" +
                                               "<td style = 'width:100px'>#: SupplierItemColor#</td>" +
                                               "</table></div>")
                                     .Events(
                                         t =>
                                         t.Open("function(e){$('#" + name +
                                                "-list').css('width','auto').css('overflow','visible'); }")
                );
            if (!string.IsNullOrEmpty(optionLabel))
                selector = selector.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                selector = selector.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                selector = selector.ReadOnly();
            return selector;

        }

        #endregion

        #region 联动面辅料档案

        public static DropDownListBuilder Inman_SelectStockItemCode<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                            string Name,
                                                                            string cascadeFrom,
                                                                            string dataTextField = "ItemCode",
                                                                            string dataValueField = "ItemCode",
                                                                            string perssmissionCode = null,
                                                                            string optionLabel = " ",
                                                                            object htmlAttributes = null)
        {

            string script = "function() { var ddl = $(\"#" + cascadeFrom + "\");return {itemCode2: ddl.val()}}";

            var dropDownBuilder = htmlHelper.Kendo().DropDownList()
                                            .Name(Name)
                                            .DataSource(
                                                ds =>
                                                ds.Read(r => r.Action("GetByItemCode", "PriceExamination").Data(script))
                                                  .ServerFiltering(true))
                                            .DataTextField(dataTextField)
                                            .DataValueField(dataValueField)
                                            .Filter(FilterType.Contains)
                                            .HeaderTemplate("<div style = 'width:700px'><table>" +
                                                            "<td style = 'width:100px'>物料SKU</td>" +
                                                            "<td style = 'width:100px'>物料编号</td>" +
                                                            "<td style = 'width:100px'>颜色名称</td>" +
                                                            "<td style = 'width:100px'>颜色编号</td>" +
                                                            "<td style = 'width:100px'>供应商编号</td>" +
                                                            "<td style = 'width:100px'>供应商色号</td></table> </div>")
                                            .Template("<div style='width:700px'><table>" +
                                                      "<td style = 'width:100px'>#: ItemCode #</td>" +
                                                      "<td style = 'width:100px'>#: ItemCode2 #</td>" +
                                                      "<td style = 'width:100px'>#: Color #</td>" +
                                                      "<td style = 'width:100px'>#: ColorCode #</td>" +
                                                      "<td style = 'width:100px'>#: SupplierItemCode #</td>" +
                                                      "<td style = 'width:100px'>#: SupplierItemColor #</td>" +
                                                      "</table></div>")
                                            .Events(
                                                t =>
                                                t.Open("function(e){$('#" + Name +
                                                       "-list').css('width','auto').css('overflow','visible'); }"))
                                            .CascadeFrom(cascadeFrom);

            if (optionLabel != null)
                dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

            if (!AuthorizeInLoginAccount(perssmissionCode))
                dropDownBuilder = dropDownBuilder.ReadOnly();

            return dropDownBuilder;
        }

        #endregion

        #region 包装类别

        public static DropDownListBuilder Inman_SelectProductCategory(this HtmlHelper htmlHelper,
                                                                      string name,
                                                                      string parentid,
                                                                      string dataTextField = "DocNum",
                                                                      string DataValueField = "Id",
                                                                      string perssmissionCode = null,
                                                                      string optionLabel = " ",
                                                                      object htmlAttributes = null)
        {


            var selector = htmlHelper.Kendo().DropDownList()
                                     .Name(name)
                                     .DataTextField(dataTextField)
                                     .DataValueField(DataValueField)
                                     .Filter(FilterType.Contains)
                                     .DataSource(
                                         ds =>
                                         ds.Read(
                                             r => r.Url("/Selector/ProductCategory?parentid=" + parentid.ToString()))
                                           .ServerFiltering(true)
                );
            if (!string.IsNullOrEmpty(optionLabel))
                selector = selector.OptionLabel(optionLabel);
            if (htmlAttributes != null)
                selector = selector.HtmlAttributes(htmlAttributes);
            if (!AuthorizeInLoginAccount(perssmissionCode))
                selector = selector.ReadOnly();
            return selector;

        }

        public static MvcHtmlString Inman_SelectCategoryPackingSet<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                           string Name,
                                                                           string dataTextField = "PackingName",
                                                                           string dataValueField = "Id",
                                                                           string selectedText = null,
                                                                           string perssmissionCode = null,
                                                                           string optionLabel = " ",
                                                                           int gridPageSize = 8,
                                                                           int? gridWidth = null,
                                                                           int? gridHeight = null,
                                                                           string changeEvent = null,
                                                                           string selectEvent = null,
                                                                           string clearEvent = null,
                                                                           bool disable = false
            )
        {
            return Inman_DropDownGrid<StockItemCategoryPackingSetModel>(htmlHelper,
                                                                        Name,
                                                                        string.Format("/Selector/CategoryPackingSet"),
                                                                        d =>
                                                                        {
                                                                            d.Bound(f => f.Brand)
                                                                             .Width(50)
                                                                             .Title("品牌");
                                                                            d.Bound(f => f.StockItemCategoryName)
                                                                             .Width(50)
                                                                             .Title("类别名称");
                                                                            d.Bound(f => f.PackingName)
                                                                             .Width(100)
                                                                             .Title("包装名称");
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        #endregion

        #region 弹出grid窗体的下拉框

        /// <summary>
        /// 弹出grid窗体的下拉框
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="dataUrl"></param>
        /// <param name="configurator"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="selectedValue"></param>
        /// <param name="optionLabel"></param>
        /// <param name="gridPageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <param name="clearEvent"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="disable"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_DropDownGrid<TSource>(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataUrl,
                                                                Action<GridColumnFactory<TSource>> configurator,
                                                                string dataTextField,
                                                                string dataValueField,
                                                                string selectedText = null,
                                                                string selectedValue = null,
                                                                string optionLabel = " ",
                                                                int gridPageSize = 8,
                                                                int? gridWidth = 500,
                                                                int? gridHeight = null,
                                                                string changeEvent = null,
                                                                string selectEvent = null,
                                                                string clearEvent = null,
                                                                string perssmissionCode = null,
                                                                bool disable = false)
            where TSource : BaseModel
        {
            bool enable = !disable && AuthorizeInLoginAccount(perssmissionCode);
            //if (!enable)
            //    return Inman_TextBoxForComplex(htmlHelper, name, selectedValue, selectedText);
            
            gridWidth = gridWidth ?? 500;
            //初始化grid
            var grid = htmlHelper.Kendo().Grid<TSource>().Name(name + "_grid").Columns(configurator)
                                 .Selectable()
                                 .Filterable(filter => filter.Enabled(true).Mode(GridFilterMode.Row))
                                 .Pageable(page => page.Enabled(true))
                                 .Scrollable()
                                 .ToolBar(
                                     t =>
                                     t.Template(
                                         Inman_Button(htmlHelper: htmlHelper, name: name + "_clear", text: "清除",
                                                      hidden: false,
                                                      htmlAttributes:
                                                          new
                                                          {
                                                              onclick =
                                                          "inman.kendoGrid(\"#" + name +
                                                          "_grid\").clearSelection();$(\"#" + name +
                                                          "\").data(\"kendoDropDownList\").text('请选择');$(\"#" + name +
                                                          "\").data(\"kendoDropDownList\").value('');$(\"#" + name +
                                                          "\").val('');" +
                                                          (!string.IsNullOrEmpty(clearEvent)
                                                               ? clearEvent + "(inman.kendoGrid('#" + name + "_grid'));"
                                                               : "")
                                                          }).ToHtmlString()))
                                 //.ColumnMenu(t=>t.)
                                 .Events(e =>
                                     {
                                         //这里用grid的行点击事件来模拟select事件
                                         string boundEvent = "function(e){setGridComponentStyle(e.sender);e.sender.tbody.find('tr[role=row]').click(function(b){b.data =e.sender.dataItem(this); ";


                                         if (!string.IsNullOrEmpty(selectEvent))
                                          boundEvent +=  selectEvent + " && " + selectEvent + "(b);";
                                         boundEvent += "});}";
                                         e.DataBound(boundEvent);

                                     })
                                 .HtmlAttributes(
                                     new
                                     {
                                         style =
                                         "display:none;min-width:" +
                                         (gridWidth.HasValue ? gridWidth.ToString() + "px" : "auto") + "min-height:" +
                                         (gridHeight.HasValue ? (gridHeight - 70).ToString() + "px" : "auto")
                                     })
                                 .DataSource(ds =>
                                             ds.Ajax()
                                             .Batch(true)
                                              .Model(m => m.Id(f => f.Id))
                                               .Read(r =>
                                                     r.Url(GetDataUrl(dataUrl))
                                                 )
                                               .PageSize(gridPageSize)
                ).ToHtmlString();

          

            string input = "<span id='" + name + "_dropdown'></span>";
            string script = "<script>" +
                            "$(function(){ $('#" + name + "_dropdown').kendoDropDownGrid({" +
                            "name:'" + name + "'," +
                            "grid:$('#" + name + "_grid').data('kendoGrid')," +
                            "dataTextField:'" + dataTextField + "'," +
                            "dataValueField:'" + dataValueField + "'," +
                            "autoBind:false," +

                            (gridWidth.HasValue ? "gridWidth:'" + gridWidth + "px'," : "") +
                            (gridHeight.HasValue ? "gridHeigth:'" + gridHeight + "px'," : "") +
                            (!string.IsNullOrEmpty(changeEvent) ? "changeEvent:" + changeEvent + "," : "") +
                            (!string.IsNullOrEmpty(selectedText) ? "text:'" + selectedText + "'," : "") +
                            "value:'" + (selectedValue ?? "") + "'," +
                            (!string.IsNullOrEmpty(optionLabel) ? "optionLabel:'" + optionLabel + "'" : "") +
                            "});" +
                            (enable ? "" : "inman.kendoDropDownList('#" + name + "').readonly();") +
                            "});" +
                            "</script>";
            return new MvcHtmlString(grid + input + script);
        }

        /// <summary>
        /// 弹出grid窗体的下拉框
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataUrl"></param>
        /// <param name="configurator"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="optionLabel"></param>
        /// <param name="gridPageSize"></param>
        /// <param name="gridWidth"></param>
        /// <param name="gridHeight"></param>
        /// <param name="changeEvent"></param>
        /// <param name="selectEvent"></param>
        /// <param name="perssmissionCode"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_DropDownGridFor<TModel, TProperty, TSource>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataUrl,
            Action<GridColumnFactory<TSource>> configurator,
            string dataTextField,
            string dataValueField,
            string selectedText = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = 500,
            int? gridHeight = 325,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            string perssmissionCode = null,
            bool disable = false)
            where TSource : BaseModel
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_DropDownGrid<TSource>(htmlHelper,
                                               name,
                                               dataUrl,
                                               configurator,
                                               dataTextField: dataTextField,
                                               dataValueField: dataValueField,
                                               selectedText: selectedText,
                                               selectedValue: value.ToString(),
                                               optionLabel: optionLabel,
                                               gridPageSize: gridPageSize,
                                               gridWidth: gridWidth,
                                               gridHeight: gridHeight,
                                               changeEvent: changeEvent,
                                               selectEvent: selectEvent,
                                               clearEvent: clearEvent,
                                               perssmissionCode: perssmissionCode,
                                               disable: disable
                );
        }

        #endregion

        #region 组织架构

        /// <summary>
        /// 组织架构
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="filterMode"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectOrganizeFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                     Expression<Func<TModel, TProperty>>
                                                                                         expression,
                                                                                     string dataTextField = "FullName",
                                                                                     string dataValueField = "Id",
                                                                                     string selectedText = null,
                                                                                     string perssmissionCode = null,
                                                                                     string optionLabel = " ",
                                                                                     object htmlAttributes = null,
                                                                                     FilterMode filterMode =
                                                                                         FilterMode.Server)
        {
            return Inman_DropDownListFor(htmlHelper, expression, "/Selector/Organize?validate=true", dataTextField,
                                         dataValueField, selectedText, null, perssmissionCode, optionLabel,
                                         htmlAttributes);
        }

        #endregion

        #region 采购单选择大货制单号

        public static MvcHtmlString Inman_SelectProduceOrderForPurchaseOrder(this HtmlHelper htmlHelper, string name,
                                                                             int? supplierId, int? purchaseOrderId, string docMode,
                                                                             int? gridWidth = null)
        {
            string section1 = (purchaseOrderId == null || purchaseOrderId == 0
                                   ? ""
                                   : "&purchaseOrderId=" + purchaseOrderId.Value);
            string section2 = (supplierId == null || supplierId == 0
                                   ? ""
                                   : "&suppliersId=" + supplierId.Value);
            string section3 = (String.IsNullOrEmpty(docMode)
                       ? ""
                       : "&produceMode=" + docMode);
            return Inman_DropDownGrid<ProduceSchedule2Model>(htmlHelper, name,
                                                             "/Selector/ProduceOrderForPurchaseOrder?1=1" + section1 +
                                                             section2 + section3
                                                             , c =>
                                                                 {
                                                                     c.Bound(f => f.ProductSN).Width(100);
                                                                     c.Bound(f => f.ProduceOrderDocNum).Width(100);
                                                                     c.Bound(f => f.Color).Width(100);
                                                                     c.Bound(f => f.SizeTotal).Width(100);
                                                                     c.Bound(f => f.ArrivalScheduleDate).Width(100);
                                                                 },
                                                             dataTextField: "ProduceOrderDocNum",
                                                             dataValueField: "ProduceOrderID",
                                                             gridWidth: gridWidth);
        }

        #endregion

        #region 选择仓库

        public static DropDownListBuilder Inman_SelectWarehouse(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataTextField = "Name",
                                                                string dataValueField = "Id",
                                                                string selectedValue = null,
                                                                string selectedText = null,
                                                                string optionLabel = " ",
                                                                string perssmissionCode = null,
                                                                SelectWarehouseBussiness bussiness =
                                                                    SelectWarehouseBussiness.Default
            )
        {
            return Inman_DropDownList(htmlHelper, name, string.Format("/Selector/Warehouses?bussiness={0}", bussiness),
                                      dataTextField: dataTextField,
                                      dataValueField: dataValueField,
                                      selectedValue: selectedValue,
                                      selectedText: selectedText,
                                      optionLabel: optionLabel,
                                      perssmissionCode: perssmissionCode
                );
        }

        public static DropDownListBuilder Inman_SelectWarehouseFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "Name",
            string dataValueField = "Id",
            string selectedValue = null,
            string selectedText = null,
            string optionLabel = " ",
            string perssmissionCode = null,
            SelectWarehouseBussiness bussiness = SelectWarehouseBussiness.Default
            )
        {
            return Inman_DropDownListFor(htmlHelper, expression,
                                         string.Format("/Selector/Warehouses?bussiness={0}", bussiness),
                                         dataTextField: dataTextField,
                                         dataValueField: dataValueField,
                                         selectedText: selectedText,
                                         optionLabel: optionLabel,
                                         perssmissionCode: perssmissionCode
                );
        }

        #endregion

        #region 成品入库预约单选择大货制单号

        public static MvcHtmlString Inman_SelectProduceOrderForEstimateArriveOrder(this HtmlHelper htmlHelper,
                                                                                   string name,
                                                                                   int? suppliersId,
                                                                                   int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0
                                   ? ""
                                   : "&suppliersId=" + suppliersId.Value);

            return Inman_DropDownGrid<ProductPurchaseOrderDetailModel>(htmlHelper, name,
                                                                       "/Selector/ProduceOrderForEstimateArriveOrder?1=1" +
                                                                       section1,
                                                                       c =>
                                                                       {
                                                                           c.Bound(f => f.DocNum).Width(100);
                                                                           c.Bound(f => f.ProduceOrderNum)
                                                                            .Width(100);
                                                                           c.Bound(f => f.ProductSN).Width(100);
                                                                           c.Bound(f => f.ProductColor).Width(100);
                                                                           c.Bound(f => f.Amount)
                                                                            .Width(100)
                                                                            .Title("下单总数");
                                                                           c.Bound(f => f.ArrivalScheduleDate)
                                                                            .Width(100);
                                                                       },
                                                                       dataTextField: "DocNum",
                                                                       dataValueField: "ProductPurchaseOrderID",
                                                                       gridWidth: gridWidth
                );
        }

        #endregion

        #region 基础弹窗

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="buttonName">按钮Name</param>
        /// <param name="buttonText">按钮名称</param>
        /// <param name="name">窗体Name</param>
        /// <param name="title">窗体名称</param>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="modal"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Window(
            this HtmlHelper htmlHelper,
            string buttonName,
            string buttonText,
            string name,
            string title,
            string controllerName,
            string actionName,
            int width = 800,
            int height = 600,
            bool modal = true,
            string perssmissionCode = null,
            object routeValues = null,
            string closeEvent = null)
        {
            if (routeValues == null)
            {
                routeValues = new { };
            }

            //var button = Inman_Button(htmlHelper, buttonName, buttonText, perssmissionCode, htmlAttributes: new
            //    {
            //        id = buttonName,
            //        onclick =@"inman.kendoWindow('#" + name + "').open();"
            //    });

            //var windowBuilder = htmlHelper.Kendo()
            //                              .Window()
            //                              .Name(name)
            //                              .Title(title)
            //                              .Draggable()
            //                              .Resizable()
            //                              .Width(width)
            //                              .Height(height)
            //                              .Actions(actions => actions.Pin().Minimize().Maximize().Close())
            //                              .LoadContentFrom(actionName, controllerName, routeValues)
            //                              .Iframe(true)
            //                              .Modal(modal)
            //                              .Visible(false);
            //return new MvcHtmlString(windowBuilder.ToHtmlString() + button.ToHtmlString());

            string buttonOnClickHandlerName = buttonName.Trim() + "_onClickHandler";
            var button = Inman_Button(htmlHelper, buttonName, buttonText, perssmissionCode, htmlAttributes: new
            {
                id = buttonName,
                onclick = buttonOnClickHandlerName + "();"
            });

            string strUrl = htmlHelper.UrlHelper().Action(actionName, controllerName, routeValues);
            string initWindowHandlerName = "init" + name.Trim();
            var script = "<script>" +
                         "   function  " + initWindowHandlerName + "(){" +
                         "         jQuery('#" + name + "').kendoWindow({" +
                         "                                         'modal':" + modal.ToString().ToLower() + "," +
                         "                                         'iframe':true," +
                         "                                         'draggable':true," +
                         "                                         'pinned':false," +
                         "                                         'title':'" + title + "'," +
                         "                                         'resizable':true," +
                         "                                         'content':'" + strUrl + "'," +
                         "                                         'width':" + width + "," +
                         "                                         'height':" + height + "," +
                         "                                         'actions':['Close']," +
                         "                                         'visible':false" +
                         (string.IsNullOrEmpty(closeEvent) ? "" : ",'close':" + closeEvent) +
                         "                                        });" +
                         "               };" +
                         "   function " + buttonOnClickHandlerName + "(){" +
                         "             var window=$('#" + name + "');" +
                         "             if (window.get().length == 0) {" +
                         "                  $('body').append(\"<div id='" + name + "'></div>\");" +
                         "                      window = $('#" + name + "');" +
                         "              }" +
                         "             if (window.data('kendoWindow')) {" +
                         "                   window.data('kendoWindow').destroy();" +
                         "                   $('body').append(\"<div id='" + name + "'></div>\");" +
                         "                        " + initWindowHandlerName + "();" +
                         "                        window = $('#" + name + "');" +
                         "                        window.data(\"kendoWindow\").center();" +
                         "                        window.data(\"kendoWindow\").open();" +
                         "                  }" +
                         "                  else {" +
                         "                        " + initWindowHandlerName + "();" +
                         "                        window.data(\"kendoWindow\").center();" +
                         "                        window.data(\"kendoWindow\").open();" +
                         "                  }" +
                         "          };" +
                         "</script>";

            return
                new MvcHtmlString(new MvcHtmlString(script).ToHtmlString() +
                                  (button != null ? button.ToHtmlString() : ""));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="buttonText"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="modal"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Window(
            this HtmlHelper htmlHelper,
            string name,
            string buttonText,
            string title,
            string content,
            int width = 800,
            int height = 600,
            bool modal = true,
            string perssmissionCode = null,
            object routeValues = null,
            string closeEvent = null)
        {

            string buttonName = name + "_button";
            var button = Inman_Button(htmlHelper, buttonName, buttonText, perssmissionCode, htmlAttributes: new
            {
                id = buttonName,
                onclick = @"inman.kendoWindow('#" + name + "').center();inman.kendoWindow('#" + name + "').open();"
            });
            var windowBuilder = htmlHelper.Kendo()
                                          .Window()
                                          .Name(name)
                                          .Title(title)
                                          .Draggable()
                                          .Resizable()
                                          .Width(width)
                                          .Height(height)
                                          .Actions(actions => actions.Pin().Minimize().Maximize().Close())
                                          .Content(content)
                                          .Iframe(true)
                                          .Modal(modal)
                                          .Visible(false)
                                          .Events(e => e.Close(closeEvent))
                ;
            return new MvcHtmlString(windowBuilder.ToHtmlString() + (button != null ? button.ToHtmlString() : ""));
        }


        /// <summary>
        /// 弹窗，获取控件值后再生成窗体
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="buttonName">按钮Name</param>
        /// <param name="buttonText">按钮名称</param>
        /// <param name="name">窗体Name</param>
        /// <param name="title">窗体名称</param>
        /// <param name="controllerName"></param>
        /// <param name="actionName"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="modal"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="routeValues"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Window(
            this HtmlHelper htmlHelper,
            string buttonName,
            string buttonText,
            string name,
            string title,
            string controllerName,
            string actionName,
            string key,
            int width = 800,
            int height = 600,
            bool modal = true,
            string perssmissionCode = null,
            object routeValues = null,
            string closeEvent = null)
        {
            if (routeValues == null)
            {
                routeValues = new { };
            }
            string buttonOnClickHandlerName = buttonName.Trim() + "_onClickHandler";
            var button = Inman_Button(htmlHelper, buttonName, buttonText, perssmissionCode, htmlAttributes: new
            {
                id = buttonName,
                datakey = key ,
                onclick = buttonOnClickHandlerName + "();"
            });

            string strUrl = htmlHelper.UrlHelper().Action(actionName, controllerName, routeValues);
            string initWindowHandlerName = "init" + name.Trim();
            var script = "<script>" +
                         "   function  " + initWindowHandlerName + "(){" +
                         "         var key = jQuery('#"+buttonName+ "').attr('datakey');" + 
                         "         if(key == null || key == undefined) key = '0';" + 
                         "         jQuery('#" + name + "').kendoWindow({" +
                         "                                         'modal':" + modal.ToString().ToLower() + "," +
                         "                                         'iframe':true," +
                         "                                         'draggable':true," +
                         "                                         'pinned':false," +
                         "                                         'title':'" + title + "'," +
                         "                                         'resizable':true," +
                         "                                         'content':'" + strUrl + "/' + key," +
                         "                                         'width':" + width + "," +
                         "                                         'height':" + height + "," +
                         "                                         'actions':['Close']," +
                         "                                         'visible':false" +
                         (string.IsNullOrEmpty(closeEvent) ? "" : ",'close':" + closeEvent) +
                         "                                        });" +
                         "               };" +
                         "   function " + buttonOnClickHandlerName + "(){" +
                         "             var key = jQuery('#" + buttonName + "').attr('datakey');" +
                         "             if(key == null || key == undefined) return;" +
                         "             if(key === '0') return;" +
                         "             var window=$('#" + name + "');" +
                         "             if (window.get().length == 0) {" +
                         "                  $('body').append(\"<div id='" + name + "'></div>\");" +
                         "                      window = $('#" + name + "');" +
                         "              }" +
                         "             if (window.data('kendoWindow')) {" +
                         "                   window.data('kendoWindow').destroy();" +
                         "                   $('body').append(\"<div id='" + name + "'></div>\");" +
                         "                        " + initWindowHandlerName + "();" +
                         "                        window = $('#" + name + "');" +
                         "                        window.data(\"kendoWindow\").center();" +
                         "                        window.data(\"kendoWindow\").open();" +
                         "                  }" +
                         "                  else {" +
                         "                        " + initWindowHandlerName + "();" +
                         "                        window.data(\"kendoWindow\").center();" +
                         "                        window.data(\"kendoWindow\").open();" +
                         "                  }" +
                         "          };" +
                         "</script>";

            return
                new MvcHtmlString(new MvcHtmlString(script).ToHtmlString() +
                                  (button != null ? button.ToHtmlString() : ""));
        }
        #endregion

        #region 尺码数量编辑框

        public static MvcHtmlString Inman_SizeQtyEditor(this HtmlHelper htmlHelper, ISizeExtend<SizeQuantityModel> obj)
        {
           
            return htmlHelper.Partial("~/Views/Shared/EditorTemplates/SizeQuantity.cshtml", obj);
        }

        public static MvcHtmlString Inman_SizeQtyShow(this HtmlHelper htmlHelper, ISizeExtend<SizeQuantityModel> obj,bool showTips = true)
        {
            htmlHelper.ViewData["SizeQtyEditorShowTips"] = showTips;
            return htmlHelper.Partial("~/Views/Shared/EditorTemplates/SizeQuantityShow.cshtml", obj);
        }

        #endregion

        #region 弹出grid的window

        public static MvcHtmlString Inman_WindowGrid<TModel>(
            this HtmlHelper htmlHelper,
            string name,
            string buttonText,
            string title,
            string dataUrl,
            Action<GridColumnFactory<TModel>> configurator,
            int pageSize = 15,
            int width = 800,
            bool modal = true,
            string perssmissionCode = null,
            string selectEvent = null,
            bool pageable = true,
            FilterMode filterMode = FilterMode.Server,
            bool showCheckboxColumn = true,
            int height = 440)
            where TModel : BaseModel
        {
            #region 搜索方式
            Action<DataSourceBuilder<TModel>> builder;
            if (filterMode == FilterMode.Server)
            { builder = ds => ds.Ajax().Read(f => f.Url(GetDataUrl(dataUrl))).PageSize(pageSize); }
            else
            { builder = ds => ds.Ajax().ServerOperation(false).Read(f => f.Url(GetDataUrl(dataUrl))).PageSize(pageSize); }

            #endregion

            #region 选择列
            Action<GridColumnFactory<TModel>> columnConfigurator = c => { };
            if (showCheckboxColumn)
            {
                columnConfigurator = c =>
                 {
                     c.Template(d => d.Id)
                         .ClientTemplate(
                             "<input name=\"selectRow\" type=\"checkbox\" title=\"选中行\" />")
                         .HeaderTemplate(
                             "<input name=\"chk_main_grid_check_all\" type=\"checkbox\" title=\"全选\"/>")
                         .Width(25);
                 };
            }
            #endregion

            var htmlAttributes = new { style = "height:" + (height - 50) };
            var grid = htmlHelper.Kendo()
                                 .Grid<TModel>()
                                 //Grid中如果直接放可枚举对象,那么该对象的所有数据将在第一次加载时全部被加载到页面发送到客户端,
                                 //无论是否启用分页,页面都已经在客户端页面中了,此时如果启用分页,由KENDOUI在客户端内存中进行分页操作,
                                 //而不是请求服务器分页
                                 .DataSource(builder)
                                 .Name(name + "_Grid")
                                 .Events(t => t.DataBound("gridBound"))
                                 .Filterable(t => t.Mode(GridFilterMode.Row))
                                 //Extra方法标识是否打开多条件 默认为开启 如果字段不需要多条件筛选即可在字段上关闭
                                 .Sortable()
                                 .Selectable(s => s.Enabled(!showCheckboxColumn))
                                 .Scrollable(s => s.Enabled(true)) 
                                 //.Scrollable(s => { s.Virtual(true); })//利用滚动条翻页
                                 .ColumnMenu(menu => menu.Filterable(true).Sortable(true))
                                 .Groupable(t => t.Enabled(false))
                                 .Resizable(r => r.Columns(true))
                                 .Columns(columnConfigurator)
                                 .Columns(configurator).HtmlAttributes(htmlAttributes);

            #region 分页方式

            if (pageable)
            {
                grid.Pageable(t => t
                                       .Input(true)
                                       .Refresh(true)
                                       .PageSizes(new int[] { 15, 30, 45 })
                                       .Messages(m => m
                                                          .ItemsPerPage("条每页")
                                                          .Empty("没有查询到数据")
                                                          .Display("当前显示第{0}-{1}条,共{2}条")
                                                          .First("第一页")
                                                          .Last("最后一页")
                                                          .Previous("上一页")
                                                          .Next("下一页")
                                       ));
            }
            else
            {
                grid.Pageable(t => t.Enabled(false));
            }

            #endregion


            string confirm = showCheckboxColumn ?
                "<div class='inman-row'><input type='button' value='确定选择' class='k-button' onclick='inman.kendoWindow(\"#" +
                name + "\").close();'/></div><br>" : "";
            var button = Inman_Button(htmlHelper, name + "_Button", buttonText, perssmissionCode, htmlAttributes: new
            {
                id = name + "_Button",
                onclick = @"inman.kendoWindow('#" + name + "').center();inman.kendoWindow('#" + name + "').open();"
            });
            var windowBuilder = htmlHelper.Kendo()
                                          .Window()
                                          .Name(name)
                                          .Title(title)
                                          .Draggable()
                                          .Resizable()
                                          .Width(width)
                                          .Height(height)
                                          .Actions(actions => actions.Maximize().Close())
                                          .Content(confirm + grid.ToHtmlString())
                                          .Modal(modal)
                                          .Events(e =>
                                              {
                                                  if (!string.IsNullOrEmpty(selectEvent))
                                                  {
                                                      if (showCheckboxColumn)
                                                      {
                                                          e.Close("function(e){var grid=inman.kendoGrid('#" + name +
                                                                  "_Grid');e.grid=grid;e.data=grid.getChecked();" +
                                                                  selectEvent + "(e);}");
                                                      }
                                                      else
                                                      {
                                                          e.Close("function(e){var grid=inman.kendoGrid('#" + name +
                                                                   "_Grid');e.grid=grid;e.data=grid.getSelect();" +
                                                                   selectEvent + "(e);}");
                                                      }
                                                  }

                                              })
                                          .Visible(false);
            return new MvcHtmlString(windowBuilder.ToHtmlString() + button.ToHtmlString());
        }

        #endregion

        #region  审批日志按钮

        /// <summary>
        /// 审批日志按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="relatedGridId"></param>
        /// <param name="htmlAttributes"></param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_WorkflowLogButton(this HtmlHelper htmlHelper
                                                            , string relatedGridId = "#grid"
                                                            , object htmlAttributes = null
                                                            , bool hidden = false)
        {
            var htmlAttributes1 = new Dictionary<string, object>
                {
                    {"relatedGridId", relatedGridId},
                    {"type", "button"},
                    {"class", "k-button"},
                    {"onclick", "showWorkflowLog('" + relatedGridId + "')"}
                };
            if (htmlAttributes != null)
            {
                var dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;
                htmlAttributes1.Union(dic);
            }
            return htmlHelper.TextBox("btnWorkflowLog", "审批日志", htmlAttributes1);
        }

        #endregion

        #region 选择BOM物料清单

        public static MvcHtmlString Inman_SelectMaterialBOM<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               int? productId = 0,
                                                                               string dataTextField = "DesignProductSN",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               int gridPageSize = 8,
                                                                               int? gridWidth = null,
                                                                               int? gridHeight = null,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               bool disable = false,
                                                                               SelectMaterialBOMBusiness business =
                                                                                   SelectMaterialBOMBusiness.Default)
        {
            return Inman_DropDownGridFor<TModel, TProperty, MaterialBOMModel>(htmlHelper,
                                                                              expression,
                                                                              string.Format(
                                                                                  "/Selector/SelectMaterialBOM?productId={0}&business={1}",
                                                                                  productId, business),
                                                                              c =>
                                                                              {
                                                                                  c.Bound(t => t.DesignProductSN)
                                                                                   .Width(120);
                                                                                  c.Bound(t => t.ColorName)
                                                                                   .Width(80);
                                                                                  c.Bound(t => t.SampleType)
                                                                                   .Width(100);
                                                                                  c.Bound(t => t.Brand).Width(80);
                                                                                  c.Bound(t => t.DevYear).Width(100);
                                                                                  c.Bound(t => t.DesignSeason)
                                                                                   .Width(100);
                                                                              },
                                                                              dataTextField: dataTextField,
                                                                              dataValueField: dataValueField,
                                                                              selectedText: selectedText,
                                                                              optionLabel: optionLabel,
                                                                              perssmissionCode: perssmissionCode,
                                                                              gridPageSize: gridPageSize,
                                                                              gridWidth: gridWidth,
                                                                              gridHeight: gridHeight,
                                                                              changeEvent: changeEvent,
                                                                              selectEvent: selectEvent,
                                                                              clearEvent: clearEvent,
                                                                              disable: disable
                );
        }


        public static MvcHtmlString Inman_SelectMaterialBOM<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                    string name,
                                                                    string dataTextField = "DesignProductSN",
                                                                    string dataValueField = "Id",
                                                                    string selectedText = null,
                                                                    int gridPageSize = 8,
                                                                    int? gridWidth = null,
                                                                    int? gridHeight = null,
                                                                    string perssmissionCode = null,
                                                                    string optionLabel = " ",
                                                                    string changeEvent = null,
                                                                    string selectEvent = null,
                                                                    string clearEvent = null,
                                                                    bool disable = false,
                                                                    SelectMaterialBOMBusiness business =
                                                                        SelectMaterialBOMBusiness.Default)
        {
            return Inman_DropDownGrid<LinkMaterialBOMModel>(htmlHelper, name,
                                                            string.Format("/Selector/SelectMaterialBOM?bussiness={0}",
                                                                          business),
                                                            c =>
                                                            {
                                                                c.Bound(t => t.DesignProductSN).Width(120);
                                                                c.Bound(t => t.ColorName).Width(80);
                                                                c.Bound(t => t.SampleType).Width(120);
                                                                c.Bound(t => t.Brand).Width(80);
                                                                c.Bound(t => t.DevYear).Width(80);
                                                                c.Bound(t => t.DesignSeason).Width(80);
                                                            },
                                                            dataTextField,
                                                            dataValueField,
                                                            selectedText: selectedText,
                                                            optionLabel: optionLabel,
                                                            gridPageSize: gridPageSize,
                                                            gridWidth: gridWidth,
                                                            gridHeight: gridHeight,
                                                            changeEvent: changeEvent,
                                                            selectEvent: selectEvent,
                                                            clearEvent: clearEvent,
                                                            disable: disable
                );
        }

        #endregion

        #region 成品入库单选择成品入库预约单

        public static MvcHtmlString Inman_SelectEstimateArriveOrderForProductStockInOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? suppliersId,
            int? estimateArriveOrderId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0
                                   ? ""
                                   : "&suppliersId=" + suppliersId.Value);
            string section2 = (estimateArriveOrderId == null || estimateArriveOrderId == 0
                                   ? ""
                                   : "&estimateArriveOrderId=" + estimateArriveOrderId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductEstimateArriveOrderModel>(htmlHelper,
                                                                                             expression,
                                                                                             "/Selector/EstimateArriveOrderForProductStockInOrder?1=1" +
                                                                                             section1 + section2,
                                                                                             c =>
                                                                                             {
                                                                                                 c.Bound(
                                                                                                     f =>
                                                                                                     f
                                                                                                         .EstimateArriveDate)
                                                                                                  .Width(120)
                                                                                                  .Title("预约日期");
                                                                                                 c.Bound(
                                                                                                     f =>
                                                                                                     f
                                                                                                         .EstimateArriveTime)
                                                                                                  .Width(80)
                                                                                                  .Title("预约时间");
                                                                                                 c.Bound(
                                                                                                     f => f.DocNum)
                                                                                                  .Width(100)
                                                                                                  .Title("预约单号");
                                                                                                 c.Bound(
                                                                                                     f =>
                                                                                                     f.Merchandiser)
                                                                                                  .Width(80)
                                                                                                  .Title("跟单员");
                                                                                             },
                                                                                             dataTextField:
                                                                                                 dataTextField,
                                                                                             dataValueField:
                                                                                                 dataValueField,
                                                                                             selectedText: selectedText,
                                                                                             optionLabel: optionLabel,
                                                                                             selectEvent: selectEvent,
                                                                                             clearEvent: clearEvent,
                                                                                             disable: disable,
                                                                                             gridWidth: gridWidth
                );
        }

        public static MvcHtmlString Inman_SelectEstimateArriveOrderForProductStockInOrder<TModel>(
            this HtmlHelper<TModel> htmlHelper,
            string name,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null)
        {
            return Inman_DropDownGrid<ProductEstimateArriveOrderModel>(htmlHelper, name,
                                                                       "/Selector/EstimateArriveOrderForProductStockInOrder",
                                                                       c =>
                                                                       {
                                                                           c.Bound(f => f.EstimateArriveDate)
                                                                            .Title("预约日期");
                                                                           c.Bound(f => f.EstimateArriveTime)
                                                                            .Title("预约时间");
                                                                           c.Bound(f => f.DocNum).Title("预约单号");
                                                                           c.Bound(f => f.Merchandiser).Title("跟单员");
                                                                       },
                                                                       dataTextField,
                                                                       dataValueField,
                                                                       selectedText: selectedText,
                                                                       optionLabel: optionLabel,
                                                                       selectEvent: selectEvent,
                                                                       clearEvent: clearEvent
                );
        }

        #endregion

        #region 成品移仓单选择成品入库单

        public static MvcHtmlString Inman_SelectProductStockInOrderForProductTransferOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductStockInModel>(htmlHelper,
                                                                                 expression,
                                                                                 "/Selector/ProductStockInOrderForProductTransferOrder",
                                                                                 c =>
                                                                                 {
                                                                                     c.Bound(f => f.DocDate)
                                                                                      .Width(120)
                                                                                      .Title("入库日期");
                                                                                     c.Bound(f => f.DocNum)
                                                                                      .Width(120)
                                                                                      .Title("入库单号");
                                                                                     c.Bound(f => f.SupplierName)
                                                                                      .Width(100)
                                                                                      .Title("供应商简称");
                                                                                     c.Bound(f => f.SupplierDocNum)
                                                                                      .Width(120)
                                                                                      .Title("送货单号");
                                                                                 },
                                                                                 dataTextField: dataTextField,
                                                                                 dataValueField: dataValueField,
                                                                                 selectedText: selectedText,
                                                                                 optionLabel: optionLabel,
                                                                                 selectEvent: selectEvent,
                                                                                 clearEvent: clearEvent,
                                                                                 disable: disable,
                                                                                 gridWidth: gridWidth
                );
        }

        #endregion

        #region 成品返修单选择成品入库单

        public static MvcHtmlString Inman_SelectProductStockInOrderForProductRepairOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? stockInId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (stockInId == null || stockInId == 0
                                   ? ""
                                   : "&stockInId=" + stockInId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductStockInModel>(htmlHelper,
                                                                                 expression,
                                                                                 "/Selector/ProductStockInOrderForProductRepairOrder?1=1" +
                                                                                 section1,
                                                                                 c =>
                                                                                 {
                                                                                     c.Bound(f => f.CreatedOn)
                                                                                      .Width(120)
                                                                                      .Title("创建日期");
                                                                                     c.Bound(f => f.DocDate)
                                                                                      .Width(120)
                                                                                      .Title("入库如期");
                                                                                     c.Bound(f => f.DocNum)
                                                                                      .Width(120)
                                                                                      .Title("单据编号");
                                                                                     c.Bound(f => f.ProductSN)
                                                                                      .Width(120)
                                                                                      .Title("大货款号");
                                                                                 },
                                                                                 dataTextField: dataTextField,
                                                                                 dataValueField: dataValueField,
                                                                                 selectedText: selectedText,
                                                                                 optionLabel: optionLabel,
                                                                                 selectEvent: selectEvent,
                                                                                 clearEvent: clearEvent,
                                                                                 disable: disable,
                                                                                 gridWidth: gridWidth
                );
        }

        #endregion

        #region 成品退厂单选择成品入库单

        public static MvcHtmlString Inman_SelectProductStockInOrderForProductReturnFactory<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? suppliersId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0
                                   ? ""
                                   : "&suppliersId=" + suppliersId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductStockInModel>(htmlHelper,
                                                                                 expression,
                                                                                 "/Selector/ProductStockInOrderForProductReturnFactory?1=1" +
                                                                                 section1,
                                                                                 c =>
                                                                                 {
                                                                                     c.Bound(f => f.DocNum)
                                                                                      .Width(100)
                                                                                      .Title("单据编号");
                                                                                     c.Bound(f => f.DocDate)
                                                                                      .Width(100)
                                                                                      .Title("入库日期");
                                                                                 },
                                                                                 dataTextField: dataTextField,
                                                                                 dataValueField: dataValueField,
                                                                                 selectedText: selectedText,
                                                                                 optionLabel: optionLabel,
                                                                                 selectEvent: selectEvent,
                                                                                 clearEvent: clearEvent,
                                                                                 disable: disable,
                                                                                 gridWidth: gridWidth);
        }

        #endregion

        #region 成品退厂单选择成品返修单

        public static MvcHtmlString Inman_SelectProductRepairOrderForProductReturnFactory<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? suppliersId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0) ? "" : "&suppliersId=" + suppliersId.Value;

            return Inman_DropDownGridFor<TModel, TProperty, ProductRepairModel>(htmlHelper,
                                                                                expression,
                                                                                "/Selector/ProductRepairOrderForProductReturnFactory?1=1" +
                                                                                section1,
                                                                                c =>
                                                                                {
                                                                                    c.Bound(f => f.DocNum)
                                                                                     .Width(100)
                                                                                     .Title("单据编号");
                                                                                    c.Bound(f => f.DocDate)
                                                                                     .Width(100)
                                                                                     .Title("返修日期");
                                                                                },
                                                                                dataTextField: dataTextField,
                                                                                dataValueField: dataValueField,
                                                                                selectedText: selectedText,
                                                                                optionLabel: optionLabel,
                                                                                selectEvent: selectEvent,
                                                                                clearEvent: clearEvent,
                                                                                disable: disable,
                                                                                gridWidth: gridWidth);
        }

        #endregion

        #region 选择成品采购单

        public static MvcHtmlString Inman_SelectProductPurchaseOrderFor(this HtmlHelper htmlHelper, string name,
                                                                        string dataTextField = "DocNum",
                                                                        string dataValueField = "Id",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        int? gridWidth = 600,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        object htmlAttributes = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false,
                                                                        SelectProductPurchaseOrderBussiness bussiness =
                                                                            SelectProductPurchaseOrderBussiness.Default)
        {

            return Inman_DropDownGrid<ProductPurchaseOrderModel>(htmlHelper,
                                                                 name,
                                                                 string.Format(
                                                                     "/Selector/ProductPurchaseOrder?bussiness={0}",
                                                                     bussiness),
                                                                 c =>
                                                                 {
                                                                     /***  请不要再这里删除列，如果必须要用单列，请考虑用用kendo原生DropDownList扩展 ***/
                                                                     c.Bound(f => f.DocNum);
                                                                     c.Bound(f => f.DocDate);
                                                                     c.Bound(f => f.Merchandiser);
                                                                 },
                                                                 dataTextField: dataTextField,
                                                                 dataValueField: dataValueField,
                                                                 selectedText: selectedText,
                                                                 selectedValue: selectedValue,
                                                                 optionLabel: optionLabel,
                                                                 perssmissionCode: perssmissionCode,
                                                                 gridWidth: gridWidth,
                                                                 changeEvent: changeEvent,
                                                                 selectEvent: selectEvent,
                                                                 clearEvent: clearEvent,
                                                                 disable: disable);
        }

        public static MvcHtmlString Inman_SelectProductPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            int? gridWidth = 600,
            string perssmissionCode = null,
            string optionLabel = " ",
            object htmlAttributes = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectProductPurchaseOrderBussiness bussiness = SelectProductPurchaseOrderBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectProductPurchaseOrderFor(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                gridWidth: gridWidth,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                htmlAttributes: htmlAttributes,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 成品预付款申请单选择成品采购单

        public static MvcHtmlString Inman_SelectProductPurchaseOrderForProductAdvancePayment<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? suppliersId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0
                                   ? ""
                                   : "&suppliersId=" + suppliersId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductPurchaseOrderModel>(htmlHelper,
                                                                                             expression,
                                                                                             "/Selector/ProductPurchaseOrderForProductAdvancePayment?1=1" +
                                                                                             section1,
                                                                                             c =>
                                                                                             {
                                                                                                 c.Bound(
                                                                                                     f => f.DocNum)
                                                                                                  .Width(250)
                                                                                                  .Title("单据编号");
                                                                                                 c.Bound(
                                                                                                     f => f.DocDate)
                                                                                                  .Width(150)
                                                                                                  .Title("下单日期");
                                                                                                 c.Bound(
                                                                                                     f =>
                                                                                                     f.Merchandiser)
                                                                                                  .Width(150)
                                                                                                  .Title("跟单员");
                                                                                             },
                                                                                             dataTextField:
                                                                                                 dataTextField,
                                                                                             dataValueField:
                                                                                                 dataValueField,
                                                                                             selectedText: selectedText,
                                                                                             optionLabel: optionLabel,
                                                                                             selectEvent: selectEvent,
                                                                                             clearEvent: clearEvent,
                                                                                             disable: disable,
                                                                                             gridWidth: gridWidth
                );
        }

        #endregion

        #region 成品预付款申请单选择供应商账户

        public static MvcHtmlString Inman_SelectSupplierBank<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                Expression<Func<TModel, TProperty>>
                                                                                    expression,
                                                                                int? suppliersId,
                                                                                string dataTextField = "Account",
                                                                                string dataValueField = "Account",
                                                                                string selectedText = null,
                                                                                string optionLabel = " ",
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false,
                                                                                int? gridWidth = 700,
                                                                                SupplierBankBussiness bussiness =
                                                                                    SupplierBankBussiness.Default)
        {

            return Inman_DropDownGridFor<TModel, TProperty, SupplierBankModel>(htmlHelper,
                                                                               expression,
                                                                               string.Format(
                                                                                   "/Selector/GetSupplierBank?suppliersId={0}&bussiness={1}",
                                                                                   suppliersId, bussiness),
                                                                               c =>
                                                                               {
                                                                                   c.Bound(f => f.Bank)
                                                                                    .Width(100)
                                                                                    .Title("开户行");
                                                                                   c.Bound(f => f.AccountName)
                                                                                    .Width(100)
                                                                                    .Title("账户名");
                                                                                   c.Bound(f => f.Account)
                                                                                    .Width(100)
                                                                                    .Title("账号");
                                                                                   c.Bound(f => f.PaymentAttribute)
                                                                                    .Width(100)
                                                                                    .Title("付款属性");
                                                                               },
                                                                               dataTextField: dataTextField,
                                                                               dataValueField: dataValueField,
                                                                               selectedText: selectedText,
                                                                               optionLabel: optionLabel,
                                                                               selectEvent: selectEvent,
                                                                               clearEvent: clearEvent,
                                                                               disable: disable,
                                                                               gridWidth: gridWidth
                );
        }

        #endregion

        #region 弹窗树基础控件,可以用来封装各种需要在弹窗中显示数的控件

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="dataUrl"></param>
        /// <param name="dataTextField"></param>
        /// <param name="dataValueField"></param>
        /// <param name="selectedText"></param>
        /// <param name="multiple"></param>
        /// <param name="selectEvent"></param>
        /// <param name="changeEvent"></param>
        /// <param name="confirmEvent">确认按钮事件,该事件必须返回bool类型,否则弹窗不会关闭</param>
        /// <returns></returns>
        public static MvcHtmlString Inman_WindowTreeFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                           Expression<Func<TModel, TProperty>>
                                                                               expression,
                                                                           string dataUrl,
                                                                           string dataTextField,
                                                                           string dataValueField,
                                                                           string selectedText = null,
                                                                           bool multiple = false,
                                                                           string selectEvent = null,
                                                                           string changeEvent = null,
                                                                           string confirmEvent = null,
                                                                                            bool disable = false
            )
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            htmlHelper.ViewData["Sys_Name"] = name;
            htmlHelper.ViewData["Sys_Value"] = value;
            htmlHelper.ViewData["Sys_Multiple"] = multiple;
            htmlHelper.ViewData["Sys_DataTextField"] = dataTextField;
            htmlHelper.ViewData["Sys_DataValueField"] = dataValueField;
            htmlHelper.ViewData["Sys_SelectedText"] = selectedText ?? value;
            htmlHelper.ViewData["Sys_DataUrl"] = dataUrl;
            htmlHelper.ViewData["Sys_SelectEvent"] = selectEvent ?? "";
            htmlHelper.ViewData["Sys_ChangeEvent"] = changeEvent ?? "";
            htmlHelper.ViewData["Sys_ConfirmEvent"] = confirmEvent ?? "";
            htmlHelper.ViewData["Sys_Disable"] = disable;
            return htmlHelper.Partial("~/Views/Shared/Selector/SelectTree.cshtml", multiple, htmlHelper.ViewData);
        }

        #endregion

        #region 办料采购单

        public static MvcHtmlString Inman_SelectSamplePurchaseFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                     Expression<Func<TModel, TProperty>>
                                                                                         expression,
                                                                                     string dataTextField = "DocNum",
                                                                                     string dataValueField = "Id",
                                                                                     string selectedText = null,
                                                                                     string perssmissionCode = null,
                                                                                     string optionLabel = " ",
                                                                                     int gridPageSize = 5,
                                                                                     int? gridWidth = 600,
                                                                                     int? gridHeight = null,
                                                                                     string changeEvent = null,
                                                                                     string selectEvent = null,
                                                                                     string clearEvent = null,
                                                                                     bool disable = false,
                                                                                     SamplePurchaseMaterialBussiness
                                                                                         bussiness =
                                                                                         SamplePurchaseMaterialBussiness
                                                                                         .Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleMaterialPurchaseOrderModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/SamplePurchase?bussiness={0}",
                                                                                                  bussiness),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(
                                                                                                      f => f.DocNum)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.DocDate)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.Year)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.Season)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.Brand)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.Amount)
                                                                                                   .Width(100);
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectSamplePurchase(this HtmlHelper htmlHelper,
                                                               string name,
                                                               string dataTextField = "DocNum",
                                                               string dataValueField = "Id",
                                                               string selectedValue = null,
                                                               string selectedText = null,
                                                               string perssmissionCode = null,
                                                               string optionLabel = " ",
                                                               int gridPageSize = 8,
                                                               int? gridWidth = 500,
                                                               int? gridHeight = null,
                                                               string changeEvent = null,
                                                               string selectEvent = null,
                                                               string clearEvent = null,
                                                               bool disable = false,
                                                               SamplePurchaseMaterialBussiness bussiness =
                                                                   SamplePurchaseMaterialBussiness.Default)
        {
            return Inman_DropDownGrid<SampleMaterialPurchaseOrderModel>(htmlHelper,
                                                                        name,
                                                                        string.Format(
                                                                            "/Selector/SamplePurchase?bussiness={0}",
                                                                            bussiness),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.DocNum).Width(100);
                                                                            c.Bound(f => f.DocDate).Width(100);
                                                                            c.Bound(f => f.Year).Width(100);
                                                                            c.Bound(f => f.Season).Width(100);
                                                                            c.Bound(f => f.Brand).Width(100);
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        selectedValue: selectedValue,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        #endregion

        #region 供应商银行账户

        //        public static MvcHtmlString Inman_SelectSupplierBankFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                Expression<Func<TModel, TProperty>> expression,
        //                string dataTextField = "Account",
        //                string dataValueField = "Id",
        //                string selectedText = null,
        //                string perssmissionCode = null,
        //                string optionLabel = " ",
        //                int gridPageSize = 8,
        //                int? gridWidth = null,
        //                int? gridHeight = null,
        //                string changeEvent = null,
        //                string selectEvent = null,
        //                string clearEvent = null,
        //                bool disable = false,
        //                SupplierBankBussiness bussiness = SupplierBankBussiness.Default
        //  )
        //        {
        //            return Inman_DropDownGridFor<TModel, TProperty, SupplierBankModel>(htmlHelper,
        //                expression,
        //                string.Format("/Selector/SupplierBank?bussiness={0}", bussiness),
        //                c =>
        //                {
        //                    c.Bound(f => f.Account);
        //                    c.Bound(f => f.AccountName);
        //                    c.Bound(f => f.Bank);
        //                },
        //                dataTextField,
        //                dataValueField,
        //                selectedText: selectedText,
        //                optionLabel: optionLabel,
        //                gridPageSize: gridPageSize,
        //                gridWidth: gridWidth,
        //                gridHeight: gridHeight,
        //                changeEvent: changeEvent,
        //                selectEvent: selectEvent,
        //                clearEvent: clearEvent,
        //                disable: disable
        //                );
        //        }
        //        public static MvcHtmlString Inman_SelectSupplierBank(this HtmlHelper htmlHelper,
        //            string name,
        //            string dataTextField = "Account",
        //            string dataValueField = "Id",
        //            string selectedValue = null,
        //             string selectedText = null,
        //            string perssmissionCode = null,
        //            string optionLabel = " ",
        //            int gridPageSize = 8,
        //            int? gridWidth = null,
        //            int? gridHeight = null,
        //            string changeEvent = null,
        //            string selectEvent = null,
        //            string clearEvent = null,
        //            bool disable = false,
        //            SamplePurchaseMaterialBussiness bussiness = SamplePurchaseMaterialBussiness.Default)
        //        {
        //            return Inman_DropDownGrid<SupplierBankModel>(htmlHelper,
        //                name,
        //                string.Format("/Selector/SupplierBank?bussiness={0}", bussiness),
        //                c =>
        //                {
        //                    c.Bound(f => f.Account);
        //                    c.Bound(f => f.AccountName);
        //                    c.Bound(f => f.Bank);
        //                },
        //                dataTextField,
        //                dataValueField,
        //                selectedText: selectedText,
        //                selectedValue: selectedValue,
        //                optionLabel: optionLabel,
        //                gridPageSize: gridPageSize,
        //                gridWidth: gridWidth,
        //                gridHeight: gridHeight,
        //                changeEvent: changeEvent,
        //                selectEvent: selectEvent,
        //                clearEvent: clearEvent,
        //                disable: disable
        //                );
        //        }

        #endregion

        #region 办料领用单选择设计款号

        public static MvcHtmlString Inman_SelectDesignForSampleMaterialApplyOrder(this HtmlHelper htmlHelper,
                                                                                  string name,
                                                                                  int? gridWidth = null)
        {
            return Inman_DropDownGrid<DesignModel>(htmlHelper, name,
                                                   "/Selector/DesignForSampleMaterialApplyOrder",
                                                   c =>
                                                   {
                                                       c.Bound(f => f.DesignProductSN).Width(100).Title("款号");
                                                       c.Bound(f => f.ProductName).Width(100).Title("款式名称");
                                                       c.Bound(f => f.Collection).Width(100).Title("系列");
                                                       c.Bound(f => f.Brand).Width(100).Title("品牌");
                                                       c.Bound(f => f.Material).Width(100).Title("材质");
                                                       c.Bound(f => f.Technology).Width(100).Title("工艺");
                                                       c.Bound(f => f.Collar).Width(100).Title("领型");
                                                       c.Bound(f => f.Shape).Width(100).Title("版型");
                                                       c.Bound(f => f.ClothesLong).Width(100).Title("衣长");
                                                       c.Bound(f => f.SleeveShape).Width(100).Title("袖型");
                                                       c.Bound(f => f.SleeveLong).Width(100).Title("袖长");
                                                   },
                                                   dataTextField: "DesignProductSN",
                                                   dataValueField: "Id",
                                                   gridWidth: gridWidth,
                                                   gridPageSize: 10
                );
        }

        #endregion

        #region 办料库存

        public static MvcHtmlString Inman_SelectInventory(this HtmlHelper htmlHelper, string name,
                                                          int? warehouseId,
                                                          string dataTextField = "ItemCode",
                                                          string dataValueField = "Id",
                                                          string selectedValue = null,
                                                          string selectedText = null,
                                                          string perssmissionCode = null,
                                                          string optionLabel = " ",
                                                          int gridPageSize = 8,
                                                          int? gridWidth = 600,
                                                          int? gridHeight = null,
                                                          string changeEvent = null,
                                                          string selectEvent = null,
                                                          string clearEvent = null,
                                                          bool disable = false,
                                                          SelectSampleMaterialInventoryBussiness bussiness = SelectSampleMaterialInventoryBussiness.Default)
        {
            string section1 = (warehouseId == null || warehouseId == 0 ? "" : "&warehouseId=" + warehouseId.Value);
            return Inman_DropDownGrid<SampleMaterialInventoryModel>(htmlHelper, name,
                string.Format(
                    "/Selector/SampleMaterialInventory?bussiness={0}" + section1, bussiness),
                c =>
                {
                    c.Bound(f => f.BatchCode).Width(100).Title("批次");
                    c.Bound(f => f.ItemCode).Width(100).Title("物料SKU");
                    c.Bound(f => f.ItemName).Width(120).Title("物料名称");
                    c.Bound(f => f.UnitPrice).Width(120).Title("单价");
                    c.Bound(f => f.ColorName).Width(80).Title("颜色");
                    c.Bound(f => f.WarehouseName).Width(100).Title("仓库");
                    c.Bound(f => f.StorageRackName).Width(100).Title("库位");
                    c.Bound(f => f.ItemSpec).Width(120).Title("物料规格");
                    c.Bound(typeof(StockTypeEnum), "StockType").Width(120).Title("库存类型");
                    c.Bound(f => f.UsableQuantity).Width(120).Title("可用库存");
                },
                dataTextField,
                dataValueField,
                selectedText: selectedText,
                selectedValue: selectedValue,
                optionLabel: optionLabel,
                gridPageSize: gridPageSize,
                gridWidth: gridWidth,
                gridHeight: gridHeight,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectInventoryFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                Expression<Func<TModel, TProperty>>
                                                                                    expression,
                                                                                int? warehouseId,
                                                                                string dataTextField = "ItemCode",
                                                                                string dataValueField = "Id",
                                                                                string selectedText = null,
                                                                                string perssmissionCode = null,
                                                                                string optionLabel = " ",
                                                                                int gridPageSize = 8,
                                                                                int? gridWidth = null,
                                                                                int? gridHeight = null,
                                                                                string changeEvent = null,
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false,
                                                                                SelectSampleMaterialInventoryBussiness bussiness = SelectSampleMaterialInventoryBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectInventory(
                htmlHelper,
                name,
                warehouseId,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 办料出库单选择办料领用单

        public static MvcHtmlString Inman_SelectSampleMaterialApplyForSampleMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? sampleMaterialApplyId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (sampleMaterialApplyId == null || sampleMaterialApplyId == 0
                                   ? ""
                                   : "&sampleMaterialApplyId=" + sampleMaterialApplyId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, SampleMaterialApplyModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SampleMaterialApplyForSampleMaterialStockOutOrder?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(300)
                                                                                           .Title("依据单号");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 办料余料入库单选择办料出库单

        public static MvcHtmlString Inman_SelectSampleMaterialStockOutForSampleMaterialSurplusOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleMaterialStockOutModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/SampleMaterialStockOutForSampleMaterialSurplusOrder",
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100)
                                                                                              .Title("出库单号");
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.WarehouseName)
                                                                                              .Width(100)
                                                                                              .Title("仓库");
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100)
                                                                                              .Title("出库时间");
                                                                                             c.Bound(
                                                                                                 typeof(
                                                                                                     SampleMaterialStockOutStatusEnum
                                                                                                     ), "Status")
                                                                                              .Width(100)
                                                                                              .Title("状态");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 办料退供应商出库单选择办料采购单

        public static MvcHtmlString Inman_SelectSampleMaterialPurchaseForSampleMaterialReturnOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleMaterialPurchaseOrderModel>(htmlHelper,
                                                                                              expression,
                                                                                              "/Selector/SampleMaterialPurchaseForSampleMaterialReturnOrder",
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(
                                                                                                      f => f.DocNum)
                                                                                                   .Width(100)
                                                                                                   .Title("采购单号");
                                                                                                  c.Bound(
                                                                                                      f =>
                                                                                                      f.DesignerName)
                                                                                                   .Width(100)
                                                                                                   .Title("设计师");
                                                                                                  c.Bound(
                                                                                                      f =>
                                                                                                      f.SupplierName)
                                                                                                   .Width(100)
                                                                                                   .Title("供应商");
                                                                                              },
                                                                                              dataTextField:
                                                                                                  dataTextField,
                                                                                              dataValueField:
                                                                                                  dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable,
                                                                                              gridWidth: gridWidth
                );
        }

        #endregion

        #region 选择面辅料采购单

        public static MvcHtmlString Inman_SelectStockItemPurchaseOrder(this HtmlHelper htmlHelper, string name,
                                                                       string dataTextField = "PurchaseOrderNum",
                                                                       string dataValueField = "PurchaseOrderNum",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = null,
                                                                       int? gridHeight = null,
                                                                       object htmlAttributes = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectStockItemPurchaseOrderBussiness bussiness =
                                                                           SelectStockItemPurchaseOrderBussiness
                                                                           .StockItemInsideCheck)
        {

            return Inman_DropDownGrid<StockItemPurchaseOrderModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/StockItemPurchaseOrder?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       /***  请不要再这里删除列，如果必须要用单列，请考虑用用kendo原生DropDownList扩展 ***/
                                                                       c.Bound(f => f.PurchaseOrderType);
                                                                       c.Bound(f => f.PurchaseOrderNum);

                                                                   },
                                                                   dataTextField: dataTextField,
                                                                   dataValueField: dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   perssmissionCode: perssmissionCode,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable);
        }

        public static MvcHtmlString Inman_SelectStockItemPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "PurchaseOrderNum",
            string dataValueField = "PurchaseOrderNum",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = null,
            int? gridHeight = null,
            object htmlAttributes = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectStockItemPurchaseOrderBussiness bussiness = SelectStockItemPurchaseOrderBussiness.StockItemInsideCheck)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectStockItemPurchaseOrder(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                gridPageSize: gridPageSize,
                gridWidth: gridWidth,
                gridHeight: gridHeight,
                htmlAttributes: htmlAttributes,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 非对单采购单

        public static MvcHtmlString Inman_SelectCommonMaterialPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectCommonMaterialPurchaseOrderBussiness bussiness = SelectCommonMaterialPurchaseOrderBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialPurchaseOrderModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/CommonMaterialPurchaseOrder?bussiness={0}",
                                                                                                  bussiness),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(
                                                                                                      f => f.DocNum)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.DocDate)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f =>
                                                                                                      f.SupplierName)
                                                                                                   .Width(100);
                                                                                                  c.Bound(
                                                                                                      f => f.Amount)
                                                                                                   .Width(100);
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectCommonMaterialPurchaseOrder(this HtmlHelper htmlHelper,
                                                                            string name,
                                                                            string dataTextField = "DocNum",
                                                                            string dataValueField = "Id",
                                                                            string selectedValue = null,
                                                                            string selectedText = null,
                                                                            string perssmissionCode = null,
                                                                            string optionLabel = " ",
                                                                            int gridPageSize = 8,
                                                                            int? gridWidth = 500,
                                                                            int? gridHeight = null,
                                                                            string changeEvent = null,
                                                                            string selectEvent = null,
                                                                            string clearEvent = null,
                                                                            bool disable = false,
                                                                            SelectCommonMaterialPurchaseOrderBussiness
                                                                                bussiness =
                                                                                SelectCommonMaterialPurchaseOrderBussiness
                                                                                .Default)
        {
            return Inman_DropDownGrid<CommonMaterialPurchaseOrderModel>(htmlHelper,
                                                                        name,
                                                                        string.Format(
                                                                            "/Selector/CommonMaterialPurchaseOrder?bussiness={0}",
                                                                            bussiness),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.DocNum).Width(100);
                                                                            c.Bound(f => f.DocDate).Width(100);
                                                                            c.Bound(f => f.SupplierName).Width(100);
                                                                            c.Bound(f => f.Amount).Width(100);
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        selectedValue: selectedValue,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        #endregion

        #region 选择战略备料单

        public static MvcHtmlString Inman_SelectStrategyCautionFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectStrategyBussiness bussiness = SelectStrategyBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, StockItemStrategyModel>(htmlHelper,
                                                                                    expression,
                                                                                    string.Format(
                                                                                        "/Selector/StrategyCaution?bussiness={0}",
                                                                                        bussiness),
                                                                                    c =>
                                                                                    {
                                                                                        c.Bound(f => f.DocNum)
                                                                                         .Width(100);
                                                                                        c.Bound(f => f.Cost)
                                                                                         .Width(100);
                                                                                        c.Bound(f => f.CreatedOn)
                                                                                         .Width(100);
                                                                                        c.Bound(f => f.SupplierName)
                                                                                         .Width(100);
                                                                                    },
                                                                                    dataTextField,
                                                                                    dataValueField,
                                                                                    selectedText: selectedText,
                                                                                    optionLabel: optionLabel,
                                                                                    gridPageSize: gridPageSize,
                                                                                    gridWidth: gridWidth,
                                                                                    gridHeight: gridHeight,
                                                                                    changeEvent: changeEvent,
                                                                                    selectEvent: selectEvent,
                                                                                    clearEvent: clearEvent,
                                                                                    disable: disable
                );
        }

        #endregion

        #region 非对单预约入库单

        public static MvcHtmlString Inman_SelectCommonMaterialAdvanceFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectCommonMaterialAdvanceBussiness bussiness = SelectCommonMaterialAdvanceBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialAdvanceModel>(htmlHelper,
                                                                                        expression,
                                                                                        string.Format(
                                                                                            "/Selector/CommonMaterialAdvance?bussiness={0}",
                                                                                            bussiness),
                                                                                        c =>
                                                                                        {
                                                                                            c.Bound(f => f.DocNum)
                                                                                             .Width(100);
                                                                                            c.Bound(f => f.DocDate)
                                                                                             .Width(100);
                                                                                            c.Bound(
                                                                                                f => f.SupplierName)
                                                                                             .Width(100);
                                                                                            c.Bound(
                                                                                                f =>
                                                                                                f.PurchaseOrderNum)
                                                                                             .Width(100);
                                                                                        },
                                                                                        dataTextField,
                                                                                        dataValueField,
                                                                                        selectedText: selectedText,
                                                                                        optionLabel: optionLabel,
                                                                                        gridPageSize: gridPageSize,
                                                                                        gridWidth: gridWidth,
                                                                                        gridHeight: gridHeight,
                                                                                        changeEvent: changeEvent,
                                                                                        selectEvent: selectEvent,
                                                                                        clearEvent: clearEvent,
                                                                                        disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectCommonMaterialAdvance(this HtmlHelper htmlHelper,
                                                                      string name,
                                                                      string dataTextField = "DocNum",
                                                                      string dataValueField = "Id",
                                                                      string selectedValue = null,
                                                                      string selectedText = null,
                                                                      string perssmissionCode = null,
                                                                      string optionLabel = " ",
                                                                      int gridPageSize = 8,
                                                                      int? gridWidth = 500,
                                                                      int? gridHeight = null,
                                                                      string changeEvent = null,
                                                                      string selectEvent = null,
                                                                      string clearEvent = null,
                                                                      bool disable = false,
                                                                      SelectCommonMaterialAdvanceBussiness bussiness =
                                                                          SelectCommonMaterialAdvanceBussiness.Default)
        {
            return Inman_DropDownGrid<CommonMaterialAdvanceModel>(htmlHelper,
                                                                  name,
                                                                  string.Format(
                                                                      "/Selector/CommonMaterialAdvance?bussiness={0}",
                                                                      bussiness),
                                                                  c =>
                                                                  {
                                                                      c.Bound(f => f.DocNum).Width(100);
                                                                      c.Bound(f => f.DocDate).Width(100);
                                                                      c.Bound(f => f.SupplierName).Width(100);
                                                                      c.Bound(f => f.PurchaseOrderNum).Width(100);
                                                                  },
                                                                  dataTextField,
                                                                  dataValueField,
                                                                  selectedText: selectedText,
                                                                  selectedValue: selectedValue,
                                                                  optionLabel: optionLabel,
                                                                  gridPageSize: gridPageSize,
                                                                  gridWidth: gridWidth,
                                                                  gridHeight: gridHeight,
                                                                  changeEvent: changeEvent,
                                                                  selectEvent: selectEvent,
                                                                  clearEvent: clearEvent,
                                                                  disable: disable
                );
        }

        #endregion

        #region 非对单库存

        public static MvcHtmlString Inman_SelectCommonMaterialInventory(this HtmlHelper htmlHelper, string name,
                                                                        int? warehouseId = null,
                                                                        string dataTextField = "ItemCode",
                                                                        string dataValueField = "Id",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        int gridPageSize = 8,
                                                                        int? gridWidth = null,
                                                                        int? gridHeight = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false,
                                                                        SelectCommonMaterialInventoryBussiness bussiness
                                                                            =
                                                                            SelectCommonMaterialInventoryBussiness
                                                                            .Default)
        {
            string section1 = (warehouseId == null || warehouseId == 0 ? "" : "&warehouseId=" + warehouseId.Value);
            return Inman_DropDownGrid<CommonMaterialInventoryModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/CommonMaterialInventory?bussiness={0}" + section1,
                                                                        bussiness),
                                                                    c =>
                                                                    {
                                                                        if (bussiness == SelectCommonMaterialInventoryBussiness.CommonMaterialAdjustment)
                                                                        {
                                                                            c.Bound(f => f.BatchCode).Width(100).Title("批次");
                                                                        }
                                                                        c.Bound(f => f.ItemCode)
                                                                         .Width(100)
                                                                         .Title("物料SKU");
                                                                        c.Bound(f => f.ItemName)
                                                                         .Width(120)
                                                                         .Title("物料名称");
                                                                        if (bussiness !=
                                                                            SelectCommonMaterialInventoryBussiness
                                                                                .ProductMaterialTransfer)
                                                                        {
                                                                            c.Bound(f => f.WarehouseName)
                                                                             .Width(100)
                                                                             .Title("仓库");
                                                                            c.Bound(f => f.StorageRackName)
                                                                             .Width(100)
                                                                             .Title("库位");
                                                                            c.Bound(f => f.ColorName)
                                                                             .Width(80)
                                                                             .Title("颜色");
                                                                            c.Bound(f => f.ItemSpec)
                                                                             .Width(100)
                                                                             .Title("物料规格");
                                                                            c.Bound(f => f.UsableQuantity)
                                                                             .Width(100)
                                                                             .Title("可用库存");
                                                                            c.Bound(f => f.UnitPrice)
                                                                             .Width(100)
                                                                             .Title("库存单价");
                                                                            c.Bound(f => f.Unit)
                                                                             .Width(80)
                                                                             .Title("单位");
                                                                        }
                                                                        else
                                                                        {
                                                                            c.Bound(f => f.ItemSpec)
                                                                             .Width(100)
                                                                             .Title("物料规格");
                                                                            c.Bound(f => f.UsableQuantity)
                                                                             .Title("可用库存");
                                                                        }
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectCommonMaterialInventoryFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ItemCode",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = null,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectCommonMaterialInventoryBussiness bussiness = SelectCommonMaterialInventoryBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectCommonMaterialInventory(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 战略退保证金申请单

        public static MvcHtmlString Inman_SelectStrategyEbbFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                  Expression<Func<TModel, TProperty>>
                                                                                      expression,
                                                                                  int? strategyId,
                                                                                  string dataTextField = "DocNum",
                                                                                  string dataValueField = "Id",
                                                                                  int gridPageSize = 8,
                                                                                  string selectedText = null,
                                                                                  string optionLabel = " ",
                                                                                  string selectEvent = null,
                                                                                  string clearEvent = null,
                                                                                  bool disable = false,
                                                                                  int? gridWidth = 700,
                                                                                  SelectStrategyEbbBussiness bussiness =
                                                                                      SelectStrategyEbbBussiness.Default)
        {
            return Inman_DropDownGridFor<TModel, TProperty, StockItemStrategyCautionModel>(htmlHelper,
                                                                                           expression,
                                                                                           string.Format(
                                                                                               "/Selector/GetStrategyEbb?strategyId={0}&bussiness={1}",
                                                                                               strategyId, bussiness),
                                                                                           c =>
                                                                                           {
                                                                                               c.Bound(f => f.DocNum);
                                                                                               c.Bound(
                                                                                                   f => f.CreatedBy);
                                                                                               c.Bound(
                                                                                                   f => f.CreatedOn);
                                                                                               c.Bound(f => f.Cost);
                                                                                               c.Bound(f => f.Bank);
                                                                                           },
                                                                                           dataTextField: dataTextField,
                                                                                           dataValueField:
                                                                                               dataValueField,
                                                                                           selectedText: selectedText,
                                                                                           gridPageSize: gridPageSize,
                                                                                           optionLabel: optionLabel,
                                                                                           selectEvent: selectEvent,
                                                                                           clearEvent: clearEvent,
                                                                                           disable: disable,
                                                                                           gridWidth: gridWidth
                );
        }

        #endregion

        #region 非对单出库单选择非对单领用单

        public static MvcHtmlString Inman_SelectCommonMaterialApplyForCommonMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? commonMaterialApplyId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (commonMaterialApplyId == null || commonMaterialApplyId == 0
                                   ? ""
                                   : "&commonMaterialApplyId=" + commonMaterialApplyId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialApplyModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/CommonMaterialApplyForCommonMaterialStockOutOrder?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(300)
                                                                                           .Title("依据单号");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 非对单余料入库单选择非对单出库单

        public static MvcHtmlString Inman_SelectCommonMaterialStockOutForCommonMaterialSurplusOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialStockOutModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/CommonMaterialStockOutForCommonMaterialSurplusOrder",
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100)
                                                                                              .Title("出库单号");
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100)
                                                                                              .Title("出库日期");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 非对单调料单

        public static MvcHtmlString Inman_SelectCommonMaterialTransferFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectCommonMaterialTransferBussiness bussiness = SelectCommonMaterialTransferBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialTransferModel>(htmlHelper,
                                                                                         expression,
                                                                                         string.Format(
                                                                                             "/Selector/CommonMaterialTransfer?bussiness={0}",
                                                                                             bussiness),
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100);
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.ApprovedDateFinal)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.ApprovedUserFinal)
                                                                                              .Width(100);
                                                                                         },
                                                                                         dataTextField,
                                                                                         dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         gridPageSize: gridPageSize,
                                                                                         gridWidth: gridWidth,
                                                                                         gridHeight: gridHeight,
                                                                                         changeEvent: changeEvent,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectCommonMaterialTransfer(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "DocNum",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectCommonMaterialTransferBussiness bussiness =
                                                                           SelectCommonMaterialTransferBussiness.Default)
        {
            return Inman_DropDownGrid<CommonMaterialTransferModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/CommonMaterialTransfer?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       c.Bound(f => f.DocNum).Width(100);
                                                                       c.Bound(f => f.DocDate).Width(100);
                                                                       c.Bound(f => f.ApprovedDateFinal).Width(100);
                                                                       c.Bound(f => f.ApprovedUserFinal).Width(100);
                                                                   },
                                                                   dataTextField,
                                                                   dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable
                );
        }

        #endregion

        #region 办料调料单

        public static MvcHtmlString Inman_SelectSampleMaterialTransferFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 600,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSampleMaterialTransferBussiness bussiness = SelectSampleMaterialTransferBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleMaterialTransferModel>(htmlHelper,
                                                                                         expression,
                                                                                         string.Format(
                                                                                             "/Selector/SampleMaterialTransfer?bussiness={0}",
                                                                                             bussiness),
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100);
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.ApprovedDateFinal)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.ApprovedUserFinal)
                                                                                              .Width(100);
                                                                                         },
                                                                                         dataTextField,
                                                                                         dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         gridPageSize: gridPageSize,
                                                                                         gridWidth: gridWidth,
                                                                                         gridHeight: gridHeight,
                                                                                         changeEvent: changeEvent,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectSampleMaterialTransfer(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "DocNum",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectSampleMaterialTransferBussiness bussiness =
                                                                           SelectSampleMaterialTransferBussiness.Default)
        {
            return Inman_DropDownGrid<CommonMaterialTransferModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/SampleMaterialTransfer?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       c.Bound(f => f.DocNum).Width(100);
                                                                       c.Bound(f => f.DocDate).Width(100);
                                                                       c.Bound(f => f.ApprovedDateFinal).Width(100);
                                                                       c.Bound(f => f.ApprovedUserFinal).Width(100);
                                                                   },
                                                                   dataTextField,
                                                                   dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable
                );
        }

        #endregion

        #region 面辅料内外检采购单

        public static MvcHtmlString Inman_SelectStockItemPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "DocNum",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectStockItemCheckPurchaseOrderBussiness bussiness = SelectStockItemCheckPurchaseOrderBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, StockItemPurchaseOrder>(htmlHelper,
                                                                                    expression,
                                                                                    string.Format(
                                                                                        "/Selector/StockItemCheckPurchaseOrder?bussiness={0}",
                                                                                        bussiness),
                                                                                    c =>
                                                                                    {
                                                                                        c.Bound(f => f.DocNum)
                                                                                         .Width(100);
                                                                                        c.Bound(f => f.Type)
                                                                                         .Width(100);

                                                                                    },
                                                                                    dataTextField,
                                                                                    dataValueField,
                                                                                    selectedText: selectedText,
                                                                                    optionLabel: optionLabel,
                                                                                    gridPageSize: gridPageSize,
                                                                                    gridWidth: gridWidth,
                                                                                    gridHeight: gridHeight,
                                                                                    changeEvent: changeEvent,
                                                                                    selectEvent: selectEvent,
                                                                                    clearEvent: clearEvent,
                                                                                    disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectStockItemPurchaseOrder(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "DocNum",
                                                                       string dataValueField = "DocNum",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectSampleMaterialTransferBussiness bussiness =
                                                                           SelectSampleMaterialTransferBussiness.Default)
        {
            return Inman_DropDownGrid<StockItemPurchaseOrder>(htmlHelper,
                                                              name,
                                                              string.Format(
                                                                  "/Selector/StockItemCheckPurchaseOrder?bussiness={0}",
                                                                  bussiness),
                                                              c =>
                                                              {
                                                                  c.Bound(f => f.DocNum).Width(100);
                                                                  c.Bound(f => f.Type).Width(100);

                                                              },
                                                              dataTextField,
                                                              dataValueField,
                                                              selectedText: selectedText,
                                                              selectedValue: selectedValue,
                                                              optionLabel: optionLabel,
                                                              gridPageSize: gridPageSize,
                                                              gridWidth: gridWidth,
                                                              gridHeight: gridHeight,
                                                              changeEvent: changeEvent,
                                                              selectEvent: selectEvent,
                                                              clearEvent: clearEvent,
                                                              disable: disable
                );
        }

        #endregion

        #region 办料出库单选择非对单调料单

        public static MvcHtmlString Inman_SelectCommonMaterialTransferForSampleMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? commonMaterialTransferId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (commonMaterialTransferId == null || commonMaterialTransferId == 0
                                   ? ""
                                   : "&commonMaterialTransferId=" + commonMaterialTransferId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialTransferModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/CommonMaterialTransferForSampleMaterialStockOutOrder?1=1" +
                                                                                         section1,
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(300)
                                                                                              .Title("依据单号");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 对单采购单

        public static MvcHtmlString Inman_SelectProductMaterialPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectProductMaterialPurchaseOrderBussiness bussiness = SelectProductMaterialPurchaseOrderBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductMaterialPurchaseOrderModel>(htmlHelper,
                                                                                               expression,
                                                                                               string.Format(
                                                                                                   "/Selector/ProductMaterialPurchaseOrder?bussiness={0}",
                                                                                                   bussiness),
                                                                                               c =>
                                                                                               {
                                                                                                   c.Bound(
                                                                                                       f => f.DocNum)
                                                                                                    .Width(100);
                                                                                                   c.Bound(
                                                                                                       f =>
                                                                                                       f.DocDate)
                                                                                                    .Width(100);
                                                                                                   c.Bound(
                                                                                                       f =>
                                                                                                       f
                                                                                                           .SupplierName)
                                                                                                    .Width(100);
                                                                                                   c.Bound(
                                                                                                       f => f.Amount)
                                                                                                    .Width(100);
                                                                                               },
                                                                                               dataTextField,
                                                                                               dataValueField,
                                                                                               selectedText:
                                                                                                   selectedText,
                                                                                               optionLabel: optionLabel,
                                                                                               gridPageSize:
                                                                                                   gridPageSize,
                                                                                               gridWidth: gridWidth,
                                                                                               gridHeight: gridHeight,
                                                                                               changeEvent: changeEvent,
                                                                                               selectEvent: selectEvent,
                                                                                               clearEvent: clearEvent,
                                                                                               disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialPurchaseOrder(this HtmlHelper htmlHelper,
                                                                             string name,
                                                                             string dataTextField = "DocNum",
                                                                             string dataValueField = "Id",
                                                                             string selectedValue = null,
                                                                             string selectedText = null,
                                                                             string perssmissionCode = null,
                                                                             string optionLabel = " ",
                                                                             int gridPageSize = 8,
                                                                             int? gridWidth = 500,
                                                                             int? gridHeight = null,
                                                                             string changeEvent = null,
                                                                             string selectEvent = null,
                                                                             string clearEvent = null,
                                                                             bool disable = false,
                                                                             SelectProductMaterialPurchaseOrderBussiness
                                                                                 bussiness =
                                                                                 SelectProductMaterialPurchaseOrderBussiness
                                                                                 .Default)
        {
            return Inman_DropDownGrid<CommonMaterialPurchaseOrderModel>(htmlHelper,
                                                                        name,
                                                                        string.Format(
                                                                            "/Selector/ProductMaterialPurchaseOrder?bussiness={0}",
                                                                            bussiness),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.DocNum).Width(100);
                                                                            c.Bound(f => f.DocDate).Width(100);
                                                                            c.Bound(f => f.SupplierName).Width(100);
                                                                            c.Bound(f => f.Amount).Width(100);
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        selectedValue: selectedValue,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        #endregion

        #region 对单需求物料

        public static MvcHtmlString Inman_SelectProductMaterialStockItemFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ItemCode",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = 700,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {


            return Inman_DropDownGridFor<TModel, TProperty, ProductBOMNeedDetailModel>(htmlHelper,
                                                                                       expression,
                                                                                       string.Format(
                                                                                           "/Selector/StockItemSelect?bussiness={0}",
                                                                                           SelectStockItemBussiness
                                                                                               .ProductMaterialPurchaseOrder),
                                                                                       d =>
                                                                                       {
                                                                                           d.Bound(
                                                                                               f =>
                                                                                               f.ProduceOrderDocNum)
                                                                                            .Width(100)
                                                                                            .Title("制单号");
                                                                                           d.Bound(f => f.ProductSN)
                                                                                            .Width(100)
                                                                                            .Title("大货款号");
                                                                                           d.Bound(f => f.ItemCode)
                                                                                            .Width(100)
                                                                                            .Title("物料SKU ");
                                                                                           d.Bound(f => f.Buyer)
                                                                                            .Width(100)
                                                                                            .Title("采购员 ");
                                                                                           d.Bound(f => f.ItemName)
                                                                                            .Width(100)
                                                                                            .Title("物料名称");
                                                                                           d.Bound(f => f.ItemSpec)
                                                                                            .Width(80)
                                                                                            .Title("规格");
                                                                                           d.Bound(f => f.Color)
                                                                                            .Width(80)
                                                                                            .Title("颜色");
                                                                                           d.Bound(f => f.Component)
                                                                                            .Width(80)
                                                                                            .Title("成分");
                                                                                           d.Bound(f => f.ItemWidth)
                                                                                            .Width(80)
                                                                                            .Title("幅宽");
                                                                                           d.Bound(f => f.Weight)
                                                                                            .Width(80)
                                                                                            .Title("克重");
                                                                                           d.Bound(f => f.CargoNum)
                                                                                            .Width(100)
                                                                                            .Title("采购需求");
                                                                                           d.Bound(
                                                                                               f => f.ProductColor)
                                                                                            .Width(100)
                                                                                            .Title("款式颜色");
                                                                                       },
                                                                                       dataTextField,
                                                                                       dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       gridPageSize: gridPageSize,
                                                                                       gridWidth: gridWidth,
                                                                                       gridHeight: gridHeight,
                                                                                       changeEvent: changeEvent,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialStockItem<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                                 string Name,
                                                                                 string dataTextField = "ItemCode",
                                                                                 string dataValueField = "Id",
                                                                                 string selectedText = null,
                                                                                 string selectedValue = null,
                                                                                 string perssmissionCode = null,
                                                                                 string optionLabel = " ",
                                                                                 int gridPageSize = 8,
                                                                                 int? gridWidth = 700,
                                                                                 int? gridHeight = null,
                                                                                 string changeEvent = null,
                                                                                 string selectEvent = null,
                                                                                 string clearEvent = null,
                                                                                 bool disable = false
            )
        {
            return Inman_DropDownGrid<ProductBOMNeedDetailModel>(htmlHelper, Name,
                                                                 string.Format(
                                                                     "/Selector/StockItemSelect?bussiness={0}",
                                                                     SelectStockItemBussiness
                                                                         .ProductMaterialPurchaseOrder),
                                                                 c =>
                                                                 {
                                                                     c.Bound(f => f.ProduceOrderDocNum)
                                                                      .Width(100)
                                                                      .Title("制单号");
                                                                     c.Bound(f => f.ProductSN)
                                                                      .Width(100)
                                                                      .Title("大货款号");
                                                                     c.Bound(f => f.ItemCode)
                                                                      .Width(100)
                                                                      .Title("物料SKU ");
                                                                     c.Bound(f => f.Buyer).Width(100).Title("采购员 ");
                                                                     c.Bound(f => f.ItemName)
                                                                      .Width(100)
                                                                      .Title("物料名称");
                                                                     c.Bound(f => f.ItemSpec).Width(80).Title("规格");
                                                                     c.Bound(f => f.Color).Width(80).Title("颜色");
                                                                     c.Bound(f => f.Component).Width(80).Title("成分");
                                                                     c.Bound(f => f.ItemWidth).Width(80).Title("幅宽");
                                                                     c.Bound(f => f.Weight).Width(80).Title("克重");
                                                                     c.Bound(f => f.CargoNum)
                                                                      .Width(100)
                                                                      .Title("采购需求");
                                                                     c.Bound(f => f.ProductColor)
                                                                      .Width(100)
                                                                      .Title("款式颜色");
                                                                 },
                                                                 dataTextField: dataTextField,
                                                                 dataValueField: dataValueField,
                                                                 selectedText: selectedText,
                                                                 selectedValue: selectedValue,
                                                                 optionLabel: optionLabel,
                                                                 perssmissionCode: perssmissionCode,
                                                                 gridPageSize: gridPageSize,
                                                                 gridWidth: gridWidth,
                                                                 gridHeight: gridHeight,
                                                                 changeEvent: changeEvent,
                                                                 selectEvent: selectEvent,
                                                                 clearEvent: clearEvent,
                                                                 disable: disable
                );

        }

        #endregion

        #region 配料通知单需求物料

        public static MvcHtmlString Inman_SelectProductMaterialPrepareNoticeStockItemFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ItemCode",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = 700,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {


            return Inman_DropDownGridFor<TModel, TProperty, ProductBOMNeedDetailModel>(htmlHelper,
                                                                                       expression,
                                                                                       string.Format(
                                                                                           "/Selector/StockItemSelect?bussiness={0}",
                                                                                           SelectStockItemBussiness
                                                                                               .ProductMaterialPrepareNotice),
                                                                                       d =>
                                                                                       {
                                                                                           d.Bound(
                                                                                               f =>
                                                                                               f.ProduceOrderDocNum)
                                                                                            .Width(100)
                                                                                            .Title("制单号");
                                                                                           d.Bound(f => f.ProductSN)
                                                                                            .Width(100)
                                                                                            .Title("大货款号");
                                                                                           d.Bound(f => f.ItemCode)
                                                                                            .Width(100)
                                                                                            .Title("物料SKU ");
                                                                                           d.Bound(f => f.Buyer)
                                                                                            .Width(100)
                                                                                            .Title("采购员 ");
                                                                                           d.Bound(f => f.ItemName)
                                                                                            .Width(100)
                                                                                            .Title("物料名称");
                                                                                           d.Bound(f => f.ItemSpec)
                                                                                            .Width(80)
                                                                                            .Title("规格");
                                                                                           d.Bound(f => f.Color)
                                                                                            .Width(80)
                                                                                            .Title("颜色");
                                                                                           d.Bound(f => f.Component)
                                                                                            .Width(80)
                                                                                            .Title("成分");
                                                                                           d.Bound(f => f.ItemWidth)
                                                                                            .Width(80)
                                                                                            .Title("幅宽");
                                                                                           d.Bound(f => f.Weight)
                                                                                            .Width(80)
                                                                                            .Title("克重");
                                                                                           d.Bound(f => f.CargoNum)
                                                                                            .Width(100)
                                                                                            .Title("采购需求");
                                                                                           d.Bound(
                                                                                               f => f.ProductColor)
                                                                                            .Width(100)
                                                                                            .Title("款式颜色");
                                                                                       },
                                                                                       dataTextField,
                                                                                       dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       gridPageSize: gridPageSize,
                                                                                       gridWidth: gridWidth,
                                                                                       gridHeight: gridHeight,
                                                                                       changeEvent: changeEvent,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialPrepareNoticeStockItem<TModel>(this HtmlHelper<TModel> htmlHelper,
                                                                                 string Name,
                                                                                 string dataTextField = "ItemCode",
                                                                                 string dataValueField = "Id",
                                                                                 string selectedText = null,
                                                                                 string selectedValue = null,
                                                                                 string perssmissionCode = null,
                                                                                 string optionLabel = " ",
                                                                                 int gridPageSize = 8,
                                                                                 int? gridWidth = 700,
                                                                                 int? gridHeight = null,
                                                                                 string changeEvent = null,
                                                                                 string selectEvent = null,
                                                                                 string clearEvent = null,
                                                                                 bool disable = false
            )
        {
            return Inman_DropDownGrid<ProductBOMNeedDetailModel>(htmlHelper, Name,
                                                                 string.Format(
                                                                     "/Selector/StockItemSelect?bussiness={0}",
                                                                     SelectStockItemBussiness
                                                                         .ProductMaterialPrepareNotice),
                                                                 c =>
                                                                 {
                                                                     c.Bound(f => f.ProduceOrderDocNum)
                                                                      .Width(100)
                                                                      .Title("制单号");
                                                                     c.Bound(f => f.ProductSN)
                                                                      .Width(100)
                                                                      .Title("大货款号");
                                                                     c.Bound(f => f.ItemCode)
                                                                      .Width(100)
                                                                      .Title("物料SKU ");
                                                                     c.Bound(f => f.Buyer).Width(100).Title("采购员 ");
                                                                     c.Bound(f => f.ItemName)
                                                                      .Width(100)
                                                                      .Title("物料名称");
                                                                     c.Bound(f => f.ItemSpec).Width(80).Title("规格");
                                                                     c.Bound(f => f.Color).Width(80).Title("颜色");
                                                                     c.Bound(f => f.Component).Width(80).Title("成分");
                                                                     c.Bound(f => f.ItemWidth).Width(80).Title("幅宽");
                                                                     c.Bound(f => f.Weight).Width(80).Title("克重");
                                                                     c.Bound(f => f.CargoNum)
                                                                      .Width(100)
                                                                      .Title("采购需求");
                                                                     c.Bound(f => f.ProductColor)
                                                                      .Width(100)
                                                                      .Title("款式颜色");
                                                                 },
                                                                 dataTextField: dataTextField,
                                                                 dataValueField: dataValueField,
                                                                 selectedText: selectedText,
                                                                 selectedValue: selectedValue,
                                                                 optionLabel: optionLabel,
                                                                 perssmissionCode: perssmissionCode,
                                                                 gridPageSize: gridPageSize,
                                                                 gridWidth: gridWidth,
                                                                 gridHeight: gridHeight,
                                                                 changeEvent: changeEvent,
                                                                 selectEvent: selectEvent,
                                                                 clearEvent: clearEvent,
                                                                 disable: disable
                );

        }

        #endregion

        #region 对单预约入库单

        public static MvcHtmlString Inman_SelectProductMaterialAdvanceFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectProductMaterialAdvanceBussiness bussiness = SelectProductMaterialAdvanceBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductMaterialAdvanceModel>(htmlHelper,
                                                                                         expression,
                                                                                         string.Format(
                                                                                             "/Selector/ProductMaterialAdvance?bussiness={0}",
                                                                                             bussiness),
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100);
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f => f.SupplierName)
                                                                                              .Width(100);
                                                                                             c.Bound(
                                                                                                 f =>
                                                                                                 f.PurchaseOrderNum)
                                                                                              .Width(100);
                                                                                         },
                                                                                         dataTextField,
                                                                                         dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         gridPageSize: gridPageSize,
                                                                                         gridWidth: gridWidth,
                                                                                         gridHeight: gridHeight,
                                                                                         changeEvent: changeEvent,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialAdvance(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "DocNum",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectProductMaterialAdvanceBussiness bussiness =
                                                                           SelectProductMaterialAdvanceBussiness.Default)
        {
            return Inman_DropDownGrid<ProductMaterialAdvanceModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/ProductMaterialAdvance?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       c.Bound(f => f.DocNum).Width(100);
                                                                       c.Bound(f => f.DocDate).Width(100);
                                                                       c.Bound(f => f.SupplierName).Width(100);
                                                                       c.Bound(f => f.PurchaseOrderNum).Width(100);
                                                                   },
                                                                   dataTextField,
                                                                   dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable
                );
        }

        #endregion

        #region 对单物料需求单

        public static MvcHtmlString Inman_SelectProductMaterialNeedFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ProduceOrderDouNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectProductMaterialNeedBussiness bussiness = SelectProductMaterialNeedBussiness.Default
            )
        {
            if (bussiness == SelectProductMaterialNeedBussiness.ProductMaterialTransfer ||
                bussiness == SelectProductMaterialNeedBussiness.ProductMaterialAllot)
            {
                dataTextField = "ProduceOrderDocNum";
                return Inman_DropDownGridFor<TModel, TProperty, ProductBOMNeedDetailModel>(htmlHelper,
                                                                                           expression,
                                                                                           string.Format(
                                                                                               "/Selector/ProductMaterialNeed?bussiness={0}",
                                                                                               bussiness),
                                                                                           c =>
                                                                                           {
                                                                                               c.Bound(
                                                                                                   f =>
                                                                                                   f
                                                                                                       .ProduceOrderDocNum)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f => f.ProductSN)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f =>
                                                                                                   f.ProductColor)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f => f.ItemName)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f => f.ItemCode)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f => f.ItemSpec)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f => f.CargoNum)
                                                                                                .Width(100);
                                                                                               c.Bound(
                                                                                                   f =>
                                                                                                   f
                                                                                                       .ProductMaterialInventoryQuantity)
                                                                                                .Width(100);
                                                                                               c.Bound(f => f.Color)
                                                                                                .Width(100);
                                                                                           },
                                                                                           dataTextField,
                                                                                           dataValueField,
                                                                                           selectedText: selectedText,
                                                                                           optionLabel: optionLabel,
                                                                                           gridPageSize: gridPageSize,
                                                                                           gridWidth: gridWidth,
                                                                                           gridHeight: gridHeight,
                                                                                           changeEvent: changeEvent,
                                                                                           selectEvent: selectEvent,
                                                                                           clearEvent: clearEvent,
                                                                                           disable: disable
                    );
            }
            return Inman_DropDownGridFor<TModel, TProperty, ProductBOMNeedModel>(htmlHelper,
                                                                                 expression,
                                                                                 string.Format(
                                                                                     "/Selector/ProductMaterialNeed?bussiness={0}",
                                                                                     bussiness),
                                                                                 c =>
                                                                                 {
                                                                                     c.Bound(
                                                                                         f => f.ProduceOrderDouNum)
                                                                                      .Width(100);
                                                                                     c.Bound(f => f.ProductSN)
                                                                                      .Width(100);
                                                                                     c.Bound(f => f.Color)
                                                                                      .Width(100);

                                                                                 },
                                                                                 dataTextField,
                                                                                 dataValueField,
                                                                                 selectedText: selectedText,
                                                                                 optionLabel: optionLabel,
                                                                                 gridPageSize: gridPageSize,
                                                                                 gridWidth: gridWidth,
                                                                                 gridHeight: gridHeight,
                                                                                 changeEvent: changeEvent,
                                                                                 selectEvent: selectEvent,
                                                                                 clearEvent: clearEvent,
                                                                                 disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialNeed(this HtmlHelper htmlHelper,
                                                                    string name,
                                                                    string dataTextField = "ProduceOrderDouNum",
                                                                    string dataValueField = "Id",
                                                                    string selectedValue = null,
                                                                    string selectedText = null,
                                                                    string perssmissionCode = null,
                                                                    string optionLabel = " ",
                                                                    int gridPageSize = 8,
                                                                    int? gridWidth = 500,
                                                                    int? gridHeight = 500,
                                                                    string changeEvent = null,
                                                                    string selectEvent = null,
                                                                    string clearEvent = null,
                                                                    bool disable = false,
                                                                    SelectProductMaterialNeedBussiness bussiness =
                                                                        SelectProductMaterialNeedBussiness.Default)
        {
            if (bussiness == SelectProductMaterialNeedBussiness.ProductMaterialTransfer ||
                bussiness == SelectProductMaterialNeedBussiness.ProductMaterialAllot)
            {
                dataTextField = "ProduceOrderDocNum";
                return Inman_DropDownGrid<ProductBOMNeedDetailModel>(htmlHelper,
                                                                     name,
                                                                     string.Format(
                                                                         "/Selector/ProductMaterialNeed?bussiness={0}",
                                                                         bussiness),
                                                                     c =>
                                                                     {

                                                                         c.Bound(f => f.ProduceOrderDocNum).Width(100);
                                                                         c.Bound(f => f.ProductSN).Width(100);
                                                                         c.Bound(f => f.ProductColor).Width(100);
                                                                         c.Bound(f => f.ItemName).Width(100);
                                                                         c.Bound(f => f.ItemCode).Width(100);
                                                                         c.Bound(f => f.ItemSpec).Width(100);
                                                                         c.Bound(f => f.CargoNum).Width(100);
                                                                         c.Bound(f => f.ProductMaterialInventoryQuantity).Width(120);
                                                                         c.Bound(f => f.Color).Width(100);
                                                                     },
                                                                     dataTextField,
                                                                     dataValueField,
                                                                     selectedText: selectedText,
                                                                     selectedValue: selectedValue,
                                                                     optionLabel: optionLabel,
                                                                     gridPageSize: gridPageSize,
                                                                     gridWidth: gridWidth,
                                                                     gridHeight: gridHeight,
                                                                     changeEvent: changeEvent,
                                                                     selectEvent: selectEvent,
                                                                     clearEvent: clearEvent,
                                                                     disable: disable
                    );
            }
            return Inman_DropDownGrid<ProductBOMNeedModel>(htmlHelper,
                                                           name,
                                                           string.Format("/Selector/ProductMaterialNeed?bussiness={0}",
                                                                         bussiness),
                                                           c =>
                                                           {

                                                               c.Bound(f => f.ProduceOrderDouNum).Width(100);
                                                               c.Bound(f => f.ProductSN).Width(100);
                                                               c.Bound(f => f.Color).Width(100);
                                                           },
                                                           dataTextField,
                                                           dataValueField,
                                                           selectedText: selectedText,
                                                           selectedValue: selectedValue,
                                                           optionLabel: optionLabel,
                                                           gridPageSize: gridPageSize,
                                                           gridWidth: gridWidth,
                                                           gridHeight: gridHeight,
                                                           changeEvent: changeEvent,
                                                           selectEvent: selectEvent,
                                                           clearEvent: clearEvent,
                                                           disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialNeedDetailFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ItemCode",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductBOMNeedDetailModel>(htmlHelper,
                                                                                       expression,
                                                                                       string.Format(
                                                                                           "/Selector/ProduceMaterialNeedDetail"),
                                                                                       c =>
                                                                                       {
                                                                                           c.Bound(f => f.ItemCode)
                                                                                            .Width(100);
                                                                                           c.Bound(f => f.ItemName)
                                                                                            .Width(100);
                                                                                           c.Bound(f => f.CargoNum)
                                                                                            .Width(100);
                                                                                           c.Bound(f => f.Color)
                                                                                            .Width(100);
                                                                                           c.Bound(
                                                                                               f => f.SupplierName)
                                                                                            .Width(100);
                                                                                           c.Bound(f => f.Size)
                                                                                            .Width(100);
                                                                                       },
                                                                                       dataTextField,
                                                                                       dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       gridPageSize: gridPageSize,
                                                                                       gridWidth: gridWidth,
                                                                                       gridHeight: gridHeight,
                                                                                       changeEvent: changeEvent,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialNeedDetail(this HtmlHelper htmlHelper,
                                                                          string name,
                                                                          string dataTextField = "ItemCode",
                                                                          string dataValueField = "Id",
                                                                          string selectedValue = null,
                                                                          string selectedText = null,
                                                                          string perssmissionCode = null,
                                                                          string optionLabel = " ",
                                                                          int gridPageSize = 8,
                                                                          int? gridWidth = 500,
                                                                          int? gridHeight = null,
                                                                          string changeEvent = null,
                                                                          string selectEvent = null,
                                                                          string clearEvent = null,
                                                                          bool disable = false)
        {
            return Inman_DropDownGrid<ProductBOMNeedDetailModel>(htmlHelper,
                                                                 name,
                                                                 string.Format("/Selector/ProduceMaterialNeedDetail"),
                                                                 c =>
                                                                 {
                                                                     c.Bound(f => f.ItemCode).Width(100);
                                                                     c.Bound(f => f.ItemName).Width(100);
                                                                     c.Bound(f => f.CargoNum).Width(100);
                                                                     c.Bound(f => f.Color).Width(100);
                                                                     c.Bound(f => f.SupplierName).Width(100);
                                                                     c.Bound(f => f.Size).Width(100);
                                                                 },
                                                                 dataTextField,
                                                                 dataValueField,
                                                                 selectedText: selectedText,
                                                                 selectedValue: selectedValue,
                                                                 optionLabel: optionLabel,
                                                                 gridPageSize: gridPageSize,
                                                                 gridWidth: gridWidth,
                                                                 gridHeight: gridHeight,
                                                                 changeEvent: changeEvent,
                                                                 selectEvent: selectEvent,
                                                                 clearEvent: clearEvent,
                                                                 disable: disable
                );
        }

        #endregion

        #region 对单库存

        public static MvcHtmlString Inman_SelectProductMaterialInventory(this HtmlHelper htmlHelper, string name,
            int? warehouseId = null,
                                                                         string dataTextField = "ItemCode",
                                                                         string dataValueField = "Id",
                                                                         string selectedValue = null,
                                                                         string selectedText = null,
                                                                         string perssmissionCode = null,
                                                                         string optionLabel = " ",
                                                                         int gridPageSize = 8,
                                                                         int? gridWidth = null,
                                                                         int? gridHeight = null,
                                                                         string changeEvent = null,
                                                                         string selectEvent = null,
                                                                         string clearEvent = null,
                                                                         bool disable = false,
                                                                         SelectProductMaterialInventoryBussiness
                                                                             bussiness =
                                                                             SelectProductMaterialInventoryBussiness
                                                                             .Default)
        {
            return Inman_DropDownGrid<ProductMaterialInventoryModel>(htmlHelper, name,
                                                                     string.Format(
                                                                         "/Selector/ProductMaterialInventory?bussiness={0}&warehouseId={1}",
                                                                         bussiness, warehouseId),
                                                                     c =>
                                                                     {
                                                                         c.Bound(f => f.ItemCode)
                                                                          .Width(100)
                                                                          .Title("物料SKU");
                                                                         c.Bound(f => f.ItemName)
                                                                          .Width(120)
                                                                          .Title("物料名称");
                                                                         c.Bound(f => f.ColorName)
                                                                          .Width(80)
                                                                          .Title("颜色");
                                                                         c.Bound(f => f.ProduceOrderDocNum)
                                                                          .Width(100)
                                                                          .Title("大货制单号");
                                                                         c.Bound(f => f.ProductSN)
                                                                          .Width(100)
                                                                          .Title("大货款号");
                                                                         c.Bound(f => f.ProductColor)
                                                                          .Width(100)
                                                                          .Title("款号颜色");
                                                                         c.Bound(f => f.ItemSpec)
                                                                          .Width(100)
                                                                          .Title("规格");
                                                                         c.Bound(f => f.UsableQuantity)
                                                                          .Width(100)
                                                                          .Title("可用数");
                                                                         c.Bound(f => f.Unit).Width(80).Title("单位");
                                                                         c.Bound(f => f.UnitPrice)
                                                                          .Width(100)
                                                                          .Title("领用金额");
                                                                         c.Bound(f => f.WarehouseName)
                                                                          .Width(100)
                                                                          .Title("仓库");
                                                                         c.Bound(f => f.StorageRackName)
                                                                          .Width(100)
                                                                          .Title("库位");
                                                                     },
                                                                     dataTextField,
                                                                     dataValueField,
                                                                     selectedText: selectedText,
                                                                     selectedValue: selectedValue,
                                                                     optionLabel: optionLabel,
                                                                     gridPageSize: gridPageSize,
                                                                     gridWidth: gridWidth,
                                                                     gridHeight: gridHeight,
                                                                     changeEvent: changeEvent,
                                                                     selectEvent: selectEvent,
                                                                     clearEvent: clearEvent,
                                                                     disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProductMaterialInventoryFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ItemCode",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = null,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectProductMaterialInventoryBussiness bussiness = SelectProductMaterialInventoryBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectProductMaterialInventory(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 对单领用单选择大货制单号

        public static MvcHtmlString Inman_SelectProduceOrderForProductMaterialApply(this HtmlHelper htmlHelper,
                                                                                    string name,
                                                                                    string supplierName = null,
                                                                                    string dataTextField = "DocNum",
                                                                                    string dataValueField = "Id",
                                                                                    string selectedValue = null,
                                                                                    string selectedText = null,
                                                                                    string perssmissionCode = null,
                                                                                    string optionLabel = " ",
                                                                                    int gridPageSize = 8,
                                                                                    int? gridWidth = null,
                                                                                    int? gridHeight = null,
                                                                                    string changeEvent = null,
                                                                                    string selectEvent = null,
                                                                                    string clearEvent = null,
                                                                                    bool disable = false)
        {
            string section1 = string.IsNullOrEmpty(supplierName) ? "" : "&supplierName=" + supplierName;
            return Inman_DropDownGrid<ProduceOrderModel>(htmlHelper, name,
                                                         string.Format("/Selector/ProduceOrderForProductMaterialApply?1=1" + section1),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.DocNum).Width(120).Title("大货制单号");
                                                             c.Bound(f => f.ProductSN).Width(100).Title("大货款号");
                                                             c.Bound(f => f.Color).Width(60).Title("颜色");
                                                             c.Bound(f => f.ProductName).Width(100).Title("款号名称");
                                                             c.Bound(f => f.Brand).Width(60).Title("品牌");
                                                             c.Bound(f => f.DesignProductSN)
                                                              .Width(100)
                                                              .Title("设计款号");
                                                         },
                                                         dataTextField,
                                                         dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectProduceOrderForProductMaterialApplyFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = null,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectProduceOrderForProductMaterialApply(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable);
        }

        #endregion

        #region 对单出库单选择对单领用单

        public static MvcHtmlString Inman_SelectProductMaterialApplyForProductMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? productMaterialApplyId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (productMaterialApplyId == null || productMaterialApplyId == 0
                                   ? ""
                                   : "&productMaterialApplyId=" + productMaterialApplyId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductMaterialApplyModel>(htmlHelper,
                                                                                       expression,
                                                                                       "/Selector/ProductMaterialApplyForProductMaterialStockOutOrder" +
                                                                                       section1,
                                                                                       c =>
                                                                                       {
                                                                                           c.Bound(f => f.DocNum)
                                                                                            .Width(200)
                                                                                            .Title("领用单号");
                                                                                           c.Bound(f => f.DocUser)
                                                                                            .Width(100)
                                                                                            .Title("领用人");
                                                                                       },
                                                                                       dataTextField: dataTextField,
                                                                                       dataValueField: dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable,
                                                                                       gridWidth: gridWidth
                );
        }

        #endregion

        #region 对单余料入库单选择对单出库单

        public static MvcHtmlString Inman_SelectProductMaterialStockOutForProductMaterialSurplusOrder<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> expression,
             string dataTextField = "DocNum",
             string dataValueField = "Id",
             string selectedText = null,
             string optionLabel = " ",
             string selectEvent = null,
             string clearEvent = null,
             bool disable = false,
             int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialStockOutModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/ProductMaterialStockOutForProductMaterialSurplusOrder",
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum)
                                                                                              .Width(100)
                                                                                              .Title("出库单号");
                                                                                             c.Bound(f => f.DocDate)
                                                                                              .Width(100)
                                                                                              .Title("出库日期");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 对单/非对单出库催款单选择加工厂

        public static MvcHtmlString Inman_SelectSupplierForStockOutDunning<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dateMonth,
            string dataTextField = "Name",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null,
            SelectSupplierForStockOutDunningBussiness bussiness = SelectSupplierForStockOutDunningBussiness.Default)
        {
            string section1 = (string.IsNullOrEmpty(dateMonth)
                                   ? ""
                                   : "&dateMonth=" + dateMonth);

            return Inman_DropDownGridFor<TModel, TProperty, SupplierModel>(htmlHelper,
                                                                           expression,
                                                                           string.Format("/Selector/SupplierForStockOutDunning?bussiness={0}" + section1, bussiness),
                                                                           c =>
                                                                           {
                                                                               c.Bound(f => f.Name)
                                                                                .Width(120)
                                                                                .Title("工厂简称");
                                                                               c.Bound(f => f.FullName)
                                                                                .Width(100)
                                                                                .Title("工厂全称");
                                                                               c.Bound(f => f.SupplyProducts)
                                                                                .Width(100)
                                                                                .Title("工厂产品");
                                                                               c.Bound(f => f.Contact)
                                                                                .Width(100)
                                                                                .Title("联系人");
                                                                               c.Bound(f => f.Mobile)
                                                                                .Width(120)
                                                                                .Title("联系电话");
                                                                           },
                                                                           dataTextField: dataTextField,
                                                                           dataValueField: dataValueField,
                                                                           selectedText: selectedText,
                                                                           optionLabel: optionLabel,
                                                                           selectEvent: selectEvent,
                                                                           clearEvent: clearEvent,
                                                                           disable: disable,
                                                                           gridWidth: gridWidth
                );
        }

        #endregion

        #region 选择库位

        /// <summary>
        /// 库位选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectStorageRackFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string cascadeFrom,
            string dataTextField = "Name", string dataValueField = "Id", string perssmissionCode = null,
            string optionLabel = " ", object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {warehouseId: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                                .DataSource(
                                                    ds =>
                                                    ds.Read(r => r.Url("/Selector/StorageRack").Data(script))
                                                      .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true);

                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;
        }

        /// <summary>
        /// 库位选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectStorageRack(this HtmlHelper htmlHelper, string name,
                                                                  string cascadeFrom, string dataTextField = "Name",
                                                                  string dataValueField = "Id",
                                                                  string selectedValue = null,
                                                                  string perssmissionCode = null,
                                                                  string optionLabel = " ",
                                                                  object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {
                string script = "function() {var ddl = $(\"#" + cascadeFrom +
                                "\").data(\"kendoDropDownList\");return {warehouseId: ddl.dataItem(ddl.select()).Id};}";

                var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                                .DataSource(
                                                    t =>
                                                    t.Read(r => r.Url("/Selector/StorageRack").Data(script))
                                                     .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .CascadeFrom(cascadeFrom).AutoBind(true).Filter(FilterType.Contains);

                if (!string.IsNullOrEmpty(selectedValue))
                    dropDownBuilder = dropDownBuilder.Value(selectedValue);
                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;

        }

        #endregion

        #region 非对单出库单选择办料调料单

        public static MvcHtmlString Inman_SelectSampleMaterialTransferForCommonMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? sampleMaterialTransferId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (sampleMaterialTransferId == null || sampleMaterialTransferId == 0
                                   ? ""
                                   : "&sampleMaterialTransferId=" + sampleMaterialTransferId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialApplyModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SampleMaterialTransferForCommonMaterialStockOutOrder?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      c.Bound(f => f.DocNum)
                                                                                       .Width(300)
                                                                                       .Title("依据单号"),
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 物料二次加工领用单选择二次加工单

        public static MvcHtmlString Inman_SelectSecOptMaterialOrderForSecOptMaterialApply<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? orderId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (orderId == null || orderId == 0
                                   ? ""
                                   : "&orderId=" + orderId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SecOptMaterialOrderForSecOptMaterialApply?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(150)
                                                                                           .Title("加工单号");
                                                                                          c.Bound(f => f.Type)
                                                                                           .Width(150)
                                                                                           .Title("加工方式");
                                                                                          c.Bound(
                                                                                              f => f.SupplierName)
                                                                                           .Width(150)
                                                                                           .Title("加工厂");
                                                                                          c.Bound(f => f.Price)
                                                                                           .Width(100)
                                                                                           .Title("单价");
                                                                                          c.Bound(f => f.Times)
                                                                                           .Width(150)
                                                                                           .Title("加工次数");
                                                                                          c.Bound(f => f.Amount)
                                                                                           .Width(100)
                                                                                           .Title("金额");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 物料二次加工单

        public static MvcHtmlString Inman_SelectSecOptMaterialPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSecOptMaterialOrderBussiness bussiness = SelectSecOptMaterialOrderBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      string.Format(
                                                                                          "/Selector/SecOptMaterialPurchaseOrder?bussiness={0}",
                                                                                          bussiness),
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum).Width(100);
                                                                                          c.Bound(f => f.DocDate).Width(100);
                                                                                          c.Bound(f => f.SupplierName).Width(100);
                                                                                          c.Bound(f => f.Amount).Width(100);
                                                                                      },
                                                                                      dataTextField,
                                                                                      dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      gridPageSize: gridPageSize,
                                                                                      gridWidth: gridWidth,
                                                                                      gridHeight: gridHeight,
                                                                                      changeEvent: changeEvent,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable
                );
        }

        #endregion

        #region 物料二次加工领用单选择物料

        public static MvcHtmlString Inman_SelectStockItemForSecOptMaterialApply(this HtmlHelper htmlHelper,
                                                                                    string name,
                                                                                    string dataTextField = "ItemCode",
                                                                                    string dataValueField = "Id",
                                                                                    string selectedValue = null,
                                                                                    string selectedText = null,
                                                                                    string perssmissionCode = null,
                                                                                    string optionLabel = " ",
                                                                                    int gridPageSize = 8,
                                                                                    int? gridWidth = null,
                                                                                    int? gridHeight = null,
                                                                                    string changeEvent = null,
                                                                                    string selectEvent = null,
                                                                                    string clearEvent = null,
                                                                                    bool disable = false)
        {
            return Inman_DropDownGrid<StockItemModel>(htmlHelper, name,
                                                         string.Format("/Selector/StockItemForSecOptMaterialApply"),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.ItemCode).Width(120).Title("物料SKU");
                                                             c.Bound(f => f.ItemName).Width(100).Title("物料名称");
                                                             c.Bound(f => f.Color).Width(60).Title("颜色");
                                                             c.Bound(f => f.ItemSpec).Width(100).Title("规格");
                                                             c.Bound(f => f.Unit).Width(60).Title("单位");
                                                             c.Bound(f => f.Price).Width(100).Title("单价");
                                                         },
                                                         dataTextField,
                                                         dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        #endregion

        #region 物料二次加工领用单选择仓库

        public static MvcHtmlString Inman_SelectInventoryForSecOptMaterialApply(this HtmlHelper htmlHelper,
                                                                                    string name,
                                                                                    string dataTextField = "ItemCode",
                                                                                    string dataValueField = "Id",
                                                                                    string selectedValue = null,
                                                                                    string selectedText = null,
                                                                                    string perssmissionCode = null,
                                                                                    string optionLabel = " ",
                                                                                    int gridPageSize = 8,
                                                                                    int? gridWidth = null,
                                                                                    int? gridHeight = null,
                                                                                    string changeEvent = null,
                                                                                    string selectEvent = null,
                                                                                    string clearEvent = null,
                                                                                    bool disable = false)
        {
            return Inman_DropDownGrid<SecOptMaterialInventoryModel>(htmlHelper, name,
                                                         string.Format("/Selector/InventoryForSecOptMaterialApply"),
                                                         c =>
                                                         {
                                                             c.Bound(f => f.ItemCode).Width(120).Title("物料SKU");
                                                             c.Bound(f => f.ItemName).Width(120).Title("物料名称");
                                                             c.Bound(f => f.ColorName).Width(80).Title("颜色");
                                                             c.Bound(f => f.ItemSpec).Width(80).Title("规格");
                                                             c.Bound(f => f.UsableQuantity).Width(100).Title("可用数");
                                                             c.Bound(f => f.Unit).Width(80).Title("单位");
                                                             c.Bound(f => f.WarehouseName).Width(100).Title("仓库");
                                                             c.Bound(f => f.StorageRackName).Width(100).Title("库位");
                                                             c.Bound(f => f.ProduceOrderDocNum).Width(100).Title("制单号");
                                                             c.Bound(f => f.ProductSN).Width(120).Title("大货款号");
                                                             c.Bound(f => f.ProductColor).Width(120).Title("大货颜色");
                                                         },
                                                         dataTextField,
                                                         dataValueField,
                                                         selectedText: selectedText,
                                                         selectedValue: selectedValue,
                                                         optionLabel: optionLabel,
                                                         gridPageSize: gridPageSize,
                                                         gridWidth: gridWidth,
                                                         gridHeight: gridHeight,
                                                         changeEvent: changeEvent,
                                                         selectEvent: selectEvent,
                                                         clearEvent: clearEvent,
                                                         disable: disable
                );
        }

        #endregion

        #region 物料二次加工预约入库单

        public static MvcHtmlString Inman_SelectSecOptMaterialAdvanceFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSecOptMaterialAdvanceBussiness bussiness = SelectSecOptMaterialAdvanceBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialAdvanceModel>(htmlHelper,
                                                                                         expression,
                                                                                         string.Format(
                                                                                             "/Selector/SecOptMaterialAdvance?bussiness={0}",
                                                                                             bussiness),
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum).Width(100);
                                                                                             c.Bound(f => f.RangeDate).Width(100);
                                                                                             c.Bound(f => f.SupplierName).Width(100);
                                                                                             c.Bound(f => f.SecOptMaterialOrderNum).Width(100);
                                                                                         },
                                                                                         dataTextField,
                                                                                         dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         gridPageSize: gridPageSize,
                                                                                         gridWidth: gridWidth,
                                                                                         gridHeight: gridHeight,
                                                                                         changeEvent: changeEvent,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectSecOptMaterialAdvance(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "DocNum",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectSecOptMaterialAdvanceBussiness bussiness =
                                                                           SelectSecOptMaterialAdvanceBussiness.Default)
        {
            return Inman_DropDownGrid<SecOptMaterialAdvanceModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/SecOptMaterialAdvance?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       c.Bound(f => f.DocNum).Width(100);
                                                                       c.Bound(f => f.RangeDate).Width(100);
                                                                       c.Bound(f => f.SupplierName).Width(100);
                                                                       c.Bound(f => f.SecOptMaterialOrderNum).Width(100);
                                                                   },
                                                                   dataTextField,
                                                                   dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable
                );
        }

        #endregion

        #region 对单出库单选择对单领用单

        public static MvcHtmlString Inman_SelectSecOptMaterialApplyForSecOptMaterialStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? applyId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (applyId == null || applyId == 0
                                   ? ""
                                   : "&applyId=" + applyId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialApplyModel>(htmlHelper,
                                                                                       expression,
                                                                                       "/Selector/SecOptMaterialApplyForSecOptMaterialStockOutOrder?1=1" +
                                                                                       section1,
                                                                                       c =>
                                                                                       {
                                                                                           c.Bound(f => f.DocNum).Width(200).Title("领用单号");
                                                                                           c.Bound(f => f.DocUser).Width(100).Title("领用人");
                                                                                       },
                                                                                       dataTextField: dataTextField,
                                                                                       dataValueField: dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable,
                                                                                       gridWidth: gridWidth
                );
        }

        #endregion

        #region 物料二次加工余料入库单选择物料二次加工出库单

        public static MvcHtmlString Inman_SelectSecOptMaterialStockOutForSecOptMaterialSurplusOrder<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> expression,
             string dataTextField = "DocNum",
             string dataValueField = "Id",
             string selectedText = null,
             string optionLabel = " ",
             string selectEvent = null,
             string clearEvent = null,
             bool disable = false,
             int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialStockOutModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/SecOptMaterialStockOutForSecOptMaterialSurplusOrder",
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum).Width(100).Title("出库单号");
                                                                                             c.Bound(f => f.DocDate).Width(100).Title("出库时间");
                                                                                             c.Bound(f => f.OrderDocNum).Width(100).Title("加工单号");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 办料采购单

        public static MvcHtmlString Inman_SelectSecOptProductOrderFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                     Expression<Func<TModel, TProperty>>
                                                                                         expression,
                                                                                     string dataTextField = "DocNum",
                                                                                     string dataValueField = "Id",
                                                                                     string selectedText = null,
                                                                                     string perssmissionCode = null,
                                                                                     string optionLabel = " ",
                                                                                     int gridPageSize = 5,
                                                                                     int? gridWidth = 500,
                                                                                     int? gridHeight = null,
                                                                                     string changeEvent = null,
                                                                                     string selectEvent = null,
                                                                                     string clearEvent = null,
                                                                                     bool disable = false,
                                                                                     SelectSecOptProductOrderBussiness
                                                                                         bussiness =
                                                                                         SelectSecOptProductOrderBussiness
                                                                                         .Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SecOptProductOrderModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/SecOptProductOrder?bussiness={0}",
                                                                                                  bussiness),
                c =>
                {
                    c.Bound(f => f.DocNum).Width(100);
                    c.Bound(f => f.DocDate).Width(100);
                    c.Bound(f => f.Amount).Width(100);
                },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectSecOptProductOrder(this HtmlHelper htmlHelper,
                                                               string name,
                                                               string dataTextField = "DocNum",
                                                               string dataValueField = "Id",
                                                               string selectedValue = null,
                                                               string selectedText = null,
                                                               string perssmissionCode = null,
                                                               string optionLabel = " ",
                                                               int gridPageSize = 8,
                                                               int? gridWidth = 500,
                                                               int? gridHeight = null,
                                                               string changeEvent = null,
                                                               string selectEvent = null,
                                                               string clearEvent = null,
                                                               bool disable = false,
                                                               SelectSecOptProductOrderBussiness bussiness =
                                                                   SelectSecOptProductOrderBussiness.Default)
        {
            return Inman_DropDownGrid<SecOptProductOrderModel>(htmlHelper,
                                                                        name,
                                                                        string.Format(
                                                                            "/Selector/SecOptProductOrder?bussiness={0}",
                                                                            bussiness),
                                                                        c =>
                                                                        {
                                                                            c.Bound(f => f.DocNum).Width(100);
                                                                            c.Bound(f => f.DocDate).Width(100);
                                                                            c.Bound(f => f.Amount).Width(100);
                                                                        },
                                                                        dataTextField,
                                                                        dataValueField,
                                                                        selectedText: selectedText,
                                                                        selectedValue: selectedValue,
                                                                        optionLabel: optionLabel,
                                                                        gridPageSize: gridPageSize,
                                                                        gridWidth: gridWidth,
                                                                        gridHeight: gridHeight,
                                                                        changeEvent: changeEvent,
                                                                        selectEvent: selectEvent,
                                                                        clearEvent: clearEvent,
                                                                        disable: disable
                );
        }

        #endregion

        #region 半成品二次加工加减款申请单选择半成品二次加工单

        public static MvcHtmlString Inman_SelectSecOptProductOrderForSecOptProductTakeOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? orderId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (orderId == null || orderId == 0
                                   ? ""
                                   : "&orderId=" + orderId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, SecOptProductOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SecOptProductOrderForSecOptProductTakeOrder?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum).Width(100).Title("加工单号");
                                                                                          c.Bound(f => f.DocDate).Width(100).Title("合同日期");
                                                                                          c.Bound(f => f.SupplierName).Width(100).Title("供应商");
                                                                                          c.Bound(f => f.DocUser).Width(50).Title("申请人");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion



        #region 半成品二次加工单

        public static MvcHtmlString Inman_SelectSecOptProductPurchaseOrderFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSecOptProductOrderBussiness bussiness = SelectSecOptProductOrderBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SecOptProductOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      string.Format(
                                                                                          "/Selector/SecOptProductPurchaseOrder?bussiness={0}",
                                                                                          bussiness),
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum).Width(100);
                                                                                          c.Bound(f => f.DocDate).Width(100);
                                                                                          c.Bound(f => f.SupplierName).Width(100);
                                                                                          c.Bound(f => f.Amount).Width(100);
                                                                                      },
                                                                                      dataTextField,
                                                                                      dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      gridPageSize: gridPageSize,
                                                                                      gridWidth: gridWidth,
                                                                                      gridHeight: gridHeight,
                                                                                      changeEvent: changeEvent,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable
                );
        }

        #endregion

        #region 样衣编号
        public static MvcHtmlString Inman_SelectSampleProductFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "ProductSN",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSampleProductBussiness bussiness = SelectSampleProductBussiness.Default
            )
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleProductModel>(htmlHelper,
                                                                                         expression,
                                                                                         string.Format(
                                                                                             "/Selector/SampleProduct?bussiness={0}",
                                                                                             bussiness),
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.ProductSN).Width(100);
                                                                                             c.Bound(f => f.Color).Width(100);
                                                                                             c.Bound(f => f.CategoryName).Width(100);
                                                                                             c.Bound(f => f.Price).Width(100);
                                                                                         },
                                                                                         dataTextField,
                                                                                         dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         gridPageSize: gridPageSize,
                                                                                         gridWidth: gridWidth,
                                                                                         gridHeight: gridHeight,
                                                                                         changeEvent: changeEvent,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable
                );
        }

        public static MvcHtmlString Inman_SelectSampleProduct(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "ProductSN",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       int gridPageSize = 8,
                                                                       int? gridWidth = 500,
                                                                       int? gridHeight = null,
                                                                       string changeEvent = null,
                                                                       string selectEvent = null,
                                                                       string clearEvent = null,
                                                                       bool disable = false,
                                                                       SelectSampleProductBussiness bussiness =
                                                                           SelectSampleProductBussiness.Default)
        {
            return Inman_DropDownGrid<SampleProductModel>(htmlHelper,
                                                                   name,
                                                                   string.Format(
                                                                       "/Selector/SampleProduct?bussiness={0}",
                                                                       bussiness),
                                                                   c =>
                                                                   {
                                                                       c.Bound(f => f.ProductSN).Width(100);
                                                                       c.Bound(f => f.Color).Width(100);
                                                                       c.Bound(f => f.CategoryName).Width(100);
                                                                       c.Bound(f => f.Price).Width(100);
                                                                   },
                                                                   dataTextField,
                                                                   dataValueField,
                                                                   selectedText: selectedText,
                                                                   selectedValue: selectedValue,
                                                                   optionLabel: optionLabel,
                                                                   gridPageSize: gridPageSize,
                                                                   gridWidth: gridWidth,
                                                                   gridHeight: gridHeight,
                                                                   changeEvent: changeEvent,
                                                                   selectEvent: selectEvent,
                                                                   clearEvent: clearEvent,
                                                                   disable: disable
                );
        }
        #endregion

        #region
        public static DropDownListBuilder Inman_SelectSizeFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "Name",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            SelectSizeBussiness bussiness = SelectSizeBussiness.Default)
        {
            return Inman_DropDownListFor(htmlHelper, expression,
                string.Format("/Selector/Size?bussiness={0}", bussiness),
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedText: selectedText,
                optionLabel: optionLabel,
                perssmissionCode: perssmissionCode
                );
        }

        public static DropDownListBuilder Inman_SelectSize(this HtmlHelper htmlHelper,
                                                                       string name,
                                                                       string dataTextField = "Name",
                                                                       string dataValueField = "Id",
                                                                       string selectedValue = null,
                                                                       string selectedText = null,
                                                                       string perssmissionCode = null,
                                                                       string optionLabel = " ",
                                                                       SelectSizeBussiness bussiness =
                                                                           SelectSizeBussiness.Default)
        {
            return Inman_DropDownList(htmlHelper, name, string.Format("/Selector/Size?bussiness={0}", bussiness),
                                      dataTextField: dataTextField,
                                      dataValueField: dataValueField,
                                      selectedValue: selectedValue,
                                      selectedText: selectedText,
                                      optionLabel: optionLabel,
                                      perssmissionCode: perssmissionCode
                );
        }
        #endregion

        #region 样衣库存

        public static MvcHtmlString Inman_SelectSampleProductInventory(this HtmlHelper htmlHelper, string name,
                                                                        int? warehouseId = null,
                                                                         string dataTextField = "ProductSN",
                                                                         string dataValueField = "Id",
                                                                         string selectedValue = null,
                                                                         string selectedText = null,
                                                                         string perssmissionCode = null,
                                                                         string optionLabel = " ",
                                                                         int gridPageSize = 8,
                                                                         int? gridWidth = null,
                                                                         int? gridHeight = null,
                                                                         string changeEvent = null,
                                                                         string selectEvent = null,
                                                                         string clearEvent = null,
                                                                         bool disable = false,
                                                                         SelectSampleProductInventoryBussiness bussiness = SelectSampleProductInventoryBussiness.Default)
        {
            string section1 = (warehouseId == null || warehouseId == 0 ? "" : "&warehouseId=" + warehouseId.Value);

            if (bussiness == SelectSampleProductInventoryBussiness.SampleProductApply)
            {
                return Inman_DropDownGrid<SampleProductInventoryModel>(htmlHelper, name,
                string.Format("/Selector/SampleProductInventory?bussiness={0}" + section1, bussiness),
                c =>
                {
                    c.Bound(f => f.ProductSN).Width(120).Title("样衣编号");
                    c.Bound(f => f.SampleProductTypeEnum).Width(120).Title("样衣类型");
                    c.Bound(f => f.ColorName).Width(120).Title("样衣颜色");
                    c.Bound(f => f.SizeName).Width(120).Title("样衣尺寸");
                    c.Bound(f => f.UnitPrice).Width(100).Title("单价");
                    c.Bound(f => f.UsableQuantity).Width(120).Title("可用库存数");
                    c.Bound(f => f.StorageRackName).Width(100).Title("库位");
                    c.Bound(f => f.WarehouseName).Width(100).Title("仓库");
                },
                dataTextField,
                dataValueField,
                selectedText: selectedText,
                selectedValue: selectedValue,
                optionLabel: optionLabel,
                gridPageSize: gridPageSize,
                gridWidth: gridWidth,
                gridHeight: gridHeight,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable
                );
            }
            else
            {
                return Inman_DropDownGrid<SampleProductInventoryModel>(htmlHelper, name,
                string.Format("/Selector/SampleProductInventory?bussiness={0}" + section1, bussiness),
                c =>
                {


                    c.Bound(f => f.SampleProductTypeEnum).Width(120).Title("样衣类型");
                    c.Bound(f => f.SizeName).Width(80).Title("尺寸");
                    c.Bound(f => f.ProductSN).Width(100).Title("样衣编号");
                    c.Bound(f => f.UnitPrice).Width(100).Title("单价");
                    c.Bound(f => f.ColorName).Width(120).Title("颜色");
                    c.Bound(f => f.StorageRackName).Width(100).Title("库位");
                    c.Bound(f => f.Quantity).Width(100).Title("库存数");
                    c.Bound(f => f.WarehouseName).Width(100).Title("仓库名称");
                },
                dataTextField,
                dataValueField,
                selectedText: selectedText,
                selectedValue: selectedValue,
                optionLabel: optionLabel,
                gridPageSize: gridPageSize,
                gridWidth: gridWidth,
                gridHeight: gridHeight,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable
                );
            }
        }

        public static MvcHtmlString Inman_SelectSampleProductInventoryFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? warehouseId = null,
            string dataTextField = "ProductSN",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 8,
            int? gridWidth = null,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            SelectSampleProductInventoryBussiness bussiness = SelectSampleProductInventoryBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectSampleProductInventory(
                htmlHelper,
                name,
                warehouseId,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        #endregion

        #region 样衣出库单选择样衣领用单

        public static MvcHtmlString Inman_SelectSampleProductApplyForSampleProductStockOutOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? applyId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (applyId == null || applyId == 0
                                   ? ""
                                   : "&applyId=" + applyId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, SampleProductApplyModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SampleProductApplyForSampleProductStockOutOrder?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(150)
                                                                                           .Title("领用单号");
                                                                                          c.Bound(f => f.DocUser)
                                                                                           .Width(100)
                                                                                           .Title("领用人");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 选择部门
        /// <summary>
        /// 部门选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="optionCode"></param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectDept(this HtmlHelper htmlHelper
                                                             , string name

                                                             , string selectedValue = null
                                                             , string selectedText = null
                                                             , string optionLabel = " "
                                                             , object htmlAttributes = null)
        {
            return Inman_DropDownList(htmlHelper
                                      , name
                                      , "/Selector/Dept"
                                      , "ItemName"
                                      , "ItemValue"
                                      , null
                                      , selectedValue
                                      , selectedText
                                      , null
                                      , optionLabel
                                      , htmlAttributes);
        }

        /// <summary>
        /// 部门选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="optionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectDeptFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                                   Expression<Func<TModel, TProperty>> expression,
                                                                                   string optionLabel = " ",
                                                                                   object htmlAttributes = null,
                                                                                   FilterMode filterMode =
                                                                                       FilterMode.Server)
        {
            //string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            object value = modelMetadata.Model;
            return Inman_DropDownListFor(htmlHelper, expression,
                                         "/Selector/Dept",
                                         "ItemName",
                                         "ItemValue",
                                         value != null ? value.ToString() : "",
                                         null,
                                         null,
                                         optionLabel,
                                         htmlAttributes,
                                         filterMode: filterMode);
        }
        #endregion

        #region 样衣归还入库单选择样衣出库单

        public static MvcHtmlString Inman_SelectSampleProductStockOutForSampleProductBackOrder<TModel, TProperty>
            (this HtmlHelper<TModel> htmlHelper,
             Expression<Func<TModel, TProperty>> expression,
             string dataTextField = "DocNum",
             string dataValueField = "Id",
             string selectedText = null,
             string optionLabel = " ",
             string selectEvent = null,
             string clearEvent = null,
             bool disable = false,
             int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, SampleProductBackModel>(htmlHelper,
                                                                                         expression,
                                                                                         "/Selector/SampleProductStockOutForSampleProductBackOrder",
                                                                                         c =>
                                                                                         {
                                                                                             c.Bound(f => f.DocNum).Width(150).Title("出库单号");
                                                                                             c.Bound(f => f.DocDate).Width(100).Title("出库时间");
                                                                                         },
                                                                                         dataTextField: dataTextField,
                                                                                         dataValueField: dataValueField,
                                                                                         selectedText: selectedText,
                                                                                         optionLabel: optionLabel,
                                                                                         selectEvent: selectEvent,
                                                                                         clearEvent: clearEvent,
                                                                                         disable: disable,
                                                                                         gridWidth: gridWidth
                );
        }

        #endregion

        #region 选择系列

        /// <summary>
        /// 系列选择器
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="htmlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectSerieFor<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "SeriesName", string dataValueField = "Id", string perssmissionCode = null,
            string optionLabel = " ", object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {


                var dropDownBuilder = htmlHelper.Kendo().DropDownListFor(expression)
                                                .DataSource(
                                                    ds =>
                                                    ds.Read(r => r.Url("/Selector/SeriesAll"))
                                                      .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .AutoBind(true);

                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;
        }

        /// <summary>
        /// 系列选择器
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <param name="cascadeFrom">联动关联的控件名称,区分大小写</param>
        /// <param name="dataTextField">显示文本字段的名称,默认为"Name"</param>
        /// <param name="dataValueField">值字段的名称,默认为"Name"</param>
        /// <param name="selectedValue"></param>
        /// <param name="perssmissionCode"></param>
        /// <param name="optionLabel"></param>
        /// <param name="htmlAttributes"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectSerie(this HtmlHelper htmlHelper, string name,
                                                                  string dataTextField = "SeriesName",
                                                                  string dataValueField = "Id",
                                                                  string selectedValue = null,
                                                                  string perssmissionCode = null,
                                                                  string optionLabel = " ",
                                                                  object htmlAttributes = null)
        {
            if (string.IsNullOrEmpty(perssmissionCode) || GetPerssmissionSrv().AuthorizeInLoginAccount(perssmissionCode))
            {


                var dropDownBuilder = htmlHelper.Kendo().DropDownList().Name(name)
                                                .DataSource(
                                                    t =>
                                                    t.Read(r => r.Url("/Selector/SeriesAll"))
                                                     .ServerFiltering(true))
                                                .DataTextField(dataTextField).DataValueField(dataValueField)
                                                .AutoBind(true);

                if (!string.IsNullOrEmpty(selectedValue))
                    dropDownBuilder = dropDownBuilder.Value(selectedValue);
                if (optionLabel != null)
                    dropDownBuilder = dropDownBuilder.OptionLabel(optionLabel);
                if (htmlAttributes != null)
                    dropDownBuilder = dropDownBuilder.HtmlAttributes(htmlAttributes);

                return dropDownBuilder;
            }
            return null;

        }

        #endregion

        #region 对单验布报告选择对单预约入库单

        public static MvcHtmlString Inman_SelectProductMaterialAdvanceForProductMaterialPerching<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductMaterialAdvanceModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/ProductMaterialAdvanceForProductMaterialPerching",
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(150)
                                                                                           .Title("入库单号");
                                                                                          c.Bound(f => f.DocUser)
                                                                                           .Width(100)
                                                                                           .Title("预约人");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 非对单验布报告选择对单预约入库单

        public static MvcHtmlString Inman_SelectCommonMaterialAdvanceForCommonMaterialPerching<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialAdvanceModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/CommonMaterialAdvanceForCommonMaterialPerching",
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(150)
                                                                                           .Title("入库单号");
                                                                                          c.Bound(f => f.DocUser)
                                                                                           .Width(100)
                                                                                           .Title("预约人");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 物料二次加工验布报告选择对单预约入库单

        public static MvcHtmlString Inman_SelectSecOptMaterialAdvanceForSecOptMaterialPerching<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialAdvanceModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/SecOptMaterialAdvanceForSecOptMaterialPerching",
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum)
                                                                                           .Width(150)
                                                                                           .Title("入库单号");
                                                                                          c.Bound(f => f.DocUser)
                                                                                           .Width(100)
                                                                                           .Title("预约人");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 模特办移交单选择BOM物料清单

        public static MvcHtmlString Inman_SelectMaterialBOMForModelTransferOrder(this HtmlHelper htmlHelper, string name,
                                                                                string brand = null,
                                                                                string dataTextField = "DesignProductSN",
                                                                                string dataValueField = "Id",
                                                                                string selectedValue = null,
                                                                                string selectedText = null,
                                                                                string perssmissionCode = null,
                                                                                string optionLabel = " ",
                                                                                int gridPageSize = 8,
                                                                                int? gridWidth = null,
                                                                                int? gridHeight = null,
                                                                                string changeEvent = null,
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false)
        {
            string section1 = string.IsNullOrEmpty(brand) ? "" : brand;
            return Inman_DropDownGrid<MaterialBOMModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/MaterialBOMForModelTransferOrder?1=1" + section1),
                                                                    c =>
                                                                    {
                                                                        c.Bound(f => f.Collection).Width(150).Title("系列");
                                                                        c.Bound(f => f.WaveSession).Width(80).Title("波段");
                                                                        c.Bound(f => f.UpnewDate).Width(150).Title("上新日期");
                                                                        c.Bound(f => f.DesignProductSN).Width(150).Title("设计款号");
                                                                        c.Bound(f => f.ColorName).Width(80).Title("颜色");
                                                                        c.Bound(f => f.DevYear).Width(80).Title("年份");
                                                                        c.Bound(f => f.DesignSeason).Width(80).Title("季节");
                                                                        c.Bound(f => f.ItemCategory3).Width(150).Title("三级分类");
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        #endregion

        #region 唯品会配货计划选择大货款号

        public static MvcHtmlString Inman_SelectProductForVIPDistributionPlan(this HtmlHelper htmlHelper, string name,
                                                                                string dataTextField = "ProductSN",
                                                                                string dataValueField = "Id",
                                                                                string selectedValue = null,
                                                                                string selectedText = null,
                                                                                string perssmissionCode = null,
                                                                                string optionLabel = " ",
                                                                                int gridPageSize = 8,
                                                                                int? gridWidth = null,
                                                                                int? gridHeight = null,
                                                                                string changeEvent = null,
                                                                                string selectEvent = null,
                                                                                string clearEvent = null,
                                                                                bool disable = false)
        {
            return Inman_DropDownGrid<DistinctProductForVIPModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/ProductForVIPDistributionPlan"),
                                                                    c =>
                                                                    {
                                                                        c.Bound(f => f.ProductSN).Width(150).Title("大货款号");
                                                                        c.Bound(f => f.Brand).Width(80).Title("品牌");
                                                                        c.Bound(f => f.ProductYear).Width(80).Title("年份");
                                                                        c.Bound(f => f.Season).Width(80).Title("季节");
                                                                        c.Bound(f => f.FirstOnsaleShelveDate).Width(150).Title("上架日期");
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        #endregion

        #region 获取动态报表数据库
        public static DropDownListBuilder Inman_SelectReportManagementDatabase(this HtmlHelper htmlHelper, string name,
                                                         string dataTextField = "Name",
                                                         string dataValueField = "Id",
                                                         string selectedValue = null,
                                                         string selectedText = null,
                                                         int gridPageSize = 8,
                                                         string perssmissionCode = null,
                                                         string optionLabel = " ",
                                                         object htmlAttributes = null,
                                                         string changeEvent = null,
                                                         string selectEvent = null,
                                                         string clearEvent = null,
                                                         bool disable = false)
        {

            return Inman_DropDownList(htmlHelper, name,
                                                     string.Format("/Selector/ReportManagementDatabase"),
                                                     dataTextField: dataTextField,
                                                     dataValueField: dataValueField,
                                                     selectedText: selectedText,
                                                     selectedValue: selectedValue,
                                                     optionLabel: optionLabel,
                                                     perssmissionCode: perssmissionCode);

        }

        public static DropDownListBuilder Inman_SelectReportManagementDatabaseFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               string dataTextField = "DatabaseName",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               int gridPageSize = 8,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               object htmlAttributes = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               bool disable = false)
        {


            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectReportManagementDatabase(htmlHelper,
                                        name,
                                        dataTextField: dataTextField,
                                        dataValueField: dataValueField,
                                        selectedValue: value,
                                        selectedText: selectedText,
                                        gridPageSize: gridPageSize,
                                        perssmissionCode: perssmissionCode,
                                        optionLabel: optionLabel,
                                        htmlAttributes: htmlAttributes,
                                        changeEvent: changeEvent,
                                        selectEvent: selectEvent,
                                        clearEvent: clearEvent,
                                        disable: disable);
        }

        #endregion

        #region 款式元素企划选择商品分类

        public static MvcHtmlString Inman_SelectProductCategoryForPlanWallProductElement<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "Name",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            return Inman_DropDownGridFor<TModel, TProperty, ProductCategoryModel>(htmlHelper,
                                                                                       expression,
                                                                                       "/Selector/ProductCategoryForPlanWallProductElement",
                                                                                       c =>
                                                                                       {
                                                                                           c.Bound(f => f.Name).Width(200).Title("分类");
                                                                                           c.Bound(f => f.Type).Width(200).Title("类型");
                                                                                       },
                                                                                       dataTextField: dataTextField,
                                                                                       dataValueField: dataValueField,
                                                                                       selectedText: selectedText,
                                                                                       optionLabel: optionLabel,
                                                                                       selectEvent: selectEvent,
                                                                                       clearEvent: clearEvent,
                                                                                       disable: disable,
                                                                                       gridWidth: gridWidth
                );
        }

        #endregion

        #region 非对单退供应商出库单选择非对单预约入库单

        public static MvcHtmlString Inman_SelectCommonMaterialAdvanceForCommonMaterialReturn<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? purchaseOrderId = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (purchaseOrderId == null || purchaseOrderId == 0 ? "" : "&purchaseOrderId=" + purchaseOrderId.Value);
            return Inman_DropDownGridFor<TModel, TProperty, CommonMaterialAdvanceModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/CommonMaterialAdvanceForCommonMaterialReturn?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.DocNum).Width(100).Title("预约单号");
                                                                                                  c.Bound(f => f.PurchaseOrderNum).Width(100).Title("采购单");
                                                                                                  c.Bound(f => f.DocDate).Width(100).Title("预约入库日期");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 对单退供应商出库单选择对单预约入库单

        public static MvcHtmlString Inman_SelectProductMaterialAdvanceForProductMaterialReturn<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? purchaseOrderId = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (purchaseOrderId == null || purchaseOrderId == 0 ? "" : "&purchaseOrderId=" + purchaseOrderId.Value);
            return Inman_DropDownGridFor<TModel, TProperty, ProductMaterialAdvanceModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/ProductMaterialAdvanceForProductMaterialReturn?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.DocNum).Width(100).Title("预约单号");
                                                                                                  c.Bound(f => f.PurchaseOrderNum).Width(100).Title("采购单");
                                                                                                  c.Bound(f => f.DocDate).Width(100).Title("预约入库日期");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 用户角色申请

        public static MvcHtmlString Inman_SelectCustomerRoleApply(this HtmlHelper htmlHelper, string name,
                                                                         string dataTextField = "name",
                                                                         string dataValueField = "Id",
                                                                         string selectedValue = null,
                                                                         string selectedText = null,
                                                                         string perssmissionCode = null,
                                                                         string optionLabel = " ",
                                                                         int gridPageSize = 8,
                                                                         int? gridWidth = null,
                                                                         int? gridHeight = null,
                                                                         string changeEvent = null,
                                                                         string selectEvent = null,
                                                                         string clearEvent = null,
                                                                         bool disable = false,
                                                                         SelectCustomerRoleApplyBussiness bussiness = SelectCustomerRoleApplyBussiness.Default)
        {
            return Inman_DropDownGrid<BaseRoleModel>(htmlHelper, name,
                                                                     string.Format(
                                                                         "/Selector/CustomerRoleApply?bussiness={0}", bussiness),
                                                                     c =>
                                                                     {
                                                                         c.Bound(f => f.name).Width(100).Title("角色");
                                                                     },
                                                                     dataTextField,
                                                                     dataValueField,
                                                                     selectedText: selectedText,
                                                                     selectedValue: selectedValue,
                                                                     optionLabel: optionLabel,
                                                                     gridPageSize: gridPageSize,
                                                                     gridWidth: gridWidth,
                                                                     gridHeight: gridHeight,
                                                                     changeEvent: changeEvent,
                                                                     selectEvent: selectEvent,
                                                                     clearEvent: clearEvent,
                                                                     disable: disable
                );
        }

        #endregion

        #region 选择所有账套

        public static DropDownListBuilder Inman_SelectAllAcounts(this HtmlHelper htmlHelper, string name,
                                                         string dataTextField = "name",
                                                         string dataValueField = "Id",
                                                         string selectedValue = null,
                                                         string selectedText = null,
                                                         int gridPageSize = 8,
                                                         string perssmissionCode = null,
                                                         string optionLabel = " ",
                                                         object htmlAttributes = null,
                                                         string changeEvent = null,
                                                         string selectEvent = null,
                                                         string clearEvent = null,
                                                         bool disable = false)
        {

            return Inman_DropDownList(htmlHelper, name, string.Format("/Selector/Accounts"),
                                        dataTextField: dataTextField,
                                        dataValueField: dataValueField,
                                        selectedValue: selectedValue,
                                        selectedText: selectedText,
                                        optionLabel: optionLabel
                                       );

        }

        public static DropDownListBuilder Inman_SelectAllAcountsFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               string dataTextField = "name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               int gridPageSize = 8,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               object htmlAttributes = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               bool disable = false)
        {


            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectAllAcounts(htmlHelper,
                                        name,
                                        dataTextField: dataTextField,
                                        dataValueField: dataValueField,
                                        selectedValue: value,
                                        selectedText: selectedText,
                                        gridPageSize: gridPageSize,
                                        perssmissionCode: perssmissionCode,
                                        optionLabel: optionLabel,
                                        htmlAttributes: htmlAttributes,
                                        changeEvent: changeEvent,
                                        selectEvent: selectEvent,
                                        clearEvent: clearEvent,
                                        disable: disable);
        }

        #endregion

        #region 选择已登陆并且有操作权限的账套

        public static DropDownListBuilder Inman_SelectLoginedAcountsWithPermission(this HtmlHelper htmlHelper, string name,
            string permissionCode,
                                                         string dataTextField = "name",
                                                         string dataValueField = "Id",
                                                         string selectedValue = null,
                                                         string selectedText = null,
                                                         int gridPageSize = 8,
                                                         string perssmissionCode = null,
                                                         string optionLabel = " ",
                                                         object htmlAttributes = null,
                                                         string changeEvent = null,
                                                         string selectEvent = null,
                                                         string clearEvent = null,
                                                         bool disable = false)
        {

            return Inman_DropDownList(htmlHelper, name, string.Format("/Selector/LoginedAccounts?permissionCode={0}", permissionCode),
                                       dataTextField: dataTextField,
                                       dataValueField: dataValueField,
                                       selectedValue: selectedValue,
                                       selectedText: selectedText,
                                       optionLabel: optionLabel
                                      );
        }

        public static DropDownListBuilder Inman_SelectLoginedAcountsWithPermissionFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>
                                                                                   expression,
                                                                               string permissionCode,
                                                                               string dataTextField = "name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               int gridPageSize = 8,
                                                                               string perssmissionCode = null,
                                                                               string optionLabel = " ",
                                                                               object htmlAttributes = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               bool disable = false)
        {


            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();

            return Inman_SelectLoginedAcountsWithPermission(htmlHelper,
                                        name,
                                        permissionCode,
                                        dataTextField: dataTextField,
                                        dataValueField: dataValueField,
                                        selectedValue: value,
                                        selectedText: selectedText,
                                        gridPageSize: gridPageSize,
                                        perssmissionCode: perssmissionCode,
                                        optionLabel: optionLabel,
                                        htmlAttributes: htmlAttributes,
                                        changeEvent: changeEvent,
                                        selectEvent: selectEvent,
                                        clearEvent: clearEvent,
                                        disable: disable);
        }

        #endregion


        #region 切换操作账套
        /// <summary>
        /// 切换操作账套
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="permissionCode"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_OperateAccounts(this HtmlHelper htmlHelper, string permissionCode)
        {

            var _iPermissionService = EngineContext.Current.Resolve<IPermissionService>();
            var _workContext = EngineContext.Current.Resolve<IWorkContext>();
            var _iBaseAccountSrv = EngineContext.Current.Resolve<IBaseAccountService>();

            var loginedAccountId = _iPermissionService.GetListAccountId(permissionCode, _workContext.CurrentCustomer.Id);


            var accounts =
                _iBaseAccountSrv.GetListDataInAllAccount<BaseAccountModel>(t => loginedAccountId.Contains(t.Id) && t.Deleted == false).Take(160);
            string optionLabel = "选择操作账套";
            if (accounts.Count() == 1)
                optionLabel = null;
            return Inman_DropDownList(htmlHelper, "ddl_write_account", accounts, dataTextField: "name",
                dataValueField: "Id", optionLabel: optionLabel);

        }

        #endregion

        #region 选择已登陆账套
        /// <summary>
        /// 切换操作账套
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="permissionCode"></param>
        /// <returns></returns>
        public static DropDownListBuilder Inman_SelectLoginedAccounts(this HtmlHelper htmlHelper,
            string name,
            string dataTextField = "name", string dataValueField = "Id", string optionLabel = "选择账套",
            string selectedValue = null, string selectedText = null)
        {


            var _workContext = EngineContext.Current.Resolve<IWorkContext>();
            var _iBaseAccountSrv = EngineContext.Current.Resolve<IBaseAccountService>();

            var loginedAccountId = _workContext.GetAccounts();


            var accounts =
                _iBaseAccountSrv.GetListDataInAllAccount<BaseAccountModel>(
                    t => loginedAccountId.Contains(t.Id) && t.Deleted == false).Take(160);

            //if (accounts.Count() == 1)
            //    optionLabel = null;
            return Inman_DropDownList(htmlHelper, name, accounts, dataTextField: dataTextField,
                dataValueField: dataValueField, optionLabel: optionLabel, selectedValue: selectedValue, selectedText: selectedText);

        }

        #endregion

        #region 选择能登陆的账套
        public static DropDownListBuilder Inman_SelectCanLoginAccounts(this HtmlHelper htmlHelper,
            string name,
            string dataTextField = "name", string dataValueField = "Id", string optionLabel = "选择账套",
            string selectedValue = null, string selectedText = null)
        {
            var _iPermissionService = EngineContext.Current.Resolve<IPermissionService>();
            var _iBaseAccountSrv = EngineContext.Current.Resolve<IBaseAccountService>();


            var canLoginAccountIds = _iPermissionService.GetAccountIdsByPermissionCode(StandardPermissionProvider.CustomerLogin);
            var accounts = _iBaseAccountSrv.GetListDataInAllAccount<BaseAccountModel>(t => canLoginAccountIds.Contains(t.Id)).OrderBy(t => t.SortCode);

            return Inman_DropDownList(htmlHelper, name, accounts, dataTextField: dataTextField,
                dataValueField: dataValueField, optionLabel: optionLabel, selectedValue: selectedValue, selectedText: selectedText).Height(450);


        }

        #endregion

        #region 正品退厂单选择采购单

        public static MvcHtmlString Inman_SelectProductPurchaseOrderForProductGenuineReturnFactory<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? supplierId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (supplierId == null || supplierId == 0
                                   ? ""
                                   : "&supplierId=" + supplierId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, ProductPurchaseOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/ProductPurchaseOrderForProductGenuineReturnFactory?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum).Width(150).Title("采购单号");
                                                                                          c.Bound(f => f.Merchandiser).Width(150).Title("跟单员");
                                                                                          c.Bound(f => f.DocMode).Width(150).Title("单据类型");
                                                                                          c.Bound(f => f.SupplierName).Width(150).Title("供应商");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 对单采购单选择战略备料单

        public static MvcHtmlString Inman_SelectStockItemStrategyForProductMaterialPurchaseOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? supplierid = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (supplierid == null || supplierid == 0 ? "" : "&supplierid=" + supplierid.Value);
            return Inman_DropDownGridFor<TModel, TProperty, StockItemStrategyModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/StockItemStrategyForProductMaterialPurchaseOrder?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.DocNum).Width(100).Title("战略备料单");
                                                                                                  c.Bound(f => f.Year).Width(100).Title("年份");
                                                                                                  c.Bound(f => f.Season).Width(100).Title("季节");
                                                                                                  c.Bound(f => f.Brand).Width(100).Title("品牌");
                                                                                                  c.Bound(f => f.SupplierName).Width(100).Title("供应商");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 非对单采购单选择战略备料单

        public static MvcHtmlString Inman_SelectStockItemStrategyForCommonMaterialPurchaseOrder<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? supplierid = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (supplierid == null || supplierid == 0 ? "" : "&supplierid=" + supplierid.Value);
            return Inman_DropDownGridFor<TModel, TProperty, StockItemStrategyModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/StockItemStrategyForCommonMaterialPurchaseOrder?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.DocNum).Width(100).Title("战略备料单");
                                                                                                  c.Bound(f => f.Year).Width(100).Title("年份");
                                                                                                  c.Bound(f => f.Season).Width(100).Title("季节");
                                                                                                  c.Bound(f => f.Brand).Width(100).Title("品牌");
                                                                                                  c.Bound(f => f.SupplierName).Width(100).Title("供应商");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 非对单退供应商出库单选择非对单预约入库单

        public static MvcHtmlString Inman_SelectSecOptMaterialAdvanceForSecOptMaterialReturn<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? purchaseOrderId = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = null,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (purchaseOrderId == null || purchaseOrderId == 0 ? "" : "&OrderId=" + purchaseOrderId.Value);
            return Inman_DropDownGridFor<TModel, TProperty, SecOptMaterialAdvanceModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/SecOptMaterialAdvanceForSecOptMaterialReturn?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.DocNum).Width(100).Title("预约单号");
                                                                                                  c.Bound(f => f.SecOptMaterialOrderNum).Width(100).Title("加工单");
                                                                                                  c.Bound(f => f.RangeDate).Width(100).Title("预约入库日期");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 开发款式报价单选择样衣开发记录

        public static MvcHtmlString Inman_SelectSampleDev(this HtmlHelper htmlHelper, string name,
                                                                        string brand,
                                                                        int? supplierId = null,
                                                                        string dataTextField = "DesignProductSN",
                                                                        string dataValueField = "Id",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        int gridPageSize = 8,
                                                                        int? gridWidth = null,
                                                                        int? gridHeight = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false)
        {
            string section1 = (string.IsNullOrEmpty(brand) ? "" : "&brand=" + brand);
            string section2 = (supplierId == null || supplierId == 0 ? "" : "&supplierId=" + supplierId.Value);
            return Inman_DropDownGrid<SampleDevModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/SampleDevForDevelopStyleQuotation?1=1" + section1 + section2),
                                                                    c =>
                                                                    {
                                                                        c.Bound(t => t.DesignProductSN).Width(100).Title("设计款号");
                                                                        c.Bound(t => t.Brand).Title("品牌");
                                                                        c.Bound(t => t.SupplierName).Width(120).Title("供应商");
                                                                        c.Bound(t => t.ProductCategoryName2).Title("二级分类");
                                                                        c.Bound(t => t.ProductCategoryName3).Title("三级分类");
                                                                        c.Bound(t => t.SampleType).Title("样板类别");
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        #endregion

        #region 大货款式报价单选择大货制单号

        public static MvcHtmlString Inman_SelectProduceOrderForProduceStyleQuotation(this HtmlHelper htmlHelper, string name,
                                                                        string brand,
                                                                        int? supplierId = null,
                                                                        string dataTextField = "DocNum",
                                                                        string dataValueField = "Id",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        int gridPageSize = 8,
                                                                        int? gridWidth = null,
                                                                        int? gridHeight = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false)
        {
            string section1 = (string.IsNullOrEmpty(brand) ? "" : "&brand=" + brand);
            string section2 = (supplierId == null || supplierId == 0 ? "" : "&supplierId=" + supplierId.Value);
            return Inman_DropDownGrid<ProduceOrderModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/ProduceOrderForProduceStyleQuotation?1=1" + section1 + section2),
                                                                    c =>
                                                                    {
                                                                        c.Bound(t => t.DocNum).Width(100).Title("制单号");
                                                                        c.Bound(t => t.ProductSN).Width(100).Title("大货款号");
                                                                        c.Bound(t => t.Color).Width(100).Title("颜色");
                                                                        c.Bound(t => t.DesignProductSN).Width(100).Title("设计款号");
                                                                        c.Bound(t => t.DevelopPrice).Width(100).Title("开发报价").Sortable(false).Filterable(false);
                                                                        c.Bound(t => t.Brand).Title("品牌");
                                                                        c.Bound(t => t.CateName2).Title("二级分类");
                                                                        c.Bound(t => t.CateName3).Title("三级分类");
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        #endregion

        #region 商品返单选择大货制单号

        public static MvcHtmlString Inman_SelectProduceOrderForReturnGoods(this HtmlHelper htmlHelper, string name,
                                                                        string brand = null,
                                                                        string dataTextField = "ProductSN",
                                                                        string dataValueField = "ProduceOrderID",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        int gridPageSize = 8,
                                                                        int? gridWidth = null,
                                                                        int? gridHeight = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false)
        {
            string section1 = string.IsNullOrEmpty(brand) ? "" :( "&brand="+brand);
            return Inman_DropDownGrid<ReturnGoodsSelectProduceScheduleModel>(htmlHelper, name,
                                                                    string.Format(
                                                                        "/Selector/ProduceOrderForReturnGoods?1=1"+ section1),
                                                                    c =>
                                                                    {
                                                                        c.Bound(t => t.ProduceOrderNum).Width(100).Title("制单号");
                                                                        c.Bound(t => t.ProductSN).Width(100).Title("款号");
                                                                        c.Bound(t => t.ColorName).Width(100).Title("颜色");
                                                                        c.Bound(t => t.FactoryName).Width(100).Title("成衣加工厂");
                                                                    },
                                                                    dataTextField,
                                                                    dataValueField,
                                                                    selectedText: selectedText,
                                                                    selectedValue: selectedValue,
                                                                    optionLabel: optionLabel,
                                                                    gridPageSize: gridPageSize,
                                                                    gridWidth: gridWidth,
                                                                    gridHeight: gridHeight,
                                                                    changeEvent: changeEvent,
                                                                    selectEvent: selectEvent,
                                                                    clearEvent: clearEvent,
                                                                    disable: disable
                );
        }

        #endregion


        #region 外部用户选择供应商,设计师

        public static MvcHtmlString Inman_SelectSupplierForOutsourceUser<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? OutsourceType = null,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string perssmissionCode = null,
            string optionLabel = " ",
            int gridPageSize = 5,
            int? gridWidth = 500,
            int? gridHeight = 500,
            string changeEvent = null,
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false
            )
        {
            string section1 = (OutsourceType == null || OutsourceType == 0 ? "" : "&OutsourceType=" + OutsourceType.Value);
            return Inman_DropDownGridFor<TModel, TProperty, SupplierModel>(htmlHelper,
                                                                                              expression,
                                                                                              string.Format(
                                                                                                  "/Selector/SelectSupplierForOutsourceUser?1=1" + section1),
                                                                                              c =>
                                                                                              {
                                                                                                  c.Bound(f => f.Name).Width(100).Title("名字");
                                                                                              },
                                                                                              dataTextField,
                                                                                              dataValueField,
                                                                                              selectedText: selectedText,
                                                                                              optionLabel: optionLabel,
                                                                                              gridPageSize: gridPageSize,
                                                                                              gridWidth: gridWidth,
                                                                                              gridHeight: gridHeight,
                                                                                              changeEvent: changeEvent,
                                                                                              selectEvent: selectEvent,
                                                                                              clearEvent: clearEvent,
                                                                                              disable: disable
                );
        }

        #endregion

        #region 通用产品选择器

        #region 选择通用产品采购单
        public static MvcHtmlString Inman_SelectGenProductPurchaseOrderFor<TModel, TProperty>(
          this HtmlHelper<TModel> htmlHelper,
          Expression<Func<TModel, TProperty>> expression,
          string dataTextField = "DocNum",
          string dataValueField = "Id",
          string selectedText = null,
          int? gridWidth = 600,
          string perssmissionCode = null,
          string optionLabel = " ",
          object htmlAttributes = null,
          string changeEvent = null,
          string selectEvent = null,
          string clearEvent = null,
          bool disable = false,
          SelectGenProductPurchaseOrderBussiness bussiness = SelectGenProductPurchaseOrderBussiness.Default)
        {
            string name = ExpressionHelper.GetExpressionText(expression);
            ModelMetadata modelMetadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            string value = (modelMetadata.Model ?? "").ToString();
            return Inman_SelectGenProductPurchaseOrderFor(
                htmlHelper,
                name,
                dataTextField: dataTextField,
                dataValueField: dataValueField,
                selectedValue: value,
                selectedText: selectedText,
                gridWidth: gridWidth,
                perssmissionCode: perssmissionCode,
                optionLabel: optionLabel,
                htmlAttributes: htmlAttributes,
                changeEvent: changeEvent,
                selectEvent: selectEvent,
                clearEvent: clearEvent,
                disable: disable,
                bussiness: bussiness);
        }

        public static MvcHtmlString Inman_SelectGenProductPurchaseOrderFor(this HtmlHelper htmlHelper, string name,
                                                                        string dataTextField = "DocNum",
                                                                        string dataValueField = "Id",
                                                                        string selectedValue = null,
                                                                        string selectedText = null,
                                                                        int? gridWidth = 600,
                                                                        string perssmissionCode = null,
                                                                        string optionLabel = " ",
                                                                        object htmlAttributes = null,
                                                                        string changeEvent = null,
                                                                        string selectEvent = null,
                                                                        string clearEvent = null,
                                                                        bool disable = false,
                                                                        SelectGenProductPurchaseOrderBussiness bussiness =
                                                                            SelectGenProductPurchaseOrderBussiness.Default)
        {
            return Inman_DropDownGrid<GenProductPurchaseOrderModel>(htmlHelper,
                                                                 name,
                                                                 string.Format(
                                                                     "/Selector/GenProductPurchaseOrder?bussiness={0}",
                                                                     bussiness),
                                                                 c =>
                                                                 {
                                                                     /***  请不要再这里删除列，如果必须要用单列，请考虑用用kendo原生DropDownList扩展 ***/
                                                                     c.Bound(f => f.DocNum);
                                                                     c.Bound(f => f.DocDate);
                                                                     c.Bound(f => f.Merchandiser);
                                                                 },
                                                                 dataTextField: dataTextField,
                                                                 dataValueField: dataValueField,
                                                                 selectedText: selectedText,
                                                                 selectedValue: selectedValue,
                                                                 optionLabel: optionLabel,
                                                                 perssmissionCode: perssmissionCode,
                                                                 gridWidth: gridWidth,
                                                                 changeEvent: changeEvent,
                                                                 selectEvent: selectEvent,
                                                                 clearEvent: clearEvent,
                                                                 disable: disable);
        }

      
        #endregion

        #region

        #region 选择通用采购单 
        /// <summary>
        /// 选择通用采购单
        /// </summary>
        public static MvcHtmlString Inman_SelectGenPurchaseOrderFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
                                                                               Expression<Func<TModel, TProperty>>expression,
                                                                               string dataTextField = "Name",
                                                                               string dataValueField = "Id",
                                                                               string selectedText = null,
                                                                               string optionLabel = " ",
                                                                               int gridPageSize = 10,
                                                                               int? gridWidth = null,
                                                                               int? gridHeight = null,
                                                                               string changeEvent = null,
                                                                               string selectEvent = null,
                                                                               string clearEvent = null,
                                                                               string perssmissionCode = null,
                                                                               bool disable = false,
                                                                               int supplierId = 0 ,
                                                                               SelectGenProductPurchaseOrderBussiness bussiness = SelectGenProductPurchaseOrderBussiness.GenProductStockIn
        )
        {
            var queryString = "?supplierId=" + supplierId.ToString() + "&bussiness=" + bussiness;
            return Inman_DropDownGridFor<TModel, TProperty, GenProductPurchaseOrderModel>(htmlHelper,
                                                                           expression,
                                                                           "/Selector/GenProductPurchaseOrder" + queryString, //读取采购单
                                                                           c =>
                                                                           {
                                                                               c.Bound(f => f.DocNum).Width(100);
                                                                               c.Bound(f => f.DocDate).Width(100);
                                                                               c.Bound(f => f.Merchandiser).Width(100);
                                                                               //c.Bound(f => f.Groups).Width(100);
                                                                           },
                                                                           dataTextField: dataTextField,
                                                                           dataValueField: dataValueField,
                                                                           selectedText: selectedText,
                                                                           optionLabel: optionLabel,
                                                                           gridPageSize: gridPageSize,
                                                                           gridWidth: gridWidth,
                                                                           gridHeight: gridHeight,
                                                                           changeEvent: changeEvent,
                                                                           selectEvent: selectEvent,
                                                                           clearEvent: clearEvent,
                                                                           perssmissionCode: perssmissionCode,
                                                                           disable: disable
                );
        }
        #endregion

        #endregion

        #region 通用产品采购单 大货款号选择
        public static MvcHtmlString Inman_SelectProduceOrderForGenPurchaseOrder(this HtmlHelper htmlHelper, string name,
                                                                             string  brand, int? purchaseOrderId, string docMode,
                                                                             int? gridWidth = null)
        {
            string section1 = purchaseOrderId == null || purchaseOrderId == 0 ? "": "&purchaseOrderId=" + purchaseOrderId.Value;
            string section2 = string.IsNullOrEmpty(brand) ? "" : "&brand=" + HttpUtility.UrlEncode(brand);
            string section3 = string.IsNullOrEmpty(docMode) ? "": "&produceMode=" + docMode;
            //return
            return Inman_DropDownGrid<ProduceOrder4GenProductPurchaseOrderModel>(htmlHelper, name,
                                                             "/Selector/ProduceOrderForGenPurchaseOrder?" + section1 +
                                                             section2 + section3, 
                                                             c =>
                                                             {
                                                                 c.Bound(f => f.ProductSN).Width(120);
                                                                 c.Bound(f => f.ProduceOrderNum).Width(120);
                                                                 c.Bound(f => f.Brand).Width(100);//add brand 
                                                                 c.Bound(f => f.Color).Width(100);
                                                                 c.Bound(f => f.ConfirmTotalAmount).Width(100);
                                                                 c.Bound(f => f.SizeTotal).Width(100);
                                                                 c.Bound(f => f.ArrivalScheduleDate).Width(100);
                                                             },
                                                             dataTextField: "ProduceOrderNum",
                                                             dataValueField: "ProduceOrderId",
                                                             gridWidth: gridWidth);
        }

        #endregion

        #endregion 

        #region 通用产品退厂单选择通用采购单

        public static MvcHtmlString Inman_SelectProductPurchaseOrderForGenProductGenuineReturnFactory<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? supplierId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (supplierId == null || supplierId == 0
                                   ? ""
                                   : "&supplierId=" + supplierId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, GenProductPurchaseOrderModel>(htmlHelper,
                                                                                      expression,
                                                                                      "/Selector/ProductPurchaseOrderForGenProductGenuineReturnFactory?1=1" +
                                                                                      section1,
                                                                                      c =>
                                                                                      {
                                                                                          c.Bound(f => f.DocNum).Width(150).Title("采购单号");
                                                                                          c.Bound(f => f.Merchandiser).Width(150).Title("跟单员");
                                                                                          c.Bound(f => f.DocMode).Width(150).Title("单据类型");
                                                                                          c.Bound(f => f.SupplierName).Width(150).Title("供应商");
                                                                                      },
                                                                                      dataTextField: dataTextField,
                                                                                      dataValueField: dataValueField,
                                                                                      selectedText: selectedText,
                                                                                      optionLabel: optionLabel,
                                                                                      selectEvent: selectEvent,
                                                                                      clearEvent: clearEvent,
                                                                                      disable: disable,
                                                                                      gridWidth: gridWidth
                );
        }

        #endregion

        #region 通用产品预付款申请单选择通用采购单

        public static MvcHtmlString Inman_SelectProductPurchaseOrderForGenProductAdvancePayment<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            int? suppliersId,
            string dataTextField = "DocNum",
            string dataValueField = "Id",
            string selectedText = null,
            string optionLabel = " ",
            string selectEvent = null,
            string clearEvent = null,
            bool disable = false,
            int? gridWidth = null)
        {
            string section1 = (suppliersId == null || suppliersId == 0
                                   ? ""
                                   : "&suppliersId=" + suppliersId.Value);

            return Inman_DropDownGridFor<TModel, TProperty, GenProductPurchaseOrderModel>(htmlHelper,
                                                                                             expression,
                                                                                             "/Selector/ProductPurchaseOrderForGenProductAdvancePayment?1=1" +
                                                                                             section1,
                                                                                             c =>
                                                                                             {
                                                                                                 c.Bound(
                                                                                                     f => f.DocNum)
                                                                                                  .Width(250)
                                                                                                  .Title("单据编号");
                                                                                                 c.Bound(
                                                                                                     f => f.DocDate)
                                                                                                  .Width(150)
                                                                                                  .Title("下单日期");
                                                                                                 c.Bound(
                                                                                                     f =>
                                                                                                     f.Merchandiser)
                                                                                                  .Width(150)
                                                                                                  .Title("跟单员");
                                                                                             },
                                                                                             dataTextField:
                                                                                                 dataTextField,
                                                                                             dataValueField:
                                                                                                 dataValueField,
                                                                                             selectedText: selectedText,
                                                                                             optionLabel: optionLabel,
                                                                                             selectEvent: selectEvent,
                                                                                             clearEvent: clearEvent,
                                                                                             disable: disable,
                                                                                             gridWidth: gridWidth
                );
        }

        #endregion

        #region 通用产品入库单
        public static DropDownListBuilder Inman_SelectGenStockIn(this HtmlHelper htmlHelper,
                                                                string name,
                                                                string dataTextField = "Name",
                                                                string dataValueField = "Id",
                                                                string selectedValue = null,
                                                                string selectedText = null,
                                                                string optionLabel = " ",
                                                                string perssmissionCode = null,
                                                                SelectGenStockInBussiness bussiness =
                                                                    SelectGenStockInBussiness.Default
            )
        {
            return Inman_DropDownList(htmlHelper, name, string.Format("/Selector/GenProductStockIn?bussiness={0}", bussiness),
                                      dataTextField: dataTextField,
                                      dataValueField: dataValueField,
                                      selectedValue: selectedValue,
                                      selectedText: selectedText,
                                      optionLabel: optionLabel,
                                      perssmissionCode: perssmissionCode
                );
        }

        public static DropDownListBuilder Inman_SelectGenStockIn<TModel, TProperty>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TProperty>> expression,
            string dataTextField = "Name",
            string dataValueField = "Id",
            string selectedValue = null,
            string selectedText = null,
            string optionLabel = " ",
            string perssmissionCode = null,
            SelectGenStockInBussiness bussiness = SelectGenStockInBussiness.Default
            )
        {
            return Inman_DropDownListFor(htmlHelper, expression,
                                         string.Format("/Selector/GenProductStockIn?bussiness={0}", bussiness),
                                         dataTextField: dataTextField,
                                         dataValueField: dataValueField,
                                         selectedText: selectedText,
                                         optionLabel: optionLabel,
                                         perssmissionCode: perssmissionCode
                );
        }
        #endregion

        #region 按钮

        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name">名称</param>
        /// <param name="text">显示文本</param>
        /// <param name="perssmissionCode">权限码</param>
        /// <param name="htmlAttributes">html属性</param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        public static MvcHtmlString Inman_Info(this HtmlHelper htmlHelper, string name, string text,
                                                 string perssmissionCode = null, object htmlAttributes = null,
                                                 bool hidden = false)
        {
            if (hidden || !AuthorizeInLoginAccount(perssmissionCode))
                return null;
            var htmlAttributes1 = new Dictionary<string, object>
                {
                    {"type", "button"},
                    {"class", "k-button"},
                  {"style", "color:#FF3030; font-weight:bold"}
        };

            if (htmlAttributes == null)
                return htmlHelper.Label(name, text, htmlAttributes1);
            var dic = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes) as IDictionary<string, object>;
            htmlAttributes1.Union(dic);

            return htmlHelper.Label(name, text, htmlAttributes1);
        }

        #endregion


        #region 检测Excel列是否一致
        /// <summary>
        /// 在DEBUG模式才会输出执行的代码，用于检测Excel的列是否跟列表页面一致
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static String GenExcelCheckScript(this HtmlHelper htmlHelper)
        {
            string scriptStr = "";
#if DEBUG
            scriptStr = "CheckExcel();";
#endif

            return scriptStr;
        }
        #endregion

        /// <summary>
        /// jquery模板 li标签 信息配置
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static MvcHtmlString JqueryTmplLiAttr(this HtmlHelper htmlHelper)
        {
            return new MvcHtmlString(" <span style=\"font-size:16px;color:{{if OPERATION_STATE=='待新增'}} green; {{else OPERATION_STATE=='新增中'}} red; {{else}} gray; text-decoration:line-through; {{/if}}\">${OPERATION_STATE}</span> {{if OPERATION_STATE=='新增中'|| OPERATION_STATE=='已完成'}} &nbsp; {{else}} <a href=\"javascript: insertData(${ AUTO_ID})\">添加到面板</a> {{/if}}");
        }
     }
}