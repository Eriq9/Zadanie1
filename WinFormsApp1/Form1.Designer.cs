
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Run = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Waga = new System.Windows.Forms.TextBox();
            this.Pojemnosc = new System.Windows.Forms.TextBox();
            this.Wartosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(619, 310);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 125);
            this.textBox1.TabIndex = 1;
            // 
            // Waga
            // 
            this.Waga.Location = new System.Drawing.Point(110, 311);
            this.Waga.Name = "Waga";
            this.Waga.Size = new System.Drawing.Size(100, 23);
            this.Waga.TabIndex = 2;
            // 
            // Pojemnosc
            // 
            this.Pojemnosc.Location = new System.Drawing.Point(594, 97);
            this.Pojemnosc.Name = "Pojemnosc";
            this.Pojemnosc.Size = new System.Drawing.Size(100, 23);
            this.Pojemnosc.TabIndex = 3;
            this.Pojemnosc.Tag = "";
            this.Pojemnosc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Wartosc
            // 
            this.Wartosc.Location = new System.Drawing.Point(236, 311);
            this.Wartosc.Name = "Wartosc";
            this.Wartosc.Size = new System.Drawing.Size(100, 23);
            this.Wartosc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.Wartosc);
            this.Controls.Add(this.Pojemnosc);
            this.Controls.Add(this.Waga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Run);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Waga;
        private System.Windows.Forms.TextBox Pojemnosc;
        private System.Windows.Forms.TextBox Wartosc;
    }
}

