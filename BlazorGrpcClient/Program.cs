using BlazorGrpcClient.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using StudentRemote;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add gRPC client
builder.Services.AddGrpcClient<StudentRemote.StudentRemote.StudentRemoteClient>(options =>
{
    options.Address = new Uri("http://localhost:5003");
}).ConfigurePrimaryHttpMessageHandler(
    () => new GrpcWebHandler(new HttpClientHandler()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
