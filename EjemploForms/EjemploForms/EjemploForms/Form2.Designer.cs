
namespace EjemploForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.miTextbox7 = new EjemploForms.MITextbox();
            this.miTextbox5 = new EjemploForms.MITextbox();
            this.miTextbox4 = new EjemploForms.MITextbox();
            this.miTextbox6 = new EjemploForms.MITextbox();
            this.miTextbox3 = new EjemploForms.MITextbox();
            this.miTextbox2 = new EjemploForms.MITextbox();
            this.miTextbox1 = new EjemploForms.MITextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // miTextbox7
            // 
            this.miTextbox7.Location = new System.Drawing.Point(88, 253);
            this.miTextbox7.Name = "miTextbox7";
            this.miTextbox7.Requerido = true;
            this.miTextbox7.Size = new System.Drawing.Size(284, 20);
            this.miTextbox7.TabIndex = 5;
            // 
            // miTextbox5
            // 
            this.miTextbox5.Location = new System.Drawing.Point(88, 154);
            this.miTextbox5.Name = "miTextbox5";
            this.miTextbox5.Requerido = false;
            this.miTextbox5.Size = new System.Drawing.Size(284, 20);
            this.miTextbox5.TabIndex = 4;
            // 
            // miTextbox4
            // 
            this.miTextbox4.Location = new System.Drawing.Point(88, 113);
            this.miTextbox4.Name = "miTextbox4";
            this.miTextbox4.Requerido = true;
            this.miTextbox4.Size = new System.Drawing.Size(284, 20);
            this.miTextbox4.TabIndex = 3;
            // 
            // miTextbox6
            // 
            this.miTextbox6.Location = new System.Drawing.Point(88, 195);
            this.miTextbox6.Name = "miTextbox6";
            this.miTextbox6.Requerido = true;
            this.miTextbox6.Size = new System.Drawing.Size(284, 20);
            this.miTextbox6.TabIndex = 3;
            // 
            // miTextbox3
            // 
            this.miTextbox3.Location = new System.Drawing.Point(88, 221);
            this.miTextbox3.Name = "miTextbox3";
            this.miTextbox3.Requerido = false;
            this.miTextbox3.Size = new System.Drawing.Size(284, 20);
            this.miTextbox3.TabIndex = 3;
            // 
            // miTextbox2
            // 
            this.miTextbox2.Location = new System.Drawing.Point(88, 70);
            this.miTextbox2.Name = "miTextbox2";
            this.miTextbox2.Requerido = true;
            this.miTextbox2.Size = new System.Drawing.Size(284, 20);
            this.miTextbox2.TabIndex = 2;
            // 
            // miTextbox1
            // 
            this.miTextbox1.Location = new System.Drawing.Point(88, 35);
            this.miTextbox1.Name = "miTextbox1";
            this.miTextbox1.Requerido = true;
            this.miTextbox1.Size = new System.Drawing.Size(284, 20);
            this.miTextbox1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.miTextbox7);
            this.Controls.Add(this.miTextbox5);
            this.Controls.Add(this.miTextbox4);
            this.Controls.Add(this.miTextbox6);
            this.Controls.Add(this.miTextbox3);
            this.Controls.Add(this.miTextbox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.miTextbox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MITextbox miTextbox1;
        private System.Windows.Forms.Button button1;
        private MITextbox miTextbox2;
        private MITextbox miTextbox3;
        private MITextbox miTextbox4;
        private MITextbox miTextbox5;
        private MITextbox miTextbox6;
        private MITextbox miTextbox7;
    }
}