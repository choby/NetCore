namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public interface ISchedulerEventService<T>
        where T : class, ISchedulerEvent
    {
        IQueryable<T> GetAll();
        void Insert(T appointment, ModelStateDictionary modelState);
        void Update(T appointment, ModelStateDictionary modelState);
        void Delete(T appointment, ModelStateDictionary modelState);
    }
}
