using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_tests
{
    public class Data
    {
        public static string adress = "https://reqres.in/api/";

        public static int user_id = 1;

        public static string user_email = "george.bluth@reqres.in";
        
        public static string user_first_name = "George";

        public static string user_last_name = "Bluth";

        public static string user_avatar = "https://reqres.in/img/faces/1-image.jpg";

        public static string support_text = "To keep ReqRes free, contributions towards server costs are appreciated!";

        public static int pageList = 1;
        public static int per_page = 6;
        public static int pageTotal = 12;
        public static int total_pages = 2;

        public static string new_user_first_name = "Kir";
        public static string new_user_job = "QA";

        public static string update_user_first_name = "Lee";
        public static string update_user_job = "Auto QA";
    }
}
