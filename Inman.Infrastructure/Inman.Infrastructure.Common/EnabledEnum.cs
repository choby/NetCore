using System.ComponentModel.DataAnnotations;

namespace Inman.Infrastructure.Common
{
    public enum EnabledEnum
    {
        [Display(Name = "有效")]
        Enable = 1,


        [Display(Name = "无效")]
        Disable = 0
    }
}
