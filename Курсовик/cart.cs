using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Курсовик
{
    public partial class cart : Form
    {
        private bool flag;
        public cart()
        {
            InitializeComponent();
        }

        private void cart_Load(object sender, EventArgs e)
        {
        

            DB db = new DB();
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM sklad ");
            db.Openconnection();
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            db.closeconnectoin();
            dataGridView1.DataSource = data;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        simul f = new simul();

 

        string[] name_org = { "ОхранаТруда", "Росгварлия", "Полиция", "Армия", "ПрезиденскаяОхрана", "Пограничье", "МузейнаяОхрана", "СОБР", "ОМОН", "СПЕЦНАЗ" };
        string[] password = { "123", "342","567","087","3456","12","35464", "ratger21", "wfeae5", "avtrse4", "etve456", "evtet12", "QQwfcsj1", "GYRcsb" };
        string[] email = { "Pat@gmail.com", "Gil@gmail.com", "Sol@gmail.com", "Fhvbz@gmail.com", "grob@gmail.com", "Pdog@gmail.com", "Frog@gmail.com", "Bog@gmail.com", "inyaz@gmail.com", "voron@gmail.com" };
        string[] login = { "Mas", "Effect", "Far", "BOGDAN", "LOgin","fany", "Dogs2", "Far", "With1", "cry" };

        Random rng = new Random();
        int count = 0;

        public void NewCustomer()
        {
            while (flag)
            {
                string Name_org = name_org[rng.Next(0, name_org.Length)];
                string Password = password[rng.Next(0, password.Length)];
                string Email = email[rng.Next(0, email.Length)];
                string Login = login[rng.Next(0, login.Length)];

                f.Add_to_Pets(Name_org, Password, Email, Login);
                count++;
                label1.Invoke(new Action(() => label1.Text = count.ToString()));
                Thread.Sleep(300);
            }
        }
        simul d = new simul();



        string[] ougo = { "50", "1000", "35", "45", "21" };
        string[]  tip_go = { "AK-47", "M4A1", "Usp-s", "Galil", "Glock", "Desert-eagle", "Макаров", };
        string[] type = { "automatic", "pistol", "pistol", "automatic", "automatic" };
        string[]  price = { "2000", "1000", "1555", "4586", "23424" };

        Random rang = new Random();
        int coun = 0;

        public void NewSklad()
        {
            while (flag)
            {

                string Qugo = ougo[rang.Next(0, ougo.Length)];
                string Tip_go = tip_go[rang.Next(0, tip_go.Length)];
                string Type = type[rang.Next(0, type.Length)];
                string Price = price[rang.Next(0, price.Length)];

                d.Add ( Qugo , Tip_go, Type, Price);
                coun++;
                label1.Invoke(new Action(() => label1.Text = coun.ToString()));
                Thread.Sleep(300);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            flag = true;
            Task.Run(() => NewCustomer());

            Task.Run(() => NewSklad());


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            flag = false;

        }

    }
}
