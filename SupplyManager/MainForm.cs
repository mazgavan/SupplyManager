using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using supply_card;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace SupplyManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Form1 form1 = new Form1();

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret ="Sao7CM9BpXKeEjPetmR7UhRaDHE8xOW0YGGLYths",
            BasePath ="https://supplymanager-1071b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                if (client!= null)
                {
                    this.CenterToScreen();
                }
            }
            catch
            {
                MessageBox.Show("Bad internet connection:(");
            }
            //refresh_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supply_add edit = new supply_add();
            edit.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            create_cal();
            form1.Show();
        }

        public void create_cal()
        {
            FirebaseResponse res = client.Get(@"Counter");
            int Counter = int.Parse(res.ResultAs<string>());

            for (int j = 1; j <= Counter; j++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+j+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    if (Nomber == "1")
                    {
                        if (spl!=null)
                        {
                            form1.supply_card1.Visible = true;
                            form1.supply_card1.supply_name.Text = spl.Name;
                            form1.supply_card1.supply_link.Text = spl.Link;
                            form1.supply_card1.button1.BackColor = spl.Color;
                            form1.supply_card1.button1.Text = "1";
                            if (spl.Orders == "1") { form1.supply_card1.label2.Text ="Поставка по понедельникам"; }
                            if (spl.Orders == "2") { form1.supply_card1.label2.Text ="Поставка каждый день"; }
                            if (spl.Orders == "3") { form1.supply_card1.label2.Text ="Поставка через день"; }
                            if (spl.Orders == "4") { form1.supply_card1.label2.Text ="Поставка раз в месяц"; }
                            if (spl.Orders == "5") { form1.supply_card1.label2.Text ="Поставка по запросу"; }

                        }
                    }

                    if (Nomber == "2")
                    {
                        if (spl!=null)
                        {
                            form1.supply_card2.Visible = true;
                            form1.supply_card2.supply_name.Text = spl.Name;
                            form1.supply_card2.supply_link.Text = spl.Link;
                            form1.supply_card2.button1.BackColor = spl.Color;
                            form1.supply_card2.button1.Text = "2";
                            if (spl.Orders == "1") { form1.supply_card2.label2.Text ="Поставка по понедельникам"; }
                            if (spl.Orders == "2") { form1.supply_card2.label2.Text ="Поставка каждый день"; }
                            if (spl.Orders == "3") { form1.supply_card2.label2.Text ="Поставка через день"; }
                            if (spl.Orders == "4") { form1.supply_card2.label2.Text ="Поставка раз в месяц"; }
                            if (spl.Orders == "5") { form1.supply_card2.label2.Text ="Поставка по запросу"; }
                        }
                    }

                    if (Nomber == "3")
                    {
                        if (spl!=null)
                        {
                            form1.supply_card3.Visible = true;
                            form1.supply_card3.supply_name.Text = spl.Name;
                            form1.supply_card3.supply_link.Text = spl.Link;
                            form1.supply_card3.button1.BackColor = spl.Color;
                            form1.supply_card3.button1.Text = "3";

                            if (spl.Orders == "1") { form1.supply_card3.label2.Text ="Поставка по понедельникам"; }
                            if (spl.Orders == "2") { form1.supply_card3.label2.Text ="Поставка каждый день"; }
                            if (spl.Orders == "3") { form1.supply_card3.label2.Text ="Поставка через день"; }
                            if (spl.Orders == "4") { form1.supply_card3.label2.Text ="Поставка раз в месяц"; }
                            if (spl.Orders == "5") { form1.supply_card3.label2.Text ="Поставка по запросу"; }
                        }
                    }
                    if (Nomber == "4")
                    {
                        if (spl!=null)
                        {
                            form1.supply_card4.Visible = true;
                            form1.supply_card4.supply_name.Text = spl.Name;
                            form1.supply_card4.supply_link.Text = spl.Link;
                            form1.supply_card4.button1.BackColor = spl.Color;
                            form1.supply_card4.button1.Text = "4";
                            if (spl.Orders == "1") { form1.supply_card4.label2.Text ="Поставка по понедельникам"; }
                            if (spl.Orders == "2") { form1.supply_card4.label2.Text ="Поставка каждый день"; }
                            if (spl.Orders == "3") { form1.supply_card4.label2.Text ="Поставка через день"; }
                            if (spl.Orders == "4") { form1.supply_card4.label2.Text ="Поставка раз в месяц"; }
                            if (spl.Orders == "5") { form1.supply_card4.label2.Text ="Поставка по запросу"; }
                        }
                    }
                }
            }
            
        }


    }
}
