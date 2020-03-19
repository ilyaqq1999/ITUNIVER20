using ItUniver.Tasks.Managers;
using ItUniver.Tasks.Stores;


using Microsoft.Extensions.DependencyInjection;

namespace ItUniver.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ITaskStore, TaskMemoryStore>();
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }
    }
}
