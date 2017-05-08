namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Creates toolbar commands for the <see cref="Scheduler{T}" /> class.
    /// </summary>
    public class SchedulerToolbarFactory<T> : IHideObjectMembers
        where T : class, ISchedulerEvent
    {
        private readonly Scheduler<T> container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerToolbarFactory{T}"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public SchedulerToolbarFactory(Scheduler<T> container)
        {
            this.container = container;
        }

        /// <summary>
        /// Enables Pdf command.
        /// </summary>
        /// <returns></returns>
        public void Pdf()
        {
            SchedulerToolbarCommand command = new SchedulerToolbarCommand(SchedulerToolbarCommandType.Pdf);

            container.ToolbarCommands.Add(command);
        }
    }
}