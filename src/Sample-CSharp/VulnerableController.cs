using Microsoft.AspNetCore.Mvc;
using System.Xml;

public class ExampleController : Controller
{

    public void x()
    {

    }


    [HttpGet]
    public IActionResult Authenticate(string user, string pass)
    {
        var doc = new XmlDocument();

        var expression = "/users/user[@name='" + user + "' and @pass='" + pass + "']";

        return Json(doc.SelectSingleNode(expression) != null);
    }
}