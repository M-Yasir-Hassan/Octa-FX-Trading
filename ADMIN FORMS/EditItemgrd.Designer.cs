namespace OSSDG
{
    partial class EditItemgrd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnldockrifgt = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.piclogoesit = new System.Windows.Forms.PictureBox();
            this.itemGRD = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnldockrifgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoesit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGRD)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldockrifgt
            // 
            this.pnldockrifgt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnldockrifgt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldockrifgt.Controls.Add(this.btnback);
            this.pnldockrifgt.Controls.Add(this.label1);
            this.pnldockrifgt.Controls.Add(this.piclogoesit);
            this.pnldockrifgt.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnldockrifgt.Location = new System.Drawing.Point(1005, 0);
            this.pnldockrifgt.Name = "pnldockrifgt";
            this.pnldockrifgt.Size = new System.Drawing.Size(200, 450);
            this.pnldockrifgt.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(34, 367);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 34);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDIT ITEM";
            // 
            // piclogoesit
            // 
            this.piclogoesit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.piclogoesit.Image = global::OSSDG.Properties.Resources._6;
            this.piclogoesit.Location = new System.Drawing.Point(34, 43);
            this.piclogoesit.Name = "piclogoesit";
            this.piclogoesit.Size = new System.Drawing.Size(136, 97);
            this.piclogoesit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogoesit.TabIndex = 0;
            this.piclogoesit.TabStop = false;
            // 
            // itemGRD
            // 
            this.itemGRD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemGRD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemGRD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemGRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGRD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemGRD.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemGRD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemGRD.Location = new System.Drawing.Point(0, 0);
            this.itemGRD.Name = "itemGRD";
            this.itemGRD.RowHeadersWidth = 51;
            this.itemGRD.RowTemplate.Height = 24;
            this.itemGRD.Size = new System.Drawing.Size(1005, 450);
            this.itemGRD.TabIndex = 1;
            this.itemGRD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGRD_CellContentClick);
            // 
            // EDIT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EDIT.DefaultCellStyle = dataGridViewCellStyle2;
            this.EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EDIT.HeaderText = "EDIT";
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Text = "EDIT";
            this.EDIT.UseColumnTextForButtonValue = true;
            this.EDIT.Width = 125;
            // 
            // EditItemgrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 450);
            this.Controls.Add(this.itemGRD);
            this.Controls.Add(this.pnldockrifgt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditItemgrd";
            this.Text = "EditItemgrd";
            this.Load += new System.EventHandler(this.EditItemgrd_Load);
            this.pnldockrifgt.ResumeLayout(false);
            this.pnldockrifgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogoesit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGRD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldockrifgt;
        private System.Windows.Forms.PictureBox piclogoesit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView itemGRD;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
    }
}