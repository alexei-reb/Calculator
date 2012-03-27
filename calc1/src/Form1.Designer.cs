namespace calc1
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
            this.textBox1 = new System.Windows.Forms.TextBox();

            this.buttons = new System.Windows.Forms.Button[10];
            for (int i = 0; i < 10; i++)
            {
                this.buttons[i] = new System.Windows.Forms.Button();

                this.buttons[i].Location = new System.Drawing.Point(30 + 25*(i%3), 150 - 25*(i/3));
                this.buttons[i].Name = "button" + i.ToString();
                this.buttons[i].Size = new System.Drawing.Size(25, 25);
                this.buttons[i].TabIndex = 1;
                this.buttons[i].Tag = i.ToString();
                this.buttons[i].Text = i.ToString();
                this.buttons[i].UseVisualStyleBackColor = true;
                this.buttons[i].Click += new System.EventHandler(this.button_Click);
                this.Controls.Add(this.buttons[i]);
            }

            this.buttonsSign = new System.Windows.Forms.Button[4];
            for (int i = 0; i < 4; i++)
            {
                this.buttonsSign[i] = new System.Windows.Forms.Button();

                this.buttonsSign[i].Location = new System.Drawing.Point(150, 150 - 25 * i);
                this.buttonsSign[i].Name = "buttonSign" + i.ToString();
                this.buttonsSign[i].Size = new System.Drawing.Size(25, 25);
                this.buttonsSign[i].TabIndex = 1;
                this.buttonsSign[i].UseVisualStyleBackColor = true;
                this.buttonsSign[i].Click += new System.EventHandler(this.buttonSign_Click);
                this.Controls.Add(this.buttonsSign[i]);
            }
            this.buttonsSign[0].Text = "+";
            this.buttonsSign[1].Text = "-";
            this.buttonsSign[2].Text = "*";
            this.buttonsSign[3].Text = "/";

            this.CalcButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(27, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 

            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(150, 180);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(25, 25);
            this.CalcButton.TabIndex = 14;
            this.CalcButton.Text = "=";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(30, 180);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(25, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "C";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 262);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CalcButton);

            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button[] buttons;
        private System.Windows.Forms.Button[] buttonsSign;

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

