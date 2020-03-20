using ItUniver.AspNetCore;
using ItUniver.Tasks.Application;
using ItUniver.Tasks.Application.Services;
using ItUniver.Tasks.Application.Services.Imps;
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

        public static IServiceCollection AddTaskApplicationServices(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskApplicationModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();

            return services;
        }
    }
}
