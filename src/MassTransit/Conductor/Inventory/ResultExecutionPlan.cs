namespace MassTransit.Conductor.Inventory
{
    /// <summary>
    /// Identity function that completes the plan, returning the response
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    public class ResultExecutionPlan<TResult> :
        IExecutionPlan<TResult, TResult>
        where TResult : class
    {
        public void Build(BuildContext<TResult, TResult> context)
        {
            context.Response();
        }
    }
}
