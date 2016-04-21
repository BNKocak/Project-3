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
                

                //Read the data  of the selected items and store them in the list
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
                        else if(voorwaarde3 == "only")
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
                        else
                        {
                            list[0].Add(dataReader["Naam"] + "");
                        }
                    }
                }
                else if (voorwerp == "parkeergarage3")
                {
                    if (voorwaarde != "")
                    {
                        if (Amount2 == "Hoeveelheid_Diensten")
                        {
                            while (dataReader.Read())
                            {
                                list[0].Add(dataReader["Hoeveelheid_Diensten"] + "");
                                list[1].Add(dataReader["Naam"] + "");
                            }
                        }
                        else
                        {
                            while (dataReader.Read())
                            {
                                list[0].Add(dataReader["Hoeveelheid_Betaalmogelijkheden"] + "");
                                list[1].Add(dataReader["Naam"] + "");
                            }
                        }
                         
                    }
                    else
                    {
                        if (Amount2 == "Hoeveelheid_Diensten")
                        {
                            while (dataReader.Read())
                            {
                                list[0].Add(dataReader["sum(Lift)"] + "");
                                list[1].Add(dataReader["sum(Camera)"] + "");
                                list[2].Add(dataReader["Sum(Info_Punt_)"] + "");
                                list[3].Add(dataReader["Sum(Invalide_)"] + "");
                                list[4].Add(dataReader["sum(E_Opladen)"] + "");
                                list[5].Add(dataReader["sum(GSM_dekking)"] + "");
                                list[6].Add(dataReader["sum(SnackAutomaat)"] + "");
                            }
                        }
                        else
                        {
                            while (dataReader.Read())
                            {
                                list[0].Add(dataReader["sum(Contant)"] + "");
                                list[1].Add(dataReader["sum(Pin)"] + "");
                                list[2].Add(dataReader["Sum(Master)"] + "");
                                list[3].Add(dataReader["Sum(Maestro)"] + "");
                                list[4].Add(dataReader["sum(American_Express)"] + "");
                                list[5].Add(dataReader["sum(Visa)"] + "");
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
    }
}

class Program
{
    static void Main(string[] args)
    {
        Application.Run(new Connection_to_database.Main());
    }
}