using Microsoft.AspNetCore.Mvc;
using System.Xml;

public class ExampleController : Controller
{
    [HttpGet]
    public IActionResult Method(string user, string pass)
    {
        var doc = new XmlDocument();

        var expression = "/users/user[@name='" + user + "' and @pass='" + pass + "']";

        return Json(doc.SelectSingleNode(expression) != null);
    }
}