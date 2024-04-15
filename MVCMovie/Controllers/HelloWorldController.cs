using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;


namespace MVCMovie;

public class HelloWorldController:Controller
{
    public IActionResult Index(){
        return View();
    }

    public IActionResult Welcome(string name, int numTimes= 1){
        
        //ViewData is dynamic dictionary 
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
