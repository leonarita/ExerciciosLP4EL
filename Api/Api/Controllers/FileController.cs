using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace Api.Controllers
{
    public class FileController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage upload()
        {
            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            try
            {
                foreach (string fileName in HttpContext.Current.Request.Files.Keys)
                {
                    var file = HttpContext.Current.Request.Files[fileName];
                    file.SaveAs("C:\\Teste\\" + file.FileName);
                }

                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public HttpResponseMessage download(string filename)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);

            response.Content = new StreamContent(new FileStream("C:\\Teste\\" + filename, FileMode.Open));
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            response.Content.Headers.Add("Content-Disposition", "attachment; filename=" + filename);
                
            return response;
        }

    }
}

