namespace OSSDG
{
    partial class orderform
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
            this.pnlbuy = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblbuy = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnlbuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbuy
            // 
            this.pnlbuy.BackColor = System.Drawing.SystemColors.Menu;
            this.pnlbuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbuy.Controls.Add(this.btnclose);
            this.pnlbuy.Controls.Add(this.lblbuy);
            this.pnlbuy.Controls.Add(this.piclogo);
            this.pnlbuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlbuy.Location = new System.Drawing.Point(0, 0);
            this.pnlbuy.Name = "pnlbuy";
            this.pnlbuy.Size = new System.Drawing.Size(699, 107);
            this.pnlbuy.TabIndex = 1;
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(652, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblbuy
            // 
            this.lblbuy.AutoSize = true;
            this.lblbuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbuy.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuy.Location = new System.Drawing.Point(344, 27);
            this.lblbuy.Name = "lblbuy";
            this.lblbuy.Size = new System.Drawing.Size(176, 36);
            this.lblbuy.TabIndex = 1;
            this.lblbuy.Text = "ORDER ITEM";
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(102, 202);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(117, 46);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.Location = new System.Drawing.Point(414, 202);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(117, 46);
            this.btnbuy.TabIndex = 4;
            this.btnbuy.Text = "ORDER";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // piclogo
            // 
            this.piclogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.piclogo.Image = global::OSSDG.Properties.Resources._91;
            this.piclogo.Location = new System.Drawing.Point(-1, 2);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(172, 100);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // orderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 329);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pnlbuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderform";
            this.Text = "orderform";
            this.pnlbuy.ResumeLayout(false);
            this.pnlbuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlbuy;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblbuy;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnbuy;
    }
}