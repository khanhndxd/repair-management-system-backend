global using repair_management_backend.Models;
global using repair_management_backend.DTOs;
global using repair_management_backend.Data;
global using Microsoft.EntityFrameworkCore;
global using repair_management_backend.Configuration;
global using repair_management_backend.Repositories.Auth;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using repair_management_backend.Repositories.RepairOrderRepo;
using repair_management_backend.Repositories.StatusRepo;
using repair_management_backend.Repositories.RepairTypeRepo;
using repair_management_backend.Repositories.RepairReasonRepo;
using repair_management_backend.Repositories.TaskRepo;
using repair_management_backend.Repositories.AccessoryRepo;
using repair_management_backend.Repositories.CustomerRepo;
using repair_management_backend.Repositories.PurchaseOrderRepo;
using repair_management_backend.Repositories.RepairAccessoryRepo;
using repair_management_backend.Repositories.RepairProductRepo;
using repair_management_backend.Repositories.TokenRepo;
using repair_management_backend.Repositories.RepairTask;
using repair_management_backend.Repositories.RepairCustomerProductRepo;
using repair_management_backend.Repositories.CustomerProductRepo;
using repair_management_backend.Hubs;
using repair_management_backend.Repositories.RepairLogRepo;
using repair_management_backend.Repositories.UserRepo;
using repair_management_backend.Repositories.WarrantyPolicyTaskRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IRepairOrderRepository, RepairOrderRepository>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<IRepairTypeRepository, RepairTypeRepository>();
builder.Services.AddScoped<IRepairReasonRepository, RepairReasonRepository>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<IAccessoryRepository, AccessoryRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
builder.Services.AddScoped<IRepairAccessoryRepository, RepairAccessoryRepository>();
builder.Services.AddScoped<IRepairProductRepository, RepairProductRepository>();
builder.Services.AddScoped<IRepairTaskRepository, RepairTaskRepository>();
builder.Services.AddScoped<IRepairCustomerProductRepository, RepairCustomerProductRepository>();
builder.Services.AddScoped<ICustomerProductRepository, CustomerProductRepository>();
builder.Services.AddScoped<ITokenRepository, TokenRepository>();
builder.Services.AddScoped<IRepairLogRepository, RepairLogRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IWarrantyPolicyTaskRepository, WarrantyPolicyTaskRepository>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(jwt =>
{
    var key = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtConfig:Secret").Value!);
    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        RequireExpirationTime = true,
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.AllowedUserNameCharacters = "";
    options.User.RequireUniqueEmail = true;

    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<DataContext>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("FullControlPolicy", policy =>
    {
        policy.RequireRole("Admin");
    });
    options.AddPolicy("ReadWritePolicy", policy =>
    {
        policy.RequireRole("Admin", "Creator", "Receiver", "Technician");
    });
    options.AddPolicy("NotTechnicianPolicy", policy =>
    {
        policy.RequireRole("Admin", "Creator", "Receiver");
    });
});

builder.Services.AddControllers();
builder.Services.AddCors(c =>
{
    c.AddPolicy("CorsPolicy", builder =>
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
    //.SetIsOriginAllowed(_ => true)
    //.AllowCredentials()); 
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(x => x
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true) // allow any origin
        .AllowCredentials()); // allow credentials
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapHub<NotificationHub>("/notification");

app.Run();
