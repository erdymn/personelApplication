namespace OOP_Project
{
    partial class regster_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regster_screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_4 = new System.Windows.Forms.Label();
            this.picB_1 = new System.Windows.Forms.PictureBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.lb_3 = new System.Windows.Forms.Label();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.t_register = new System.Windows.Forms.Timer(this.components);
            this.log_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.log_lbl);
            this.panel1.Controls.Add(this.lb_4);
            this.panel1.Controls.Add(this.picB_1);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.lb_3);
            this.panel1.Controls.Add(this.txt_3);
            this.panel1.Controls.Add(this.lb_2);
            this.panel1.Controls.Add(this.txt_2);
            this.panel1.Controls.Add(this.lb_1);
            this.panel1.Controls.Add(this.txt_1);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.Location = new System.Drawing.Point(334, 259);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(0, 15);
            this.lb_4.TabIndex = 11;
            // 
            // picB_1
            // 
            this.picB_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_1.BackgroundImage")));
            this.picB_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_1.Location = new System.Drawing.Point(12, 23);
            this.picB_1.Name = "picB_1";
            this.picB_1.Size = new System.Drawing.Size(404, 94);
            this.picB_1.TabIndex = 10;
            this.picB_1.TabStop = false;
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Tomato;
            this.btn_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(249, 297);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(72, 40);
            this.btn_2.TabIndex = 9;
            this.btn_2.Text = "Cancel";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(12, 254);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(139, 20);
            this.lb_3.TabIndex = 8;
            this.lb_3.Text = "Confirm Password";
            // 
            // txt_3
            // 
            this.txt_3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_3.Location = new System.Drawing.Point(156, 253);
            this.txt_3.Multiline = true;
            this.txt_3.Name = "txt_3";
            this.txt_3.PasswordChar = '*';
            this.txt_3.Size = new System.Drawing.Size(163, 27);
            this.txt_3.TabIndex = 7;
            this.txt_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_3.TextChanged += new System.EventHandler(this.conf_tick);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(72, 197);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(80, 20);
            this.lb_2.TabIndex = 6;
            this.lb_2.Text = "Password";
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.Location = new System.Drawing.Point(156, 198);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.PasswordChar = '*';
            this.txt_2.Size = new System.Drawing.Size(163, 27);
            this.txt_2.TabIndex = 5;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(66, 144);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(86, 20);
            this.lb_1.TabIndex = 4;
            this.lb_1.Text = "Username ";
            this.lb_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(158, 143);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(163, 27);
            this.txt_1.TabIndex = 1;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(156, 297);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(72, 40);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Sign Up";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // t_register
            // 
            this.t_register.Interval = 1000;
            this.t_register.Tick += new System.EventHandler(this.t_register_Tick);
            // 
            // log_lbl
            // 
            this.log_lbl.AutoSize = true;
            this.log_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_lbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.log_lbl.Location = new System.Drawing.Point(151, 383);
            this.log_lbl.Name = "log_lbl";
            this.log_lbl.Size = new System.Drawing.Size(0, 31);
            this.log_lbl.TabIndex = 12;
            // 
            // regster_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "regster_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.PictureBox picB_1;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Timer t_register;
        private System.Windows.Forms.Label log_lbl;
    }
}