namespace OSSDG
{
    partial class buy
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
            this.pnltop = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbladditem = new System.Windows.Forms.Label();
            this.lbladditem1 = new System.Windows.Forms.Label();
            this.pnladditem = new System.Windows.Forms.Panel();
            this.txtadditem = new System.Windows.Forms.TextBox();
            this.lblquantity = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.textaddquantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnltop.SuspendLayout();
            this.pnladditem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnltop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnltop.Controls.Add(this.btnclose);
            this.pnltop.Controls.Add(this.lbladditem);
            this.pnltop.Controls.Add(this.pictureBox1);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(683, 100);
            this.pnltop.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Honeydew;
            this.btnclose.Location = new System.Drawing.Point(638, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 9;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbladditem
            // 
            this.lbladditem.AutoSize = true;
            this.lbladditem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbladditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbladditem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem.ForeColor = System.Drawing.Color.Honeydew;
            this.lbladditem.Location = new System.Drawing.Point(319, 22);
            this.lbladditem.Name = "lbladditem";
            this.lbladditem.Size = new System.Drawing.Size(146, 39);
            this.lbladditem.TabIndex = 2;
            this.lbladditem.Text = "BUY ITEM";
            //this.lbladditem.Click += new System.EventHandler(this.lbladditem_Click);
            // 
            // lbladditem1
            // 
            this.lbladditem1.AutoSize = true;
            this.lbladditem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladditem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladditem1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem1.ForeColor = System.Drawing.Color.Black;
            this.lbladditem1.Location = new System.Drawing.Point(120, 166);
            this.lbladditem1.Name = "lbladditem1";
            this.lbladditem1.Size = new System.Drawing.Size(69, 29);
            this.lbladditem1.TabIndex = 2;
            this.lbladditem1.Text = "ITEM:";
            // 
            // pnladditem
            // 
            this.pnladditem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladditem.Controls.Add(this.txtadditem);
            this.pnladditem.Location = new System.Drawing.Point(215, 163);
            this.pnladditem.Name = "pnladditem";
            this.pnladditem.Size = new System.Drawing.Size(429, 29);
            this.pnladditem.TabIndex = 6;
            // 
            // txtadditem
            // 
            this.txtadditem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtadditem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadditem.Location = new System.Drawing.Point(3, 2);
            this.txtadditem.Name = "txtadditem";
            this.txtadditem.Size = new System.Drawing.Size(421, 23);
            this.txtadditem.TabIndex = 0;
           // this.txtadditem.TextChanged += new System.EventHandler(this.txtadditem_TextChanged);
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblquantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(61, 268);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(128, 29);
            this.lblquantity.TabIndex = 4;
            this.lblquantity.Text = "QUANTITY:";
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(82, 372);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.ForeColor = System.Drawing.Color.Black;
            this.btnbuy.Location = new System.Drawing.Point(537, 372);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(90, 34);
            this.btnbuy.TabIndex = 9;
            this.btnbuy.Text = "BUY";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // textaddquantity
            // 
            this.textaddquantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textaddquantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaddquantity.Location = new System.Drawing.Point(223, 268);
            this.textaddquantity.Name = "textaddquantity";
            this.textaddquantity.Size = new System.Drawing.Size(421, 23);
            this.textaddquantity.TabIndex = 1;
            //this.textaddquantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::OSSDG.Properties.Resources._91;
            this.pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 466);
            this.Controls.Add(this.textaddquantity);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.pnladditem);
            this.Controls.Add(this.lbladditem1);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "buy";
           // this.Load += new System.EventHandler(this.buy_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnladditem.ResumeLayout(false);
            this.pnladditem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbladditem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbladditem1;
        private System.Windows.Forms.Panel pnladditem;
        private System.Windows.Forms.TextBox txtadditem;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.TextBox textaddquantity;
    }
}