using Microsoft.EntityFrameworkCore;
using BibliotecaPublica.API.Helper.DB;
using BibliotecaPublica.API.Services;
using BibliotecaPublica.API.Helper;
using BibliotecaPublica.API.Helper.DB.DBData;

var builder = WebApplication.CreateBuilder(args);


string MyAllowSpecificOrigins = "http://localhost:4200/";
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DbContextSeed>(option =>
{
    option.UseInMemoryDatabase("BibliotecaPublica");
    //option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:4200/");
                      });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IDtoToEntity, DtoToEntity>();
builder.Services.AddScoped<IEntityToDto, EntityToDto>();
builder.Services.AddTransient<DBData>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

IServiceScopeFactory scopeFactory = app.Services.GetService<IServiceScopeFactory>();
using (IServiceScope scope = scopeFactory.CreateScope())
{
    DBData seeder = scope.ServiceProvider.GetService<DBData>();
    seeder.seedDBAsync();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
