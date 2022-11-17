using System.Net.Http.Headers;
using System.Xml;
using System.Xml.Linq;
using Adapter;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIadapter.Controllers;

[ApiController]
[Route("[controller]")]
public class AdapterController : ControllerBase
{

    [HttpGet(Name = "Adapter")]

    public async Task<string> GetAsync()
    {

        var cliente = new Myclient(new IlibroXMLAdapter(), new IlibroJSONAdapter());
        var xml = cliente.GetBookData();

        XmlNodeList lista = xml.GetElementsByTagName("Libros");
        XmlNodeList libros = ((XmlElement)lista[0]).GetElementsByTagName("collectionLibros");
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        foreach (System.Xml.XmlElement xEle in libros)
        {
            Console.WriteLine(xEle.OuterXml);
            if (xEle.OuterXml.Length == 0)
                sb.Append(xEle.OuterXml);
            else
                sb.Append("\r\n" + xEle.OuterXml);
        }
        return sb.ToString();
    }
}