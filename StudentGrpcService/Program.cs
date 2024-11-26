using StudentGrpcService.Services;
using StudentGrpcService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", 
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Add DbContext
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlite("Data Source=../StudentsMinimalApi/school.db;Cache=Shared"));

// Configure Kestrel
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5003, o => o.Protocols = 
        Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2);
});

var app = builder.Build();

// Enable CORS
app.UseCors("AllowAll");
app.UseGrpcWeb();

app.MapGrpcService<StudentService>()
   .EnableGrpcWeb()
   .RequireCors("AllowAll");

app.MapGet("/", () => "gRPC Student Service is running...");

app.Run();
