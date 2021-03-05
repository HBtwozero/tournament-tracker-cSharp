using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GLobalConfig
    {
        //You can't instantiate Static class. It's visible for everybody.
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles) 
        {
            if (database)
            {
                //TODO- Setup SQL Connector properly
                SqlConnector sql = new SqlConnector();

                Connections.Add(sql);
            }
            else if (textFiles)
            {
                //TODO- Setup Text Connector properly
                TextConnector txt = new TextConnector();

                Connections.Add(txt);
            }
        }
                
        }
}
