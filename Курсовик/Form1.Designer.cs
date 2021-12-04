
namespace Курсовик
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlNaw = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnlna = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tank = new System.Windows.Forms.Button();
            this.Plan = new System.Windows.Forms.Button();
            this.Btncart = new System.Windows.Forms.Button();
            this.BtnRoc = new System.Windows.Forms.Button();
            this.BtnAmmu = new System.Windows.Forms.Button();
            this.BtnPist = new System.Windows.Forms.Button();
            this.BtnAvt = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PnlNaw);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 137);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PnlNaw
            // 
            this.PnlNaw.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PnlNaw.Location = new System.Drawing.Point(0, 193);
            this.PnlNaw.Name = "PnlNaw";
            this.PnlNaw.Size = new System.Drawing.Size(3, 100);
            this.PnlNaw.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "some user text here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Pnlna);
            this.panel1.Controls.Add(this.tank);
            this.panel1.Controls.Add(this.Plan);
            this.panel1.Controls.Add(this.Btncart);
            this.panel1.Controls.Add(this.BtnRoc);
            this.panel1.Controls.Add(this.BtnAmmu);
            this.panel1.Controls.Add(this.BtnPist);
            this.panel1.Controls.Add(this.BtnAvt);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 577);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pnlna
            // 
            this.Pnlna.BackColor = System.Drawing.Color.Lime;
            this.Pnlna.Location = new System.Drawing.Point(0, 137);
            this.Pnlna.Name = "Pnlna";
            this.Pnlna.Size = new System.Drawing.Size(5, 440);
            this.Pnlna.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(753, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.panel3);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmenu.Location = new System.Drawing.Point(175, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(776, 577);
            this.panelmenu.TabIndex = 9;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 28);
            this.panel3.TabIndex = 9;
            // 
            // tank
            // 
            this.tank.Dock = System.Windows.Forms.DockStyle.Top;
            this.tank.FlatAppearance.BorderSize = 0;
            this.tank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tank.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tank.ForeColor = System.Drawing.Color.Lime;
            this.tank.Image = global::Курсовик.Properties.Resources.premium_icon_tank_2046893__1_;
            this.tank.Location = new System.Drawing.Point(0, 389);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(175, 42);
            this.tank.TabIndex = 5;
            this.tank.Text = "Military equipment";
            this.tank.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tank.UseVisualStyleBackColor = true;
            this.tank.Click += new System.EventHandler(this.tank_Click);
            this.tank.Leave += new System.EventHandler(this.tank_Leave);
            // 
            // Plan
            // 
            this.Plan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Plan.FlatAppearance.BorderSize = 0;
            this.Plan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plan.ForeColor = System.Drawing.Color.Lime;
            this.Plan.Image = global::Курсовик.Properties.Resources.premium_icon_military_aircraft_2046891__1_;
            this.Plan.Location = new System.Drawing.Point(0, 347);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(175, 42);
            this.Plan.TabIndex = 5;
            this.Plan.Text = "Planes";
            this.Plan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Plan.UseVisualStyleBackColor = true;
            this.Plan.Click += new System.EventHandler(this.Plan_Click);
            this.Plan.Leave += new System.EventHandler(this.Plan_Leave);
            // 
            // Btncart
            // 
            this.Btncart.FlatAppearance.BorderSize = 0;
            this.Btncart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncart.ForeColor = System.Drawing.Color.Lime;
            this.Btncart.Image = global::Курсовик.Properties.Resources.sklad;
            this.Btncart.Location = new System.Drawing.Point(0, 535);
            this.Btncart.Name = "Btncart";
            this.Btncart.Size = new System.Drawing.Size(175, 42);
            this.Btncart.TabIndex = 6;
            this.Btncart.Text = "Sklad";
            this.Btncart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btncart.UseVisualStyleBackColor = true;
            this.Btncart.Click += new System.EventHandler(this.BtnSett_Click);
            // 
            // BtnRoc
            // 
            this.BtnRoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRoc.FlatAppearance.BorderSize = 0;
            this.BtnRoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoc.ForeColor = System.Drawing.Color.Lime;
            this.BtnRoc.Image = global::Курсовик.Properties.Resources.premium_icon_torpedo_2062254;
            this.BtnRoc.Location = new System.Drawing.Point(0, 305);
            this.BtnRoc.Name = "BtnRoc";
            this.BtnRoc.Size = new System.Drawing.Size(175, 42);
            this.BtnRoc.TabIndex = 5;
            this.BtnRoc.Text = "Rockets";
            this.BtnRoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRoc.UseVisualStyleBackColor = true;
            this.BtnRoc.Click += new System.EventHandler(this.BtnRoc_Click);
            this.BtnRoc.Leave += new System.EventHandler(this.BtnRoc_Leave);
            // 
            // BtnAmmu
            // 
            this.BtnAmmu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAmmu.FlatAppearance.BorderSize = 0;
            this.BtnAmmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAmmu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmmu.ForeColor = System.Drawing.Color.Lime;
            this.BtnAmmu.Image = global::Курсовик.Properties.Resources.premium_icon_bullet_proof_vest_2062187;
            this.BtnAmmu.Location = new System.Drawing.Point(0, 263);
            this.BtnAmmu.Name = "BtnAmmu";
            this.BtnAmmu.Size = new System.Drawing.Size(175, 42);
            this.BtnAmmu.TabIndex = 4;
            this.BtnAmmu.Text = "Ammunition";
            this.BtnAmmu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAmmu.UseVisualStyleBackColor = true;
            this.BtnAmmu.Click += new System.EventHandler(this.BtnAmmu_Click);
            this.BtnAmmu.Leave += new System.EventHandler(this.BtnAmmu_Leave);
            // 
            // BtnPist
            // 
            this.BtnPist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPist.FlatAppearance.BorderSize = 0;
            this.BtnPist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPist.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPist.ForeColor = System.Drawing.Color.Lime;
            this.BtnPist.Image = global::Курсовик.Properties.Resources.premium_icon_gun_2062249;
            this.BtnPist.Location = new System.Drawing.Point(0, 221);
            this.BtnPist.Name = "BtnPist";
            this.BtnPist.Size = new System.Drawing.Size(175, 42);
            this.BtnPist.TabIndex = 3;
            this.BtnPist.Text = "Pistol\r\n";
            this.BtnPist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPist.UseVisualStyleBackColor = true;
            this.BtnPist.Click += new System.EventHandler(this.button2_Click);
            this.BtnPist.Leave += new System.EventHandler(this.BtnPist_Leave);
            // 
            // BtnAvt
            // 
            this.BtnAvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAvt.FlatAppearance.BorderSize = 0;
            this.BtnAvt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvt.ForeColor = System.Drawing.Color.Lime;
            this.BtnAvt.Image = global::Курсовик.Properties.Resources.free_icon_rifle_2062174__1_;
            this.BtnAvt.Location = new System.Drawing.Point(0, 179);
            this.BtnAvt.Name = "BtnAvt";
            this.BtnAvt.Size = new System.Drawing.Size(175, 42);
            this.BtnAvt.TabIndex = 2;
            this.BtnAvt.Text = "Automatic ";
            this.BtnAvt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAvt.UseVisualStyleBackColor = true;
            this.BtnAvt.Click += new System.EventHandler(this.button1_Click);
            this.BtnAvt.Leave += new System.EventHandler(this.BtnAvt_Leave);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Lime;
            this.BtnDashboard.Image = global::Курсовик.Properties.Resources.premium_icon_barracks_2046897__1_;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 137);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(175, 42);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Profile";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Курсовик.Properties.Resources.free_icon_soldier_2062172;
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlNaw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnAvt;
        private System.Windows.Forms.Button BtnPist;
        private System.Windows.Forms.Button BtnAmmu;
        private System.Windows.Forms.Button BtnRoc;
        private System.Windows.Forms.Button Btncart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Plan;
        private System.Windows.Forms.Button tank;
        private System.Windows.Forms.Panel Pnlna;
    }
}

