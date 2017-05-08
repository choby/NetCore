using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRowCellValidationSettings
    /// </summary>
    public partial class SpreadsheetSheetRowCellValidationSettingsBuilder
        
    {
        /// <summary>
        /// Defines the validation type. The acceptable options are reject or warning
        /// </summary>
        /// <param name="value">The value for Type</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// Defines the comparer type used to validate the cell value, e.g. "greaterThan", "between" and etc.
        /// </summary>
        /// <param name="value">The value for ComparerType</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder ComparerType(string value)
        {
            Container.ComparerType = value;
            return this;
        }

        /// <summary>
        /// Defines the data type of the cell value.
        /// </summary>
        /// <param name="value">The value for DataType</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder DataType(string value)
        {
            Container.DataType = value;
            return this;
        }

        /// <summary>
        /// Defines a formula or value used for the comparison process. Used as only if comparer type does not require second argument.
        /// </summary>
        /// <param name="value">The value for From</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder From(string value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if a button for selecting list items (dataType set to list) should be displayed.
        /// </summary>
        /// <param name="value">The value for ShowButton</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder ShowButton(bool value)
        {
            Container.ShowButton = value;
            return this;
        }

        /// <summary>
        /// A boolean value indicating if a button for selecting list items (dataType set to list) should be displayed.
        /// </summary>
        public SpreadsheetSheetRowCellValidationSettingsBuilder ShowButton()
        {
            Container.ShowButton = true;
            return this;
        }

        /// <summary>
        /// Defines a formula or value used for the comparison process. Will be used if comparer type requires second argument.
        /// </summary>
        /// <param name="value">The value for To</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder To(string value)
        {
            Container.To = value;
            return this;
        }

        /// <summary>
        /// Specifies whether to allow nulls.
        /// </summary>
        /// <param name="value">The value for AllowNulls</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder AllowNulls(bool value)
        {
            Container.AllowNulls = value;
            return this;
        }

        /// <summary>
        /// Defines the hint message that will be displayed if value is invalid.The template is giving an access to the following variables: from{0}, to{1}, fromFormula{2}, toFormula{3}, dataType{4}, type{5} and comparerType{6}.
        /// </summary>
        /// <param name="value">The value for MessageTemplate</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder MessageTemplate(string value)
        {
            Container.MessageTemplate = value;
            return this;
        }

        /// <summary>
        /// Defines the hint message that will be displayed if value is invalid.The template is giving an access to the following variables: from{0}, to{1}, fromFormula{2}, toFormula{3}, dataType{4}, type{5} and comparerType{6}.
        /// </summary>
        /// <param name="value">The ID of the template element for MessageTemplate</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder MessageTemplateId(string templateId)
        {
            Container.MessageTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Defines the hint title that will be displayed if value is invalid.
        /// </summary>
        /// <param name="value">The value for TitleTemplate</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder TitleTemplate(string value)
        {
            Container.TitleTemplate = value;
            return this;
        }

        /// <summary>
        /// Defines the hint title that will be displayed if value is invalid.
        /// </summary>
        /// <param name="value">The ID of the template element for TitleTemplate</param>
        public SpreadsheetSheetRowCellValidationSettingsBuilder TitleTemplateId(string templateId)
        {
            Container.TitleTemplateId = templateId;
            return this;
        }

    }
}
