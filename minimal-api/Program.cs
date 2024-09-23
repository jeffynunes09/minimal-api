using minimal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");




app.MapPost("/login", (LoginDTO loginDto) => {


 if(loginDto.Email == "adm@teste.com" && loginDto.Senha == "12345678"){
   
   return Results.Ok("Login feito com sucesso!");
 }
 else{

   return Results.Unauthorized();
 }
});



app.Run();



