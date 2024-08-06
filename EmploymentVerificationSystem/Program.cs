using EmploymentVerification.Business.IServices;
using EmploymentVerification.Business.Services;
using EmploymentVerification.Data.CoreServices;
using EmploymentVerification.Data.ICoreServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
        //WithOrigins("https://localhost:44336") 
               .AllowAnyHeader()
               .WithMethods("POST");
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IVerifyEmploymentService, VerifyEmploymentService>();
builder.Services.AddScoped<ICoreVerifyEmploymentService, CoreVerifyEmploymentService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CustomCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
