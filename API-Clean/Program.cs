using Application.Repository;
using Infrastructure.Persistence;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;


var builder = WebApplication.CreateBuilder(args);
var MyAllowOrigins = "MyAllowOrigins";

var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

builder.Services.AddCors(options =>
{
    //cors policy comment add
    options.AddPolicy(name: MyAllowOrigins,
        policy =>
        {
            Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder corsPolicyBuilder = policy.WithOrigins(allowedOrigins)
                       .AllowAnyHeader()
                       .AllowAnyMethod()
                        .AllowCredentials();
        });
});

builder.Services.AddControllers();

builder.Services.AddDistributedMemoryCache(); // Add this line

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true;                 // Only accessible via HTTP
    options.Cookie.IsEssential = true;              // Essential for GDPR compliance
});
builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();
//builder.Services.AddScoped<IModuleRepository, ModulesRepository>();


//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("Infrastructure") // 👈 মাইগ্রেশন যাবে Infrastructure প্রোজেক্টে
    ));

//builder.Services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
//{
//    var httpContextAccessor = serviceProvider.GetService<IHttpContextAccessor>(); // Get HttpContextAccessor
//    var configuration = serviceProvider.GetService<IConfiguration>(); // Get Configuration

//    var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>();
//    var applicationDbContext = new ApplicationDbContext(dbContextOptions.Options, configuration, httpContextAccessor); // Inject the HttpContextAccessor into the DbContext
//});
builder.Services.AddHttpClient();


IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "HRMS API CLEN", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });


    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,
        //ValidAudience = builder.Configuration["Jwt:Audience"],
        //ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

//builder.Services.AddSingleton<IAttendanceProgress, AttendanceProgressServiceTest>();


//builder.Services.AddScoped<IUserRepository, UserRepository>();

//builder.Services.AddSingleton<IConverter>(new SynchronizedConverter(new PdfTools()));
//builder.Services.AddScoped<IPdfGenerator, DinkPdfGenerator>();

// Add your custom repository

//builder.Services.Configure<IncremetPersDTO>(builder.Configuration.GetSection("CustomPersAdd"));

builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = 104857600; // 100 MB
});

builder.Services.Configure<KestrelServerOptions>(options =>
{
    options.Limits.MaxRequestBodySize = 104857600; // 100 MB
});
//add signalR
builder.Services.AddSignalR();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddMemoryCache();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(MyAllowOrigins);
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseSession();
app.UseRouting();

//app.UseMiddleware<TimestampMiddleware>();

app.Use(async (context, next) =>
{
    context.Response.Headers.Remove("Cache-Control");
    context.Response.Headers.Remove("Pragma");
    context.Response.Headers.Remove("Expires");

    context.Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
    context.Response.Headers["Pragma"] = "no-cache";
    context.Response.Headers["Expires"] = "0";

    Console.WriteLine("Custom cache-control middleware executed and headers set!"); // Debugging
    await next();
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
