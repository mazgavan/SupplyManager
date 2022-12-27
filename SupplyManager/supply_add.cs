using LiteDB;
using supply_card;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Telerik.WinControls.VistaAeroTheme;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SupplyManager
{
    public partial class supply_add : Form
    {
        Form1 form1 = new Form1();

        public supply_add()
        {
            InitializeComponent();
        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret ="Sao7CM9BpXKeEjPetmR7UhRaDHE8xOW0YGGLYths",
            BasePath ="https://supplymanager-1071b-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void supply_link_Click(object sender, EventArgs e)
        {

        }

        private void add_new_supply_Click(object sender, EventArgs e)
        {
            AddCard();
            refresh_data();
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void AddCard()
        {
            supply spl = new supply()
            {
                Id = textBox4.Text,
                Name = textBox1.Text,
                Link = textBox2.Text,
                Email= textBox3.Text,
                Color = radColorBox1.Value,
                Orders = trackBar1.Value.ToString()
        };
            var setter = client.Set("SupplyManager/"+ textBox4.Text, spl);
            MessageBox.Show("all right");

        }

        public void supply_add_Load(object sender, EventArgs e)
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
            refresh_data();
        }

        
        private void Delete_Click(object sender, EventArgs e)
        {
            var result = client.Delete ("SupplyManager/" + textBox4.Text);
            MessageBox.Show("Информация о поставщике удалена");
            refresh_data();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox5.Text);
            if (x <= 4)
            {
                var result = client.Get("SupplyManager/" + textBox5.Text);
                supply spl = result.ResultAs<supply>();
                textBox1.Text = spl.Name;
                textBox2.Text = spl.Link;
                textBox3.Text = spl.Email;
                textBox4.Text = textBox5.Text;
                radColorBox1.Value = spl.Color;
            }
            else
            {
                MessageBox.Show("Поставщик не найден");
            }
        }

        private void supplyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            supply spl = new supply()
            {
                Id = textBox4.Text,
                Name = textBox1.Text,
                Link = textBox2.Text,
                Email= textBox3.Text,
                Color = radColorBox1.Value
            };
            var setter = client.Update("SupplyManager/"+ textBox4.Text, spl);
            MessageBox.Show("Данные успешно добавлены");
        }

        private void gridRefresh_Click(object sender, EventArgs e)
        {
            refresh_data();
        }

        public void refresh_data()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Link");
            dt.Columns.Add("Email");
            dt.Columns.Add("Color");
            dt.Columns.Add("Orders");
            dataGridView1.Rows.Clear();
            FirebaseResponse res = client.Get(@"Counter");
            int Counter = int.Parse(res.ResultAs<string>());

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/"+i+ "/Nomber");
                string Nomber = res2.ResultAs<string>();

                var res3 = client.Get(@"SupplyManager/" + Nomber);
                supply spl = res3.ResultAs<supply>();

                if (spl!=null)
                {
                    dt.Rows.Add
                        (spl.Id,
                        spl.Name,
                        spl.Link,
                        spl.Email,
                        spl.Color,
                        spl.Orders);
                }
            }
            foreach (DataRow item in dt.Rows)
            {
                dataGridView1.Rows.Add(item.ItemArray);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
