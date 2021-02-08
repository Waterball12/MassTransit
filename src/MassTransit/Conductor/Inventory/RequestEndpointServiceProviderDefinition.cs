namespace MassTransit.Conductor.Inventory
{
    public class RequestEndpointServiceProviderDefinition<TInput, TResult> :
        IServiceProviderDefinition<TInput, TResult>
        where TResult : class
        where TInput : class
    {
        public void Configure(IServiceRegistrationConfigurator<TInput> configurator)
        {
        }

        public IProviderRegistration<TInput, TResult> CreateProvider()
        {
            return new RequestEndpointProviderRegistration<TInput, TResult>();
        }
    }
}
