// a controller is a c# class that handles http requests and produces http responses
// a controller provides the code to handle that request


/*
Client
  ↓
HTTP Request
  ↓
ASP.NET Core
  ↓
Controller
  ↓
Method
  ↓
HTTP Response
  ↓
Client

*/


// a controller can contain methods handling these different operations
// these methods are called action methods or actions.
using Microsoft.AspNetCore.Mvc;

[ApiController] // an attribute that tells asp.net to treat this class as an api controller and apply api specific behavior
[Route("api/[controller]")] // defines route path for the controller, controller is replaced based on the controller name
public class StudentController : ControllerBase // provides functionality useful for api controllers, provides useful methods like BadRequest(), NotFound(), Ok(), Created()
{
    // [HttpGet] // this action helps the html get requests
    // public string GetStudents()
    // {   
    //     return "here are the students";
    // }

    // [HttpPost] // for html post, others are put and delete
    // public string CreateStudent()
    // {
    //     return "student created";
    // }


    private readonly AppDbContext _db;
    public StudentController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        
    }
}