using CoPilot.Models;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace CoPilot.Controllers;

[ApiController]
[Route("[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class UserController : ControllerBase
{
    // Simulates a Read operation
    [HttpGet]
    public User Read(Guid id) => new()
    {
        Id = id,
        FirstName = "John",
        LastName = "Doe",
        Username = "jdoe",
        Email = "john.doe@email.com"
    };
    
    // Remaining Create, Update, Delete, and List operations based on the model.
}