using NUnit.Framework;
using System;

namespace Api_tests
{
    public class Tests
    {
            string adress = Data.adress;
            string key = Data.key;
            string ogrn = Data.ogrn;
            Uri myUri = null;

            [Test]
            [Description("Запрос информации по компании")]
            public void GetCompany()
            {
                myUri = new Uri(adress + "company?key=" + key+ "&ogrn="+ogrn);
                string json = Methods.MethodGet(myUri);
                Console.WriteLine(json);
            }
    }
}