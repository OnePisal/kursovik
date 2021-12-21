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
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();



        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void Usname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usname_Enter(object sender, EventArgs e)
        {
            if (Usname.Text == "Введите организ")
            {
                Usname.Text = "";
                Usname.ForeColor = Color.Black;
            }
        }

        private void Usname_Leave(object sender, EventArgs e)
        {
            if (Usname.Text == "")
            {
                Usname.Text = "Введите организ";
                Usname.ForeColor = Color.DarkSlateGray;

            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Введите Email")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Введите Email";
                Surname.ForeColor = Color.DarkSlateGray;
            }
        }



        private void Pass_Enter(object sender, EventArgs e)
        {
            if (Pass.Text == "Введите пароль")
            {
                Pass.Text = "";
                Pass.ForeColor = Color.Black;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
            if (Pass.Text == "")
            {
                Pass.Text = "Введите пароль";
                Pass.ForeColor = Color.DarkSlateGray;
            }
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите Логин")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите Логин";
                Login.ForeColor = Color.DarkSlateGray;
            }
        }


        private void Registration_Click(object sender, EventArgs e)
        {
            if (Usname.Text == "Введите организ")
            {
                MessageBox.Show("Введите организ");
                return;
            }

            if (Surname.Text == "")
            {
                MessageBox.Show("Введите Email");
                return;
            }
            if (Pass.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (Login.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (checkUser())
                return;


            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO Customer (Login, Password, Name_org, Email) VALUES (@Login ,@Password ,@Name_org ,@Email )", db.GetConnection());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Pass.Text;
            command.Parameters.Add("@Name_org", MySqlDbType.VarChar).Value = Usname.Text;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Surname.Text;



            db.Openconnection();

            if (command.ExecuteNonQuery() == 1)

                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");


            db.closeconnectoin();
        }
        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable tabel = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Customer` WHERE `Login`= @uL ", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;



            adapter.SelectCommand = command;

            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует");
                return true;
            }

            else
                return false;
        }

        private void avtoriz_Click(object sender, EventArgs e)
        {
            this.Hide();
            log log = new log();
            log.Show();
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}