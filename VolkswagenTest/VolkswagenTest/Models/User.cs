using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace VolkswagenTest.Models
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public byte Rights { get; set; }
        public User() { }
        public User(string Username, string Password) {
            this.Username = Username;
            this.Password = Password;
        }
        public bool CheckInfo()
        {
            if (this.Username !=null && this.Password !=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
