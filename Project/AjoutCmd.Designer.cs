namespace Project
{
    partial class AjoutCmd
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
            this.RefCmdTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LignesCmdGrid = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupprimerLigneCmd = new System.Windows.Forms.Button();
            this.ModifierLigneCmd = new System.Windows.Forms.Button();
            this.AjouterLigneCmd = new System.Windows.Forms.Button();
            this.LignesCmd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labrue = new System.Windows.Forms.Label();
            this.ClientAjoutCmd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefCom = new System.Windows.Forms.Label();
            this.TelTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.CodePostalTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.VilleTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AnnulerLigneCmd = new System.Windows.Forms.Button();
            this.ValiderLigneCmd = new System.Windows.Forms.Button();
            this.DateAjoutCmd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RueTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LignesCmdGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefCmdTextBoxAjoutCmd
            // 
            this.RefCmdTextBoxAjoutCmd.Location = new System.Drawing.Point(147, 25);
            this.RefCmdTextBoxAjoutCmd.Name = "RefCmdTextBoxAjoutCmd";
            this.RefCmdTextBoxAjoutCmd.Size = new System.Drawing.Size(72, 20);
            this.RefCmdTextBoxAjoutCmd.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LignesCmdGrid);
            this.groupBox4.Controls.Add(this.SupprimerLigneCmd);
            this.groupBox4.Controls.Add(this.ModifierLigneCmd);
            this.groupBox4.Controls.Add(this.AjouterLigneCmd);
            this.groupBox4.Controls.Add(this.LignesCmd);
            this.groupBox4.Location = new System.Drawing.Point(25, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 168);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // LignesCmdGrid
            // 
            this.LignesCmdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LignesCmdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LignesCmdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Quantité,
            this.Prix});
            this.LignesCmdGrid.Location = new System.Drawing.Point(6, 57);
            this.LignesCmdGrid.Name = "LignesCmdGrid";
            this.LignesCmdGrid.Size = new System.Drawing.Size(597, 105);
            this.LignesCmdGrid.TabIndex = 4;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.Name = "Produit";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantté";
            this.Quantité.Name = "Quantité";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // SupprimerLigneCmd
            // 
            this.SupprimerLigneCmd.Location = new System.Drawing.Point(627, 132);
            this.SupprimerLigneCmd.Name = "SupprimerLigneCmd";
            this.SupprimerLigneCmd.Size = new System.Drawing.Size(75, 30);
            this.SupprimerLigneCmd.TabIndex = 3;
            this.SupprimerLigneCmd.Text = "Supprimer";
            this.SupprimerLigneCmd.UseVisualStyleBackColor = true;
            // 
            // ModifierLigneCmd
            // 
            this.ModifierLigneCmd.Location = new System.Drawing.Point(627, 96);
            this.ModifierLigneCmd.Name = "ModifierLigneCmd";
            this.ModifierLigneCmd.Size = new System.Drawing.Size(75, 30);
            this.ModifierLigneCmd.TabIndex = 2;
            this.ModifierLigneCmd.Text = "Modifier";
            this.ModifierLigneCmd.UseVisualStyleBackColor = true;
            // 
            // AjouterLigneCmd
            // 
            this.AjouterLigneCmd.Location = new System.Drawing.Point(627, 57);
            this.AjouterLigneCmd.Name = "AjouterLigneCmd";
            this.AjouterLigneCmd.Size = new System.Drawing.Size(75, 33);
            this.AjouterLigneCmd.TabIndex = 1;
            this.AjouterLigneCmd.Text = "Ajouter";
            this.AjouterLigneCmd.UseVisualStyleBackColor = true;
            // 
            // LignesCmd
            // 
            this.LignesCmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LignesCmd.Location = new System.Drawing.Point(6, 16);
            this.LignesCmd.Name = "LignesCmd";
            this.LignesCmd.Size = new System.Drawing.Size(696, 31);
            this.LignesCmd.TabIndex = 0;
            this.LignesCmd.Text = "Lignes Commande";
            this.LignesCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ville";
            // 
            // labrue
            // 
            this.labrue.AutoSize = true;
            this.labrue.Location = new System.Drawing.Point(114, 74);
            this.labrue.Name = "labrue";
            this.labrue.Size = new System.Drawing.Size(27, 13);
            this.labrue.TabIndex = 10;
            this.labrue.Text = "Rue";
            // 
            // ClientAjoutCmd
            // 
            this.ClientAjoutCmd.AutoSize = true;
            this.ClientAjoutCmd.Location = new System.Drawing.Point(108, 51);
            this.ClientAjoutCmd.Name = "ClientAjoutCmd";
            this.ClientAjoutCmd.Size = new System.Drawing.Size(33, 13);
            this.ClientAjoutCmd.TabIndex = 9;
            this.ClientAjoutCmd.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // RefCom
            // 
            this.RefCom.AutoSize = true;
            this.RefCom.Location = new System.Drawing.Point(26, 28);
            this.RefCom.Name = "RefCom";
            this.RefCom.Size = new System.Drawing.Size(115, 13);
            this.RefCom.TabIndex = 7;
            this.RefCom.Text = "Référence commande ";
            // 
            // TelTextBoxAjoutCmd
            // 
            this.TelTextBoxAjoutCmd.Location = new System.Drawing.Point(560, 100);
            this.TelTextBoxAjoutCmd.Name = "TelTextBoxAjoutCmd";
            this.TelTextBoxAjoutCmd.Size = new System.Drawing.Size(100, 20);
            this.TelTextBoxAjoutCmd.TabIndex = 5;
            // 
            // CodePostalTextBoxAjoutCmd
            // 
            this.CodePostalTextBoxAjoutCmd.Location = new System.Drawing.Point(366, 100);
            this.CodePostalTextBoxAjoutCmd.Name = "CodePostalTextBoxAjoutCmd";
            this.CodePostalTextBoxAjoutCmd.Size = new System.Drawing.Size(100, 20);
            this.CodePostalTextBoxAjoutCmd.TabIndex = 4;
            // 
            // VilleTextBoxAjoutCmd
            // 
            this.VilleTextBoxAjoutCmd.Location = new System.Drawing.Point(147, 100);
            this.VilleTextBoxAjoutCmd.Name = "VilleTextBoxAjoutCmd";
            this.VilleTextBoxAjoutCmd.Size = new System.Drawing.Size(127, 20);
            this.VilleTextBoxAjoutCmd.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AnnulerLigneCmd);
            this.groupBox3.Controls.Add(this.ValiderLigneCmd);
            this.groupBox3.Location = new System.Drawing.Point(25, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // AnnulerLigneCmd
            // 
            this.AnnulerLigneCmd.Location = new System.Drawing.Point(627, 14);
            this.AnnulerLigneCmd.Name = "AnnulerLigneCmd";
            this.AnnulerLigneCmd.Size = new System.Drawing.Size(75, 34);
            this.AnnulerLigneCmd.TabIndex = 1;
            this.AnnulerLigneCmd.Text = "Annuler";
            this.AnnulerLigneCmd.UseVisualStyleBackColor = true;
            // 
            // ValiderLigneCmd
            // 
            this.ValiderLigneCmd.Location = new System.Drawing.Point(546, 14);
            this.ValiderLigneCmd.Name = "ValiderLigneCmd";
            this.ValiderLigneCmd.Size = new System.Drawing.Size(75, 34);
            this.ValiderLigneCmd.TabIndex = 0;
            this.ValiderLigneCmd.Text = "Valider";
            this.ValiderLigneCmd.UseVisualStyleBackColor = true;
            // 
            // DateAjoutCmd
            // 
            this.DateAjoutCmd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAjoutCmd.Location = new System.Drawing.Point(299, 22);
            this.DateAjoutCmd.Name = "DateAjoutCmd";
            this.DateAjoutCmd.Size = new System.Drawing.Size(200, 20);
            this.DateAjoutCmd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tel";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(296, 103);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(64, 13);
            this.lab.TabIndex = 12;
            this.lab.Text = "Code Postal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.DateAjoutCmd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lab);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labrue);
            this.groupBox2.Controls.Add(this.ClientAjoutCmd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RefCom);
            this.groupBox2.Controls.Add(this.TelTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.CodePostalTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.VilleTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.RueTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.RefCmdTextBoxAjoutCmd);
            this.groupBox2.Location = new System.Drawing.Point(25, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(512, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // RueTextBoxAjoutCmd
            // 
            this.RueTextBoxAjoutCmd.Location = new System.Drawing.Point(147, 74);
            this.RueTextBoxAjoutCmd.Name = "RueTextBoxAjoutCmd";
            this.RueTextBoxAjoutCmd.Size = new System.Drawing.Size(513, 20);
            this.RueTextBoxAjoutCmd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 394);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AjoutCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutCmd";
            this.Text = "AjoutCmd";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LignesCmdGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RefCmdTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView LignesCmdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Button SupprimerLigneCmd;
        private System.Windows.Forms.Button ModifierLigneCmd;
        private System.Windows.Forms.Button AjouterLigneCmd;
        private System.Windows.Forms.Label LignesCmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labrue;
        private System.Windows.Forms.Label ClientAjoutCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RefCom;
        private System.Windows.Forms.TextBox TelTextBoxAjoutCmd;
        private System.Windows.Forms.TextBox CodePostalTextBoxAjoutCmd;
        private System.Windows.Forms.TextBox VilleTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AnnulerLigneCmd;
        private System.Windows.Forms.Button ValiderLigneCmd;
        private System.Windows.Forms.DateTimePicker DateAjoutCmd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox RueTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}