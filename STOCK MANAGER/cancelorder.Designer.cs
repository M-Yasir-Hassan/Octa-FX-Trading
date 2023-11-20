namespace OSSDG
{
    partial class cancelorder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbledititem = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.deletegrid = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbledititem);
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(882, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // lbledititem
            // 
            this.lbledititem.AutoSize = true;
            this.lbledititem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbledititem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbledititem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbledititem.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledititem.ForeColor = System.Drawing.Color.Snow;
            this.lbledititem.Location = new System.Drawing.Point(13, 247);
            this.lbledititem.Name = "lbledititem";
            this.lbledititem.Size = new System.Drawing.Size(174, 36);
            this.lbledititem.TabIndex = 2;
            this.lbledititem.Text = "DELETE ITEM";
            //this.lbledititem.Click += new System.EventHandler(this.lbledititem_Click);
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(57, 370);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 10;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // deletegrid
            // 
            this.deletegrid.AllowUserToAddRows = false;
            this.deletegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE});
            this.deletegrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletegrid.Location = new System.Drawing.Point(0, 0);
            this.deletegrid.Name = "deletegrid";
            this.deletegrid.RowHeadersWidth = 51;
            this.deletegrid.RowTemplate.Height = 24;
            this.deletegrid.Size = new System.Drawing.Size(882, 450);
            this.deletegrid.TabIndex = 2;
            this.deletegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DELETE
            // 
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OSSDG.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cancelorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.deletegrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cancelorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cancelorder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbledititem;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView deletegrid;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}