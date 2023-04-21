using DbAccess;
using GameIndustry_v2.Data;
using GameIndustry_v2.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Tewr.Blazor.FileReader;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration["ConnectionStrings:DbConnection"], new MySqlServerVersion(new Version(8, 0, 25)),
        options => options.EnableRetryOnFailure())
);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddAntDesign();
builder.Services.AddScoped<IRepository, SqlGameRepository>();
//builder.Services.AddSingleton<IRepository, MockGamesRepository>();
//���� � ��� �� ���������� ���� ���������  ����� �������� ����� ����
//-�� ��� ��� �� ����������   � ������� IRepository, �������� AddTransient �� AddSingletone ,�������


//�� ����� ��� ������, ��� Singleton ������ ���� ��������� ������� �� ����.
//������ �������� ������ � ������� � ������. �� ���������, ��� � ���� ����������� ����� ����, � ��� ������, �� �������� ������� ������ 
//��� �� ���������. ������� ������ ��������� ������ �� ��������� ���� ������ �� ���� � �� ����� ������������.

//�� �� �� "��������� ��" � �������� ����� �� �� ���������� � ���, � ����� �� ���� ���, �
//������ ����� ��� ��� � ��� � � ���� �� ������������ ����� ���� ,� ��������� ���������, � ������ ������� � ����� ��� �� ������
//��� �������� "5��" ���  �� ����� ����������� � �����  "��" �� ��� �� ��������� ������������ ���������,� ������ ����� �� 4 ��������...
builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
