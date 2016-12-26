using System.Collections.Generic;

namespace Inman.Infrastructure.Web
{
    public enum InputSize
    {
        Default = 2,
        Short = 1,
        Middle = 2,
        Long = 3
    }



    public static class FormExtensions
    {

        //public static MvcHtmlString DateControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                        Expression<Func<TModel, TProperty>> expression,
        //                                                        IDictionary<string, object> htmlAttributes = null,
        //                                                        string format = "yyyy-MM-dd")
        //{
        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {
        //                                   {
        //                                       "onclick",
        //                                       "WdatePicker({charset:'gb2312',dateFmt:'" + format +"'})"
        //                                    },
        //                                   {"class ", "txt txt_short wdate"},
        //                                   {"style", "width:120px;"}
        //                               };

        //    tmpHtmlAttribute.Union(htmlAttributes);

        //    return htmlHelper.TextBoxFor(expression, tmpHtmlAttribute);
        //}

        //public static MvcHtmlString DatetimeControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                Expression<Func<TModel, TProperty>> expression,
        //                                                IDictionary<string, object> htmlAttributes = null,
        //                                                string format = "yyyy-MM-dd hh:mm:ss")
        //{
        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {
        //                                   {
        //                                       "onclick",
        //                                       "WdatePicker({charset:'gb2312',dateFmt:'" + format +"'})"
        //                                    },
        //                                   {"class ", "txt txt_short wdate"},
        //                                   {"style", "width:180px;"}
        //                               };

        //    tmpHtmlAttribute.Union(htmlAttributes);

        //    return htmlHelper.TextBoxFor(expression, tmpHtmlAttribute);
        //}

        //public static MvcHtmlString DropDownListControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                                Expression<Func<TModel, TProperty>> expression,
        //                                                                IEnumerable<SelectListItem> selectList,
        //                                                                IDictionary<string, object> htmlAttributes = null,
        //                                                                InputSize size = InputSize.Default)
        //{
        //    string strSize = "select_middle ";
        //    if (size == InputSize.Long)
        //        strSize = "select_long ";
        //    else if (size == InputSize.Short)
        //        strSize = "select_short ";

        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {  
        //                                   {"class ",string.Concat("select ",strSize,"chzn-select ")}
        //                               };
        //    tmpHtmlAttribute.Union(htmlAttributes);
        //    return htmlHelper.DropDownListFor(expression, selectList, tmpHtmlAttribute);
        //}


        //public static MvcHtmlString ListBoxControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                              Expression<Func<TModel, TProperty>> expression,
        //                                                              IEnumerable<SelectListItem> selectList,
        //                                                              IDictionary<string, object> htmlAttributes = null,
        //                                                              InputSize size = InputSize.Default)
        //{
        //    string strSize = "select_middle ";
        //    if (size == InputSize.Long)
        //        strSize = "select_long ";
        //    else if (size == InputSize.Short)
        //        strSize = "select_short ";

        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {  
        //                                   {"class ",string.Concat("select ",strSize,"chzn-select ")},
        //                                   {"multiple",""}
        //                               };
        //    tmpHtmlAttribute.Union(htmlAttributes);

        //    return htmlHelper.ListBoxFor(expression, selectList, tmpHtmlAttribute);
        //}

        //public static MvcHtmlString LabelControl(this HtmlHelper htmlHelper,
        //                                             string text,
        //                                             bool required = false,
        //                                             InputSize size = InputSize.Default)
        //{
        //    string strSize = "info_middle ";
        //    if (size == InputSize.Long)
        //        strSize = "info_long ";
        //    else if (size == InputSize.Short)
        //        strSize = "info_short ";

        //    return MvcHtmlString.Create(string.Format("<span class=\"info_box {0}\">{1}{2}</span>",
        //                                                strSize,
        //                                                string.IsNullOrEmpty(text) ? text : string.Concat(text, ":"),
        //                                                required ? "<span class=\"coff\">*</span>" : String.Empty));
        //}

        //public static MvcHtmlString TextBoxControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                     Expression<Func<TModel, TProperty>> expression,
        //                                                     IDictionary<string, object> htmlAttributes = null,
        //                                                     InputSize size = InputSize.Default)
        //{
        //    string strSize = "txt_middle ";
        //    if (size == InputSize.Long)
        //        strSize = "txt_long ";
        //    else if (size == InputSize.Short)
        //        strSize = "txt_short ";

        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {  
        //                                   {"class ",string.Concat( "txt ",strSize)}
        //                               };

        //    tmpHtmlAttribute.Union(htmlAttributes);

        //    return htmlHelper.TextBoxFor(expression, tmpHtmlAttribute);
        //}

        //public static MvcHtmlString TextAreaControlFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                                  Expression<Func<TModel, TProperty>> expression,
        //                                                                  IDictionary<string, object> htmlAttributes = null,
        //                                                                  InputSize size = InputSize.Default)
        //{
        //    string strSize = "area_middle ";
        //    if (size == InputSize.Long)
        //        strSize = "area_long ";
        //    else if (size == InputSize.Short)
        //        strSize = "area_short ";

        //    var tmpHtmlAttribute = new Dictionary<string, object>
        //                               {  
        //                                   {"class ",string.Concat( "area ",strSize)}
        //                               };

        //    tmpHtmlAttribute.Union(htmlAttributes);

        //    return htmlHelper.TextAreaFor(expression, tmpHtmlAttribute);
        //}

        //public static MvcHtmlString DropDownListTreeFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper,
        //                                                               Expression<Func<TModel, TProperty>> expression,
        //                                                               string id,
        //                                                               string value,
        //                                                               IList<TreeNode> selectList,
        //                                                               IDictionary<string, object> htmlAttributes = null,
        //                                                               InputSize size = InputSize.Default)
        //{
        //    IDictionary<string, object> tmpDictionary = new Dictionary<string, object>()
        //                                                    {
        //                                                        {"id",id},
        //                                                        {"class","easyui-combotree"}
        //                                                    };
        //    if (htmlAttributes != null)
        //        tmpDictionary = tmpDictionary.Union(htmlAttributes);

        //    TreeNode tree = new TreeNodeHelper().GenerateTreeRoot(selectList as List<TreeNode>);

        //    string strscript1 = string.Format("{0}{1};", "var arrData=", tree.ToJsonTreeString());
        //    string strScript2 = string.Format("var $cbxCategory= $('{0}');$cbxCategory.combotree('loadData', arrData);", string.Format("{0}{1}", "#", id));
        //    string strScript3 = string.Format("$cbxCategory.combotree('setValue', '{0}');", value);

        //    var strScript = new StringBuilder();
        //    strScript.Append("<script language=\"javascript\" type=\"text/javascript\">");
        //    strScript.Append("$(document).ready(function () {");

        //    strScript.Append(strscript1);
        //    strScript.Append(strScript2);
        //    strScript.Append(strScript3);

        //    strScript.Append("});");
        //    strScript.Append("</script>");

        //    var output1 = htmlHelper.DropDownListFor(expression, new List<SelectListItem>(), tmpDictionary);
        //    var output2 = MvcHtmlString.Create(strScript.ToString());
        //    return MvcHtmlString.Create(output1 + output2.ToString());
        //}

        public static IDictionary<TKey, TValue> Union<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second, bool overwrite = true)
        {
            first = first ?? new Dictionary<TKey, TValue>();

            if (second == null)
            { return first; }

            foreach (var keyValuePair in second)
            {
                if (first.ContainsKey(keyValuePair.Key))
                {
                    if (overwrite)
                    { first[keyValuePair.Key] = second[keyValuePair.Key]; }
                }
                else
                { first.Add(keyValuePair); }
            }

            return first;
        }
    }
}
