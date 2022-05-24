var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseStatusCodePages("text/plain","An error occured.Status code: {0}"); //method1 for httpstatuscode error handling
    app.UseStatusCodePages(async context =>
    {
        context.HttpContext.Response.ContentType = "text/plain";
        await context.HttpContext.Response.WriteAsync($"An error occured.Status Code:{context.HttpContext.Response.StatusCode}");//method2  for httpstatuscode error handling
    });
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
