﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VolkswagenTest.Data;
using VolkswagenTest.Droid.Data;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Android))]
namespace VolkswagenTest.Droid.Data
{
    public class SQLite_Android:ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection() {
            var sqliteFileName = "TestDB.db3";
            string documensPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documensPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}