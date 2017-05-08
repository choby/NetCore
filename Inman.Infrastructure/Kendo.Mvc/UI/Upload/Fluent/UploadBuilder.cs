using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Upload
    /// </summary>
    public partial class UploadBuilder: WidgetBuilderBase<Upload, UploadBuilder>
        
    {
        public UploadBuilder(Upload component) : base(component)
        {
        }

		public UploadBuilder Enable(bool value)
		{
			Container.Enabled = value;
			return this;
		}

		/// <summary>
		/// Sets the strings rendered by the Upload.
		/// </summary>
		/// <param name="configurator">The configurator for the localization setting.</param>
		public UploadBuilder Messages(Action<UploadMessagesSettingsBuilder> configurator)
		{
			configurator(new UploadMessagesSettingsBuilder(Container.Messages));
			return this;
		}
	}
}

