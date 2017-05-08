namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		/// <summary>
		/// Creates a <see cref="Notification"/>
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Notification()
		///             .Name("Notification1");
		/// %&gt;
		/// </code>
		/// </example>
		public virtual NotificationBuilder Notification()
		{
			return new NotificationBuilder(new Notification(HtmlHelper.ViewContext));
		}
	}
}