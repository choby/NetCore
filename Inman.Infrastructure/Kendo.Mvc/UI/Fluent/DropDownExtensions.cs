using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    internal static class DropDownExtentions
    {
        internal static string SelectedValue(this IEnumerable<SelectListItem> source)
        {
            var selectListItem = source.Where(item => item.Selected == true).FirstOrDefault();

            if (selectListItem != null)
            {
                return selectListItem.Value ?? selectListItem.Text;
            }

            return null;
        }
    }
}
