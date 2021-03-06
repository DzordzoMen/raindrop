using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RaindropApi.Model.Weather;
using RaindropApi.Services;

namespace RaindropApi {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddCors();
			services.AddAutoMapper(typeof(WeatherProfileMap).Assembly);
			services.AddScoped<OpenWeatherService>();
			services.AddControllers();
			services.AddSwaggerGen(c => {
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "RaindropApi", Version = "v1" });
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RaindropApi v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseCors(builder =>
				builder
					.WithOrigins("http://localhost:8080", "http://localhost:8081", "http://localhost:1024")
					.SetIsOriginAllowedToAllowWildcardSubdomains()
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials());

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
		}
	}
}