using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public static class SQLConnection
    {
        public static string ConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ya'akov Goldberg\Desktop\Web Projects\Web-Based-Projects-Team-5\Database\Breaddit_DB.mdf;Integrated Security=True";
        }
    }
}
