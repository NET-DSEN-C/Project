namespace Project
{
    partial class rechercheClient
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
            this.RechClient = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRechClient = new System.Windows.Forms.DataGridView();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValiderRechClientbtn = new System.Windows.Forms.Button();
            this.AnnulerRechClientbtn = new System.Windows.Forms.Button();
            this.ClientExbtn = new System.Windows.Forms.Button();
            this.CodePostalTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.VilleTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.RueTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.ClientTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.CodePostalRechClient = new System.Windows.Forms.Label();
            this.VilleRechClient = new System.Windows.Forms.Label();
            this.RueRechClient = new System.Windows.Forms.Label();
            this.ClientRechClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).BeginInit();
            this.SuspendLayout();
            // 
            // RechClient
            // 
            this.RechClient.AutoSize = true;
            this.RechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechClient.Location = new System.Drawing.Point(25, 69);
            this.RechClient.Name = "RechClient";
            this.RechClient.Size = new System.Drawing.Size(132, 17);
            this.RechClient.TabIndex = 25;
            this.RechClient.Text = "Recherche Client";
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Clinet";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // dataRechClient
            // 
            this.dataRechClient.AllowUserToAddRows = false;
            this.dataRechClient.AllowUserToDeleteRows = false;
            this.dataRechClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRechClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Rue,
            this.Ville,
            this.CodePostal,
            this.Telephone});
            this.dataRechClient.Location = new System.Drawing.Point(179, 29);
            this.dataRechClient.Name = "dataRechClient";
            this.dataRechClient.ReadOnly = true;
            this.dataRechClient.Size = new System.Drawing.Size(538, 393);
            this.dataRechClient.TabIndex = 24;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Télléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // ValiderRechClientbtn
            // 
            this.ValiderRechClientbtn.Location = new System.Drawing.Point(723, 88);
            this.ValiderRechClientbtn.Name = "ValiderRechClientbtn";
            this.ValiderRechClientbtn.Size = new System.Drawing.Size(75, 46);
            this.ValiderRechClientbtn.TabIndex = 23;
            this.ValiderRechClientbtn.Text = "Valider\r\n";
            this.ValiderRechClientbtn.UseVisualStyleBackColor = true;
            // 
            // AnnulerRechClientbtn
            // 
            this.AnnulerRechClientbtn.Location = new System.Drawing.Point(723, 140);
            this.AnnulerRechClientbtn.Name = "AnnulerRechClientbtn";
            this.AnnulerRechClientbtn.Size = new System.Drawing.Size(75, 46);
            this.AnnulerRechClientbtn.TabIndex = 22;
            this.AnnulerRechClientbtn.Text = "Annuler";
            this.AnnulerRechClientbtn.UseVisualStyleBackColor = true;
            // 
            // ClientExbtn
            // 
            this.ClientExbtn.Location = new System.Drawing.Point(723, 195);
            this.ClientExbtn.Name = "ClientExbtn";
            this.ClientExbtn.Size = new System.Drawing.Size(75, 46);
            this.ClientExbtn.TabIndex = 21;
            this.ClientExbtn.Tag = "Client in";
            this.ClientExbtn.Text = "Client inexistant";
            this.ClientExbtn.UseVisualStyleBackColor = true;
            // 
            // CodePostalTextBoxRechClient
            // 
            this.CodePostalTextBoxRechClient.Location = new System.Drawing.Point(73, 221);
            this.CodePostalTextBoxRechClient.Name = "CodePostalTextBoxRechClient";
            this.CodePostalTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.CodePostalTextBoxRechClient.TabIndex = 20;
            // 
            // VilleTextBoxRechClient
            // 
            this.VilleTextBoxRechClient.Location = new System.Drawing.Point(73, 190);
            this.VilleTextBoxRechClient.Name = "VilleTextBoxRechClient";
            this.VilleTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.VilleTextBoxRechClient.TabIndex = 19;
            // 
            // RueTextBoxRechClient
            // 
            this.RueTextBoxRechClient.Location = new System.Drawing.Point(73, 154);
            this.RueTextBoxRechClient.Name = "RueTextBoxRechClient";
            this.RueTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.RueTextBoxRechClient.TabIndex = 18;
            // 
            // ClientTextBoxRechClient
            // 
            this.ClientTextBoxRechClient.Location = new System.Drawing.Point(73, 117);
            this.ClientTextBoxRechClient.Name = "ClientTextBoxRechClient";
            this.ClientTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.ClientTextBoxRechClient.TabIndex = 17;
            // 
            // CodePostalRechClient
            // 
            this.CodePostalRechClient.AutoSize = true;
            this.CodePostalRechClient.Location = new System.Drawing.Point(3, 224);
            this.CodePostalRechClient.Name = "CodePostalRechClient";
            this.CodePostalRechClient.Size = new System.Drawing.Size(64, 13);
            this.CodePostalRechClient.TabIndex = 16;
            this.CodePostalRechClient.Text = "Code Postal";
            // 
            // VilleRechClient
            // 
            this.VilleRechClient.AutoSize = true;
            this.VilleRechClient.Location = new System.Drawing.Point(41, 193);
            this.VilleRechClient.Name = "VilleRechClient";
            this.VilleRechClient.Size = new System.Drawing.Size(26, 13);
            this.VilleRechClient.TabIndex = 15;
            this.VilleRechClient.Text = "Ville";
            // 
            // RueRechClient
            // 
            this.RueRechClient.AutoSize = true;
            this.RueRechClient.Location = new System.Drawing.Point(40, 157);
            this.RueRechClient.Name = "RueRechClient";
            this.RueRechClient.Size = new System.Drawing.Size(27, 13);
            this.RueRechClient.TabIndex = 14;
            this.RueRechClient.Text = "Rue";
            // 
            // ClientRechClient
            // 
            this.ClientRechClient.AutoSize = true;
            this.ClientRechClient.Location = new System.Drawing.Point(34, 121);
            this.ClientRechClient.Name = "ClientRechClient";
            this.ClientRechClient.Size = new System.Drawing.Size(33, 13);
            this.ClientRechClient.TabIndex = 13;
            this.ClientRechClient.Text = "Client";
            // 
            // rechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RechClient);
            this.Controls.Add(this.dataRechClient);
            this.Controls.Add(this.ValiderRechClientbtn);
            this.Controls.Add(this.AnnulerRechClientbtn);
            this.Controls.Add(this.ClientExbtn);
            this.Controls.Add(this.CodePostalTextBoxRechClient);
            this.Controls.Add(this.VilleTextBoxRechClient);
            this.Controls.Add(this.RueTextBoxRechClient);
            this.Controls.Add(this.ClientTextBoxRechClient);
            this.Controls.Add(this.CodePostalRechClient);
            this.Controls.Add(this.VilleRechClient);
            this.Controls.Add(this.RueRechClient);
            this.Controls.Add(this.ClientRechClient);
            this.Name = "rechercheClient";
            this.Text = "rechercheClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RechClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridView dataRechClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.Button ValiderRechClientbtn;
        private System.Windows.Forms.Button AnnulerRechClientbtn;
        private System.Windows.Forms.Button ClientExbtn;
        private System.Windows.Forms.TextBox CodePostalTextBoxRechClient;
        private System.Windows.Forms.TextBox VilleTextBoxRechClient;
        private System.Windows.Forms.TextBox RueTextBoxRechClient;
        private System.Windows.Forms.TextBox ClientTextBoxRechClient;
        private System.Windows.Forms.Label CodePostalRechClient;
        private System.Windows.Forms.Label VilleRechClient;
        private System.Windows.Forms.Label RueRechClient;
        private System.Windows.Forms.Label ClientRechClient;
    }
}