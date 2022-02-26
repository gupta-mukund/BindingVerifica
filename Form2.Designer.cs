
namespace GuptaVerifica
{
    partial class Form2
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
            this.cmbReparto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbDipendenti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRetribuzione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbReparto
            // 
            this.cmbReparto.FormattingEnabled = true;
            this.cmbReparto.Location = new System.Drawing.Point(87, 71);
            this.cmbReparto.Name = "cmbReparto";
            this.cmbReparto.Size = new System.Drawing.Size(121, 21);
            this.cmbReparto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reparto";
            // 
            // lsbDipendenti
            // 
            this.lsbDipendenti.FormattingEnabled = true;
            this.lsbDipendenti.Location = new System.Drawing.Point(43, 191);
            this.lsbDipendenti.Name = "lsbDipendenti";
            this.lsbDipendenti.Size = new System.Drawing.Size(224, 186);
            this.lsbDipendenti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dipendenti";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(346, 242);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRetribuzione
            // 
            this.txtRetribuzione.Location = new System.Drawing.Point(346, 327);
            this.txtRetribuzione.Name = "txtRetribuzione";
            this.txtRetribuzione.Size = new System.Drawing.Size(151, 20);
            this.txtRetribuzione.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome e Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Retribuzione";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRetribuzione);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbDipendenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReparto);
            this.Name = "Form2";
            this.Text = "Esercizio 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReparto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbDipendenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRetribuzione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}