using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StorageDemo.Controllers;


[ApiController]
public class FIleController : ControllerBase
{

    //private string _connstr = "DefaultEndpointsProtocol=https;AccountName=testdocstoragehvp;AccountKey=/lCSnq9A9HrJPu4OU/UeT/n7EKwrQo7ciWfVkKSSs+R0r5mF9YkcAyiz/hFxsEWE6m6l8ZknhmAf+AStkJS7Tg==;EndpointSuffix=core.windows.net";
    //ConfigurationBuilder configuration = new ConfigurationBuilder();
    public readonly IConfiguration _configuration;
    public FIleController(IConfiguration configuration)
    {
        _configuration = configuration;
    }


[Route("fileUpload")]
    [HttpPost]
    public async Task<IActionResult> UploadFile(IList<IFormFile> files)
    {
        string storageConnStr = _configuration.GetConnectionString("Storage");
        BlobContainerClient blobContainerClient = new BlobContainerClient(storageConnStr, "demo");
        foreach (IFormFile file in files)
        {
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                stream.Position = 0;
                await blobContainerClient.UploadBlobAsync($"folder1/{file.FileName}", stream);
            }
        }
        return Ok("Files Uploaded successfully");
    }
}
