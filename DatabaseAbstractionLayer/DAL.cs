using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using RomGeo.QuizObjects;
using RomGeo.Utils;

namespace RomGeo.DatabaseAbstractionLayer
{
    static class DAL
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        // Constructor (static)
	    static DAL()
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
        private static bool OpenConnection()
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
        private static bool CloseConnection()
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

        public static Question getQuestion()
        {
            int id = 0;
            int difficultyPercent = 0;
            bool isGraphic = false;
            string text = string.Empty;
            Domain domain = Domain.None;
            Answers answers = new Answers();

            // Open connection
            if (OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                using (var command = new MySqlCommand("GetQuestion", connection) { CommandType = CommandType.StoredProcedure })
                {
                    MySqlDataReader myReader = command.ExecuteReader();
                    if (myReader.Read())
                    {
                        id = myReader.GetInt32(0);
                        text = myReader.GetString(1);
                        domain = myReader.GetDomain(2);
                        difficultyPercent = myReader.GetInt32(3);
                        isGraphic = myReader.GetBoolean(4);
                        answers.CorrectAnswer = myReader.GetString(5);

                        int i = 1;
                        while (i <= PersistentData.MAX_ANSWERS)
                        {
                            answers[i] = myReader.GetString(5 + i);
                            i++;
                        }
                    }
                }
                // Close connection
                CloseConnection();
            }
            else Console.WriteLine("Connection failed to open using DAL method.");
            return new Question(id, text, domain, difficultyPercent, isGraphic, answers);
        }
    }
}
