namespace Naughts_and_Crosses_V2
{
    partial class Minesweeper
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
            this.Home = new System.Windows.Forms.Button();
            this.DifficultyDrop = new System.Windows.Forms.ComboBox();
            this.DifficultyBox = new System.Windows.Forms.CheckBox();
            this.CountBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBut = new System.Windows.Forms.Button();
            this.CountText = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(61, 33);
            this.Home.TabIndex = 14;
            this.Home.Text = "Home";
            this.Home.UseMnemonic = false;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // DifficultyDrop
            // 
            this.DifficultyDrop.FormattingEnabled = true;
            this.DifficultyDrop.Items.AddRange(new object[] {
            "Easy",
            "Intermediate",
            "Expert",
            "Master"});
            this.DifficultyDrop.Location = new System.Drawing.Point(233, 217);
            this.DifficultyDrop.MaxDropDownItems = 4;
            this.DifficultyDrop.Name = "DifficultyDrop";
            this.DifficultyDrop.Size = new System.Drawing.Size(121, 21);
            this.DifficultyDrop.TabIndex = 16;
            this.DifficultyDrop.Text = "Chose dificulty";
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.AutoSize = true;
            this.DifficultyBox.Location = new System.Drawing.Point(252, 187);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(15, 14);
            this.DifficultyBox.TabIndex = 17;
            this.DifficultyBox.UseVisualStyleBackColor = true;
            this.DifficultyBox.CheckedChanged += new System.EventHandler(this.DifficultyBox_CheckedChanged);
            // 
            // CountBox
            // 
            this.CountBox.AutoSize = true;
            this.CountBox.Location = new System.Drawing.Point(318, 187);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(15, 14);
            this.CountBox.TabIndex = 18;
            this.CountBox.UseVisualStyleBackColor = true;
            this.CountBox.CheckedChanged += new System.EventHandler(this.CountBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dificulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mine count";
            // 
            // StartBut
            // 
            this.StartBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartBut.Location = new System.Drawing.Point(421, 215);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(82, 33);
            this.StartBut.TabIndex = 21;
            this.StartBut.Text = "Start";
            this.StartBut.UseMnemonic = false;
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(233, 218);
            this.CountText.MaxLength = 3;
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(121, 20);
            this.CountText.TabIndex = 22;
            this.CountText.Text = "50";
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(297, 286);
            this.ErrorBox.MaxLength = 30000000;
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(156, 46);
            this.ErrorBox.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1604, 1037);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.DifficultyDrop);
            this.Controls.Add(this.Home);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Minesweeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.ComboBox DifficultyDrop;
        private System.Windows.Forms.CheckBox DifficultyBox;
        private System.Windows.Forms.CheckBox CountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.TextBox CountText;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}