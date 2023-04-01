namespace IPhoneWindowsTransfer
{
	partial class IphoneConnected
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
			this.ChangeFolderBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.CurPathDisplay = new System.Windows.Forms.Label();
			this.CurrentPathLabel = new System.Windows.Forms.Label();
			this.IphoneDisplay = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// ChangeFolderBtn
			// 
			this.ChangeFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.ChangeFolderBtn.Location = new System.Drawing.Point(12, 27);
			this.ChangeFolderBtn.Name = "ChangeFolderBtn";
			this.ChangeFolderBtn.Size = new System.Drawing.Size(106, 29);
			this.ChangeFolderBtn.TabIndex = 0;
			this.ChangeFolderBtn.Text = "Change Folders";
			this.ChangeFolderBtn.UseVisualStyleBackColor = true;
			this.ChangeFolderBtn.Click += new System.EventHandler(this.ChangeFolderBtn_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(365, 149);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(8, 8);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// CurPathDisplay
			// 
			this.CurPathDisplay.AutoSize = true;
			this.CurPathDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.CurPathDisplay.Location = new System.Drawing.Point(13, 9);
			this.CurPathDisplay.Name = "CurPathDisplay";
			this.CurPathDisplay.Size = new System.Drawing.Size(155, 15);
			this.CurPathDisplay.TabIndex = 2;
			this.CurPathDisplay.Text = "Current Path to Transfer to: ";
			// 
			// CurrentPathLabel
			// 
			this.CurrentPathLabel.AutoSize = true;
			this.CurrentPathLabel.Location = new System.Drawing.Point(164, 11);
			this.CurrentPathLabel.Name = "CurrentPathLabel";
			this.CurrentPathLabel.Size = new System.Drawing.Size(35, 13);
			this.CurrentPathLabel.TabIndex = 3;
			this.CurrentPathLabel.Text = "label1";
			// 
			// IphoneDisplay
			// 
			this.IphoneDisplay.Location = new System.Drawing.Point(574, 27);
			this.IphoneDisplay.Name = "IphoneDisplay";
			this.IphoneDisplay.Size = new System.Drawing.Size(286, 569);
			this.IphoneDisplay.TabIndex = 4;
			// 
			// IphoneConnected
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(888, 625);
			this.Controls.Add(this.IphoneDisplay);
			this.Controls.Add(this.CurrentPathLabel);
			this.Controls.Add(this.CurPathDisplay);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.ChangeFolderBtn);
			this.Name = "IphoneConnected";
			this.Text = "IphoneConnected";
			this.Load += new System.EventHandler(this.IphoneConnected_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ChangeFolderBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label CurPathDisplay;
		private System.Windows.Forms.Label CurrentPathLabel;
		private System.Windows.Forms.FlowLayoutPanel IphoneDisplay;
	}
}