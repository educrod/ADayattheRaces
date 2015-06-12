namespace ADayattheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dogToBet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bucksToBet = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.nameBetlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksToBet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 11);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 200);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogToBet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bucksToBet);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nameBetlabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.JoeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // dogToBet
            // 
            this.dogToBet.Location = new System.Drawing.Point(318, 110);
            this.dogToBet.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogToBet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogToBet.Name = "dogToBet";
            this.dogToBet.Size = new System.Drawing.Size(55, 20);
            this.dogToBet.TabIndex = 13;
            this.dogToBet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "bucks on dog number ";
            // 
            // bucksToBet
            // 
            this.bucksToBet.Location = new System.Drawing.Point(123, 108);
            this.bucksToBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bucksToBet.Name = "bucksToBet";
            this.bucksToBet.Size = new System.Drawing.Size(46, 20);
            this.bucksToBet.TabIndex = 11;
            this.bucksToBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Bets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameBetlabel
            // 
            this.nameBetlabel.AutoSize = true;
            this.nameBetlabel.Location = new System.Drawing.Point(10, 110);
            this.nameBetlabel.Name = "nameBetlabel";
            this.nameBetlabel.Size = new System.Drawing.Size(33, 13);
            this.nameBetlabel.TabIndex = 9;
            this.nameBetlabel.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bets";
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(185, 83);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(148, 13);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(185, 60);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(148, 13);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(185, 37);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(148, 13);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "JoeBetLabel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Race!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(13, 83);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(13, 60);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Checked = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(13, 37);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(101, 17);
            this.JoeRadioButton.TabIndex = 1;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "JoeRadioButton";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(10, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(130, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum bet: 5 bucks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogToBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksToBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown bucksToBet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label nameBetlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.NumericUpDown dogToBet;
        private System.Windows.Forms.Label label1;
    }
}

