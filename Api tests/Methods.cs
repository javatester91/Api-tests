using NUnit.Framework;
using System.Net;
using System.Text;

namespace Api_tests
{
    public class Methods
    {
        // Запрос для получения информации о компании
        // На вход принимает URl запроса
        // Возвращает Json в формате string
        public static string MethodGet(Uri myUri)
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
    }
}
