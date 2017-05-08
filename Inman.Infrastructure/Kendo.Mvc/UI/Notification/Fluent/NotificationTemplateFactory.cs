namespace Kendo.Mvc.UI.Fluent
{
	/// <summary>
	/// Defines the fluent interface for configuring the <see cref="Notification.Templates"/>.
	/// </summary>
	public class NotificationTemplateFactory : IHideObjectMembers
    {
        private readonly Notification container;        

        public NotificationTemplateFactory(Notification container)
        {
            this.container = container;            
        }

        public virtual NotificationTemplateBuilder Add()
        {
            NotificationTemplateSettings item = new NotificationTemplateSettings();

            container.Templates.Add(item);

            return new NotificationTemplateBuilder(item);
        }
    }
}