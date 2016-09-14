using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Asmt {

	public class Startup {

		public Startup(IHostingEnvironment env) {
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables();
			Configuration = builder.Build();
		}

		public IConfigurationRoot Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			// services.Configure<RazorViewEngineOptions>(options => { options.FileProviders.Add(new
			// EmbeddedFileProvider( typeof(ControllerCore).GetTypeInfo().Assembly,
			// "QuickFrame.Mvc")); }); Add framework services.
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory) {
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();

			if(env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
				app.UseBrowserLink();
			} else {
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			IOptions<RazorViewEngineOptions> razorViewEngineOptions =
	app.ApplicationServices.GetService<IOptions<RazorViewEngineOptions>>();
			//razorViewEngineOptions.Value.FileProviders.Add(new EmbeddedFileProvider(
			//		typeof(ControllerCore).GetTypeInfo().Assembly,
			//		"QuickFrame.Mvc"));

			app.UseMvc(routes => {
				routes.MapRoute(
					name: "default",
					template: "{controller=Applications}/{action=Index}/{id?}");
			});
		}
	}
}