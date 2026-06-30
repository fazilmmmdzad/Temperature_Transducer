namespace TemperatureTransducer
{
    partial class Temperature_Transducer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperature_Transducer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Minimized = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Degree = new System.Windows.Forms.TextBox();
            this.lbl_Degree = new System.Windows.Forms.Label();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_K = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_F = new System.Windows.Forms.TextBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_K = new System.Windows.Forms.TextBox();
            this.copy_All = new System.Windows.Forms.PictureBox();
            this.copy_K = new System.Windows.Forms.PictureBox();
            this.copy_C = new System.Windows.Forms.PictureBox();
            this.copy_F = new System.Windows.Forms.PictureBox();
            this.btn_information = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_F)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Minimized);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Honey Degrees";
            // 
            // btn_Minimized
            // 
            this.btn_Minimized.FlatAppearance.BorderSize = 0;
            this.btn_Minimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_Minimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimized.Image = global::TemperatureTransducer.Properties.Resources.minimize;
            this.btn_Minimized.Location = new System.Drawing.Point(755, 0);
            this.btn_Minimized.Name = "btn_Minimized";
            this.btn_Minimized.Size = new System.Drawing.Size(47, 41);
            this.btn_Minimized.TabIndex = 1;
            this.toolTip.SetToolTip(this.btn_Minimized, "Minimize");
            this.btn_Minimized.UseVisualStyleBackColor = true;
            this.btn_Minimized.Click += new System.EventHandler(this.btn_Minimized_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::TemperatureTransducer.Properties.Resources.close;
            this.btn_Exit.Location = new System.Drawing.Point(803, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(47, 41);
            this.btn_Exit.TabIndex = 1;
            this.toolTip.SetToolTip(this.btn_Exit, "Close");
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Image = global::TemperatureTransducer.Properties.Resources.Honey_Degrees_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Degree
            // 
            this.txt_Degree.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Degree.ForeColor = System.Drawing.Color.Black;
            this.txt_Degree.Location = new System.Drawing.Point(211, 173);
            this.txt_Degree.Name = "txt_Degree";
            this.txt_Degree.Size = new System.Drawing.Size(409, 29);
            this.txt_Degree.TabIndex = 2;
            this.txt_Degree.TextChanged += new System.EventHandler(this.txt_Degree_TextChanged);
            this.txt_Degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Degree_KeyPress);
            // 
            // lbl_Degree
            // 
            this.lbl_Degree.AutoSize = true;
            this.lbl_Degree.BackColor = System.Drawing.Color.White;
            this.lbl_Degree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Degree.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Degree.ForeColor = System.Drawing.Color.Turquoise;
            this.lbl_Degree.Location = new System.Drawing.Point(218, 177);
            this.lbl_Degree.Name = "lbl_Degree";
            this.lbl_Degree.Size = new System.Drawing.Size(67, 23);
            this.lbl_Degree.TabIndex = 3;
            this.lbl_Degree.Text = "Degree";
            this.lbl_Degree.Click += new System.EventHandler(this.lbl_Degree_Click);
            // 
            // btn_F
            // 
            this.btn_F.FlatAppearance.BorderSize = 0;
            this.btn_F.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_F.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F.Location = new System.Drawing.Point(349, 127);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(40, 40);
            this.btn_F.TabIndex = 1;
            this.btn_F.Text = "°F";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // btn_C
            // 
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.Location = new System.Drawing.Point(402, 127);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(40, 40);
            this.btn_C.TabIndex = 1;
            this.btn_C.Text = "°C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_K
            // 
            this.btn_K.FlatAppearance.BorderSize = 0;
            this.btn_K.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_K.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_K.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_K.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_K.Location = new System.Drawing.Point(454, 127);
            this.btn_K.Name = "btn_K";
            this.btn_K.Size = new System.Drawing.Size(40, 40);
            this.btn_K.TabIndex = 1;
            this.btn_K.Text = "K";
            this.btn_K.UseVisualStyleBackColor = true;
            this.btn_K.Click += new System.EventHandler(this.btn_K_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "°F :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "°C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "K :";
            // 
            // txt_F
            // 
            this.txt_F.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_F.ForeColor = System.Drawing.Color.Black;
            this.txt_F.Location = new System.Drawing.Point(257, 243);
            this.txt_F.Name = "txt_F";
            this.txt_F.ReadOnly = true;
            this.txt_F.Size = new System.Drawing.Size(333, 29);
            this.txt_F.TabIndex = 2;
            this.txt_F.TextChanged += new System.EventHandler(this.txt_Degree_TextChanged);
            this.txt_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Degree_KeyPress);
            // 
            // txt_C
            // 
            this.txt_C.BackColor = System.Drawing.SystemColors.Control;
            this.txt_C.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_C.ForeColor = System.Drawing.Color.Black;
            this.txt_C.Location = new System.Drawing.Point(257, 278);
            this.txt_C.Name = "txt_C";
            this.txt_C.ReadOnly = true;
            this.txt_C.Size = new System.Drawing.Size(333, 29);
            this.txt_C.TabIndex = 2;
            this.txt_C.TextChanged += new System.EventHandler(this.txt_Degree_TextChanged);
            this.txt_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Degree_KeyPress);
            // 
            // txt_K
            // 
            this.txt_K.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_K.ForeColor = System.Drawing.Color.Black;
            this.txt_K.Location = new System.Drawing.Point(257, 313);
            this.txt_K.Name = "txt_K";
            this.txt_K.ReadOnly = true;
            this.txt_K.Size = new System.Drawing.Size(333, 29);
            this.txt_K.TabIndex = 2;
            this.txt_K.TextChanged += new System.EventHandler(this.txt_Degree_TextChanged);
            this.txt_K.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Degree_KeyPress);
            // 
            // copy_All
            // 
            this.copy_All.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.copy_All.Image = global::TemperatureTransducer.Properties.Resources.copy__2_;
            this.copy_All.Location = new System.Drawing.Point(803, 397);
            this.copy_All.Name = "copy_All";
            this.copy_All.Size = new System.Drawing.Size(30, 30);
            this.copy_All.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_All.TabIndex = 4;
            this.copy_All.TabStop = false;
            this.toolTip.SetToolTip(this.copy_All, "Copy All (Ctrl + C)");
            this.copy_All.Click += new System.EventHandler(this.copy_All_Click);
            // 
            // copy_K
            // 
            this.copy_K.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.copy_K.Image = global::TemperatureTransducer.Properties.Resources.copy__1_;
            this.copy_K.Location = new System.Drawing.Point(606, 310);
            this.copy_K.Name = "copy_K";
            this.copy_K.Size = new System.Drawing.Size(30, 30);
            this.copy_K.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_K.TabIndex = 4;
            this.copy_K.TabStop = false;
            this.toolTip.SetToolTip(this.copy_K, "Copy K Input");
            this.copy_K.Click += new System.EventHandler(this.copy_K_Click);
            // 
            // copy_C
            // 
            this.copy_C.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.copy_C.Image = global::TemperatureTransducer.Properties.Resources.copy__1_;
            this.copy_C.Location = new System.Drawing.Point(606, 275);
            this.copy_C.Name = "copy_C";
            this.copy_C.Size = new System.Drawing.Size(30, 30);
            this.copy_C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_C.TabIndex = 4;
            this.copy_C.TabStop = false;
            this.toolTip.SetToolTip(this.copy_C, "Copy °C Input");
            this.copy_C.Click += new System.EventHandler(this.copy_C_Click);
            // 
            // copy_F
            // 
            this.copy_F.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.copy_F.Image = global::TemperatureTransducer.Properties.Resources.copy__1_;
            this.copy_F.Location = new System.Drawing.Point(606, 240);
            this.copy_F.Name = "copy_F";
            this.copy_F.Size = new System.Drawing.Size(30, 30);
            this.copy_F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copy_F.TabIndex = 4;
            this.copy_F.TabStop = false;
            this.toolTip.SetToolTip(this.copy_F, "Copy °F Input");
            this.copy_F.Click += new System.EventHandler(this.copy_F_Click);
            // 
            // btn_information
            // 
            this.btn_information.FlatAppearance.BorderSize = 0;
            this.btn_information.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_information.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_information.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_information.Image = global::TemperatureTransducer.Properties.Resources.information;
            this.btn_information.Location = new System.Drawing.Point(14, 397);
            this.btn_information.Name = "btn_information";
            this.btn_information.Size = new System.Drawing.Size(37, 41);
            this.btn_information.TabIndex = 1;
            this.toolTip.SetToolTip(this.btn_information, "Information (Ctrl + I)");
            this.btn_information.UseVisualStyleBackColor = true;
            this.btn_information.Click += new System.EventHandler(this.btn_information_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.minimizeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // Temperature_Transducer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.copy_All);
            this.Controls.Add(this.copy_K);
            this.Controls.Add(this.copy_C);
            this.Controls.Add(this.copy_F);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_information);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Degree);
            this.Controls.Add(this.txt_K);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.txt_F);
            this.Controls.Add(this.txt_Degree);
            this.Controls.Add(this.btn_K);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_F);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Temperature_Transducer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honey Degrees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copy_F)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Minimized;
        private System.Windows.Forms.TextBox txt_Degree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Degree;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_K;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_F;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_K;
        private System.Windows.Forms.Button btn_information;
        private System.Windows.Forms.PictureBox copy_F;
        private System.Windows.Forms.PictureBox copy_C;
        private System.Windows.Forms.PictureBox copy_K;
        private System.Windows.Forms.PictureBox copy_All;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
    }
}

