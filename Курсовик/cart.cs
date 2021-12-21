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



        string[] product = { "AK-47", "M4A4", "GLOCK-18", "ТТ", "ПМ-80", "Т-90", "СУ-57", "Рысь", "Крылатая", "Зем.зем.", "Зем.воз.", "Воз.воз.", "Кольт M1911", "Калибр 9", "Калибр 7.62", "калибр 5.56", "БТР-80", "БКЗ", "ZTZ-99", "MTV", "M3", "IOTV", "IBA", "HK G36", "FN Skar"};
        string[]  id_user = { "1", "2", "3", "4", "5", "6", "7", "8","9","10","11", "12",  "13", "14", "15", "16", "17", "18", "19", "20", "21" ,  "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41" };
        string[] ddc = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        string[]  price = { "2000", "1000", "1555", "4586", "23424", "343мил", "3000мил", "200000", "10мил.", "31000", "30", "15", "22", "19мил", "43670", "3000мил", "200000", "10мил.", "25000", "45000", "150000", "167800", "19мил", "43670" };
        string[] id_product = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41" };

        Random rang = new Random();
        int coun = 0;

        public void NewSklad()
        {
            while (flag)
            {

                string Product = product[rang.Next(0, product.Length)];
                string Id_user = id_user[rang.Next(0, id_user.Length)];
                string Ddc = ddc[rang.Next(0, ddc.Length)];
                string Price = price[rang.Next(0, price.Length)];
                string Id_product = id_product[rang.Next(0, id_product.Length)];

                d.Add (Product, Id_user, Ddc, Price, Id_product);
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
