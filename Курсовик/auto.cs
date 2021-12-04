using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовик
{
    public partial class auto : Form
    {
        DataTable data = new DataTable();
        public auto()
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
            string sql = String.Format("SELECT * FROM sklad WHERE Type = 'automatic' ");
            db.Openconnection();
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader sqldr = command.ExecuteReader();
            data.Load(sqldr);
            db.closeconnectoin();
            return data;
        }



        private void addPicture(int i, FlowLayoutPanel flw)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "pb" + i;
            pb.Image = Image.FromFile("C:/Users/Матвей/Desktop/важно пиздец/курсач 3000/Курсовик/Курсовик/Resources/free-icon-rifle-2062174 (1).png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Top;
            pb.Size = new Size(75, 75);
            
            flw.Controls.Add(pb);
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
            //nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbomb);
        }

        private void addtxtBox(int i, FlowLayoutPanel flw)
        {
            TextBox nbomb = new TextBox();
            nbomb.Name = "txt" + i;
            nbomb.Dock = DockStyle.Top;
            nbomb.Width = 110;

            flw.Controls.Add(nbomb);
        }
        private void addButton(int i, FlowLayoutPanel flw)
        {
            Button nbomb = new Button();
            nbomb.Name = "btn" + i;
            nbomb.Dock = DockStyle.Top;
            nbomb.Text = "Купить";
            nbomb.Width = 110;
            nbomb.BackColor = Color.Teal;  
            //nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbomb);
        }

        private void addFlw(int i, FlowLayoutPanel flw)
        {
            FlowLayoutPanel nbomb = new FlowLayoutPanel();
            nbomb.Name = "flw" + i;
         
            nbomb.BackColor = Color.Teal;

            nbomb.Location = new Point(40, i * 100 + 50);
            nbomb.Size = new System.Drawing.Size(120, 170);

            flw.Controls.Add(nbomb);
            addPicture(i, nbomb);
            addLabel(i, nbomb);
            addtxtBox(i, nbomb);
            addButton(i, nbomb);

            
        }

        private void auto_Load(object sender, EventArgs e)
        {

            
            data.Clear();
            data = selectTable();
            //FlowLayoutPanel flw = flw_Main;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                
                addFlw(i, flw_Main);

                Console.WriteLine("Имя:" + flw_Main.Name);
                Console.WriteLine("Loc:" + flw_Main.Location);
                
            }
            flw_Main = null;
        }

        private void flw_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
