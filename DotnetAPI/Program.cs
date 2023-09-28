using DotnetAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//внедрение зависмостей
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("SqlLiteDB")));
//создал контекст и зарегистрировал его
var app = builder.Build(); //этап сборки


//----------------------------------------------


app.UseHttpsRedirection();//перенаправление на конечные точки
app.Run();//запуск