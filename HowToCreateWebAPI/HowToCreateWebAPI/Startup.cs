using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToCreateWebAPI.Contracts;
using HowToCreateWebAPI.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using HowToCreateWebAPI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;

namespace HowToCreateWebAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private const string SECRET_CONFIG_KEY = "MySecretKey";

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var secret = _configuration.GetValue<string>(SECRET_CONFIG_KEY);
            var validationParameters = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = true,
                ValidIssuer = "test",
                ValidAudience = string.Empty,
                IssuerSigningKey = new SymmetricSecurityKey
                    (
                        Encoding.UTF8.GetBytes(secret)
                    )
            };
            services.AddControllers();
            services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddSingleton<IHeroRepository, HeroRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<ITokenService>(s => new TokenService(validationParameters, secret));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(op =>
                {
                    op.TokenValidationParameters = validationParameters;
                });

            services.AddSwaggerGen(s => {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Sample API V1",
                    Description = "This is a sample API only"
                });
                s.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    In = ParameterLocation.Header,
                    Description = "Input your bearer token here"
                });
                s.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference{
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            }
                        }, Array.Empty<string>()
                    }
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(s =>
                {
                    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Sample Web API only");
                });
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
