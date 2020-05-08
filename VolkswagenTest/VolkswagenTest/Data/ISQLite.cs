using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace VolkswagenTest.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
