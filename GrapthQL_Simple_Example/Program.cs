using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GrapthQL_Simple_Example;
using GrapthQL_Simple_Example.GraphQL;
using GrapthQL_Simple_Example.GraphQL.GraphQLSchema;
using GrapthQL_Simple_Example.Repositories;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

//GraphQl Configs
builder.Services.AddScoped<AppSchema>();
builder.Services.AddGraphQL()
        .AddSystemTextJson()
        .AddGraphTypes(typeof(AppSchema), ServiceLifetime.Scoped);

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.AllowSynchronousIO = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

//GraphQL
app.UseGraphQL<AppSchema>();
app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());

app.MapControllers();

app.Run();
