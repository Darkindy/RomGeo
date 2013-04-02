using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace RomGeo.DatabaseAbstractionLayer
{
    class DAL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructor
	    public DAL()
	    {
    		Initialize();
	    }

	    // Initialize values
	    private void Initialize()
	    {
		    server = "86.120.252.100";
		    database = "erg_db";
		    uid = "romgeo";
		    password = "romgeo";
		    string connectionString;
		    connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
		    connection = new MySqlConnection(connectionString);
	    }

        // Open Connection
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void getQuestion(out string question, out string answer1, out string answer2, out string answer3, out string answer4, out string correct)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                using (var command = new MySqlCommand("getQuestion", connection)
                {CommandType = CommandType.StoredProcedure})
                {
                    MySqlDataReader myReader = command.ExecuteReader();
                    while (myReader.Read())
                    {
                        Console.WriteLine(myReader.GetString(0));
                        Console.WriteLine(myReader.GetString(1));
                        Console.WriteLine(myReader.GetString(2));
                        Console.WriteLine(myReader.GetString(3));
                        Console.WriteLine(myReader.GetString(4));
                        Console.WriteLine("Correct: "+myReader.GetString(5));
                    }
                }

                //close connection
                this.CloseConnection();
            }
            else Console.WriteLine("Connection failed to open using DAL method.");

            question = "lol";
            answer1 = "lmfao";
            answer2 = "lolita";
            answer3 = "rofl";
            answer4 = "roflmfao";
            correct = "correct";
        }
    }
}
