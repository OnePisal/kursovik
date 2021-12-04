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
    public partial class pistol : Form
    {
        DataTable data = new DataTable();
        public pistol()
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
            string sql = String.Format("SELECT * FROM sklad WHERE Type = 'pistol'");
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
            pa.Image = Image.FromFile("C:/Users/Матвей/Desktop/важно пиздец/курсач 3000/Курсовик/Курсовик/Resources/premium-icon-gun-2062249.png");
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
            nbom.Name = "txt" + i;
            nbom.Dock = DockStyle.Top;
            nbom.Width = 110;

            flw.Controls.Add(nbom);
        }
        private void addButton(int i, FlowLayoutPanel flw)
        {
            Button nbom = new Button();
            nbom.Name = "btn" + i;
            nbom.Dock = DockStyle.Top;
            nbom.Text = "Купить";
            nbom.Width = 110;
            nbom.BackColor = Color.Teal;
            //nbomb.Text = checks.BalanceCheck[i] + " " + checks.CurrencyCheck[i];
            flw.Controls.Add(nbom);
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

        private void pistol_Load(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pistol_Load_1(object sender, EventArgs e)
        {
            data.Clear();
            data = selectTable();
            //FlowLayoutPanel flw = flw_Main;
            for (int i = 0; i < data.Rows.Count; i++)
            {

                addFlw(i, flw_ma);

                Console.WriteLine("Имя:" + flw_ma.Name);
                Console.WriteLine("Loc:" + flw_ma.Location);

            }
            flw_ma = null;
        }

        private void flw_ma_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
