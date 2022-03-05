
namespace BiohazardRansomware
{
    partial class BiohazardMainForm
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiohazardMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.biohazardgreen = new System.Windows.Forms.PictureBox();
            this.randomcolorlabel1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.keybox = new System.Windows.Forms.TextBox();
            this.rndcolorlabel1 = new System.Windows.Forms.Timer(this.components);
            this.randommsg1 = new System.Windows.Forms.Timer(this.components);
            this.randommsg2 = new System.Windows.Forms.Timer(this.components);
            this.check_badprocesses = new System.Windows.Forms.Timer(this.components);
            this.whatshappening = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biohazardgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            button1.Location = new System.Drawing.Point(344, 395);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(132, 43);
            button1.TabIndex = 6;
            button1.Text = "Decrypt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.biohazardgreen);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 167);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(551, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ur Files is Encrypted :D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biohazard Ransomware";
            // 
            // biohazardgreen
            // 
            this.biohazardgreen.Image = ((System.Drawing.Image)(resources.GetObject("biohazardgreen.Image")));
            this.biohazardgreen.Location = new System.Drawing.Point(346, 16);
            this.biohazardgreen.Name = "biohazardgreen";
            this.biohazardgreen.Size = new System.Drawing.Size(154, 130);
            this.biohazardgreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.biohazardgreen.TabIndex = 0;
            this.biohazardgreen.TabStop = false;
            // 
            // randomcolorlabel1
            // 
            this.randomcolorlabel1.Enabled = true;
            this.randomcolorlabel1.Interval = 5000;
            this.randomcolorlabel1.Tick += new System.EventHandler(this.randomcolorlabel1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(212, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(431, 169);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(663, 169);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(116, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // keybox
            // 
            this.keybox.BackColor = System.Drawing.Color.Black;
            this.keybox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keybox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.keybox.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keybox.ForeColor = System.Drawing.Color.Red;
            this.keybox.Location = new System.Drawing.Point(306, 337);
            this.keybox.Multiline = true;
            this.keybox.Name = "keybox";
            this.keybox.Size = new System.Drawing.Size(219, 43);
            this.keybox.TabIndex = 5;
            // 
            // rndcolorlabel1
            // 
            this.rndcolorlabel1.Enabled = true;
            this.rndcolorlabel1.Interval = 5000;
            this.rndcolorlabel1.Tick += new System.EventHandler(this.rndcolorlabel1_Tick);
            // 
            // randommsg1
            // 
            this.randommsg1.Enabled = true;
            this.randommsg1.Interval = 9000;
            this.randommsg1.Tick += new System.EventHandler(this.randommsg1_Tick);
            // 
            // randommsg2
            // 
            this.randommsg2.Enabled = true;
            this.randommsg2.Interval = 9000;
            this.randommsg2.Tick += new System.EventHandler(this.randommsg2_Tick);
            // 
            // check_badprocesses
            // 
            this.check_badprocesses.Enabled = true;
            this.check_badprocesses.Interval = 60000;
            this.check_badprocesses.Tick += new System.EventHandler(this.check_badprocesses_Tick);
            // 
            // whatshappening
            // 
            this.whatshappening.BackColor = System.Drawing.Color.Black;
            this.whatshappening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whatshappening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.whatshappening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(120)))));
            this.whatshappening.Location = new System.Drawing.Point(557, 336);
            this.whatshappening.Name = "whatshappening";
            this.whatshappening.Size = new System.Drawing.Size(202, 44);
            this.whatshappening.TabIndex = 7;
            this.whatshappening.Text = "What\'s Happening?";
            this.whatshappening.UseVisualStyleBackColor = false;
            this.whatshappening.Click += new System.EventHandler(this.whatshappening_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(312, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Pay Form";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BiohazardMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.whatshappening);
            this.Controls.Add(button1);
            this.Controls.Add(this.keybox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BiohazardMainForm";
            this.ShowInTaskbar = false;
            this.Text = "Biohazard Ransomware";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiohazardMainForm_FormClosing);
            this.Load += new System.EventHandler(this.BiohazardMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biohazardgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox biohazardgreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer randomcolorlabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox keybox;
        private System.Windows.Forms.Timer rndcolorlabel1;
        private System.Windows.Forms.Timer randommsg1;
        private System.Windows.Forms.Timer randommsg2;
        private System.Windows.Forms.Timer check_badprocesses;
        private System.Windows.Forms.Button whatshappening;
        private System.Windows.Forms.Button button3;
    }
}

