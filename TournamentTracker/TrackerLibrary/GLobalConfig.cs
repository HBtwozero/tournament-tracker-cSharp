using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GLobalConfig
    {
        //You can't instantiate Static class. It's visible for everybody.
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(DatabaseType db) 
        {

            switch (db)
            {
                case DatabaseType.sql:
                    SqlConnector sql = new SqlConnector();
                    Connections = sql;
                    break;
                case DatabaseType.TextFile:
                    TextConnector txt = new TextConnector();
                    Connections = txt;
                    break;
                default:
                    break;
            }

            //if (db == DatabaseType.sql)
            //{
            //    //TODO- Setup SQL Connector properly
            //    SqlConnector sql = new SqlConnector();

            //    Connections = sql;
            //}
            //else if (db == DatabaseType.TextFile)
            //{
            //    //TODO- Setup Text Connector properly
            //    TextConnector txt = new TextConnector();

            //    Connections= txt;
            //}
        }
                
        }
}
