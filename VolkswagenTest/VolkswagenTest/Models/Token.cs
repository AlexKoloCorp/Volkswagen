using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace VolkswagenTest.Models
{
    public class Token
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string access_token { get; set; }
        public string ecpire_date { get; set; }
        public Token() { }
    }
}
