using AutoMapper.Extensions.ExpressionMapping;
using log4net.Config;
using log4net;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PAUYS.AspNetCore.API.Services;
using PAUYS.BLL.Managers.Abstract;
using PAUYS.BLL.Managers.Concrete;
using PAUYS.DAL.Context;
using PAUYS.DAL.Repositories.Abstract;
using PAUYS.DAL.Repositories.Concrete;
using PAUYS.DAL.Services.Abstract;
using PAUYS.DAL.Services.Concrete;
using PAUYS.DAL.UnýtOfWorks;
using PAUYS.Entity.Entities.Concrete;
using System.Reflection;
using System.Text;
using PAUYS.WebApi.ActionFilters__;


var builder = WebApplication.CreateBuilder(args);

// Log4Net yapýlandýrmasý
var logRepository = LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
var logConfigFile = new System.IO.FileInfo(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config"));
XmlConfigurator.Configure(logRepository, logConfigFile);

// Örnek bir log mesajý
var logger = LogManager.GetLogger(typeof(Program));
logger.Info("Uygulama baþlatýldý.");


// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);//.AddNewtonsoftJson();

builder.Services.AddDbContext<PAUYSDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
});
// Servisleri ekleyin
builder.Services.AddControllersWithViews(options =>
{
    // Global olarak Log4NetActionFilter'ý ekliyoruz
    options.Filters.Add(new Log4NetActionFilter());
});

builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<PAUYSDbContext>()
                .AddDefaultTokenProviders();
// JWT Authentication Kodlarý
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = builder.Configuration["JWTSettings:Issuer"],
        ValidAudience = builder.Configuration["JWTSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWTSettings:SecretKey"])), //"çok-gizli-bir-þifre-olarak-bunu-yazdým"))
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.OperationFilter<FileUploadOperationFilter>();
//});
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "PAUYS API", Version = "v1" });

    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Lutfen token degerini giriniz.",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });

    opt.AddSecurityRequirement(new OpenApiSecurityRequirement{
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

builder.Services.AddScoped<ITokenService, JwtTokenService>();

builder.Services.AddScoped<RoleManager<IdentityRole>>();

builder.Services.AddAutoMapper(cfg =>
{
    #region DLL olarak assembly dosyasýný almak
    //string baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    //string assemblyPath = Path.Combine(baseDirectory, "BookStore.Mapping.dll");
    //Assembly bookStoreMappingLibrary = Assembly.LoadFrom(assemblyPath); 
    #endregion

    #region Proje Referansý isminde assembly dosyasý almak
    Assembly PAUYSMappingLibrary = Assembly.Load("PAUYS.Mapping");
    #endregion

    cfg.AddExpressionMapping().AddMaps(PAUYSMappingLibrary);
});

// Reposityoies Add Service
builder.Services.AddScoped<IMaterialRepository, MaterialRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IBlogRepository, BlogRepository>();
builder.Services.AddScoped<INewsRepository, NewsRepository>();
builder.Services.AddScoped<ICustomerRequestRepository, CustomerRequestRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IPackingGuideRepository, PackingGuideRepository>();


// UnitOfWork Add Service
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// DalService Add Service
builder.Services.AddScoped<IMaterialDalService, MaterialDalService>();
builder.Services.AddScoped<ICategoryDalService, CategoryDalService>();
builder.Services.AddScoped<IProductDalService, ProductDalService>();
builder.Services.AddScoped<IBlogDalService, BlogDalService>();
builder.Services.AddScoped<INewsDalService, NewsDalService>();
builder.Services.AddScoped<ICustomerRequestDalService, CustomerRequestDalService>();
builder.Services.AddScoped<IQuestionDalService, QuestionDalService>();
builder.Services.AddScoped<IPackingGuideDalService, PackingGuideDalService>();

// Manager Add Service
builder.Services.AddScoped<IMaterialManager, MaterialManager>();
builder.Services.AddScoped<ICategoryManager, CategoryManager>();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddScoped<IBlogManager, BlogManager>();
builder.Services.AddScoped<INewsManager, NewsManager>();
builder.Services.AddScoped<ICustomerRequestManager, CustomerRequestManager>();
builder.Services.AddScoped<IQuestionManager, QuestionManager>();
builder.Services.AddScoped<IPackingGuideManager, PackingGuideManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();