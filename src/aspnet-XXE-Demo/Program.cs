using Microsoft.AspNetCore.Mvc;

using System.IO;
using System.Reflection.Metadata;
using System.Xml;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/upload", async ([FromForm] IFormFile file) => {
    var filename = file.Name;
    // https://github.com/dotnet/aspnetcore/discussions/49882
    app.Logger.LogInformation(filename);

    XmlDocument xmlDoc = new XmlDocument();
    using (var stream = file.OpenReadStream()) {
        xmlDoc.Load(stream);
    }
    return await Task.FromResult(xmlDoc.OuterXml);
}).DisableAntiforgery();
//https://stackoverflow.com/questions/77189996/upload-files-to-a-minimal-api-endpoint-in-net-8

app.MapPost("/uploadvulninband", async ([FromForm] IFormFile file) => {
    var filename = file.Name;
    // https://github.com/dotnet/aspnetcore/discussions/49882
    app.Logger.LogInformation(filename);

    XmlDocument xmlDoc = new XmlDocument();
    var settings = new XmlReaderSettings {
        DtdProcessing = DtdProcessing.Parse
    };
    settings.XmlResolver = new XmlUrlResolver();

    using (var stream = file.OpenReadStream()) {
        using (var reader = XmlReader.Create(stream, settings)) {
            xmlDoc.Load(reader);
        }
    }
    return await Task.FromResult(xmlDoc.OuterXml);
}).DisableAntiforgery();

app.MapPost("/uploadvulnoutofband", async ([FromForm] IFormFile file) => {
    var filename = file.Name;
    // https://github.com/dotnet/aspnetcore/discussions/49882
    app.Logger.LogInformation(filename);

    XmlDocument xmlDoc = new XmlDocument();
    var settings = new XmlReaderSettings {
        DtdProcessing = DtdProcessing.Parse
    };
    settings.XmlResolver = new XmlUrlResolver();

    using (var stream = file.OpenReadStream()) {
        using (var reader = XmlReader.Create(stream, settings)) {
            xmlDoc.Load(reader);
        }
    }
    return await Task.FromResult(xmlDoc.OuterXml);
}).DisableAntiforgery();

app.Run();
