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
        int id = Data.user_id;

        int pageList= Data.pageList;

        [Test]
        [Description("Запрос информации по клиенту")]
        public void GetUser()
        {
            myUri = new Uri(adress + "users/"+ id);
            string json = Methods.GetRequest(myUri);
            var result = JsonConvert.DeserializeObject<GetUsers>(json);
            Assert.That(result!.Data.Id, Is.EqualTo(Data.user_id));
            Assert.That(result.Data.Email, Is.EqualTo(Data.user_email));
            Assert.That(result.Data.first_name, Is.EqualTo(Data.user_first_name));
            Assert.That(result.Data.last_name, Is.EqualTo(Data.user_last_name));
            Assert.That(result.Data.avatar, Is.EqualTo(Data.user_avatar));
            Assert.That(result.Support.Text, Is.EqualTo(Data.support_text));
        }

        [Test]
        [Description("Запрос информации по списку клиенту")]
        public void GetUserList()
        {
            myUri = new Uri(adress + "users?page="+ pageList);
            string json = Methods.GetRequest(myUri);
            var status = Methods.StatusGetRequest(myUri);
            Assert.That(status.ToString(), Is.EqualTo("OK"));
            var result = JsonConvert.DeserializeObject<GetUsersList>(json);
            Assert.That(result!.page, Is.EqualTo(Data.pageList));
            Assert.That(result.per_page, Is.EqualTo(Data.per_page));
            Assert.That(result.total, Is.EqualTo(Data.pageTotal));
            Assert.That(result.total_pages, Is.EqualTo(Data.total_pages));

            Assert.That(result.Data[0].id, Is.EqualTo(Data.user_id));
            Assert.That(result.Data[0].email, Is.EqualTo(Data.user_email));
            Assert.That(result.Data[0].first_name, Is.EqualTo(Data.user_first_name));
            Assert.That(result.Data[0].last_name, Is.EqualTo(Data.user_last_name));
            Assert.That(result.Data[0].avatar, Is.EqualTo(Data.user_avatar));
            Assert.That(result.Support.Text, Is.EqualTo(Data.support_text));
        }

        [Test]
        [Description("Запрос на создание клиента")]
        public void CreateUser()
        {
            myUri = new Uri(adress + "users");
            string json = Methods.PostRequest(myUri);
            var result = JsonConvert.DeserializeObject<CreateUser>(json);
            var status = Methods.StatusPostRequest(myUri);
            Assert.That(status.ToString(), Is.EqualTo("OK"));
            Assert.That(result!.name, Is.EqualTo(Data.new_user_first_name));
            Assert.That(result.job, Is.EqualTo(Data.new_user_job));
        }

    }
}