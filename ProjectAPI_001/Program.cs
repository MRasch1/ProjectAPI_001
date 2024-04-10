using Microsoft.EntityFrameworkCore;
using ProjectAPI_001_Repository.Context;
using ProjectAPI_001_Repository.Interfaces;
using ProjectAPI_001_Repository.Repositories;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        string conStr = @"Server=SKAB3-PC8;Database=ProjektAPI_Database; Trusted_Connection=true";
        builder.Services.AddDbContext<DataContext>(obj => obj.UseSqlServer(conStr));

        //DependcyInjection - activate
        builder.Services.AddScoped<ISamuraiRepository, SamuraiRepo>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}