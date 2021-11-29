
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlNaw = new System.Windows.Forms.Panel();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnAvt = new System.Windows.Forms.Button();
            this.BtnPist = new System.Windows.Forms.Button();
            this.BtnAmmu = new System.Windows.Forms.Button();
            this.BtnRoc = new System.Windows.Forms.Button();
            this.BtnSett = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnlna = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(183, 143);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
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
            // PnlNaw
            // 
            this.PnlNaw.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PnlNaw.Location = new System.Drawing.Point(0, 193);
            this.PnlNaw.Name = "PnlNaw";
            this.PnlNaw.Size = new System.Drawing.Size(3, 100);
            this.PnlNaw.TabIndex = 7;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.Lime;
            this.BtnDashboard.Image = global::Курсовик.Properties.Resources.premium_icon_barracks_2046897__1_;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 143);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(183, 42);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Profile";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.BtnDashboard.Leave += new System.EventHandler(this.BtnDashboard_Leave);
            // 
            // BtnAvt
            // 
            this.BtnAvt.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAvt.FlatAppearance.BorderSize = 0;
            this.BtnAvt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvt.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvt.ForeColor = System.Drawing.Color.Lime;
            this.BtnAvt.Image = global::Курсовик.Properties.Resources.free_icon_rifle_2062174__1_;
            this.BtnAvt.Location = new System.Drawing.Point(0, 185);
            this.BtnAvt.Name = "BtnAvt";
            this.BtnAvt.Size = new System.Drawing.Size(183, 42);
            this.BtnAvt.TabIndex = 2;
            this.BtnAvt.Text = "Automatic ";
            this.BtnAvt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAvt.UseVisualStyleBackColor = true;
            this.BtnAvt.Click += new System.EventHandler(this.button1_Click);
            this.BtnAvt.Leave += new System.EventHandler(this.BtnAvt_Leave);
            // 
            // BtnPist
            // 
            this.BtnPist.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPist.FlatAppearance.BorderSize = 0;
            this.BtnPist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPist.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPist.ForeColor = System.Drawing.Color.Lime;
            this.BtnPist.Image = global::Курсовик.Properties.Resources.premium_icon_gun_2062249;
            this.BtnPist.Location = new System.Drawing.Point(0, 227);
            this.BtnPist.Name = "BtnPist";
            this.BtnPist.Size = new System.Drawing.Size(183, 42);
            this.BtnPist.TabIndex = 3;
            this.BtnPist.Text = "Pistol\r\n";
            this.BtnPist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPist.UseVisualStyleBackColor = true;
            this.BtnPist.Click += new System.EventHandler(this.button2_Click);
            this.BtnPist.Leave += new System.EventHandler(this.BtnPist_Leave);
            // 
            // BtnAmmu
            // 
            this.BtnAmmu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAmmu.FlatAppearance.BorderSize = 0;
            this.BtnAmmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAmmu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmmu.ForeColor = System.Drawing.Color.Lime;
            this.BtnAmmu.Image = global::Курсовик.Properties.Resources.premium_icon_bullet_proof_vest_2062187;
            this.BtnAmmu.Location = new System.Drawing.Point(0, 269);
            this.BtnAmmu.Name = "BtnAmmu";
            this.BtnAmmu.Size = new System.Drawing.Size(183, 42);
            this.BtnAmmu.TabIndex = 4;
            this.BtnAmmu.Text = "Ammunition";
            this.BtnAmmu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAmmu.UseVisualStyleBackColor = true;
            this.BtnAmmu.Click += new System.EventHandler(this.BtnAmmu_Click);
            this.BtnAmmu.Leave += new System.EventHandler(this.BtnAmmu_Leave);
            // 
            // BtnRoc
            // 
            this.BtnRoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRoc.FlatAppearance.BorderSize = 0;
            this.BtnRoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoc.ForeColor = System.Drawing.Color.Lime;
            this.BtnRoc.Image = global::Курсовик.Properties.Resources.premium_icon_torpedo_2062254;
            this.BtnRoc.Location = new System.Drawing.Point(0, 311);
            this.BtnRoc.Name = "BtnRoc";
            this.BtnRoc.Size = new System.Drawing.Size(183, 42);
            this.BtnRoc.TabIndex = 5;
            this.BtnRoc.Text = "Rockets";
            this.BtnRoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnRoc.UseVisualStyleBackColor = true;
            this.BtnRoc.Click += new System.EventHandler(this.BtnRoc_Click);
            this.BtnRoc.Leave += new System.EventHandler(this.BtnRoc_Leave);
            // 
            // BtnSett
            // 
            this.BtnSett.FlatAppearance.BorderSize = 0;
            this.BtnSett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSett.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSett.ForeColor = System.Drawing.Color.LimeGreen;
            this.BtnSett.Image = global::Курсовик.Properties.Resources.premium_icon_white_flag_2062227;
            this.BtnSett.Location = new System.Drawing.Point(0, 535);
            this.BtnSett.Name = "BtnSett";
            this.BtnSett.Size = new System.Drawing.Size(186, 42);
            this.BtnSett.TabIndex = 6;
            this.BtnSett.Text = "Settings";
            this.BtnSett.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSett.UseVisualStyleBackColor = true;
            this.BtnSett.Click += new System.EventHandler(this.BtnSett_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Pnlna);
            this.panel1.Controls.Add(this.BtnSett);
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
            this.panel1.Size = new System.Drawing.Size(183, 577);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pnlna
            // 
            this.Pnlna.BackColor = System.Drawing.Color.Lime;
            this.Pnlna.Location = new System.Drawing.Point(0, 193);
            this.Pnlna.Name = "Pnlna";
            this.Pnlna.Size = new System.Drawing.Size(3, 100);
            this.Pnlna.TabIndex = 7;
            this.Pnlna.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlna_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button BtnSett;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnlna;
    }
}

