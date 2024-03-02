using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Api_tests
{
    public class Methods
    {
        // Получение статуса Get запроса
        // На вход принимает URl запроса
        // Возвращает StatusCode запроса
        public static HttpStatusCode StatusGetRequest(Uri myUri)
        {
            try
            {
                WebRequest myWebRequest = HttpWebRequest.Create(myUri);
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

                myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

                HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();

                return response.StatusCode;
            }
            catch (WebException ex)
            {
                var resp = (HttpWebResponse)ex.Response;
                Console.WriteLine(resp.StatusCode);
                return resp.StatusCode;
            }
        }

        // Get запрос
        // На вход принимает URl запроса
        // Возвращает Json в формате string
        public static string GetRequest(Uri myUri)
        {
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

            myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            WebResponse myWebResponse = myWebRequest.GetResponse();

            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream);
            string json = myStreamReader.ReadToEnd();

            responseStream.Close();
            myWebResponse.Close();

            return json;
        }

        // Получение статуса Post запроса
        // На вход принимает URl запроса
        // Возвращает StatusCode запроса
        public static HttpStatusCode StatusPostRequest(Uri myUri)
        {
            try
            {
                WebRequest myWebRequest = HttpWebRequest.Create(myUri);
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

                myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

                HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
                myHttpWebRequest.Method = "POST";

                return response.StatusCode;
            }
            catch (WebException ex)
            {
                var resp = (HttpWebResponse)ex.Response;
                Console.WriteLine(resp.StatusCode);
                return resp.StatusCode;
            }
        }

        // Post запрос
        // На вход принимает URl запроса
        // Возвращает Json в формате string
        public static string PostRequest(Uri myUri)
        {
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

            myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "application/json";
            using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
            {
                string jsonBody = JsonConvert.SerializeObject(new
                {
                    name = "Kir",
                    job = "QA"
                });

                streamWriter.Write(jsonBody);
            }

            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream);
            string json = myStreamReader.ReadToEnd();

            responseStream.Close();
            myWebResponse.Close();

            Console.WriteLine(json);

            return json;
        }

        // Получение статуса Post запроса
        // На вход принимает URl запроса
        // Возвращает StatusCode запроса
        public static HttpStatusCode StatusPutRequest(Uri myUri)
        {
            try
            {
                WebRequest myWebRequest = HttpWebRequest.Create(myUri);
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

                myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

                HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse();
                myHttpWebRequest.Method = "PUT";

                return response.StatusCode;
            }
            catch (WebException ex)
            {
                var resp = (HttpWebResponse)ex.Response;
                Console.WriteLine(resp.StatusCode);
                return resp.StatusCode;
            }
        }

        // Post запрос
        // На вход принимает URl запроса
        // Возвращает Json в формате string
        public static string PutRequest(Uri myUri)
        {
            WebRequest myWebRequest = HttpWebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;

            myHttpWebRequest.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            myHttpWebRequest.Method = "PUT";
            myHttpWebRequest.ContentType = "application/json";
            using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
            {
                string jsonBody = JsonConvert.SerializeObject(new
                {
                    name = "Lee",
                    job = "Auto QA"
                });

                streamWriter.Write(jsonBody);
            }

            WebResponse myWebResponse = myWebRequest.GetResponse();
            Stream responseStream = myWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(responseStream);
            string json = myStreamReader.ReadToEnd();

            responseStream.Close();
            myWebResponse.Close();

            Console.WriteLine(json);

            return json;
        }
    }
}
