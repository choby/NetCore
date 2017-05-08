using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumn
    /// </summary>
    public partial class TreeListColumnBuilder<T>
        where T : class 
    {
        /// <summary>
        /// HTML attributes of the table cell (&lt;td&gt;) rendered for the column.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public TreeListColumnBuilder<T> HtmlAttributes(IDictionary<string,object> value)
        {
            Container.HtmlAttributes = value;
            return this;
        }

        /// <summary>
        /// HTML attributes of the table cell (&lt;td&gt;) rendered for the column.
        /// </summary>
        /// <param name="value">The value for HtmlAttributes</param>
        public TreeListColumnBuilder<T> HtmlAttributes(object value)
        {
            Container.HtmlAttributes = value.ToDictionary();
            return this;
        }

        /// <summary>
        /// The configuration of the column command(s). If set the column would display a button for every command. Commands can be custom or built-in ("edit", "createChild" or "destroy"):Custom commands are supported by specifying the click option.
        /// </summary>
        /// <param name="configurator">The configurator for the command setting.</param>
        public TreeListColumnBuilder<T> Command(Action<TreeListColumnCommandFactory<T>> configurator)
        {

            configurator(new TreeListColumnCommandFactory<T>(Container.Command)
            {
                TreeList = Container.TreeList
            });

            return this;
        }

        /// <summary>
        /// If set to true the column value will be HTML-encoded before it is displayed. If set to false the column value will be displayed as is. By default the column value is HTML-encoded.
        /// </summary>
        /// <param name="value">The value for Encoded</param>
        public TreeListColumnBuilder<T> Encoded(bool value)
        {
            Container.Encoded = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will show the icons that are used for expanding and collapsing child rows. By default, the first column of the TreeList is expandable.
        /// </summary>
        /// <param name="value">The value for Expandable</param>
        public TreeListColumnBuilder<T> Expandable(bool value)
        {
            Container.Expandable = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will show the icons that are used for expanding and collapsing child rows. By default, the first column of the TreeList is expandable.
        /// </summary>
        public TreeListColumnBuilder<T> Expandable()
        {
            Container.Expandable = true;
            return this;
        }

        /// <summary>
        /// The field to which the column is bound. The value of this field is displayed by the column during data binding.
		/// The field name should be a valid Javascript identifier and should contain no spaces, no special characters, and the first character should be a letter.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public TreeListColumnBuilder<T> Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// If set to true a filter menu will be displayed for this column when filtering is enabled. If set to false the filter menu will not be displayed. By default a filter menu is displayed
		/// for all columns when filtering is enabled via the filterable option.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the filterable setting.</param>
        public TreeListColumnBuilder<T> Filterable(Action<TreeListColumnFilterableSettingsBuilder<T>> configurator)
        {
            Container.Filterable.Enabled = true;

            Container.Filterable.TreeList = Container.TreeList;
            configurator(new TreeListColumnFilterableSettingsBuilder<T>(Container.Filterable));

            return this;
        }

        /// <summary>
        /// If set to true a filter menu will be displayed for this column when filtering is enabled. If set to false the filter menu will not be displayed. By default a filter menu is displayed
		/// for all columns when filtering is enabled via the filterable option.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the filterable option.</param>
        public TreeListColumnBuilder<T> Filterable(bool enabled)
        {
            Container.Filterable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The template which renders the footer table cell for the column.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for FooterTemplate</param>
        public TreeListColumnBuilder<T> FooterTemplate(string value)
        {
            Container.FooterTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the footer table cell for the column.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for FooterTemplate</param>
        public TreeListColumnBuilder<T> FooterTemplateId(string templateId)
        {
            Container.FooterTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The format that is applied to the value before it is displayed. Takes the form "{0:format}" where "format" is a standard number format,
		/// custom number format, standard date format or a custom date format.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public TreeListColumnBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// HTML attributes of the table header cell (&lt;th&gt;) rendered for the column.
        /// </summary>
        /// <param name="value">The value for HeaderAttributes</param>
        public TreeListColumnBuilder<T> HeaderAttributes(IDictionary<string,object> value)
        {
            Container.HeaderAttributes = value;
            return this;
        }

        /// <summary>
        /// HTML attributes of the table header cell (&lt;th&gt;) rendered for the column.
        /// </summary>
        /// <param name="value">The value for HeaderAttributes</param>
        public TreeListColumnBuilder<T> HeaderAttributes(object value)
        {
            Container.HeaderAttributes = value.ToDictionary();
            return this;
        }

        /// <summary>
        /// The template which renders the column header content. By default the value of the title column option
		/// is displayed in the column header cell.
        /// </summary>
        /// <param name="value">The value for HeaderTemplate</param>
        public TreeListColumnBuilder<T> HeaderTemplate(string value)
        {
            Container.HeaderTemplate = value;
            return this;
        }

        /// <summary>
        /// The template which renders the column header content. By default the value of the title column option
		/// is displayed in the column header cell.
        /// </summary>
        /// <param name="value">The ID of the template element for HeaderTemplate</param>
        public TreeListColumnBuilder<T> HeaderTemplateId(string templateId)
        {
            Container.HeaderTemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The pixel screen width below which the column will be hidden. The setting takes precedence over the hidden setting,
		/// so the two should not be used at the same time.
        /// </summary>
        /// <param name="value">The value for MinScreenWidth</param>
        public TreeListColumnBuilder<T> MinScreenWidth(double value)
        {
            Container.MinScreenWidth = value;
            return this;
        }

        /// <summary>
        /// If set to true the user can click the column header and sort the treelist by the column field when sorting is enabled. If set to false sorting will
		/// be disabled for this column. By default all columns are sortable if sorting is enabled via the sortable option.
        /// </summary>
        /// <param name="configurator">The configurator for the sortable setting.</param>
        public TreeListColumnBuilder<T> Sortable(Action<TreeListColumnSortableSettingsBuilder<T>> configurator)
        {
            Container.Sortable.Enabled = true;

            Container.Sortable.TreeList = Container.TreeList;
            configurator(new TreeListColumnSortableSettingsBuilder<T>(Container.Sortable));

            return this;
        }

        /// <summary>
        /// If set to true the user can click the column header and sort the treelist by the column field when sorting is enabled. If set to false sorting will
		/// be disabled for this column. By default all columns are sortable if sorting is enabled via the sortable option.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public TreeListColumnBuilder<T> Sortable(bool enabled)
        {
            Container.Sortable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The template which renders the column content. The treelist renders table rows (&lt;tr&gt;) which represent the data source items.
		/// Each table row consists of table cells (&lt;td&gt;) which represent the treelist columns. By default the HTML-encoded value of the field is displayed in the column.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public TreeListColumnBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the column content. The treelist renders table rows (&lt;tr&gt;) which represent the data source items.
		/// Each table row consists of table cells (&lt;td&gt;) which represent the treelist columns. By default the HTML-encoded value of the field is displayed in the column.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public TreeListColumnBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The text that is displayed in the column header cell. If not set the field is used.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public TreeListColumnBuilder<T> Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// The width of the column. Numeric values are treated as pixels. For more important information, please refer to Column Widths.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public TreeListColumnBuilder<T> Width(string value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will not be displayed in the treelist. By default all columns are displayed.
        /// </summary>
        /// <param name="value">The value for Hidden</param>
        public TreeListColumnBuilder<T> Hidden(bool value)
        {
            Container.Hidden = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will not be displayed in the treelist. By default all columns are displayed.
        /// </summary>
        public TreeListColumnBuilder<T> Hidden()
        {
            Container.Hidden = true;
            return this;
        }

        /// <summary>
        /// If set to true the column will be visible in the grid column menu. By default the column menu includes all data-bound columns (ones that have their field set).
        /// </summary>
        /// <param name="value">The value for Menu</param>
        public TreeListColumnBuilder<T> Menu(bool value)
        {
            Container.Menu = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will be displayed as locked in the treelist. Also see Frozen Columns.
        /// </summary>
        /// <param name="value">The value for Locked</param>
        public TreeListColumnBuilder<T> Locked(bool value)
        {
            Container.Locked = value;
            return this;
        }

        /// <summary>
        /// If set to true the column will be displayed as locked in the treelist. Also see Frozen Columns.
        /// </summary>
        public TreeListColumnBuilder<T> Locked()
        {
            Container.Locked = true;
            return this;
        }

        /// <summary>
        /// If set to false the column will remain in the side of the treelist into which its own locked configuration placed it.
        /// </summary>
        /// <param name="value">The value for Lockable</param>
        public TreeListColumnBuilder<T> Lockable(bool value)
        {
            Container.Lockable = value;
            return this;
        }

    }
}
