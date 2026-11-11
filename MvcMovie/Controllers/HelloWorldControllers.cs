using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers;
using System.Text.Encodings.Web;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return "This is my defoult action...";
    }
    public string Welcome(string name, int numTimes=1)
    {
        return HtmlEncoder.Default.Encode($"Hello, {name},NumTimes is: {numTimes}");
    }
}