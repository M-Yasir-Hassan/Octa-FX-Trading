namespace OSSDG
{
    partial class order
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbladditem1 = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.txtadditem = new System.Windows.Forms.TextBox();
            this.textaddquantity = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
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
            this.pnltop.Size = new System.Drawing.Size(684, 100);
            this.pnltop.TabIndex = 2;
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
            this.lbladditem.Size = new System.Drawing.Size(187, 39);
            this.lbladditem.TabIndex = 2;
            this.lbladditem.Text = "ORDER ITEM";
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
            // lbladditem1
            // 
            this.lbladditem1.AutoSize = true;
            this.lbladditem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladditem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladditem1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem1.ForeColor = System.Drawing.Color.Black;
            this.lbladditem1.Location = new System.Drawing.Point(130, 183);
            this.lbladditem1.Name = "lbladditem1";
            this.lbladditem1.Size = new System.Drawing.Size(69, 29);
            this.lbladditem1.TabIndex = 3;
            this.lbladditem1.Text = "ITEM:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblquantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(71, 250);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(128, 29);
            this.lblquantity.TabIndex = 5;
            this.lblquantity.Text = "QUANTITY:";
            // 
            // txtadditem
            // 
            this.txtadditem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtadditem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadditem.Location = new System.Drawing.Point(222, 183);
            this.txtadditem.Name = "txtadditem";
            this.txtadditem.Size = new System.Drawing.Size(421, 23);
            this.txtadditem.TabIndex = 6;
            // 
            // textaddquantity
            // 
            this.textaddquantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textaddquantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaddquantity.Location = new System.Drawing.Point(222, 256);
            this.textaddquantity.Name = "textaddquantity";
            this.textaddquantity.Size = new System.Drawing.Size(421, 23);
            this.textaddquantity.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(92, 333);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 9;
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
            this.btnbuy.Location = new System.Drawing.Point(480, 333);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(90, 34);
            this.btnbuy.TabIndex = 10;
            this.btnbuy.Text = "ORDER";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.textaddquantity);
            this.Controls.Add(this.txtadditem);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lbladditem1);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "order";
            this.Text = "order";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
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
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.TextBox txtadditem;
        private System.Windows.Forms.TextBox textaddquantity;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnbuy;
    }
}