using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Sobas_Mob_Web;
using Sobas_Mob_Web.Models;
using Sobas_Mob_Web.TestModels;
using System;
using System.Security.Cryptography;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


if (builder.Environment.IsDevelopment())
{

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter JWT Token"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
   {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
   });
});
}

//Live DB
builder.Services.AddDbContext<CommonDB_TestDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Test Db
//builder.Services.AddDbContext<TestCommonDB_TestDbContext>(options =>
 //  options.UseSqlServer(builder.Configuration.GetConnectionString("TestDefaultConnection")));




builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .WithOrigins()
            .AllowAnyHeader()
            .AllowAnyMethod());

});
// token generate
// read key from appsettings.json
var jwtKey = builder.Configuration["Jwt:Key"];

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],

        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(jwtKey))
    };
});

builder.Services.AddAuthorization();


var app = builder.Build();


if (app.Environment.IsDevelopment())  // unCommand for Development
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.Map("/swagger", builder =>
{
    builder.Run(async context =>
    {
        context.Response.StatusCode = 404;
        await context.Response.WriteAsync("Not Found");
    });
});


//if (!app.Environment.IsDevelopment())    // Un Command for publish
//{
//    app.Use(async (context, next) =>
//    {
//        if (context.Request.Path.StartsWithSegments("/swagger"))
//        {
//            context.Response.StatusCode = 404;
//            return;
//        }

//        await next();
//    });
//}



if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


//app.UseHttpsRedirection();
app.UseRouting();
app.UseMiddleware<MobileAppMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseCors("AllowAll");

//app.MapGet("/ping", () => "PING OK");

//app.MapGet("/", () => Results.Redirect("/swagger"))
//   .ExcludeFromDescription();


app.Run();
