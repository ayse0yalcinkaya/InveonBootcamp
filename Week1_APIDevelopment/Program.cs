using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
//derste yaptýðýmýz gibi yapmaya çalýþtým ama çalýþmadý o yüzden bunu deniyorum
//swagger ekleme
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

builder.Services.AddControllers();

var app = builder.Build();

//swagger aktif
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
    });
}

app.UseAuthorization();
app.MapControllers();

app.Run();
