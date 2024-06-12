using PlataformaCursos.Core.Repositories.Base;
using PlataformaCursos.Core.Repositories;
using PlataformaCursos.Core.Services;
using PlataformaCursos.Infra.Persistence.Repositories.Base;
using PlataformaCursos.Infra.Persistence.Repositories;
using PlataformaCursos.Infra.Services;

namespace PlataformaCursos.API.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //Repositories

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ILessonRepository, LessonRepository>();
            services.AddTransient<IModuleRepository, ModuleRepository>();
            services.AddTransient<IPaymentSubscriptionRepository, PaymentSubscriptionRepository>();
            services.AddTransient<ISubscriptionRepository, SubscriptionRepository>();
            services.AddTransient<IUserLessonCompletedRepository, UserLessonCompletedRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserSubscriptionRepository, UserSubcriptionRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Services
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
