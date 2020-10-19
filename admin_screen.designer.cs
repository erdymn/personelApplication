namespace OOP_Project
{
    partial class admin_screen
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.u_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_user = new System.Windows.Forms.ListView();
            this.user_coloumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usertype_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.user_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.update_btn = new System.Windows.Forms.Button();
            this.lb_3 = new System.Windows.Forms.Label();
            this.usertype_cb = new System.Windows.Forms.ComboBox();
            this.confirm_lb = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.u_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(585, 312);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_Click);
            // 
            // u_tab
            // 
            this.u_tab.Controls.Add(this.tabPage1);
            this.u_tab.Controls.Add(this.tabPage2);
            this.u_tab.Location = new System.Drawing.Point(1, 0);
            this.u_tab.Name = "u_tab";
            this.u_tab.SelectedIndex = 0;
            this.u_tab.Size = new System.Drawing.Size(671, 310);
            this.u_tab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_user);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_user
            // 
            this.listView_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.user_coloumn,
            this.usertype_column,
            this.user_info});
            this.listView_user.FullRowSelect = true;
            this.listView_user.GridLines = true;
            this.listView_user.HideSelection = false;
            this.listView_user.Location = new System.Drawing.Point(-4, 0);
            this.listView_user.Name = "listView_user";
            this.listView_user.Size = new System.Drawing.Size(308, 284);
            this.listView_user.TabIndex = 2;
            this.listView_user.UseCompatibleStateImageBehavior = false;
            this.listView_user.View = System.Windows.Forms.View.Details;
            this.listView_user.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passtouser);
            // 
            // user_coloumn
            // 
            this.user_coloumn.Text = "User";
            this.user_coloumn.Width = 80;
            // 
            // usertype_column
            // 
            this.usertype_column.Text = "User type";
            this.usertype_column.Width = 80;
            // 
            // user_info
            // 
            this.user_info.Text = "Salary";
            this.user_info.Width = 80;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(306, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(351, 271);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.CadetBlue;
            this.tabPage4.Controls.Add(this.dlt_btn);
            this.tabPage4.Controls.Add(this.update_btn);
            this.tabPage4.Controls.Add(this.lb_3);
            this.tabPage4.Controls.Add(this.usertype_cb);
            this.tabPage4.Controls.Add(this.confirm_lb);
            this.tabPage4.Controls.Add(this.lb_2);
            this.tabPage4.Controls.Add(this.txt_2);
            this.tabPage4.Controls.Add(this.lb_1);
            this.tabPage4.Controls.Add(this.txt_1);
            this.tabPage4.Controls.Add(this.add_btn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(343, 245);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Add a user";
            this.tabPage4.Click += new System.EventHandler(this.tab_click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.update_btn.Enabled = false;
            this.update_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(255, 147);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(82, 27);
            this.update_btn.TabIndex = 22;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(54, 104);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(76, 20);
            this.lb_3.TabIndex = 20;
            this.lb_3.Text = "User type";
            // 
            // usertype_cb
            // 
            this.usertype_cb.DisplayMember = "Admin";
            this.usertype_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_cb.FormattingEnabled = true;
            this.usertype_cb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usertype_cb.Items.AddRange(new object[] {
            "Admin",
            "Normal User"});
            this.usertype_cb.Location = new System.Drawing.Point(134, 104);
            this.usertype_cb.Name = "usertype_cb";
            this.usertype_cb.Size = new System.Drawing.Size(163, 24);
            this.usertype_cb.TabIndex = 19;
            this.usertype_cb.Text = "Admin";
            // 
            // confirm_lb
            // 
            this.confirm_lb.AutoSize = true;
            this.confirm_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_lb.ForeColor = System.Drawing.Color.DarkGreen;
            this.confirm_lb.Location = new System.Drawing.Point(108, 209);
            this.confirm_lb.Name = "confirm_lb";
            this.confirm_lb.Size = new System.Drawing.Size(147, 16);
            this.confirm_lb.TabIndex = 18;
            this.confirm_lb.Text = "Loading Successfull";
            this.confirm_lb.Visible = false;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(50, 58);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(80, 20);
            this.lb_2.TabIndex = 16;
            this.lb_2.Text = "Password";
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_2.Location = new System.Drawing.Point(134, 59);
            this.txt_2.Multiline = true;
            this.txt_2.Name = "txt_2";
            this.txt_2.PasswordChar = '*';
            this.txt_2.Size = new System.Drawing.Size(163, 27);
            this.txt_2.TabIndex = 15;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(44, 18);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(86, 20);
            this.lb_1.TabIndex = 14;
            this.lb_1.Text = "Username ";
            this.lb_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_1
            // 
            this.txt_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txt_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(136, 17);
            this.txt_1.Multiline = true;
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(163, 27);
            this.txt_1.TabIndex = 13;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.add_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(54, 147);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(82, 27);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add__Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dlt_btn
            // 
            this.dlt_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.dlt_btn.Enabled = false;
            this.dlt_btn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlt_btn.Location = new System.Drawing.Point(157, 147);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(82, 27);
            this.dlt_btn.TabIndex = 23;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = false;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // admin_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 339);
            this.Controls.Add(this.u_tab);
            this.Controls.Add(this.exit_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_screen";
            this.Text = "Admin Panel";
            this.u_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TabControl u_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListView listView_user;
        private System.Windows.Forms.ColumnHeader user_coloumn;
        private System.Windows.Forms.ColumnHeader usertype_column;
        private System.Windows.Forms.ColumnHeader user_info;
        private System.Windows.Forms.Label confirm_lb;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.ComboBox usertype_cb;
        private System.Windows.Forms.Button dlt_btn;
    }
}