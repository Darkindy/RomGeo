using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

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
                        Debug.ExitWithErrorMessage("Cannot connect to server.", ex.Number);
                        break;

                    case 1045:
                        Debug.ExitWithErrorMessage("Failed to authenticate client.", ex.Number);
                        break;
                }
                return false;
            }
        }

        // Close connection
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

        public static Question GetQuestion()
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
                try
                {
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
                }
                catch (MySqlException ex)
                {
                    Debug.ExitWithErrorMessage(ex.Message, ex.Number);
                }

                // Close connection
                CloseConnection();
            }
            else Debug.ExitWithErrorMessage("Connection failed to open using DAL method.");
            return new Question(id, text, domain, difficultyPercent, isGraphic, answers);
        }

        public static bool ValidateUser(string user, string password)
        {
            bool result = false;

            password = MD5.Create().GetHash(password);

            if (OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                try
                {
                    using (var command = new MySqlCommand("ValidateUser", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@hash", password);

                        
                        MySqlDataReader myReader = command.ExecuteReader();
                        if (myReader.Read())
                        {
                            result = myReader.GetBoolean(0);
                        }
                        
                    }
                }
                catch (MySqlException ex)
                {
                    Debug.ExitWithErrorMessage(ex.Message, ex.Number);
                }
                // Close connection
                CloseConnection();
            }
            return result;
        }

        public static void CreateUser(User user, string password)
        {
            password = MD5.Create().GetHash(password);

            if (OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                try
                {
                    using (var command = new MySqlCommand("CreateUser", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@hash", password);
                        if (command.ExecuteNonQuery() > 0) Debug.Log("User " + user + " created");
                    }
                }
                catch (MySqlException ex)
                {
                    Debug.ExitWithErrorMessage(ex.Message, ex.Number);
                }

                // Close connection
                CloseConnection();
            }
        }

        public static void MarkQueried(User user, Question question)
        {
            if (OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                try
                {
                    using (var command = new MySqlCommand("MarkQueried", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@idQ", question.Id);
                        if (command.ExecuteNonQuery() > 0) Debug.Log("Question " + question.Id + " marked as queried");
                    }
                }
                catch (MySqlException ex)
                {
                    Debug.ExitWithErrorMessage(ex.Message, ex.Number);
                }

                // Close connection
                CloseConnection();
            }
        }

        public static void MarkCorrect(User user, Question question)
        {
            if (OpenConnection() == true)
            {
                // Create command and assign the query and connection from the constructor
                try
                {
                    using (var command = new MySqlCommand("MarkCorrect", connection) { CommandType = CommandType.StoredProcedure })
                    {
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@idQ", question.Id);
                        if (command.ExecuteNonQuery() > 0) Debug.Log("Question " + question.Id + " marked as correct");
                    }
                }
                catch (MySqlException ex)
                {
                    Debug.ExitWithErrorMessage(ex.Message, ex.Number);
                }

                // Close connection
                CloseConnection();
            }
        }
    }
}
