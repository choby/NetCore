using System.Collections.Generic;
using System.Linq;
using Inman.Infrastructure.Common.Extensions;
using Inman.Infrastructure.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Inman.Infrastructure.Web
{
    public static class CollectionExtensions
    {
        public static IList<SelectListItem> WithNoneItem(this IList<SelectListItem> source,
                                                         string value = "0", string text = "")
        {
            if (source.Any(p => p.Value == value))
            { return source; }

            source.Insert(0, new SelectListItem
            {
                Text = text,
                Value = value
            });
            return source;
        }

        public static IList<SelectListItem> WithAllItem(this IList<SelectListItem> source,
                                                        string value = "0", string text = "全部")
        {
            if (source.Any(p => p.Value == value))
            { source.Remove(p => p.Value == value); }

            source.Insert(0, new SelectListItem
            {
                Text = text,
                Value = value
            });
            return source;
        }

        public static IList<SelectListItem> RemoveItem(this IList<SelectListItem> source, string value)
        {
            source.Remove(p => p.Value == value);
            return source;
        }

        public static void SetSelectedItem(this IEnumerable<SelectListItem> source, string selectedValue)
        {
            foreach (var item in source)
            {
                item.Selected = item.Value == selectedValue;
            }
        }

        public static List<SelectListItem> ToSelectItemList(this IEnumerable<DataSourceBinder> source,
                                                            string defualtValue)
        {
            var list = (from item in source
                        let Selected = item.ValueField == defualtValue
                        select new SelectListItem()
                        {
                            Selected = Selected,
                            Text = item.TextField_EN,
                            Value = item.ValueField
                        }).ToList();
            return list;
        }
    }
}
