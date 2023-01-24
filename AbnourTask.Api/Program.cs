using AbnourTask.Ef;
using Common.AssemplyScanning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddInstallerFromAssembly<Program>(builder.Configuration);
builder.Services.AddInstallerFromReferancedAssemblies(builder.Configuration, typeof(Program).Assembly, "*.Server.dll");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    options
        .UseSqlServer(connectionString, builder => builder.MigrationsAssembly("AbnourTask.EF"))
        .EnableDetailedErrors()
        .EnableSensitiveDataLogging()
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddScoped<DbContext, ApplicationDbContext>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                   .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})


// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
    };
});

builder.Services.AddAutoMapper(typeof(Program).Assembly,
    typeof(Customer).Assembly,
    typeof(Sale).Assembly,
    typeof(Order).Assembly);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
