namespace OSSDG
{
    partial class startform
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
            this.pnlwelcome = new System.Windows.Forms.Panel();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.lblroll = new System.Windows.Forms.Label();
            this.lblwelocme = new System.Windows.Forms.Label();
            this.bntstrtlogin = new System.Windows.Forms.Button();
            this.bntexit = new System.Windows.Forms.Button();
            this.pnlwelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlwelcome
            // 
            this.pnlwelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlwelcome.Controls.Add(this.piclogo);
            this.pnlwelcome.Controls.Add(this.lblroll);
            this.pnlwelcome.Controls.Add(this.lblwelocme);
            this.pnlwelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlwelcome.Location = new System.Drawing.Point(0, 0);
            this.pnlwelcome.Name = "pnlwelcome";
            this.pnlwelcome.Size = new System.Drawing.Size(599, 116);
            this.pnlwelcome.TabIndex = 0;
            // 
            // piclogo
            // 
            this.piclogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.piclogo.Image = global::OSSDG.Properties.Resources._2_removebg_preview;
            this.piclogo.Location = new System.Drawing.Point(3, 3);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(128, 104);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 2;
            this.piclogo.TabStop = false;
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblroll.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroll.ForeColor = System.Drawing.Color.White;
            this.lblroll.Location = new System.Drawing.Point(426, 65);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(143, 30);
            this.lblroll.TabIndex = 0;
            this.lblroll.Text = "2021-CS-46";
            // 
            // lblwelocme
            // 
            this.lblwelocme.AutoSize = true;
            this.lblwelocme.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelocme.ForeColor = System.Drawing.Color.White;
            this.lblwelocme.Location = new System.Drawing.Point(137, 9);
            this.lblwelocme.Name = "lblwelocme";
            this.lblwelocme.Size = new System.Drawing.Size(430, 40);
            this.lblwelocme.TabIndex = 0;
            this.lblwelocme.Text = "ONLINE SHOPPING STORE";
            // 
            // bntstrtlogin
            // 
            this.bntstrtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bntstrtlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntstrtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntstrtlogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntstrtlogin.ForeColor = System.Drawing.Color.White;
            this.bntstrtlogin.Location = new System.Drawing.Point(130, 190);
            this.bntstrtlogin.Name = "bntstrtlogin";
            this.bntstrtlogin.Size = new System.Drawing.Size(143, 39);
            this.bntstrtlogin.TabIndex = 3;
            this.bntstrtlogin.Text = "LOGIN";
            this.bntstrtlogin.UseVisualStyleBackColor = false;
            this.bntstrtlogin.Click += new System.EventHandler(this.bntstrtlogin_Click);
            // 
            // bntexit
            // 
            this.bntexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bntexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntexit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntexit.ForeColor = System.Drawing.Color.White;
            this.bntexit.Location = new System.Drawing.Point(366, 190);
            this.bntexit.Name = "bntexit";
            this.bntexit.Size = new System.Drawing.Size(143, 39);
            this.bntexit.TabIndex = 4;
            this.bntexit.Text = "EXIT";
            this.bntexit.UseVisualStyleBackColor = false;
            this.bntexit.Click += new System.EventHandler(this.bntexit_Click);
            // 
            // startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 300);
            this.Controls.Add(this.bntexit);
            this.Controls.Add(this.bntstrtlogin);
            this.Controls.Add(this.pnlwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startform";
            this.Text = "START PAGE";
            this.pnlwelcome.ResumeLayout(false);
            this.pnlwelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlwelcome;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Label lblwelocme;
        private System.Windows.Forms.Button bntstrtlogin;
        private System.Windows.Forms.Button bntexit;
    }
}

