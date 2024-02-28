using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api_tests.JsonClasses
{
    public class GetUsersList
    {
        public long page { get; set; }
        public long per_page { get; set; }
        public long total { get; set; }
        public long total_pages { get; set; }
        public Datum[] Data { get; set; }
        public Support Support { get; set; }
    }
    public partial class Datum
    {
        public long id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }
}
