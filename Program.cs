var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpClient<EdutotsSchools.Services.SchoolDirectoryService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["EdutotsApi:SchoolsEndpoint"]!);
    client.Timeout = TimeSpan.FromSeconds(30);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseAntiforgery();
app.MapRazorComponents<EdutotsSchools.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
