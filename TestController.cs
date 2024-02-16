namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

//övning 3

// public class HelloWorldMessage
// {
//     public string Message {get; set;} = "";
// }

// [ApiController]
// [Route("api/test")]
// public class MyController : ControllerBase
// {
//     [HttpGet()]

//     public HelloWorldMessage SayHello()
//     {
//         HelloWorldMessage message = new HelloWorldMessage();
//         message.Message = "Hello world!";
//         return message ;
//     }
// }

// övning 4

// [ApiController]
// [Route("")]
// public class TestController : ControllerBase
// {
//     [HttpGet]
//     public ActionResult GetHtmlContent()
//     {
//         string htmlContent = "<html><body><h1>Hello, testing testning...!</h1></body></html>";
//         return Content(htmlContent, "text/html");

//         // Response.Headers.Append("Content-Type", "text/html");
//         // return "<!doctype html><html><head></head><body><h1>Welcome!</h1><script>console.log('Hello World!');</script></body></html>";
//     }
// }


// övning 5



// public class HelloWorldMessage
// {
//     public string Message {get; set;} = "";
// }

// [ApiController]
// [Route("")]
// public class TestController : ControllerBase
// {

//     [HttpGet]
//     public HelloWorldMessage Greeting([FromQuery] string name)
//     {
//         HelloWorldMessage message = new HelloWorldMessage();

//         message.Message = "Hello, " + name;
//         return message;
//     }
// }


//Övning 7


// [ApiController]
// [Route("")]
// public class TestController : ControllerBase
// {

//     [HttpGet]
//     public int Calculate([FromQuery] int a, [FromQuery] int b, [FromQuery] string value)
//     {
//         if(value == "+")
//         {
//             return a + b;
//         }
//         else if (value == "-")
//         {
//             return a - b;
//         }
//          else if (value == "*")
//         {
//             return a * b;
//         }
//          else if (value == "/")
//         {
//             return a / b;
//         }
//         else 
//         {
//             return 0;
//         }
        
//     }
// }

// Övning 9



// [ApiController]
// [Route("")]
// public class TestController : ControllerBase
// {
//     private CounterService service;
//     public TestController(CounterService service)
//     {
//         this.service = service;
//     }
//     [HttpGet]
//     public int CalculateUp()
//     {
//         return service.counter++;
//     }
// }

// public class CounterService
// {
//     public int counter = 0;
// }

//övning 10



// [ApiController]
// [Route("")]
// public class TestController : ControllerBase
// {
//     private WordService service;
//     public TestController(WordService service)
//     {
//         this.service = service;
//     }
//     [HttpPost("{word}")]
//     public List<string> Words(string word)
//     {
//         service.wordList.Add(word);
//         return service.wordList;
//     }
// }

// public class WordService
// {
//     public List<string> wordList = new List<string>();
// }