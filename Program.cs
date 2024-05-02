using Lvl3Week3Day2_BlogBackend.Services;
using Lvl3Week3Day2_BlogBackend.Services.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<BoardService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PasswordService>();
builder.Services.AddScoped<TaskService>();

var connectionString = builder.Configuration.GetConnectionString("MyBlogString");
builder.Services.AddDbContext<DataContext>(Options => Options.UseSqlServer(connectionString));

builder.Services.AddCors(options => options.AddPolicy("BlogPolicy", 
builder => {
    builder.WithOrigins("http://localhost:5037", "http://localhost:3000", "http://localhost:3001", "https://maddieiscool-flax.vercel.app")
    .AllowAnyHeader()
    .AllowAnyMethod();
}
));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("BlogPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
