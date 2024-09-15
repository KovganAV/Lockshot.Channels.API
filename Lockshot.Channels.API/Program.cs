using Lockshot.Channels.API.Hubs;
using Lockshot.Channels.API.Services;
using Lockshot.Channels.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSignalR();

builder.Services.AddScoped<MessageService>();

var app = builder.Build();

app.MapHub<ChatHub>("/chatHub");

app.Run();
