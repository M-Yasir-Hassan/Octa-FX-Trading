namespace OSSDG
{
    partial class EditItem
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
            this.lbledititem = new System.Windows.Forms.Label();
            this.picadduserlogo = new System.Windows.Forms.PictureBox();
            this.lbladditem1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtadditem = new System.Windows.Forms.TextBox();
            this.txtaddprice = new System.Windows.Forms.TextBox();
            this.txtaddquantity = new System.Windows.Forms.TextBox();
            this.txtadddiscount = new System.Windows.Forms.TextBox();
            this.pnladduserdock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picadduserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnladduserdock
            // 
            this.pnladduserdock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnladduserdock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnladduserdock.Controls.Add(this.bTNCLOSE);
            this.pnladduserdock.Controls.Add(this.lbledititem);
            this.pnladduserdock.Controls.Add(this.picadduserlogo);
            this.pnladduserdock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladduserdock.Location = new System.Drawing.Point(0, 0);
            this.pnladduserdock.Name = "pnladduserdock";
            this.pnladduserdock.Size = new System.Drawing.Size(651, 109);
            this.pnladduserdock.TabIndex = 2;
            // 
            // bTNCLOSE
            // 
            this.bTNCLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTNCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTNCLOSE.Location = new System.Drawing.Point(606, -1);
            this.bTNCLOSE.Name = "bTNCLOSE";
            this.bTNCLOSE.Size = new System.Drawing.Size(40, 40);
            this.bTNCLOSE.TabIndex = 2;
            this.bTNCLOSE.Text = "X";
            this.bTNCLOSE.UseVisualStyleBackColor = true;
            this.bTNCLOSE.Click += new System.EventHandler(this.bTNCLOSE_Click);
            // 
            // lbledititem
            // 
            this.lbledititem.AutoSize = true;
            this.lbledititem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbledititem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbledititem.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledititem.Location = new System.Drawing.Point(262, 33);
            this.lbledititem.Name = "lbledititem";
            this.lbledititem.Size = new System.Drawing.Size(140, 36);
            this.lbledititem.TabIndex = 1;
            this.lbledititem.Text = "EDIT ITEM";
            // 
            // picadduserlogo
            // 
            this.picadduserlogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picadduserlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picadduserlogo.Image = global::OSSDG.Properties.Resources._6;
            this.picadduserlogo.Location = new System.Drawing.Point(11, 4);
            this.picadduserlogo.Name = "picadduserlogo";
            this.picadduserlogo.Size = new System.Drawing.Size(112, 100);
            this.picadduserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picadduserlogo.TabIndex = 0;
            this.picadduserlogo.TabStop = false;
            // 
            // lbladditem1
            // 
            this.lbladditem1.AutoSize = true;
            this.lbladditem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladditem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladditem1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladditem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbladditem1.Location = new System.Drawing.Point(58, 163);
            this.lbladditem1.Name = "lbladditem1";
            this.lbladditem1.Size = new System.Drawing.Size(131, 30);
            this.lbladditem1.TabIndex = 3;
            this.lbladditem1.Text = "ADD ITEM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(100, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRICE:";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblquantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblquantity.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblquantity.Location = new System.Drawing.Point(54, 272);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(134, 30);
            this.lblquantity.TabIndex = 5;
            this.lblquantity.Text = "QUANTITY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "DISCOUNT:";
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(147, 375);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(107, 34);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnedit
            // 
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnedit.Location = new System.Drawing.Point(512, 375);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(90, 34);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtadditem
            // 
            this.txtadditem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtadditem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadditem.Location = new System.Drawing.Point(206, 163);
            this.txtadditem.Name = "txtadditem";
            this.txtadditem.Size = new System.Drawing.Size(421, 23);
            this.txtadditem.TabIndex = 10;
            // 
            // txtaddprice
            // 
            this.txtaddprice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtaddprice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddprice.Location = new System.Drawing.Point(206, 227);
            this.txtaddprice.Name = "txtaddprice";
            this.txtaddprice.Size = new System.Drawing.Size(421, 23);
            this.txtaddprice.TabIndex = 11;
            // 
            // txtaddquantity
            // 
            this.txtaddquantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtaddquantity.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddquantity.Location = new System.Drawing.Point(206, 278);
            this.txtaddquantity.Name = "txtaddquantity";
            this.txtaddquantity.Size = new System.Drawing.Size(421, 23);
            this.txtaddquantity.TabIndex = 12;
            // 
            // txtadddiscount
            // 
            this.txtadddiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtadddiscount.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadddiscount.Location = new System.Drawing.Point(206, 326);
            this.txtadddiscount.Name = "txtadddiscount";
            this.txtadddiscount.Size = new System.Drawing.Size(421, 23);
            this.txtadddiscount.TabIndex = 13;
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 449);
            this.Controls.Add(this.txtadddiscount);
            this.Controls.Add(this.txtaddquantity);
            this.Controls.Add(this.txtaddprice);
            this.Controls.Add(this.txtadditem);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbladditem1);
            this.Controls.Add(this.pnladduserdock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItem";
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.pnladduserdock.ResumeLayout(false);
            this.pnladduserdock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picadduserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnladduserdock;
        private System.Windows.Forms.Button bTNCLOSE;
        private System.Windows.Forms.Label lbledititem;
        private System.Windows.Forms.PictureBox picadduserlogo;
        private System.Windows.Forms.Label lbladditem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtadditem;
        private System.Windows.Forms.TextBox txtaddprice;
        private System.Windows.Forms.TextBox txtaddquantity;
        private System.Windows.Forms.TextBox txtadddiscount;
    }
}