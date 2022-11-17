using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    class Myclient
    {
        private IlibroXMLTarget _libroXmlTarget;
        private IlibroJSONOrigin _libroJSONOrigin;

        public Myclient(IlibroXMLTarget libroXmlTarget, IlibroJSONOrigin libroJSONOrigin)
        {
            _libroXmlTarget = libroXmlTarget;
            _libroJSONOrigin = libroJSONOrigin;
        }

        public XmlDocument GetBookData()
        {
            return _libroXmlTarget.GetLibrosXMLSpecifications(_libroJSONOrigin);
        }
    }
}