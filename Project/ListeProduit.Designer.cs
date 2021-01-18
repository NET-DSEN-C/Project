namespace Project
{
    partial class ListeProduit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProduitInexbtn = new System.Windows.Forms.Button();
            this.AnnulerProduitsbtn = new System.Windows.Forms.Button();
            this.ValiderProduitsbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RechProduitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProduitInexbtn);
            this.groupBox2.Controls.Add(this.AnnulerProduitsbtn);
            this.groupBox2.Controls.Add(this.ValiderProduitsbtn);
            this.groupBox2.Location = new System.Drawing.Point(705, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // ProduitInexbtn
            // 
            this.ProduitInexbtn.Location = new System.Drawing.Point(6, 101);
            this.ProduitInexbtn.Name = "ProduitInexbtn";
            this.ProduitInexbtn.Size = new System.Drawing.Size(75, 36);
            this.ProduitInexbtn.TabIndex = 2;
            this.ProduitInexbtn.Text = "Produit inexistant";
            this.ProduitInexbtn.UseVisualStyleBackColor = true;
            this.ProduitInexbtn.Click += new System.EventHandler(this.ProduitInexbtn_Click);
            // 
            // AnnulerProduitsbtn
            // 
            this.AnnulerProduitsbtn.Location = new System.Drawing.Point(6, 60);
            this.AnnulerProduitsbtn.Name = "AnnulerProduitsbtn";
            this.AnnulerProduitsbtn.Size = new System.Drawing.Size(75, 35);
            this.AnnulerProduitsbtn.TabIndex = 1;
            this.AnnulerProduitsbtn.Text = "Annuler";
            this.AnnulerProduitsbtn.UseVisualStyleBackColor = true;
            // 
            // ValiderProduitsbtn
            // 
            this.ValiderProduitsbtn.Location = new System.Drawing.Point(6, 19);
            this.ValiderProduitsbtn.Name = "ValiderProduitsbtn";
            this.ValiderProduitsbtn.Size = new System.Drawing.Size(75, 35);
            this.ValiderProduitsbtn.TabIndex = 0;
            this.ValiderProduitsbtn.Text = "Valider";
            this.ValiderProduitsbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduitDataView,
            this.ProduitDataView,
            this.TypeProduitDataView});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(197, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 322);
            this.dataGridView1.TabIndex = 4;
            // 
            // CodeProduitDataView
            // 
            this.CodeProduitDataView.HeaderText = "Code Produit";
            this.CodeProduitDataView.Name = "CodeProduitDataView";
            this.CodeProduitDataView.ReadOnly = true;
            // 
            // ProduitDataView
            // 
            this.ProduitDataView.HeaderText = "Produit";
            this.ProduitDataView.Name = "ProduitDataView";
            this.ProduitDataView.ReadOnly = true;
            // 
            // TypeProduitDataView
            // 
            this.TypeProduitDataView.HeaderText = "Type Produit";
            this.TypeProduitDataView.Name = "TypeProduitDataView";
            this.TypeProduitDataView.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RechProduitTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 119);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // RechProduitTextBox
            // 
            this.RechProduitTextBox.Location = new System.Drawing.Point(75, 55);
            this.RechProduitTextBox.Name = "RechProduitTextBox";
            this.RechProduitTextBox.Size = new System.Drawing.Size(100, 20);
            this.RechProduitTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // ListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListeProduit";
            this.Text = "ListeProduit";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ProduitInexbtn;
        private System.Windows.Forms.Button AnnulerProduitsbtn;
        private System.Windows.Forms.Button ValiderProduitsbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProduitDataView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RechProduitTextBox;
        private System.Windows.Forms.Label label1;
    }
}