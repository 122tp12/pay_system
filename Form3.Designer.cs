namespace Framework {
	partial class Form3 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.Otherwise = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Location = new System.Drawing.Point(-178, -11);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1232, 431);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(251, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(324, 388);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.label1.Location = new System.Drawing.Point(364, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "L o g i n";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label2.Location = new System.Drawing.Point(301, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter your phone\'s number";
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "UA, RU, US, UK";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(276, 150);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(38, 21);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Tag = "UA, RU, US, UK";
			this.comboBox1.ValueMember = "UA, RU, US, UK";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.textBox1.Location = new System.Drawing.Point(331, 148);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(177, 26);
			this.textBox1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label3.Location = new System.Drawing.Point(345, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 27);
			this.label3.TabIndex = 12;
			this.label3.Text = "Enter an e-mail";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.textBox2.Location = new System.Drawing.Point(263, 250);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(292, 26);
			this.textBox2.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.label4.Location = new System.Drawing.Point(336, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 31);
			this.label4.TabIndex = 14;
			this.label4.Text = "Enter a password";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.textBox3.Location = new System.Drawing.Point(300, 322);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(206, 26);
			this.textBox3.TabIndex = 15;
			this.textBox3.Visible = false;
			// 
			// Otherwise
			// 
			this.Otherwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.Otherwise.Location = new System.Drawing.Point(365, 181);
			this.Otherwise.Name = "Otherwise";
			this.Otherwise.Size = new System.Drawing.Size(86, 27);
			this.Otherwise.TabIndex = 16;
			this.Otherwise.Text = "Otherwise";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(337, 358);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(134, 17);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "Remember an account";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(337, 381);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 44);
			this.button1.TabIndex = 18;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Otherwise);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label Otherwise;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
	}
}