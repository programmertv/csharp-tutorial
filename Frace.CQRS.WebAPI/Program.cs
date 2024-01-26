using Frace.CQRS.AppService;
using Frace.CQRS.Core;
using Frace.CQRS.Domain.Contracts;
using Frace.CQRS.Infrastructure.Database.Contexts;
using Frace.CQRS.Infrastructure.Database.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SchoolDBContext>(options =>
        //options.UseSqlServer(connectionString)
        options.UseInMemoryDatabase("SchoolDB")
    );
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddAutoMapper(typeof(_ForAppServiceAssembyLoadOnly).Assembly);
builder.Services.AddMediatR(typeof(_ForCoreAssembyLoadOnly).Assembly);

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options => {
        options.SuppressModelStateInvalidFilter = true;
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();