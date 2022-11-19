
namespace Memory
{
    partial class Index
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
            this.btAccetta = new System.Windows.Forms.Button();
            this.cmbPartita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAccetta
            // 
            this.btAccetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.30769F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccetta.Location = new System.Drawing.Point(147, 200);
            this.btAccetta.Name = "btAccetta";
            this.btAccetta.Size = new System.Drawing.Size(149, 59);
            this.btAccetta.TabIndex = 0;
            this.btAccetta.Text = "ACCETTA";
            this.btAccetta.UseVisualStyleBackColor = true;
            this.btAccetta.Click += new System.EventHandler(this.btAccetta_Click);
            // 
            // cmbPartita
            // 
            this.cmbPartita.FormattingEnabled = true;
            this.cmbPartita.Location = new System.Drawing.Point(160, 131);
            this.cmbPartita.Name = "cmbPartita";
            this.cmbPartita.Size = new System.Drawing.Size(130, 24);
            this.cmbPartita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scegli la modalità";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPartita);
            this.Controls.Add(this.btAccetta);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAccetta;
        private System.Windows.Forms.ComboBox cmbPartita;
        private System.Windows.Forms.Label label1;
    }
}