using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace aspnet_XXE_Demo_net48.Controllers
{
    public class XmlController : ApiController
    {
        // POST api/xml
        public HttpResponseMessage Post()
        {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;

            if (httpRequest.Files.Count > 0) {
                XmlDocument xmlDoc = new XmlDocument();
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files) {
                    var postedFile = httpRequest.Files[file];
                    
                    using (var stream = postedFile.InputStream) {
                        xmlDoc.Load(stream);
                    }
                }
                result = Request.CreateResponse(HttpStatusCode.Created, xmlDoc.OuterXml);
            }
            else {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return result;
        }

        // POST api/xml
        [HttpPost]
        [Route("api/xml/vulninband")]
        public HttpResponseMessage vulninband() {
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;

            var settings = new XmlReaderSettings {
                DtdProcessing = DtdProcessing.Parse,
            };
            settings.XmlResolver = new XmlUrlResolver();

            if (httpRequest.Files.Count > 0) {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.XmlResolver = new XmlUrlResolver();
                var docfiles = new List<string>();
                foreach (string file in httpRequest.Files) {
                    var postedFile = httpRequest.Files[file];

                    using (var stream = postedFile.InputStream) {
                        using (var reader = XmlReader.Create(stream, settings)) {
                            xmlDoc.Load(reader);
                        }
                    }
                }
                result = Request.CreateResponse(HttpStatusCode.Created, xmlDoc.OuterXml);
            }
            else {
                result = Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return result;
        }
    }
}
