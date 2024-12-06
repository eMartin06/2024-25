
namespace form_képvál_dolg
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
            this.lista = new System.Windows.Forms.ListBox();
            this.kép = new System.Windows.Forms.PictureBox();
            this.gomb = new System.Windows.Forms.Button();
            this.képválasztó = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kép)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(439, 5);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(275, 368);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // kép
            // 
            this.kép.Location = new System.Drawing.Point(12, 12);
            this.kép.Name = "kép";
            this.kép.Size = new System.Drawing.Size(368, 361);
            this.kép.TabIndex = 1;
            this.kép.TabStop = false;
            // 
            // gomb
            // 
            this.gomb.Location = new System.Drawing.Point(114, 401);
            this.gomb.Name = "gomb";
            this.gomb.Size = new System.Drawing.Size(177, 26);
            this.gomb.TabIndex = 2;
            this.gomb.Text = "Válasz képet";
            this.gomb.UseVisualStyleBackColor = true;
            this.gomb.Click += new System.EventHandler(this.gomb_Click);
            // 
            // képválasztó
            // 
            this.képválasztó.FileName = "képválasztó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gomb);
            this.Controls.Add(this.kép);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kép)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PictureBox kép;
        private System.Windows.Forms.Button gomb;
        private System.Windows.Forms.OpenFileDialog képválasztó;
    }
}

