namespace OSSDG
{
    partial class VIEWUSER
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
            this.viewusergrd = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnldockright = new System.Windows.Forms.Panel();
            this.lblviewdata = new System.Windows.Forms.Label();
            this.picview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewusergrd)).BeginInit();
            this.pnldockright.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            this.SuspendLayout();
            // 
            // viewusergrd
            // 
            this.viewusergrd.AllowUserToAddRows = false;
            this.viewusergrd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.viewusergrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewusergrd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewusergrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewusergrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewusergrd.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewusergrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewusergrd.GridColor = System.Drawing.SystemColors.Control;
            this.viewusergrd.Location = new System.Drawing.Point(0, 0);
            this.viewusergrd.Name = "viewusergrd";
            this.viewusergrd.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewusergrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.viewusergrd.RowHeadersWidth = 51;
            this.viewusergrd.RowTemplate.Height = 24;
            this.viewusergrd.Size = new System.Drawing.Size(809, 450);
            this.viewusergrd.TabIndex = 1;
            // 
            // btnback
            // 
            this.btnback.CausesValidation = false;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Transparent;
            this.btnback.Location = new System.Drawing.Point(67, 378);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(100, 44);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(159, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pnldockright
            // 
            this.pnldockright.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnldockright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldockright.Controls.Add(this.lblviewdata);
            this.pnldockright.Controls.Add(this.btnback);
            this.pnldockright.Controls.Add(this.picview);
            this.pnldockright.Controls.Add(this.btnclose);
            this.pnldockright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnldockright.Location = new System.Drawing.Point(609, 0);
            this.pnldockright.Name = "pnldockright";
            this.pnldockright.Size = new System.Drawing.Size(200, 450);
            this.pnldockright.TabIndex = 4;
            // 
            // lblviewdata
            // 
            this.lblviewdata.AutoSize = true;
            this.lblviewdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblviewdata.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewdata.ForeColor = System.Drawing.Color.White;
            this.lblviewdata.Location = new System.Drawing.Point(22, 242);
            this.lblviewdata.Name = "lblviewdata";
            this.lblviewdata.Size = new System.Drawing.Size(155, 34);
            this.lblviewdata.TabIndex = 5;
            this.lblviewdata.Text = "VIEW USER";
            // 
            // picview
            // 
            this.picview.Image = global::OSSDG.Properties.Resources._3;
            this.picview.Location = new System.Drawing.Point(67, 92);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(100, 76);
            this.picview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picview.TabIndex = 4;
            this.picview.TabStop = false;
            // 
            // VIEWUSER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.pnldockright);
            this.Controls.Add(this.viewusergrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEWUSER";
            this.Text = "VIEWUSER";
            this.Load += new System.EventHandler(this.VIEWUSER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewusergrd)).EndInit();
            this.pnldockright.ResumeLayout(false);
            this.pnldockright.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewusergrd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnldockright;
        private System.Windows.Forms.Label lblviewdata;
        private System.Windows.Forms.PictureBox picview;
    }
}