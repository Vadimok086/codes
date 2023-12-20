public void ConfigureServices(IServiceCollection services)
{
    services.AddHttpContextAccessor();

    services.AddSingleton<AppState>();
}
{

    services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{

    app.UseSession();

}
