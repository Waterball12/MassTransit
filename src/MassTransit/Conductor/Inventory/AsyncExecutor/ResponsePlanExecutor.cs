namespace MassTransit.Conductor.Inventory.AsyncExecutor
{
    using System;
    using System.Threading.Tasks;
    using GreenPipes.Internals.Extensions;


    public class ResponsePlanExecutor<TInput, TResult> :
        IPlanExecutor<TInput, TResult>
        where TInput : class
        where TResult : class
    {
        public Task<TResult> Execute(PlanContext<TInput> plan)
        {
            var response = plan.Data as TResult
                ?? throw new InvalidCastException($"Result type mismatch, expected {TypeCache<TResult>.ShortName}, was {TypeCache<TInput>.ShortName}");

            return Task.FromResult(response);
        }
    }
}
