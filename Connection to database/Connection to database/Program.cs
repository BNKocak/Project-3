using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Connection_to_database;
using System.Windows.Forms;

namespace Connection_to_database
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "Localhost";
            database = "project3";
            uid = "root";
            password = "123lol123";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
       private bool OpenConnection()
        {
            try
            {
                connection.Open();
                System.Console.WriteLine("Het werkt");
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        System.Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        System.Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                System.Console.WriteLine("Het werkt niet");
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
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }


        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(string voorwerp,string column ,string voorwaarde,string voorwaarde2, string voorwaarde3,string Amount1, string Amount2)
        {
            Querrys Select = new Querrys();
            string query = Select.SelectQuerry(voorwerp,column,voorwaarde,voorwaarde2,voorwaarde3, Amount1, Amount2);
                
            //Create a list to store the result
            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //string data2text = string.Empty;
                //string datatxt = string.Empty;

                //Read the data and store them in the list
                if (voorwerp == "parkeergarage2")
                {
                    while (dataReader.Read())
                    {
                        if (voorwaarde3 == "and")
                        {
                            if (voorwaarde == "Amount of services")
                            {
                                if (voorwaarde2 == "Amount of pay methods")
                                {
                                    list[0].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                }
                                else
                                {
                                    list[0].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Capaciteit"] + "");
                                }

                            }
                            else if (voorwaarde == "Amount of pay methods")
                            {
                                if (voorwaarde2 == "Amount of services")
                                {
                                    list[0].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                }
                                else
                                {
                                    list[0].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Capaciteit"] + "");
                                }
                            }
                            else if (voorwaarde == "Amount of parking places")
                            {
                                if (voorwaarde2 == "Amount of services")
                                {
                                    list[0].Add(dataReader["Capaciteit"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                }
                                else
                                {
                                    list[0].Add(dataReader["Capaciteit"] + "");
                                    list[1].Add(dataReader["Naam"] + "");
                                    list[2].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                }
                            }

                        }
                        else
                        {
                            if (voorwaarde == "Amount of services")
                            {
                                list[0].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                list[1].Add(dataReader["Naam"] + "");
                            }
                            else if (voorwaarde == "Amount of pay methods")
                            {
                                list[0].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                list[1].Add(dataReader["Naam"] + "");
                            }
                            else
                            {
                                list[0].Add(dataReader["Capaciteit"] + "");
                                list[1].Add(dataReader["Naam"] + "");
                            }
                        }
                    }
                }

                else
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["Count(Bouwjaar)"] + "");
                        list[1].Add(dataReader["Bouwjaar"] + "");
                    }
                } 

                        dataReader.Close();
                        this.CloseConnection();
                    }
                    //return list to be displayed
                    return list;
                }
                
            
        


        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Application.Run(new Connection_to_database.Main());
    }
}