using System;
using System.Collections.Generic;
using System.Text;

namespace VolkswagenTest.Models
{
    class Token
    {
        public int Id { get; set; }
        public string access_token { get; set; }
        public string ecpire_date { get; set; }
        public Token() { }
    }
}
