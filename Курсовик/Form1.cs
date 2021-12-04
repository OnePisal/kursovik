using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Курсовик
{
    public partial class Form1 : Form
    {

        private Form activeForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );


        public Form1()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
          
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnAvt.Height;
            Pnlna.Top = BtnAvt.Top;
            Pnlna.Left = BtnAvt.Left;
            BtnAvt.BackColor = Color.Teal;
            OpenChildForm(new auto(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnPist.Height;
            Pnlna.Top = BtnPist.Top;
            Pnlna.Left = BtnPist.Left;
            BtnPist.BackColor = Color.Teal;
            OpenChildForm(new pistol(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnDashboard.Height;
            Pnlna.Top = BtnDashboard.Top;
            Pnlna.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.Teal;

            OpenChildForm(new prof(), sender);

        }

        private void BtnAmmu_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnAmmu.Height;
            Pnlna.Top = BtnAmmu.Top;
            Pnlna.Left = BtnAmmu.Left;
            BtnAmmu.BackColor = Color.Teal;
            OpenChildForm(new ammu(), sender);

        }

        private void BtnRoc_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnRoc.Height;
            Pnlna.Top = BtnRoc.Top;
            Pnlna.Left = BtnRoc.Left;
            BtnRoc.BackColor = Color.Teal;
            OpenChildForm(new rock(), sender);


        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {

        }

        private void BtnAvt_Leave(object sender, EventArgs e)
        {

        }

        private void BtnPist_Leave(object sender, EventArgs e)
        {

        }

        private void BtnAmmu_Leave(object sender, EventArgs e)
        {

        }

        private void BtnRoc_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void BtnSett_Click(object sender, EventArgs e)
        {
            Pnlna.Height = Btncart.Height;
            Pnlna.Top = Btncart.Top;
            Pnlna.Left = Btncart.Left;
            Btncart.BackColor = Color.Teal;

            OpenChildForm(new cart(), sender);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelmenu.Controls.Add(childForm);
            this.panelmenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panel2.Text = childForm.Text;
        }
  

        private void Plan_Click(object sender, EventArgs e)
        {
            Pnlna.Height = Plan.Height;
            Pnlna.Top = Plan.Top;
            Pnlna.Left = Plan.Left;
            Plan.BackColor = Color.Teal;

            OpenChildForm(new plan(), sender);
        }

        private void tank_Click(object sender, EventArgs e)
        {
            Pnlna.Height = tank.Height;
            Pnlna.Top = tank.Top;
            Pnlna.Left = tank.Left;
            tank.BackColor = Color.Teal;

            OpenChildForm(new tank(), sender);
        }

        private void Plan_Leave(object sender, EventArgs e)
        {

        }

        private void tank_Leave(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}