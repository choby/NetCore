using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetRowCellValidationSettings class
    /// </summary>
    public partial class SpreadsheetSheetRowCellValidationSettings 
    {
        public string Type { get; set; }

        public string ComparerType { get; set; }

        public string DataType { get; set; }

        public string From { get; set; }

        public bool? ShowButton { get; set; }

        public string To { get; set; }

        public bool? AllowNulls { get; set; }

        public string MessageTemplate { get; set; }

        public string MessageTemplateId { get; set; }

        public string TitleTemplate { get; set; }

        public string TitleTemplateId { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (ComparerType?.HasValue() == true)
            {
                settings["comparerType"] = ComparerType;
            }

            if (DataType?.HasValue() == true)
            {
                settings["dataType"] = DataType;
            }

            if (From?.HasValue() == true)
            {
                settings["from"] = From;
            }

            if (ShowButton.HasValue)
            {
                settings["showButton"] = ShowButton;
            }

            if (To?.HasValue() == true)
            {
                settings["to"] = To;
            }

            if (AllowNulls.HasValue)
            {
                settings["allowNulls"] = AllowNulls;
            }

            if (MessageTemplateId.HasValue())
            {
                settings["messageTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Spreadsheet.IdPrefix, MessageTemplateId
                    )
                };
            }
            else if (MessageTemplate.HasValue())
            {
                settings["messageTemplate"] = MessageTemplate;
            }

            if (TitleTemplateId.HasValue())
            {
                settings["titleTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Spreadsheet.IdPrefix, TitleTemplateId
                    )
                };
            }
            else if (TitleTemplate.HasValue())
            {
                settings["titleTemplate"] = TitleTemplate;
            }

            return settings;
        }
    }
}
