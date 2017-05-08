using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Routing;

namespace Inman.Infrastructure.Web
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class FormValueRequiredAttribute : ActionMethodSelectorAttribute
    {
        private readonly string[] _submitButtonNames;
        private readonly FormValueRequirement _requirement;

        public FormValueRequiredAttribute(params string[] submitButtonNames) :
            this(FormValueRequirement.Equal, submitButtonNames)
        {
        }

        public FormValueRequiredAttribute(FormValueRequirement requirement, params string[] submitButtonNames)
        {
            //at least one submit button should be found
            this._submitButtonNames = submitButtonNames;
            this._requirement = requirement;
        }

        public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor action)
        {
            foreach (string buttonName in _submitButtonNames)
            {
                try
                {
                    string value = "";
                    switch (this._requirement)
                    {
                        case FormValueRequirement.Equal:
                            {
                                //do not iterate because "Invalid request" exception can be thrown
                                value = routeContext.HttpContext.Request.Form[buttonName];
                            }
                            break;
                        case FormValueRequirement.StartsWith:
                            {
                                foreach (var formValue in routeContext.HttpContext.Request.Form.Keys)
                                {
                                    if (formValue.StartsWith(buttonName, StringComparison.CurrentCultureIgnoreCase))
                                    {
                                        value = routeContext.HttpContext.Request.Form[formValue];
                                        break;
                                    }
                                }
                            }
                            break;
                    }
                    if (!String.IsNullOrEmpty(value))
                        return true;
                }
                catch (Exception exc)
                {
                    //try-catch to ensure that 
                    Debug.WriteLine(exc.Message);
                }
            }
            return false;
        }

       
    }

    public enum FormValueRequirement
    {
        Equal,
        StartsWith
    }
}
