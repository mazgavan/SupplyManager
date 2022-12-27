using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using supply_card;
using Telerik.WinControls.UI;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace SupplyManager
{
    public partial class supply_order : Form
    {
        Form1 form1 = new Form1();
        
            
        public supply_order()
        {
            InitializeComponent();
        }

        private void supply_order_Load(object sender, EventArgs e)
        {
            
        }


        static void SendMessage(string userName, string adressTo, string messageSubject, string messageText)
        {
            try
            {
                string from = @"mr.thevasya@mail.ru"; // адреса отправителя
                string pass = "UEAE8biKbyce90iHv6fP"; // пароль отправителя
                MailMessage mess = new MailMessage();
                mess.To.Add(adressTo); // адрес получателя
                mess.From = new MailAddress(from);
                mess.Subject = messageSubject; // тема
                mess.Body = messageText; // текст сообщения
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.mail.ru"; //smtp-сервер отправителя
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], pass);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mess); // отправка пользователю
                mess.To.Remove(mess.To[0]);
                mess.To.Add(from); //для сообщения на свой адрес
                mess.Subject = "Отправлено сообщение";
                mess.Body = "Пользователю " + userName + " отправлено сообщение";
                client.Send(mess); // отправка себе
                mess.Dispose();
            }
            catch (SmtpException)
            {
                MessageBox.Show("Ошибка!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text; //имя пользователя
            string adressTo = textBox2.Text; //адрес пользователя
            string messageSubject = textBox3.Text; //тема
            string messageText = richTextBox1.Text; //текст
            SendMessage(userName, adressTo, messageSubject, messageText);
            MessageBox.Show("Сообщение отправлено!\n" + "Заказ будет доставлен в дату ближайшей поставки");
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            richTextBox1.Text="";

        }
  }
}