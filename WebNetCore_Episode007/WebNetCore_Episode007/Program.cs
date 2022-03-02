using Microsoft.EntityFrameworkCore;
using WebNetCore_Episode007;
using WebNetCore_Episode007.Entities;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hContext, services) =>
    {
        var config = hContext.Configuration;
        const string STUDENTDB_CONTEXT_CONNSTRING = "Student";

        services.AddDbContext<StudentDbContext>(options => {
            options.UseSqlServer(config.GetConnectionString(STUDENTDB_CONTEXT_CONNSTRING));
        }, ServiceLifetime.Singleton);
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
