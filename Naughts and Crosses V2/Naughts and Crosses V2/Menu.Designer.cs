namespace Naughts_and_Crosses_V2
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Noughtsandcrosses = new System.Windows.Forms.Button();
            this.fourinarow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Games collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click on a button to go to the selected game";
            // 
            // Noughtsandcrosses
            // 
            this.Noughtsandcrosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Noughtsandcrosses.Location = new System.Drawing.Point(101, 75);
            this.Noughtsandcrosses.Name = "Noughtsandcrosses";
            this.Noughtsandcrosses.Size = new System.Drawing.Size(184, 33);
            this.Noughtsandcrosses.TabIndex = 14;
            this.Noughtsandcrosses.Text = "Noughts and crosses";
            this.Noughtsandcrosses.UseMnemonic = false;
            this.Noughtsandcrosses.UseVisualStyleBackColor = true;
            this.Noughtsandcrosses.Click += new System.EventHandler(this.Noughtsandcrosses_Click);
            // 
            // fourinarow
            // 
            this.fourinarow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fourinarow.Location = new System.Drawing.Point(150, 114);
            this.fourinarow.Name = "fourinarow";
            this.fourinarow.Size = new System.Drawing.Size(87, 33);
            this.fourinarow.TabIndex = 15;
            this.fourinarow.Text = "4 in a row";
            this.fourinarow.UseMnemonic = false;
            this.fourinarow.UseVisualStyleBackColor = true;
            this.fourinarow.Click += new System.EventHandler(this.fourinarow_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.fourinarow);
            this.Controls.Add(this.Noughtsandcrosses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Noughtsandcrosses;
        private System.Windows.Forms.Button fourinarow;
    }
}