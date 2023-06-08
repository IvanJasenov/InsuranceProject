using InsuraceProject.API.Proxy;
using InsuraceProject.API.Repository;
using InsuraceProject.API.Repository.RepoInterfaces;
using InsuraceProject.Context;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// enable serilog log
builder.Host.UseSerilog();
// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service registration

// register DbContext
builder.Services.AddDbContext<AuditContext>();
builder.Services.AddScoped<IClaimProxy, ClaimProxy>();
builder.Services.AddScoped<IClaimAuditRepository, ClaimAuditRepository>();
builder.Services.AddScoped<ICoverAuditRepository, CoverAuditRepositiry>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
