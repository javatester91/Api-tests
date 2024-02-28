using Api_tests.JsonClasses;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace Api_tests
{
    public class Tests
    {
        string adress = Data.adress;
        Uri myUri = null;
        
        [Test]
        [Description("Запрос информации по компании")]
        public void GetUser()
        {
            myUri = new Uri(adress + "users/1");
            string json = Methods.MethodGet(myUri);
            var result = JsonConvert.DeserializeObject<GetUsers>(json);
            Assert.That(result!.Data.Id, Is.EqualTo(Data.user_id));
            Assert.That(result.Data.Email, Is.EqualTo(Data.user_email));
            Assert.That(result.Data.first_name, Is.EqualTo(Data.user_first_name));
            Assert.That(result.Data.last_name, Is.EqualTo(Data.user_last_name));
            //Assert.That(Data.user_avatar, Is.EqualTo(result.Data.Avatar));
            Assert.That(result.Support.Text, Is.EqualTo(Data.support_text));

            Console.WriteLine(json);
        }
    }
}