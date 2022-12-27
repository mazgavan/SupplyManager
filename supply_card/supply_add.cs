using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Telerik.WinControls.VistaAeroTheme;

namespace supply_card
{
    public partial class supply_add : Form
    {
        BindingList<supply> list = new BindingList<supply>();
        public supply_add()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void supply_link_Click(object sender, EventArgs e)
        {

        }

        private void add_new_supply_Click(object sender, EventArgs e)
        {
            AddCard();
        }

        private void AddCard()
        {
            var a = textBox1.Text.ToString();
            if (!string.IsNullOrEmpty(a))
            {
                using (var db = new LiteDatabase(@"MyData.db"))
                {

                    var col = db.GetCollection<supply>("supplies");

                    var todo = new supply
                    {
                        Name = a,
                    };
                    col.Insert(todo);
                    list.Add(todo);
                }

                listBox1.DataSource = list;
                listBox1.DisplayMember = "Name";

            }
        }
    }
}
