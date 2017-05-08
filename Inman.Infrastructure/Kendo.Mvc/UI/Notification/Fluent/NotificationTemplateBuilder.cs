namespace Kendo.Mvc.UI.Fluent
{
	using Kendo.Mvc.UI;

	public class NotificationTemplateBuilder : IHideObjectMembers
    {
        private readonly NotificationTemplateSettings templateSettings;        

        public NotificationTemplateBuilder(NotificationTemplateSettings templateSettings)
        {
            this.templateSettings = templateSettings;            
        }

        /// <summary>
        /// Sets the notification type (i.e. template name). The value should be a valid Javascript identifier.
        /// </summary>
        public NotificationTemplateBuilder Type(string value)
        {
            templateSettings.Type = value;

            return this;
        }

        /// <summary>
        /// Sets the client ID of the notification template.
        /// </summary>
        public NotificationTemplateBuilder ClientTemplateID(string value)
        {
            templateSettings.ClientTemplateID = value;

            return this;
        }

        /// <summary>
        /// Sets the Kendo UI template to be used for the notifications.
        /// </summary>
        public NotificationTemplateBuilder ClientTemplate(string value)
        {
            templateSettings.ClientTemplate = value;

            return this;
        }
    }
}