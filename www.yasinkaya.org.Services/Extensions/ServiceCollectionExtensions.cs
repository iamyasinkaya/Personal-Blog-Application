using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Data.Abstract;
using www.yasinkaya.org.Data.Concrete;
using www.yasinkaya.org.Data.Concrete.EntityFramework.Contexts;
using www.yasinkaya.org.Entities.Concrete;
using www.yasinkaya.org.Services.Abstract;
using www.yasinkaya.org.Services.Concrete;

namespace www.yasinkaya.org.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<YasinKayaContext>(opt => opt.UseSqlServer(connectionString));
            serviceCollection.AddIdentity<User, Role>(options =>
            {
                // User Password Options

                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 7;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;

                //UserName and Email Options

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;

            }
            ).AddEntityFrameworkStores<YasinKayaContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            return serviceCollection;
        }
    }
}
