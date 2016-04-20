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
                if (column == "ranking")
                {
                    if (voorwaarde1 == "Amount of services")
                    {
                        if (voorwaarde2 == "Amount of pay methods")
                        {
                            query = "";
                        }
                        else if (voorwaarde2 == "Amount of parking places")
                        {

                        }
                        else if (voorwaarde2 == "Opening hours")
                        {

                        }
                    }
                    else if (voorwaarde1 == "Amount of pay methods")
                    {
                        if (voorwaarde2 == "Amount of services")
                        {

                        }
                        else if (voorwaarde2 == "Amount of parking places")
                        {

                        }
                        else if (voorwaarde2 == "Opening hours")
                        {

                        }
                    

                    }
                    else if (voorwaarde1 == "Amount of parking places")
                    {
                        if (voorwaarde2 == "Amount of services")
                        {

                        }
                        else if (voorwaarde2 == "Amount of pay methods")
                        {

                        }
                        else if(voorwaarde2 == "Opening hours")
                        {

                        }
                    }
                    else if (voorwaarde1 == "Opening hours")
                    {
                        if(voorwaarde2 == "Amount of services")
                        {

                        }
                        else if (voorwaarde2 == "Amount of pay methods")
                        {

                        }
                        else if (voorwaarde2 == "Amount of parking places")
                        {

                        }
                    }
                }
                query = "SELECT * FROM " + voorwerp + " WHERE " + column + " like '%" + voorwaarde1 + "%' ";

            }
            if(voorwerp == "straat")
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
            }
            else { query = "SELECT * FROM " + voorwerp + " WHERE " + column + " like '%" + voorwaarde1 + "%' "; }
            return query;
        }
    }
}
