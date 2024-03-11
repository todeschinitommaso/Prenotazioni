namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.surnamebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aziendabox = new System.Windows.Forms.TextBox();
            this.cfbox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(26, 66);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(330, 26);
            this.namebox.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(26, 314);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(330, 26);
            this.datePicker.TabIndex = 2;
            // 
            // surnamebox
            // 
            this.surnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamebox.Location = new System.Drawing.Point(26, 132);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(330, 26);
            this.surnamebox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            // 
            // aziendabox
            // 
            this.aziendabox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aziendabox.Location = new System.Drawing.Point(26, 193);
            this.aziendabox.Name = "aziendabox";
            this.aziendabox.Size = new System.Drawing.Size(330, 26);
            this.aziendabox.TabIndex = 6;
            // 
            // cfbox
            // 
            this.cfbox.AutoSize = true;
            this.cfbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfbox.Location = new System.Drawing.Point(22, 170);
            this.cfbox.Name = "cfbox";
            this.cfbox.Size = new System.Drawing.Size(67, 20);
            this.cfbox.TabIndex = 5;
            this.cfbox.Text = "Azienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Consulenza";
            // 
            // bookbutton
            // 
            this.bookbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookbutton.Location = new System.Drawing.Point(94, 385);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(122, 37);
            this.bookbutton.TabIndex = 8;
            this.bookbutton.Text = "PRENOTA";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.Click += new System.EventHandler(this.bookbutton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo Consulenza";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sicurezza Informatica",
            "Sviluppo Software",
            "DataBase",
            "Sviluppo Reti",
            "Implementazione tecnologie emergenti",
            "Conformità normative privacy",
            "Assistenza e Supporto Tecnico"});
            this.comboBox1.Location = new System.Drawing.Point(26, 254);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(330, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 446);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aziendabox);
            this.Controls.Add(this.cfbox);
            this.Controls.Add(this.surnamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox surnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aziendabox;
        private System.Windows.Forms.Label cfbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bookbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

