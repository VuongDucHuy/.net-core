

using TRANNING.IRepository;
using TRANNING.IServices;
using TRANNING.Repository;
using TRANNING.Service;

namespace TRANNING
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddMvc();

            services.AddControllers();
            //Begin Register Repositories
            services.AddScoped<IGetdataService, GetdataService>();
            services.AddScoped(typeof(IDatabaseExecuteRepository<>), typeof(DatabaseExecuteRepository<>));
            services.AddScoped<IGetdataResponsitory, GetdataRepository>();

            var connection = Configuration.GetConnectionString("TISCPKContext");
            services.AddScoped<ISQLServerConnection>(c =>
            {
                return new SQLServerConnection(connection);
            });

            services.AddHttpContextAccessor();
            services.AddSession();






        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

 
          

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}");
            });

        }
    }
}
