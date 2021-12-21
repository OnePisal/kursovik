
namespace Курсовик
{
    partial class regform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.avtoriz = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Usname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.avtoriz);
            this.panel1.Controls.Add(this.registration);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.Pass);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Usname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 354);
            this.panel1.TabIndex = 1;

            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // avtoriz
            // 
            this.avtoriz.AutoSize = true;
            this.avtoriz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.avtoriz.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtoriz.Location = new System.Drawing.Point(226, 255);
            this.avtoriz.Name = "avtoriz";
            this.avtoriz.Size = new System.Drawing.Size(93, 13);
            this.avtoriz.TabIndex = 11;
            this.avtoriz.Text = "Авторизоваться ";
            this.avtoriz.Click += new System.EventHandler(this.avtoriz_Click);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.Teal;
            this.registration.FlatAppearance.BorderSize = 0;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Location = new System.Drawing.Point(200, 211);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(151, 31);
            this.registration.TabIndex = 10;
            this.registration.Text = "Зарегестрироваться";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Teal;
            this.Login.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(45, 157);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(205, 29);
            this.Login.TabIndex = 9;

            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Teal;
            this.Pass.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(296, 157);
            this.Pass.Multiline = true;
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(209, 29);
            this.Pass.TabIndex = 8;

            this.Pass.Enter += new System.EventHandler(this.Pass_Enter);
            this.Pass.Leave += new System.EventHandler(this.Pass_Leave);
            // 
            // Surname
            // 
            this.Surname.BackColor = System.Drawing.Color.Teal;
            this.Surname.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(45, 122);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(205, 29);
            this.Surname.TabIndex = 6;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Курсовик.Properties.Resources.locked;
            this.pictureBox2.Location = new System.Drawing.Point(256, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;

            // 
            // Usname
            // 
            this.Usname.BackColor = System.Drawing.Color.Teal;
            this.Usname.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usname.Location = new System.Drawing.Point(296, 122);
            this.Usname.Multiline = true;
            this.Usname.Name = "Usname";
            this.Usname.Size = new System.Drawing.Size(209, 29);
            this.Usname.TabIndex = 2;
            this.Usname.TextChanged += new System.EventHandler(this.Usname_TextChanged);
            this.Usname.Enter += new System.EventHandler(this.Usname_Enter);
            this.Usname.Leave += new System.EventHandler(this.Usname_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Курсовик.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(5, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(494, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 354);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regform";
            this.Text = "regform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Usname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label avtoriz;
    }
}