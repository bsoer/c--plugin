using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace GDX
{
    class UploadClass
    {

        public static WebResponse MultipartFileUpload(
            string uploadfile,
            Uri uri,
            KeyValuePair<string, string> credentials,
            string fileFormName,
            NameValueCollection fields
            )
        {
            String contenttype = "multipart/form-data";

            string boundary = "--===-" + DateTime.Now.Ticks.ToString("x");
            // Build the trailing boundary string as a byte array
            byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            HttpWebRequest webrequest = createHttpWebRequestWithCredentials(uri, ref credentials, "multipart/form-data; boundary=" + boundary);

            // Build up the post messsage body
            StringBuilder header = new StringBuilder();
            foreach (string key in fields)
                createPairKeyValue(boundary, header, new KeyValuePair<string, string>(key, fields[key]));

            // Build the trailing file body
            header.AppendLine("--" + boundary);
            header.AppendLine(string.Format("Content-Disposition: multipart/form-data; name=\"{0}\"; filename=\"{1}\"",
                fileFormName, Path.GetFileName(uploadfile)));
            header.AppendLine(string.Format("Content-Type: {0}", contenttype));
            header.AppendLine();

            byte[] postHeaderBytes = Encoding.ASCII.GetBytes(header.ToString());
            FileStream fileStream = new FileStream(uploadfile, FileMode.Open, FileAccess.Read);

            // build stream
            webrequest.ContentLength = postHeaderBytes.Length
                + fileStream.Length
                + boundaryBytes.Length;

            Stream requestStream = webrequest.GetRequestStream();

            // Write out our post header
            requestStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);

            // Write out the file contents
            int bytesRead = 0;
            long webrequest_size = webrequest.ContentLength; ;
            byte[] buffer = new Byte[checked((uint)Math.Min(4096, (int)fileStream.Length))];
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                requestStream.Write(buffer, 0, bytesRead);
                MessageBox.Show("WebreqSize = " + webrequest_size + "( postHeader: " + postHeaderBytes.Length + ", fileStream: " + fileStream.Length + ", boundaryBytes: " + boundaryBytes.Length + ")");
            }

            // Write out the trailing boundary
            requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);

            return webrequest.GetResponse();

        }

        /// <summary>
        /// Create a HTTP Web Request using Credentials. The request uses basic http auth for authentication.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="credentials"></param>
        /// <param name="contentTypeWithBoundary">The content type with boundary. This is multipart/form-data; boundary=yourboundary for multipart encoding.</param>
        /// <returns>A HttpWebRequest with a set boundary and ContentType</returns>
        private static HttpWebRequest createHttpWebRequestWithCredentials(Uri uri, ref KeyValuePair<string, string> credentials,
            string contentTypeWithBoundary)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(uri);
            webrequest.PreAuthenticate = true;
            webrequest.ContentType = contentTypeWithBoundary;
            webrequest.Method = "POST";
            webrequest.Accept = "application/xml";
            webrequest.Headers[HttpRequestHeader.Authorization] = "Basic " +
            Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials.Key + ":" + credentials.Value));
            return webrequest;
        }

        /// <summary>
        /// create a content disposition section for the body of a http post from a key-value pair
        /// </summary>
        /// <param name="boundary">Boundary String</param>
        /// <param name="content">Current content of the HTTP Body</param>
        /// <param name="pair">Key-Value pair for the content disposition section</param>
        private static void createPairKeyValue(string boundary, StringBuilder content, KeyValuePair<String, String> pair)
        {
            content.AppendLine("--" + boundary);
            content.AppendLine(string.Format("Content-Disposition: form-data; name=\"{0}\"", pair.Key));
            content.AppendLine();
            content.AppendLine(pair.Value);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static string upload(NameValueCollection fields, String uploadfile, KeyValuePair<string, string> credentials)
        {
            //string uploadfile = "/test.txt";// set to file to upload

            // create key value pairs for data which should be uploaded to a form
            /*
            NameValueCollection fields = new NameValueCollection();
            fields.Add("upload[name]", "name der datei");
            fields.Add("upload[description", "Beschreibung");
            fields.Add("upload[tag_list]", "Tags");
             */

            // create credentials
            //KeyValuePair<string, string> credentials = new KeyValuePair<string, string>("philipp@gdx.org", "janjan");

            try
            {
                WebResponse responce = MultipartFileUpload(uploadfile, new Uri("http://46.252.21.47/uploads"), credentials, "upload[file]", fields);
                StreamReader sr = new StreamReader(responce.GetResponseStream());
                string result = sr.ReadToEnd();
                //Console.WriteLine(result);
                //Console.WriteLine(sr.ReadToEnd());
                return "Datei wurde erfolgreich hochgeladen.";
            }
            catch (WebException webex)
            {
                //Console.WriteLine("Unable to perform command");

                String resp_error = String.Empty;
                if (webex.Response != null)
                {
                    StreamReader r = new StreamReader(webex.Response.GetResponseStream());
                    resp_error = r.ReadToEnd();
                    if (resp_error.Contains("password"))
                    {
                        resp_error = "Benutzername oder Passwort wurden falsch eingegeben.";
                    }
                    r.Close();
                }
                //Console.WriteLine(webex.Message);
                //Console.WriteLine(data2);
                return "Fehler: " + resp_error;
            }
            //Console.ReadLine();

        }
    }
}
