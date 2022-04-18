using ASPNETCodeMVC6;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyService>();
//builder.Services.AddScoped<MyService>();
//builder.Services.AddSingleton<MyService>();


ConfigureServices(builder);

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("1");
//    await next();
//    await context.Response.WriteAsync("2");
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("3");
//    await next();
//    await context.Response.WriteAsync("4");
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("5");
//});


Configre(app);

app.Run();


















static void Configre(WebApplication app)
{
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
}

static void ConfigureServices(WebApplicationBuilder builder)
{
    // Add services to the container.
    builder.Services.AddControllersWithViews();
}