
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess
{

    public static class GlobalConfig
    {
        public static List<IDataConnection> Connection { get; private set; } = new List<IDataConnection>();
        


        public static void initializeConnections(DatabaseType db)
        {
            if (db==DatabaseType.Sql)
            {
                //TODO - Set up SQL Connection

                //SQLConnector sql = new SQLConnector();
                //Connection?.Add(sql);
            }

            else if (db==DatabaseType.TextFile)
            {
                //TODO - Set up Text Connection
                TextConnection text = new TextConnection();
                Connection.Add(text);
            }


        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
