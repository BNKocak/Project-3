using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection_to_database
{
    public class Querrys
    {
        public string SelectQuerry(string voorwerp,string column, string voorwaarde1,string voorwaarde2,string voorwaarde3, string Amount1, string Amount2)
        {
            string query = "";
            if (voorwerp == "parkeergarage2")
            {
                if (column == "Ranking")
                {
                    if (voorwaarde3 == "and")
                    {
                        
                        if (voorwaarde1 == "Amount of services")
                        {
                            if (voorwaarde2 == "Amount of pay methods")
                            {
                                query = "Select Naam,Hoeveelheid_Diensten, Hoeveelheid_Betaalmogelijkheden from parkeergarage2 where Hoeveelheid_Diensten >= " + Amount1 + " and Hoeveelheid_Betaalmogelijkheden >= " + Amount2 + " Group by Hoeveelheid_Diensten Limit 3 ";
                            }
                            else if (voorwaarde2 == "Amount of parking places")
                            {
                                query = "Select Naam,Hoeveelheid_Diensten, Capaciteit from parkeergarage2 where Hoeveelheid_Diensten >= " + Amount1 + " Group by Capaciteit order by Capaciteit desc Limit 3 ";
                            }

                        }
                        else if (voorwaarde1 == "Amount of pay methods")
                        {
                            if (voorwaarde2 == "Amount of services")
                            {
                                query = "Select Naam,Hoeveelheid_Betaalmogelijkheden, Hoeveelheid_Diensten from parkeergarage2 where Hoeveelheid_Betaalmogelijkheden >= " + Amount1 + " and Hoeveelheid_Diensten >= " + Amount2 + " Group by Hoeveelheid_Betaalmogelijkheden Limit 3";
                            }
                            else if (voorwaarde2 == "Amount of parking places")
                            {
                                query = "Select Naam, Hoeveelheid_Betaalmogelijkheden, Capaciteit from parkeergarage2 where Hoeveelheid_Betaalmogelijkheden >= " + Amount1 + " Group by Capaciteit order by Capaciteit desc Limit 3";

                            }


                        }
                        else if (voorwaarde1 == "Amount of parking places")
                        {
                            if (voorwaarde2 == "Amount of services")
                            {
                                query = "Select Naam, Capaciteit, Hoeveelheid_Diensten from parkeergarage2 where Hoeveelheid_Diensten >= " + Amount2 + " Group by Capaciteit order by Capaciteit desc Limit 3";
                            }
                            else if (voorwaarde2 == "Amount of pay methods")
                            {
                                query = "Select Naam, Capaciteit, Hoeveelheid_Betaalmogelijkheden from parkeergarage2 where Hoeveelheid_Betaalmogelijkheden >= " + Amount2 + " Group by Capaciteit order by Capaciteit desc Limit 3";
                            }
                        }
                    }
                    else
                    {
                        if (voorwaarde1 == "Amount of services")
                        {
                            query = "SELECT Naam, Hoeveelheid_Diensten from parkeergarage2 where Hoeveelheid_Diensten >= " + Amount1 + " Group by Hoeveelheid_Diensten Limit 3";
                        }
                        else if (voorwaarde1 == "Amount of pay methods")
                        {
                            query = "Select Naam, Hoeveelheid_Betaalmogelijkheden from parkeergarage2 where Hoeveelheid_Betaalmogelijkheden >= " + Amount1 + " Group by Hoeveelheid_Betaalmogelijkheden Limit 3";
                        }
                        else
                        {
                            query = "Select Naam, Capaciteit from parkeergarage2 Group by Capaciteit order by Capaciteit desc Limit 3";
                        }
                    }

                }
                
                else
                {
                    query = "Select Naam from parkeergarage2";
                }
                }
            else if( voorwerp == "parkeergarage3")
            {
                if (voorwaarde1 != "")
                {
                    query = "Select Naam, Hoeveelheid_Diensten from parkeergarage2 where Naam like  '"+ voorwaarde1 + "' or Naam like '"+ voorwaarde2 + "' group by Naam";
                }
                else
                {
                    query = "Select sum(Lift), sum(Camera), Sum(Info_Punt_),Sum(Invalide_), sum(E_Opladen), sum(GSM_dekking),sum(SnackAutomaat) from parkeergarage3";
                }
            }
            else
            {
                
                if (column == "Bouwjaar")
                {
                    if (voorwaarde1 != "")
                    {
                        if (voorwaarde2 != "")
                        {
                            if (voorwaarde3 == "until")
                            {
                                query = "SELECT Count(Bouwjaar), Bouwjaar FROM " + voorwerp + " Where Bouwjaar >" + voorwaarde1 + " And Bouwjaar < " + voorwaarde2 + " Group by Bouwjaar ";
                            }
                            else
                            {
                                query = "SELECT Count(Bouwjaar), Bouwjaar FROM " + voorwerp + " Where Bouwjaar = " + voorwaarde1 + " or Bouwjaar = " + voorwaarde2 + " Group by Bouwjaar";
                            }
                        }
                    }
                    else
                    { query = "SELECT Count(Bouwjaar), Bouwjaar FROM " + voorwerp + " Group By Bouwjaar order by bouwjaar asc"; }
                }
                else { query = "SELECT * FROM " + voorwerp + " WHERE " + column + " like '%" + voorwaarde1 + "%' "; }
            }
            
            return query;
        }
    }
}