using ItUniver.AspNetCore;
using ItUniver.Tasks.Application;
using ItUniver.Tasks.Application.Services;
using ItUniver.Tasks.Application.Services.Imps;
using ItUniver.Tasks.Managers;
using ItUniver.Tasks.NHibernate;
using ItUniver.Tasks.NHibernate.Repositories;
using ItUniver.Tasks.Repositories;

using Microsoft.Extensions.DependencyInjection;

using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace ItUniver.Tasks.Web
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTaskCore(this IServiceCollection services)
        {
            services.AddTransient<ITaskManager, TaskManager>();

            return services;
        }

        public static IServiceCollection AddTaskApplication(this IServiceCollection services)
        {
            services.CreateControllersForAppServices(typeof(TaskApplicationModule).Assembly);
            services.AddTransient<ITaskAppService, TaskAppService>();
            services.AddTransient<IUserAppService, UserAppService>();
            services.AddTransient<IRoleAppService, RoleAppService>();

            return services;
        }

        public static IServiceCollection AddTaskNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(TaskNHibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
                //c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                //c.SchemaAction = SchemaAutoAction.Validate;
                //c.LogFormattedSql = true;
                //c.LogSqlInConsole = true;
            });
            configuration.AddMapping(mappings);

            var sessionFactory = configuration.BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

            return services;
        }
    }
}