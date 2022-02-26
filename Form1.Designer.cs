
namespace GuptaVerifica
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
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPresidente = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtJson = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtCognomeBind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azienda";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Location = new System.Drawing.Point(129, 67);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(184, 21);
            this.cmbAzienda.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indirizzo Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presidente";
            // 
            // txtPresidente
            // 
            this.txtPresidente.Location = new System.Drawing.Point(130, 107);
            this.txtPresidente.Name = "txtPresidente";
            this.txtPresidente.Size = new System.Drawing.Size(183, 20);
            this.txtPresidente.TabIndex = 5;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(130, 152);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(183, 20);
            this.txtIndirizzo.TabIndex = 6;
            // 
            // txtJson
            // 
            this.txtJson.Location = new System.Drawing.Point(393, 12);
            this.txtJson.Multiline = true;
            this.txtJson.Name = "txtJson";
            this.txtJson.ReadOnly = true;
            this.txtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJson.Size = new System.Drawing.Size(367, 426);
            this.txtJson.TabIndex = 7;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(79, 257);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(200, 20);
            this.txtCognome.TabIndex = 8;
            // 
            // txtCognomeBind
            // 
            this.txtCognomeBind.Location = new System.Drawing.Point(79, 283);
            this.txtCognomeBind.Name = "txtCognomeBind";
            this.txtCognomeBind.Size = new System.Drawing.Size(200, 20);
            this.txtCognomeBind.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cognome";
            // 
            // txtNext
            // 
            this.txtNext.Location = new System.Drawing.Point(104, 355);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(142, 48);
            this.txtNext.TabIndex = 11;
            this.txtNext.Text = "Next Exercise";
            this.txtNext.UseVisualStyleBackColor = true;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCognomeBind);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtJson);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.txtPresidente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Esericizio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPresidente;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtJson;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCognomeBind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtNext;
    }
}

