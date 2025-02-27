using BusinessLayer.Service;
using RepositoryLayer.Service;

var builder = WebApplication.CreateBuilder(args);//intilize as web app lis platfrm p chalega kya kya hogaa

// Add services to the container.

builder.Services.AddControllers();//adding functinalities
builder.Services.AddScoped<RegisterHelloBL>();
builder.Services.AddScoped<RegisterHelloRL>();


var app = builder.Build();//build

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();//convert http to https

app.UseAuthorization();//for authorization and authentication

app.MapControllers();//kn sa controller kaha map hoga uspe kya run hogaaa 

app.Run();

// 3 layer architec
//controller
//bussiness (to change in data) logic like add create dlt
//repositry layer(database connection code)


//ioc controlller
//addscope addtransient addsingleton