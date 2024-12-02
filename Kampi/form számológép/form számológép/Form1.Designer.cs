
namespace form_számológép
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.muvelet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(23, 12);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 0;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(23, 152);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 1;
            this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(23, 208);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Számol";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(122, 210);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 3;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // muvelet
            // 
            this.muvelet.FormattingEnabled = true;
            this.muvelet.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.muvelet.Location = new System.Drawing.Point(23, 80);
            this.muvelet.Name = "muvelet";
            this.muvelet.Size = new System.Drawing.Size(121, 21);
            this.muvelet.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.muvelet);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox muvelet;
    }
}

