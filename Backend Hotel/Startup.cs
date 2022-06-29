using BackendHotel.BL.Classes;
using BackendHotel.BL.Classes.Helper;
using BackendHotel.BL.Interfaces;
using BackendHotel.DAL.Entities;
using BackendHotel.DAL.Repository.Classes;
using BackendHotel.DAL.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendHotel
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HotelDbContext")));
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BackendHotel", Version = "v1" });
            });

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IBookingRoomTypeRepository, BookingRoomTypeRepository>();

            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IBookingLogic, BookingLogic>();

            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BackendHotel v1"));
            }

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials()
            );

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
