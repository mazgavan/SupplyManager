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
using Telerik.WinControls.UI;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Diagnostics;

//DESKTOP-3Q05QGL 

namespace SupplyManager
{
    public partial class Form1 : Form
    {
        private supply_add addSupply;
        private supply_order orderSupply;
        public int counter;

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret ="Sao7CM9BpXKeEjPetmR7UhRaDHE8xOW0YGGLYths",
            BasePath ="https://supplymanager-1071b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }


        public void add_supply_Click(object sender, EventArgs e)
        {

            addSupply = new supply_add();
            addSupply.Show();
            //Form1.Close();
        }


        public void button1_Click(object sender, EventArgs e)
        {

        }


        public void supply_order1_Click(object sender, EventArgs e)
        {
            orderSupply = new supply_order();
            for (int j = 1; j <= 1; j++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+j+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    orderSupply.textBox1.Text = spl.Name;
                    orderSupply.textBox2.Text = spl.Email;
                    orderSupply.SendTo.Text = "Отправка заказа поставщику "+spl.Name;
                }
            }
            orderSupply.Show();
        }

        public void supply_order2_Click(object sender, EventArgs e)
        {
            orderSupply = new supply_order();
            for (int j = 1; j <= 2; j++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+j+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    orderSupply.textBox1.Text = spl.Name;
                    orderSupply.textBox2.Text = spl.Email;
                    orderSupply.SendTo.Text = "Отправка заказа поставщику "+spl.Name;
                }
            }
            orderSupply.Show();
        }
        public void supply_order3_Click(object sender, EventArgs e)
        {
            orderSupply = new supply_order();
            for (int j = 1; j <= 3; j++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+j+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    orderSupply.textBox1.Text = spl.Name;
                    orderSupply.textBox2.Text = spl.Email;
                    orderSupply.SendTo.Text = "Отправка заказа поставщику "+spl.Name;
                }
            }
            orderSupply.Show();
        }
        public void supply_order4_Click(object sender, EventArgs e)
        {
            orderSupply = new supply_order();
            for (int j = 1; j <= 4; j++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+j+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    orderSupply.textBox1.Text = spl.Name;
                    orderSupply.textBox2.Text = spl.Email;
                    orderSupply.SendTo.Text = "Отправка заказа поставщику "+spl.Name;
                }
            }
            orderSupply.Show();
        }

        private void supply_card2_Load(object sender, EventArgs e)
        {

        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void supply_card1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}