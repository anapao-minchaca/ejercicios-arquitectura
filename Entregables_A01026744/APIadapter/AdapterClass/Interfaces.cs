using System.Xml;

namespace Adapter
{
    interface IlibroJSONOrigin
    {
        String GetLibrosXMLSpecifications();
    }
    interface IlibroXMLTarget
    {
        XmlDocument GetLibrosXMLSpecifications(IlibroJSONOrigin librosJSONAdapter);
    }

}