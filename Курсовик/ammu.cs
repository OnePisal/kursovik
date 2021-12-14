using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовик
{
    public partial class ammu : Form
    {
        DataTable data = new DataTable();
        public ammu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public DataTable selectTable()
        {
            DB db = new DB();
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM sklad WHERE Type = 'ammunition'");
            db.Openconnection();
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            db.closeconnectoin();
            return data;
        }



        private void addPicture(int i, FlowLayoutPanel flw)
        {
            PictureBox pa = new PictureBox();
            pa.Name = "pa" + i;
            //pa.Image = Image.FromFile("C:/Users/D9/Desktop/asedrwq/Курсовик/Курсовик/Resources/Ammu.png");
            pa.SizeMode = PictureBoxSizeMode.StretchImage;
            pa.Dock = DockStyle.Top;
            pa.Size = new Size(75, 75);

            flw.Controls.Add(pa);
        }

        private void addLabel(int i, FlowLayoutPanel flw)
        {
            Label nbom = new Label();
            nbom.Name = "lbl" + i;
            nbom.ForeColor = Color.Black;
            nbom.Dock = DockStyle.Top;
            nbom.Text = data.Rows[i][2].ToString();
            nbom.TextAlign = ContentAlignment.TopCenter;
            nbom.Font = new System.Drawing.Font("Comic Sans UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            //nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbom);
        }

        private void addtxtBox(int i, FlowLayoutPanel flw)
        {
            TextBox nbom = new TextBox();
            nbom.Name = "txt" + data.Rows[i][0].ToString();
            nbom.Dock = DockStyle.Top;
            nbom.Width = 110;

            flw.Controls.Add(nbom);
        }
        private void addButton(int i, FlowLayoutPanel flw)
        {
            Button nbomb = new Button();
            nbomb.Name = data.Rows[i][0].ToString();
            nbomb.Dock = DockStyle.Top;
            nbomb.Text = "Купить";
            nbomb.Width = 110;
            nbomb.BackColor = Color.Teal;
            nbomb.Click += Button_Click;
            nbomb.Tag = i;

            //nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbomb);
        }
        private void Button_Click(object sender, EventArgs eventArgs)
        {

            DateTime curDate = DateTime.Now;
            var button = (Button)sender;
            Console.WriteLine(button.Name);
            TextBox tbx = this.Controls.Find("txt" + button.Name, true).FirstOrDefault() as TextBox;
            int count = Convert.ToInt32(tbx.Text);
            string id_product = button.Name;
            int price = count * Convert.ToInt32(data.Rows[Convert.ToInt32(button.Tag)][4]);
            string sql = String.Format("INSERT INTO transactions (product, price,Data_product) VALUES (@product,@price,@date) ");
            DB db = new DB();
            db.Openconnection();
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@product", id_product);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@date", curDate);
            command.ExecuteNonQuery();
            string sql1 = String.Format("UPDATE sklad SET Qugo= Qugo - @count WHERE ID = @Product");
            MySqlCommand cmd = new MySqlCommand(sql1, db.GetConnection());
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@Product", id_product);
            cmd.ExecuteNonQuery();
            db.closeconnectoin();


            Console.WriteLine(button.Name);
        }
        private void addFlw(int i, FlowLayoutPanel flw)
        {
            FlowLayoutPanel nbom = new FlowLayoutPanel();
            nbom.Name = "flw" + i;
      
            nbom.BackColor = Color.Teal;

            nbom.Location = new Point(40, i * 100 + 50);
            nbom.Size = new System.Drawing.Size(120, 170);

            flw.Controls.Add(nbom);
            addPicture(i, nbom);
            addLabel(i, nbom);
            addtxtBox(i, nbom);
            addButton(i, nbom);


        }

        private void ammu_Load(object sender, EventArgs e)
        {


            data.Clear();
            data = selectTable();
            //FlowLayoutPanel flw = flw_Main;
            for (int i = 0; i < data.Rows.Count; i++)
            {

                addFlw(i, flw_MainAm);

                Console.WriteLine("Имя:" + flw_MainAm.Name);
                Console.WriteLine("Loc:" + flw_MainAm.Location);

            }
            flw_MainAm = null;
        }

        private void flw_MainAm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
