using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GESCOM;
using capaEF; // Cambi� por el namespace real donde est� AppDbContext
using System;
using System.Windows.Forms;

namespace GESCOM
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // Configuraci�n de appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            // Configuraci�n de servicios e inyecci�n de dependencias
            var services = new ServiceCollection();

            services.AddDbContext<GescomDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));

            // Agreg� otros servicios si los necesit�s (ej: capaNegocio)

            ServiceProvider = services.BuildServiceProvider();

            // Crear la base de datos si no existe
            using (var context = ServiceProvider.GetRequiredService<GescomDBContext>())
            {
                context.Database.EnsureCreated(); // O reemplaz� con migraciones
            }

            // Iniciar la app WinForms
            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}
