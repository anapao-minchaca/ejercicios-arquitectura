using System.Collections.Generic;
using System.Xml;
using APIadapter;
using APIadapter.Controllers;
using Newtonsoft.Json;

namespace Adapter
{
    class IlibroJSONAdapter : IlibroJSONOrigin
    {
        public string GetLibrosXMLSpecifications()
        {
            List<Libro> libros = new List<Libro>();

            libros.Add(new Libro
            {
                codigo = "12345",
                autor = "Miso Flakes",
                titulo = "Cocina 101",
                editorial = "Staydom"
            });
            libros.Add(new Libro
            {
                codigo = "56789",
                autor = "Miso Ramsey",
                titulo = "Afterglow",
                editorial = "Bimbo"
            });

            conector c = new conector ();
            dynamic t = c.getDataAsync().Result;
            var tt = JsonConvert.DeserializeObject<List<WeatherForecast>>(t);

            dynamic collectionLibros = new { collectionLibros = tt };
            return JsonConvert.SerializeObject(collectionLibros);
        }
    }
    class IlibroXMLAdapter : IlibroXMLTarget
    {
        public XmlDocument GetLibrosXMLSpecifications(IlibroJSONOrigin libroJSONAdapter)
        {
            string jsonLibro = libroJSONAdapter.GetLibrosXMLSpecifications();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonLibro, "Libros", true);
            return doc;
        }
    }
}