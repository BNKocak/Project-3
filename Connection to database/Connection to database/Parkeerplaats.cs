using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Connection_to_database
{public partial class Main : Form
    {   public Main() { InitializeComponent(); }  
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void button2_Click(object sender, EventArgs e) // here we switch from parking lot to streets so its easy to find options of parkinglot
        {Streetname.Visible = true;
            this.chart2.Visible = false;
            ParkinglotTxt.Visible = false;
            ShowMap.Visible = true;
            Streetname.Visible = true; 
            StreetBox.Visible = true;
            ParkinglotTxt.Visible = true;
            StreetBox.Items.Clear();
            StreetBox.Items.Add("Bouwjaar");          
        }

        private void Parkeerplaats_Load(object sender, EventArgs e){}
        private void button1_Click_1(object sender, EventArgs e) // here we switch from streets to parking lot so its easy to find options of parkinglot
        {   Streetname.Visible = false;
            ParkinglotTxt.Visible = true;
            ShowMap.Visible = true;
            Streetname.Visible = true;            
            StreetBox.Visible = true;           
            ParkinglotTxt.Visible = true;
            StreetBox.Items.Clear();                      
            StreetBox.Items.Add("Services");
            StreetBox.Items.Add("Ranking");
            StreetBox.Items.Add("Pay Methods");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e){}
        private void Streetname_Click(object sender, EventArgs e){}
        private void ParkinglotTxt_Click(object sender, EventArgs e){}
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) // here you select a option so you the programm know what kind of data it needs from the database
        {   this.chart1.Series["Amount of Streets"].Points.Clear();
            this.chart1.Series["Amount of Pay Methods"].Points.Clear();
            this.chart1.Series["Amount of Services"].Points.Clear();
            this.chart1.Series["Amount of Parking Spaces"].Points.Clear();
            this.chart2.Series["Lift"].Points.Clear();
            select.Items.Clear();
            Keuze1.Items.Clear();
            keuze3.Items.Clear();
            this.chart1.Visible = false;
            Keuze1.Visible = false;
            keuze3.Visible = false;
            Value1.Visible = false;
            Value2.Visible = false;
            select.Visible = false;
            Search2.Visible = false;
            keuze3.Enabled = true;
            if (StreetBox.Text == "Bouwjaar")
            {   this.chart1.Visible = true;
                Value1.Visible = true;
                Value2.Visible = true;
                select.Visible = true;
                Search2.Visible = true;
                YearLbl.Visible = true;
                LblYear.Visible = true;
                select.Items.Add("and");
                select.Items.Add("until");
                DBConnect Database = new DBConnect();
                List<string>[] list = Database.Select("straat", "Bouwjaar", "","","","","");
                int length = list[0].Count;
                int count = 0;
                while (length > count)
                {   var item1 = list[0].ElementAt(count);
                    var item2 = list[1].ElementAt(count);
                    this.chart1.Series["Amount of Streets"].Points.AddXY(item2, item1);
                    count += 1;
                }
            }
            if (StreetBox.Text == "Ranking")
            {   this.chart1.Visible = true;
                Search2.Visible = true;
                Keuze1.Visible = true;
                keuze3.Visible = true;
                select.Visible = true;
                YearLbl.Visible = false;
                LblYear.Visible = false;
                ServiceLbl.Visible = false;
                LblService.Visible = false;
                LblOption.Visible = true;
                OptionLbl.Visible = true;
                MethodeLbl.Visible = false;
                LblMethode.Visible = false;
                Keuze1.Items.Add("Amount of services");
                Keuze1.Items.Add("Amount of pay methods");
                Keuze1.Items.Add("Amount of parking places");
                keuze3.Items.Add("Amount of services");
                keuze3.Items.Add("Amount of pay methods");
                keuze3.Items.Add("Amount of parking places");                
                select.Items.Add("and");
                select.Items.Add("only");
            }
            if (StreetBox.Text == "Services")
            {   Search2.Visible = true;
                Keuze1.Visible = true;
                keuze3.Visible = true;
                select.Visible = false;
                chart2.Visible = true;
                YearLbl.Visible = false;
                LblYear.Visible = false;
                ServiceLbl.Visible = true;
                LblService.Visible = true;
                LblOption.Visible = false;
                OptionLbl.Visible = false;
                MethodeLbl.Visible = false;
                LblMethode.Visible = false;
                DBConnect Database = new DBConnect();
                List<string>[] list = Database.Select("parkeergarage2", "Naam" , "", "", "", "", "");
                foreach (string derp in list[0])
                {   Keuze1.Items.Add(derp);
                    keuze3.Items.Add(derp);
                }               
                List<string>[] list1  = Database.Select("parkeergarage3", "", "", "", "", "", "Hoeveelheid_Diensten");
                int length = list1[0].Count;
                int count = 0;
                while (length > count)
                {   var item1 = list1[0].ElementAt(count);
                    var item2 = list1[1].ElementAt(count);
                    var item3 = list1[2].ElementAt(count);
                    var item4 = list1[3].ElementAt(count);
                    var item5 = list1[4].ElementAt(count);
                    var item6 = list1[5].ElementAt(count);
                    var item7 = list1[6].ElementAt(count);
                    this.chart2.Series["Lift"].Points.AddXY("Lift",item1);
                    this.chart2.Series["Lift"].Points.AddXY("Camera",item2);
                    this.chart2.Series["Lift"].Points.AddXY("Info-Punt",item3);
                    this.chart2.Series["Lift"].Points.AddXY("Invalide",item4);
                    this.chart2.Series["Lift"].Points.AddXY("E-Opladen",item5);
                    this.chart2.Series["Lift"].Points.AddXY("GSM-dekking",item6);
                    this.chart2.Series["Lift"].Points.AddXY("SnackAutomaat",item7);
                    count += 1;
                }
           }
           if (StreetBox.Text == "Pay Methods")
            {   Search2.Visible = true;
                Keuze1.Visible = true;
                keuze3.Visible = true;
                select.Visible = false;
                chart2.Visible = true;
                YearLbl.Visible = false;
                LblYear.Visible = false;
                ServiceLbl.Visible = false;
                LblService.Visible = false;
                LblOption.Visible = false;
                OptionLbl.Visible = false;
                MethodeLbl.Visible = true;
                LblMethode.Visible = true;
                DBConnect Database = new DBConnect();
                List<string>[] list = Database.Select("parkeergarage2", "Naam", "", "", "", "", "");
                foreach (string derp in list[0])
                {   Keuze1.Items.Add(derp);
                    keuze3.Items.Add(derp);
                }
                List<string>[] list1 = Database.Select("parkeergarage3", "", "", "", "", "", "Hoeveelheid_Betaalmogelijkheden");
                int length = list1[0].Count;
                int count = 0;
                while (length > count)
                {   var item1 = list1[0].ElementAt(count);
                    var item2 = list1[1].ElementAt(count);
                    var item3 = list1[2].ElementAt(count);
                    var item4 = list1[3].ElementAt(count);
                    var item5 = list1[4].ElementAt(count);
                    var item6 = list1[5].ElementAt(count);
                    this.chart2.Series["Lift"].Points.AddXY("Cash", item1);
                    this.chart2.Series["Lift"].Points.AddXY("Pin", item2);
                    this.chart2.Series["Lift"].Points.AddXY("Master", item3);
                    this.chart2.Series["Lift"].Points.AddXY("Maestro", item4);
                    this.chart2.Series["Lift"].Points.AddXY("American Express", item5);
                    this.chart2.Series["Lift"].Points.AddXY("Visa", item6);
                    count += 1;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e){}
        private void Select_SelectedIndexChanged(object sender, EventArgs e) // here we disable the options in the second bar because we dont want to use information of this bar
        {   if (select.SelectedItem.ToString() == "only") {keuze3.Enabled = false;}
            else { keuze3.Enabled = true; }
        }

        private void Value1_TextChanged(object sender, EventArgs e){}
        private void Value2_TextChanged(object sender, EventArgs e){}
        private void Search2_Click(object sender, EventArgs e) // here we look what every value is so we can get the informatie from the database with the accompaning graphs
        {   this.chart1.Series["Amount of Streets"].Points.Clear();
            this.chart1.Series["Amount of Pay Methods"].Points.Clear();
            this.chart1.Series["Amount of Services"].Points.Clear();
            this.chart1.Series["Amount of Parking Spaces"].Points.Clear();
            this.chart2.Series["Lift"].Points.Clear();
            string dataset = "";
            if (ParkinglotTxt.Visible == true)
            {   dataset = "parkeergarage2";
                if (StreetBox.SelectedIndex == 1)
                {   if (keuze3.Enabled == false)
                        {
                            keuze3.Text = "";
                        }                       
                        DBConnect Database = new DBConnect();
                        List<string>[] list = Database.Select(dataset, StreetBox.Text, Keuze1.Text, keuze3.Text, select.Text,Amount1.Text,Amount2.Text);
                        int length = list[1].Count;
                        int count = 0;
                        if (list[0].Count != 0 && list[1].Count != 0)
                        {   this.chart1.Visible = true;
                            if (select.Text == "and")
                            {
                                while (length > count)
                                {   Console.WriteLine(count);
                                    var item1 = list[0].ElementAt(count);
                                    var item2 = list[1].ElementAt(count);
                                    var item3 = list[2].ElementAt(count);
                                if (Keuze1.SelectedIndex == 0) { this.chart1.Series["Amount of Services"].Points.AddXY(item2, item1); }
                                else if (Keuze1.SelectedIndex == 1) { this.chart1.Series["Amount of Pay Methods"].Points.AddXY(item2, item1); }
                                else { this.chart1.Series["Amount of Parking Spaces"].Points.AddXY(item2, item1); }
                                if (keuze3.SelectedIndex == 0) { this.chart1.Series["Amount of Services"].Points.AddY(item3); }
                                else if (keuze3.SelectedIndex == 1) { this.chart1.Series["Amount of Pay Methods"].Points.AddY(item3); }
                                else { this.chart1.Series["Amount of Parking Spaces"].Points.AddY(item3); }
                                    count += 1;
                                }
                            }
                            else
                            {   while (length > count)
                                {
                                    Console.WriteLine(count);
                                    var item1 = list[0].ElementAt(count);
                                    var item2 = list[1].ElementAt(count);
                                    if (Keuze1.SelectedIndex == 0) { this.chart1.Series["Amount of Services"].Points.AddXY(item2, item1); }
                                    else if (Keuze1.SelectedIndex == 1) { this.chart1.Series["Amount of Pay Methods"].Points.AddXY(item2, item1); }
                                    else { this.chart1.Series["Amount of Parking Spaces"].Points.AddXY(item2, item1); }
                                    count += 1;
                                }                           
                        }
                    }
                }
                else if(StreetBox.SelectedIndex == 0)
                {       DBConnect Database = new DBConnect();
                        List<string>[] list = Database.Select("parkeergarage3", "", Keuze1.Text, keuze3.Text, "", "", "Hoeveelheid_Diensten");
                        int length = list[1].Count;
                        int count = 0;
                        this.chart2.Visible = true;
                        while (length > count)
                        {
                            Console.WriteLine(count);
                            var item1 = list[0].ElementAt(count);
                            var item2 = list[1].ElementAt(count);                          
                            this.chart2.Series["Lift"].Points.AddXY(item2, item1);                        
                            count += 1;
                        }     
                  }
                else if (StreetBox.SelectedIndex == 2)
                {   DBConnect Database = new DBConnect();
                    List<string>[] list = Database.Select("parkeergarage3", "", Keuze1.Text, keuze3.Text, "", "", "Hoeveelheid_Betaalmogelijkheden");
                    int length = list[1].Count;
                    int count = 0;
                    this.chart2.Visible = true;
                    while (length > count)
                    {
                        Console.WriteLine(count);
                        var item1 = list[0].ElementAt(count);
                        var item2 = list[1].ElementAt(count);
                        this.chart2.Series["Lift"].Points.AddXY(item2, item1);
                        count += 1;
                    }
                }
            }
            else
            {   dataset = "straat";
                if (StreetBox.SelectedIndex == 0)
                {   if (Value1.Text != "" && Value2.Text != "" && select.Text != "")
                    {
                        DBConnect Database = new DBConnect();
                        List<string>[] list = Database.Select(dataset, StreetBox.Text, Value1.Text, Value2.Text, select.Text,"","");
                        int length = list[0].Count;
                        int count = 0;
                        if (list[0].Count != 0 && list[1].Count != 0)
                        {   this.chart1.Visible = true;
                            while (length > count)
                            {
                                var item1 = list[0].ElementAt(count);
                                var item2 = list[1].ElementAt(count);
                                this.chart1.Series["Amount of Streets"].Points.AddXY(item2, item1);
                                count += 1;
                            }
                        }
                        else
                        {   this.chart1.Visible = false;
                            if (list[0].Count == 0 && list[0].Count == 0)
                            {
                                MessageBox.Show("During " + Value1.Text + " and " + Value2.Text + " were no streets build");
                            }
                        }
                    }
                }
            }
        }

        private void Keuze1_SelectedIndexChanged(object sender, EventArgs e) // here we provide an extra bar for the prefrencens of the user
        {   Amount1.Visible = false;
            Amount1.Enabled = false;           
            string selectedindex = Keuze1.SelectedItem.ToString();
            if (selectedindex == "Amount of services")
            {   Amount1.Enabled = true;
                Amount1.Visible = true;                
            }
            if (selectedindex == "Amount of pay methods")
            {   Amount1.Enabled = true;
                Amount1.Visible = true;                       
            }        
        }

        private void keuze3_SelectedIndexChanged(object sender, EventArgs e)  // here we provide an second extra bar for the prefrences of the user
        {   Amount2.Visible = false;
            Amount2.Enabled = false;
            string selectedindex = keuze3.SelectedItem.ToString();
            if (selectedindex == "Amount of services")
            {   Amount2.Enabled = true;
                Amount2.Visible = true;              
            }
            if (selectedindex == "Amount of pay methods")
            {   Amount2.Enabled = true;
                Amount2.Visible = true;           
            }
        }

        private void ShowMap_Click(object sender, EventArgs e) // here we show the map with the capacity
        { Form1 Map = new Form1();
            Map.Show();
        }

        private void chart2_Click(object sender, EventArgs e){}

        private void MethodeLbl_Click(object sender, EventArgs e)
        {

        }
    }
}