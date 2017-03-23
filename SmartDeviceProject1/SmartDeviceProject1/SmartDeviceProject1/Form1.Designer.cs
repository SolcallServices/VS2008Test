namespace SmartDeviceProject1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jaswinder";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pushpak";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Testing";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pushpak";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(280, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 365);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(42, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 48);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(631, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
    }
}

