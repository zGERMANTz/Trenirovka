﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;



namespace Trenirovka
{
    internal class Db
    {   
    
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=smeshariki");
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            public void closeConnection()
            {
               if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            public MySqlConnection getConnection()
            { 
                return connection;
            }    
        }

    }

