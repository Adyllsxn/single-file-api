#region Dependencies
    #:sdk Microsoft.NET.Sdk.Web
    #:package Swashbuckle.AspNetCore@6.6.2
#endregion

#region Builder & Services
    var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
#endregion

#region Application
    var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = string.Empty;
        });
        app.MapGet("/", () => "Hello, world!");
        app.Run();
#endregion