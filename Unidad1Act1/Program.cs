var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();


var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoint=>endpoint.MapDefaultControllerRoute());

app.Run();
