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
    public partial class prof : Form
    {
        DataTable data = new DataTable();
        public prof()
        {
            InitializeComponent();
        }

   

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public DataTable selectTable()
        {
            DB db = new DB();
            DataTable data = new DataTable();
            data.Clear();
            string sql = String.Format("SELECT * FROM sklad WHERE Type = 'cartridges'");
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
            pa.Image = Image.FromFile("C:/Users/Матвей/Desktop/Новая папка (3)/Курсовик/Курсовик/Resources/cartridges1.png");
            pa.SizeMode = PictureBoxSizeMode.StretchImage;
            pa.Dock = DockStyle.Top;
            pa.Size = new Size(75, 75);

            flw.Controls.Add(pa);
        }

        private void addLabel(int i, FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "lbl" + i;
            nbomb.ForeColor = Color.Black;
            nbomb.Dock = DockStyle.Top;
            nbomb.Text = data.Rows[i][2].ToString();
            nbomb.TextAlign = ContentAlignment.TopCenter;
            nbomb.Font = new System.Drawing.Font("Comic Sans UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            flw.Controls.Add(nbomb);
        }
        private void addLabelPrice(int i, FlowLayoutPanel flw)
        {
            Label nbomb = new Label();
            nbomb.Name = "lblPrice" + i;
            nbomb.ForeColor = Color.Black;
            nbomb.Dock = DockStyle.Top;
            nbomb.Text = data.Rows[i][4].ToString() + " ₽";
            nbomb.TextAlign = ContentAlignment.TopCenter;
            nbomb.Font = new System.Drawing.Font("Comic Sans UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            flw.Controls.Add(nbomb);
        }
        private void addtxtBox(int i, FlowLayoutPanel flw)
        {
            TextBox nbomb = new TextBox();
            nbomb.Name = "txt" + data.Rows[i][0].ToString();
            nbomb.Dock = DockStyle.Top;
            nbomb.Width = 110;

            flw.Controls.Add(nbomb);
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
            string sql1 = String.Format("UPDATE sklad SET Qugo= Qugo - @count WHERE ID = @Product AND Qugo >= @count ");

            MySqlCommand cmd = new MySqlCommand(sql1, db.GetConnection());
            cmd.Parameters.AddWithValue("@count", count);
            cmd.Parameters.AddWithValue("@Product", id_product);
            Console.WriteLine(cmd.ExecuteNonQuery());

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы купили товар");
            }
            else
            {
                MessageBox.Show("Выбирите кол-во товара меньше");
            }

            db.closeconnectoin();




        }
        private void addFlw(int i, FlowLayoutPanel flw)
        {
            FlowLayoutPanel nbomb = new FlowLayoutPanel();
            nbomb.Name = "flw" + i;

            nbomb.BackColor = Color.Teal;

            nbomb.Location = new Point(40, i * 100 + 50);
            nbomb.Size = new System.Drawing.Size(120, 190);

            flw.Controls.Add(nbomb);
            addPicture(i, nbomb);
            addLabel(i, nbomb);
            addLabelPrice(i, nbomb);
            addtxtBox(i, nbomb);
            addButton(i, nbomb);


        }

        private void prof_Load(object sender, EventArgs e)
        {


            data.Clear();
            data = selectTable();
            //FlowLayoutPanel flw = flw_Main;
            for (int i = 0; i < data.Rows.Count; i++)
            {

                addFlw(i, flowLayoutPanel1);

                Console.WriteLine("Имя:" + flowLayoutPanel1.Name);
                Console.WriteLine("Loc:" + flowLayoutPanel1.Location);

            }
            flowLayoutPanel1 = null;
        }
    }
}
