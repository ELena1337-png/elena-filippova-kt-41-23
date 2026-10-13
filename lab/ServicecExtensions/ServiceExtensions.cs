using lab.Interfaces.StudentsInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace lab.ServicecExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
