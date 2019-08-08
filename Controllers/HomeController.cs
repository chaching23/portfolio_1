using Microsoft.AspNetCore.Mvc; 
namespace HellASp

{
    public class HomeController: Controller
    {
        // Requests
        // localhost:5000/
        [HttpGet("")]
    
        public string index()
        {
            return "hello From Controller";
        }



        // localhost:5000/hello
        [HttpGet("hello")]
     
        public string Hello()
        {
            return "Hi again!";
        }

       // localhost:5000/users/???
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "chicago")
                return $"Hello {username} from {location}. Go Bears!";
            return $"Hello {username} from {location}";
        }


    }
}