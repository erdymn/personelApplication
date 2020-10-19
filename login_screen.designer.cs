namespace OOP_Project
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.picB_1 = new System.Windows.Forms.PictureBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.checkB_1 = new System.Windows.Forms.CheckBox();
            this.picB_2 = new System.Windows.Forms.PictureBox();
            this.picB_3 = new System.Windows.Forms.PictureBox();
            this.t_1 = new System.Windows.Forms.Timer(this.components);
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.t_2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picB_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_3)).BeginInit();
            this.SuspendLayout();
            // 
            // picB_1
            // 
            this.picB_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.picB_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_1.BackgroundImage")));
            this.picB_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_1.Location = new System.Drawing.Point(22, 12);
            this.picB_1.Name = "picB_1";
            this.picB_1.Size = new System.Drawing.Size(306, 104);
            this.picB_1.TabIndex = 0;
            this.picB_1.TabStop = false;
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_1.HideSelection = false;
            this.txt_1.Location = new System.Drawing.Point(95, 135);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(223, 24);
            this.txt_1.TabIndex = 1;
            this.txt_1.Text = "username";
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_1.Click += new System.EventHandler(this.txt_1_Click);
            this.txt_1.TabIndexChanged += new System.EventHandler(this.txt_2_Click);
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_2.Location = new System.Drawing.Point(95, 184);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.PasswordChar = '*';
            this.txt_2.Size = new System.Drawing.Size(223, 24);
            this.txt_2.TabIndex = 2;
            this.txt_2.Text = "password";
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_2.Click += new System.EventHandler(this.txt_2_Click);
            this.txt_2.TabIndexChanged += new System.EventHandler(this.login_Click);
            // 
            // checkB_1
            // 
            this.checkB_1.AutoSize = true;
            this.checkB_1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkB_1.Location = new System.Drawing.Point(95, 223);
            this.checkB_1.Name = "checkB_1";
            this.checkB_1.Size = new System.Drawing.Size(109, 19);
            this.checkB_1.TabIndex = 3;
            this.checkB_1.Text = "Remember Me";
            this.checkB_1.UseVisualStyleBackColor = true;
            // 
            // picB_2
            // 
            this.picB_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_2.BackgroundImage")));
            this.picB_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_2.Location = new System.Drawing.Point(32, 135);
            this.picB_2.Name = "picB_2";
            this.picB_2.Size = new System.Drawing.Size(57, 24);
            this.picB_2.TabIndex = 6;
            this.picB_2.TabStop = false;
            // 
            // picB_3
            // 
            this.picB_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_3.BackgroundImage")));
            this.picB_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_3.Location = new System.Drawing.Point(32, 184);
            this.picB_3.Name = "picB_3";
            this.picB_3.Size = new System.Drawing.Size(57, 24);
            this.picB_3.TabIndex = 7;
            this.picB_3.TabStop = false;
            // 
            // t_1
            // 
            this.t_1.Interval = 20;
            this.t_1.Tick += new System.EventHandler(this.u_login_Tick);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(153, 315);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(51, 19);
            this.lb_1.TabIndex = 8;
            this.lb_1.Text = "alert1";
            this.lb_1.Visible = false;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.LightBlue;
            this.lb_2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_2.Location = new System.Drawing.Point(113, 367);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(114, 16);
            this.lb_2.TabIndex = 9;
            this.lb_2.Text = "Create an account";
            this.lb_2.Click += new System.EventHandler(this.register_Click);
            // 
            // t_2
            // 
            this.t_2.Interval = 20;
            this.t_2.Tick += new System.EventHandler(this.a_login_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.login_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(190, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(0, 398);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 10);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(350, 410);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.picB_3);
            this.Controls.Add(this.picB_2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkB_1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.picB_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.picB_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.CheckBox checkB_1;
        private System.Windows.Forms.PictureBox picB_2;
        private System.Windows.Forms.PictureBox picB_3;
        private System.Windows.Forms.Timer t_1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Timer t_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

