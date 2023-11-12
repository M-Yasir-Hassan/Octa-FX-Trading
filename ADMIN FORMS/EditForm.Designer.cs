namespace OSSDG
{
    partial class EditForm
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
            this.pnladduserdock = new System.Windows.Forms.Panel();
            this.bTNCLOSE = new System.Windows.Forms.Button();
            this.lbladduser = new System.Windows.Forms.Label();
            this.picadduserlogo = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbladdpass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtroles = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pnladduserdock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picadduserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnladduserdock
            // 
            this.pnladduserdock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnladduserdock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladduserdock.Controls.Add(this.bTNCLOSE);
            this.pnladduserdock.Controls.Add(this.lbladduser);
            this.pnladduserdock.Controls.Add(this.picadduserlogo);
            this.pnladduserdock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladduserdock.Location = new System.Drawing.Point(0, 0);
            this.pnladduserdock.Name = "pnladduserdock";
            this.pnladduserdock.Size = new System.Drawing.Size(581, 109);
            this.pnladduserdock.TabIndex = 1;
            // 
            // bTNCLOSE
            // 
            this.bTNCLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTNCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTNCLOSE.Location = new System.Drawing.Point(528, 3);
            this.bTNCLOSE.Name = "bTNCLOSE";
            this.bTNCLOSE.Size = new System.Drawing.Size(40, 40);
            this.bTNCLOSE.TabIndex = 2;
            this.bTNCLOSE.Text = "X";
            this.bTNCLOSE.UseVisualStyleBackColor = true;
            this.bTNCLOSE.Click += new System.EventHandler(this.bTNCLOSE_Click);
            // 
            // lbladduser
            // 
            this.lbladduser.AutoSize = true;
            this.lbladduser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbladduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladduser.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladduser.Location = new System.Drawing.Point(232, 33);
            this.lbladduser.Name = "lbladduser";
            this.lbladduser.Size = new System.Drawing.Size(152, 36);
            this.lbladduser.TabIndex = 1;
            this.lbladduser.Text = "EDIT USER ";
            // 
            // picadduserlogo
            // 
            this.picadduserlogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picadduserlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picadduserlogo.Image = global::OSSDG.Properties.Resources._1;
            this.picadduserlogo.Location = new System.Drawing.Point(11, 4);
            this.picadduserlogo.Name = "picadduserlogo";
            this.picadduserlogo.Size = new System.Drawing.Size(112, 100);
            this.picadduserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picadduserlogo.TabIndex = 0;
            this.picadduserlogo.TabStop = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(18, 152);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(139, 29);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "USERNAME:";
            // 
            // lbladdpass
            // 
            this.lbladdpass.AutoSize = true;
            this.lbladdpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladdpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladdpass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdpass.Location = new System.Drawing.Point(14, 211);
            this.lbladdpass.Name = "lbladdpass";
            this.lbladdpass.Size = new System.Drawing.Size(143, 29);
            this.lbladdpass.TabIndex = 4;
            this.lbladdpass.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "ROLES:";
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(18, 348);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 34);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(433, 348);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(106, 34);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "EDIT";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(207, 211);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(305, 22);
            this.txtpassword.TabIndex = 11;
            // 
            // txtroles
            // 
            this.txtroles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtroles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtroles.ForeColor = System.Drawing.Color.Black;
            this.txtroles.Location = new System.Drawing.Point(207, 262);
            this.txtroles.Name = "txtroles";
            this.txtroles.Size = new System.Drawing.Size(305, 22);
            this.txtroles.TabIndex = 12;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(207, 159);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(305, 22);
            this.txtusername.TabIndex = 13;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtroles);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbladdpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.pnladduserdock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.pnladduserdock.ResumeLayout(false);
            this.pnladduserdock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picadduserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnladduserdock;
        private System.Windows.Forms.Button bTNCLOSE;
        private System.Windows.Forms.Label lbladduser;
        private System.Windows.Forms.PictureBox picadduserlogo;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbladdpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtroles;
        private System.Windows.Forms.TextBox txtusername;
    }
}