namespace Stopwatch
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnstart = new System.Windows.Forms.Button();
			this.btnstop = new System.Windows.Forms.Button();
			this.btnreset = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("LCDMono2", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(81, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(609, 86);
			this.label1.TabIndex = 0;
			this.label1.Text = "00:00:00:00";
			// 
			// btnstart
			// 
			this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(151)))));
			this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnstart.ForeColor = System.Drawing.Color.White;
			this.btnstart.Location = new System.Drawing.Point(96, 176);
			this.btnstart.Name = "btnstart";
			this.btnstart.Size = new System.Drawing.Size(160, 50);
			this.btnstart.TabIndex = 1;
			this.btnstart.Text = "Start";
			this.btnstart.UseVisualStyleBackColor = false;
			this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
			// 
			// btnstop
			// 
			this.btnstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(86)))), ((int)(((byte)(91)))));
			this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnstop.ForeColor = System.Drawing.Color.White;
			this.btnstop.Location = new System.Drawing.Point(315, 176);
			this.btnstop.Name = "btnstop";
			this.btnstop.Size = new System.Drawing.Size(160, 50);
			this.btnstop.TabIndex = 2;
			this.btnstop.Text = "Stop";
			this.btnstop.UseVisualStyleBackColor = false;
			this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
			// 
			// btnreset
			// 
			this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
			this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnreset.ForeColor = System.Drawing.Color.White;
			this.btnreset.Location = new System.Drawing.Point(530, 176);
			this.btnreset.Name = "btnreset";
			this.btnreset.Size = new System.Drawing.Size(160, 50);
			this.btnreset.TabIndex = 3;
			this.btnreset.Text = "Reset";
			this.btnreset.UseVisualStyleBackColor = false;
			this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::Stopwatch.Properties.Resources.pngtreejpg;
			this.pictureBox1.Location = new System.Drawing.Point(742, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(806, 261);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnreset);
			this.Controls.Add(this.btnstop);
			this.Controls.Add(this.btnstart);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnstart;
		private System.Windows.Forms.Button btnstop;
		private System.Windows.Forms.Button btnreset;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

