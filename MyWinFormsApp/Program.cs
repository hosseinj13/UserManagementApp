using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using MyWinFormsApp.Data;
using MyWinFormsApp.Repositories;
using MyWinFormsApp.Services;
using Microsoft.EntityFrameworkCore;

namespace MyWinFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=maktab;Username=postgres;Password=h9311240246N"));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var userService = serviceProvider.GetRequiredService<IUserService>();
                Application.Run(new Forms.MainForm(userService));
            }
        }
    }
}
