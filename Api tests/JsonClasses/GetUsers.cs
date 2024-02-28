using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Api_tests.JsonClasses
{
    class GetUsers
    {
        public Data Data { get; set; }

        public Support Support { get; set; }
    }

    public partial class Data
    {
        public long Id { get; set; }

        public string Email { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public Uri Avatar { get; set; }
    }

    public partial class Support
    {
        public string Url { get; set; }

        public string Text { get; set; }
    }
}
