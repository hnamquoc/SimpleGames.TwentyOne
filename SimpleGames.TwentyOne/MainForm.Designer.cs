
namespace SimpleGames.TwentyOne
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.FlowLayoutPanel pnlNumber;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblScore = new System.Windows.Forms.Label();
			this.pnlNumber = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// lblScore
			// 
			this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(12, 92);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(72, 77);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "0";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlNumber
			// 
			this.pnlNumber.AutoSize = true;
			this.pnlNumber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlNumber.Location = new System.Drawing.Point(0, 9);
			this.pnlNumber.Margin = new System.Windows.Forms.Padding(0);
			this.pnlNumber.Name = "pnlNumber";
			this.pnlNumber.Size = new System.Drawing.Size(0, 0);
			this.pnlNumber.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(96, 178);
			this.Controls.Add(this.pnlNumber);
			this.Controls.Add(this.lblScore);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleGames.TwentyOne";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
