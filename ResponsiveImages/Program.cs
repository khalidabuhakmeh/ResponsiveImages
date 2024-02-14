using Microsoft.AspNetCore.StaticFiles;
using Westwind.AspNetCore.Markdown;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddMarkdown();

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

app.Run();