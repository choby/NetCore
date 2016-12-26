using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Errors = new List<ErrorMsg>();
            ShowSuccess = true;
            ShowErrors = true;
        }

        public bool Success { get; set; }

        public bool Redirect { get; set; }

        public string RedirectUrl { get; set; }

        public List<ErrorMsg> Errors { get; set; }

        public bool ShowSuccess { get; set; }

        public bool ShowErrors { get; set; }

        /// <summary>
        /// 是否需要客户端二次确认
        /// </summary>
        public bool NeedConfirm { get; set; }

        /// <summary>
        /// 确认提示信息
        /// </summary>
        public string ConfirmTip { get; set; }

        /// <summary>
        /// 客户端需要执行的回调方法
        /// </summary>
        public string Callback { get; set; }

        /// <summary>
        /// 下一步骤路径
        /// </summary>
        public string NextStepUrl { get; set; }
    }
}
