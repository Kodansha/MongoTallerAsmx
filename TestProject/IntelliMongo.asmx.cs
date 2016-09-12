using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using FluentAssertions;
using MongoDB;
using System.Xml;
using MongoDB.Driver.Builders;
using System.Text.RegularExpressions;


namespace TestProject
{
           

    [System.CodeDom.Compiler.GeneratedCodeAttribute("WSDLToWebService", "1.0.0.0")]
    [System.Web.Services.WebServiceAttribute(Namespace = "http://SoyGeek")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "SoyGeekMongo", Namespace = "http://SoyGeek")]
    [XmlRoot(DataType = "searchEntitiesResult", ElementName ="result" )]
    public class IntelliMongo : System.Web.Services.WebService
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
 
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://SoyGeek/search",
        RequestNamespace = "http://SoyGeek", ResponseNamespace = "http://SoyGeek",
        Use = System.Web.Services.Description.SoapBindingUse.Literal,
        ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Default)
        ]
        
        public string search(string searchString)
        {

            return null;

        }
    }
}