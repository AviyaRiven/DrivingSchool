//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Dal.dalapi;
using Dal.dalImplements;
using Dal;
using Bl.Profiles;

namespace Bl
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection AddServicesBl(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IStudentServiceDal, StudentServiceDal>();
            services.AddRepositories(configuration);
            services.AddAutoMapper(typeof(TeacherProfile));
            services.AddAutoMapper(typeof(StudentProfile));
            services.AddAutoMapper(typeof(AddressProfile));
            return services;
        }
    }
}
