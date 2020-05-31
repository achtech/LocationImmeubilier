namespace WindowsFormsApp2.categories
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.libelleCategorie = new System.Windows.Forms.TextBox();
            this.addButtom = new System.Windows.Forms.Button();
            this.annuletBtm = new System.Windows.Forms.Button();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "libelle Categorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Les categorie";
            // 
            // libelleCategorie
            // 
            this.libelleCategorie.Location = new System.Drawing.Point(153, 153);
            this.libelleCategorie.Multiline = true;
            this.libelleCategorie.Name = "libelleCategorie";
            this.libelleCategorie.Size = new System.Drawing.Size(143, 40);
            this.libelleCategorie.TabIndex = 2;
            // 
            // addButtom
            // 
            this.addButtom.Location = new System.Drawing.Point(12, 239);
            this.addButtom.Name = "addButtom";
            this.addButtom.Size = new System.Drawing.Size(122, 50);
            this.addButtom.TabIndex = 3;
            this.addButtom.Text = "sauvegarder";
            this.addButtom.UseVisualStyleBackColor = true;
            this.addButtom.Click += new System.EventHandler(this.addButtom_Click);
            // 
            // annuletBtm
            // 
            this.annuletBtm.Location = new System.Drawing.Point(154, 235);
            this.annuletBtm.Name = "annuletBtm";
            this.annuletBtm.Size = new System.Drawing.Size(143, 54);
            this.annuletBtm.TabIndex = 4;
            this.annuletBtm.Text = "supprimer";
            this.annuletBtm.UseVisualStyleBackColor = true;
            this.annuletBtm.Click += new System.EventHandler(this.annuletBtm_Click);
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(352, 84);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowTemplate.Height = 24;
            this.dataGridViewCat.Size = new System.Drawing.Size(436, 225);
            this.dataGridViewCat.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.annuletBtm);
            this.Controls.Add(this.addButtom);
            this.Controls.Add(this.libelleCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox libelleCategorie;
        private System.Windows.Forms.Button addButtom;
        private System.Windows.Forms.Button annuletBtm;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}