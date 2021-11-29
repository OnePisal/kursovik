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
            Pnlna.Height = BtnDashboard.Height;
            Pnlna.Top = BtnDashboard.Top;
            Pnlna.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.Teal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnAvt.Height;
            Pnlna.Top = BtnAvt.Top;
            Pnlna.Left = BtnAvt.Left;
            BtnAvt.BackColor = Color.Teal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnPist.Height;
            Pnlna.Top = BtnPist.Top;
            Pnlna.Left = BtnPist.Left;
            BtnPist.BackColor = Color.Teal;
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

        }

        private void BtnAmmu_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnAmmu.Height;
            Pnlna.Top = BtnAmmu.Top;
            Pnlna.Left = BtnAmmu.Left;
            BtnAmmu.BackColor = Color.Teal;

        }

        private void BtnRoc_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnRoc.Height;
            Pnlna.Top = BtnRoc.Top;
            Pnlna.Left = BtnRoc.Left;
            BtnRoc.BackColor = Color.Teal ;
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

        private void Pnlna_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSett_Click(object sender, EventArgs e)
        {
            Pnlna.Height = BtnSett.Height;
            Pnlna.Top = BtnSett.Top;
            Pnlna.Left = BtnSett.Left;
            BtnSett.BackColor = Color.Teal;
        }
    }
}
