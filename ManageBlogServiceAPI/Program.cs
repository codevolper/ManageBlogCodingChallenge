using ManageBlogServiceCore.Application.Interfaces;
using ManageBlogServiceCore.Application.Services;
using ManageBlogServiceCore.Domain.Interfaces;
using ManageBlogServiceInfrastructure.DataContext;
using ManageBlogServiceInfrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependecy Injection
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddSingleton<InMemoryBlogPostRepository>();
builder.Services.AddSingleton<InMemoryBlogCommentRepository>();
// End Dependecy Injection

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
