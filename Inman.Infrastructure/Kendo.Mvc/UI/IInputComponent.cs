namespace Kendo.Mvc.UI
{
    public interface IInputComponent<T> : IWidget where T : struct
    {
        T? Value { get; set; }
    }
}
