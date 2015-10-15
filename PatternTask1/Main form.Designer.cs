namespace PatternTask1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.hight = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MU = new System.Windows.Forms.Label();
            this.Seg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RedData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GreenData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlueData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(63, 355);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 2;
            // 
            // hight
            // 
            this.hight.Location = new System.Drawing.Point(248, 355);
            this.hight.Name = "hight";
            this.hight.Size = new System.Drawing.Size(100, 20);
            this.hight.TabIndex = 3;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(262, 295);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 4;
            this.gen.Text = "Generate";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "hight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "C1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "C2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "C3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "C4";
            // 
            // MU
            // 
            this.MU.AutoSize = true;
            this.MU.Location = new System.Drawing.Point(593, 45);
            this.MU.Name = "MU";
            this.MU.Size = new System.Drawing.Size(24, 13);
            this.MU.TabIndex = 36;
            this.MU.Text = "MU";
            // 
            // Seg
            // 
            this.Seg.AutoSize = true;
            this.Seg.Location = new System.Drawing.Point(591, 62);
            this.Seg.Name = "Seg";
            this.Seg.Size = new System.Drawing.Size(26, 13);
            this.Seg.TabIndex = 37;
            this.Seg.Text = "Seg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(593, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "MU";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(593, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Seg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(591, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "MU";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(589, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Seg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(589, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "MU";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(591, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Seg";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedData,
            this.GreenData,
            this.BlueData});
            this.dataGridView1.Location = new System.Drawing.Point(623, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 209);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RedData
            // 
            this.RedData.FillWeight = 110F;
            this.RedData.HeaderText = "Red";
            this.RedData.Name = "RedData";
            // 
            // GreenData
            // 
            this.GreenData.HeaderText = "Green";
            this.GreenData.Name = "GreenData";
            // 
            // BlueData
            // 
            this.BlueData.HeaderText = "Blue";
            this.BlueData.Name = "BlueData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Seg);
            this.Controls.Add(this.MU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.hight);
            this.Controls.Add(this.width);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Bitmap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox hight;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MU;
        private System.Windows.Forms.Label Seg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GreenData;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlueData;
    }
}

