namespace OSSDG
{
    partial class VIEWITEM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnldockrightitem = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblviewdata = new System.Windows.Forms.Label();
            this.picviewlogo = new System.Windows.Forms.PictureBox();
            this.viewitemgrd = new System.Windows.Forms.DataGridView();
            this.pnldockrightitem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picviewlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewitemgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldockrightitem
            // 
            this.pnldockrightitem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnldockrightitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldockrightitem.Controls.Add(this.btnback);
            this.pnldockrightitem.Controls.Add(this.btnclose);
            this.pnldockrightitem.Controls.Add(this.lblviewdata);
            this.pnldockrightitem.Controls.Add(this.picviewlogo);
            this.pnldockrightitem.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnldockrightitem.Location = new System.Drawing.Point(919, 0);
            this.pnldockrightitem.Name = "pnldockrightitem";
            this.pnldockrightitem.Size = new System.Drawing.Size(200, 458);
            this.pnldockrightitem.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(55, 359);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 44);
            this.btnback.TabIndex = 7;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Gray;
            this.btnclose.Location = new System.Drawing.Point(159, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // lblviewdata
            // 
            this.lblviewdata.AutoSize = true;
            this.lblviewdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblviewdata.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewdata.ForeColor = System.Drawing.Color.White;
            this.lblviewdata.Location = new System.Drawing.Point(28, 253);
            this.lblviewdata.Name = "lblviewdata";
            this.lblviewdata.Size = new System.Drawing.Size(151, 34);
            this.lblviewdata.TabIndex = 6;
            this.lblviewdata.Text = "VIEW ITEM";
            // 
            // picviewlogo
            // 
            this.picviewlogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picviewlogo.Image = global::OSSDG.Properties.Resources._3;
            this.picviewlogo.Location = new System.Drawing.Point(34, 72);
            this.picviewlogo.Name = "picviewlogo";
            this.picviewlogo.Size = new System.Drawing.Size(145, 98);
            this.picviewlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picviewlogo.TabIndex = 0;
            this.picviewlogo.TabStop = false;
            // 
            // viewitemgrd
            // 
            this.viewitemgrd.AllowUserToAddRows = false;
            this.viewitemgrd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewitemgrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewitemgrd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewitemgrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewitemgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewitemgrd.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewitemgrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewitemgrd.Location = new System.Drawing.Point(0, 0);
            this.viewitemgrd.Name = "viewitemgrd";
            this.viewitemgrd.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewitemgrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.viewitemgrd.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.viewitemgrd.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.viewitemgrd.RowTemplate.Height = 24;
            this.viewitemgrd.Size = new System.Drawing.Size(919, 458);
            this.viewitemgrd.TabIndex = 1;
            this.viewitemgrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewitemgrd_CellContentClick);
            // 
            // VIEWITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 458);
            this.Controls.Add(this.viewitemgrd);
            this.Controls.Add(this.pnldockrightitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEWITEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIEWITEM";
            this.Load += new System.EventHandler(this.VIEWITEM_Load);
            this.pnldockrightitem.ResumeLayout(false);
            this.pnldockrightitem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picviewlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewitemgrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldockrightitem;
        private System.Windows.Forms.PictureBox picviewlogo;
        private System.Windows.Forms.Label lblviewdata;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView viewitemgrd;
    }
}