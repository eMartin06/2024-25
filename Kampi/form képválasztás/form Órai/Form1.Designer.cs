
namespace form_Órai
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
            this.kép = new System.Windows.Forms.PictureBox();
            this.képválasztó = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.előzmények = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.kép)).BeginInit();
            this.SuspendLayout();
            // 
            // kép
            // 
            this.kép.Location = new System.Drawing.Point(12, 12);
            this.kép.Name = "kép";
            this.kép.Size = new System.Drawing.Size(321, 337);
            this.kép.TabIndex = 0;
            this.kép.TabStop = false;
            // 
            // képválasztó
            // 
            this.képválasztó.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kép kiválasztása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // előzmények
            // 
            this.előzmények.FormattingEnabled = true;
            this.előzmények.Location = new System.Drawing.Point(355, 12);
            this.előzmények.Name = "előzmények";
            this.előzmények.Size = new System.Drawing.Size(346, 342);
            this.előzmények.TabIndex = 2;
            this.előzmények.SelectedIndexChanged += new System.EventHandler(this.előzmények_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.előzmények);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kép);
            this.Name = "Form1";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.kép)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kép;
        private System.Windows.Forms.OpenFileDialog képválasztó;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox előzmények;
    }
}

