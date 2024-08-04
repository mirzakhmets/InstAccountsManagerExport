/*
 * Created by SharpDevelop.
 * User: mspma
 * Date: 5/23/2024
 * Time: 3:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace InstAccountsManagerExport
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelUserAgent;
		private System.Windows.Forms.TextBox textBoxUserAgent;
		private System.Windows.Forms.Label labelCookies;
		private System.Windows.Forms.TextBox textBoxCookies;
		private System.Windows.Forms.Label labelProxyList;
		private System.Windows.Forms.RichTextBox richTextBoxProxyList;
		private System.Windows.Forms.Button buttonUsers;
		private System.Windows.Forms.Button buttonExport;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		
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
			this.labelUserAgent = new System.Windows.Forms.Label();
			this.textBoxUserAgent = new System.Windows.Forms.TextBox();
			this.labelCookies = new System.Windows.Forms.Label();
			this.textBoxCookies = new System.Windows.Forms.TextBox();
			this.labelProxyList = new System.Windows.Forms.Label();
			this.richTextBoxProxyList = new System.Windows.Forms.RichTextBox();
			this.buttonUsers = new System.Windows.Forms.Button();
			this.buttonExport = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// labelUserAgent
			// 
			this.labelUserAgent.Location = new System.Drawing.Point(16, 15);
			this.labelUserAgent.Name = "labelUserAgent";
			this.labelUserAgent.Size = new System.Drawing.Size(152, 19);
			this.labelUserAgent.TabIndex = 1;
			this.labelUserAgent.Text = "User Agent (optional):";
			// 
			// textBoxUserAgent
			// 
			this.textBoxUserAgent.Location = new System.Drawing.Point(175, 12);
			this.textBoxUserAgent.Name = "textBoxUserAgent";
			this.textBoxUserAgent.Size = new System.Drawing.Size(395, 22);
			this.textBoxUserAgent.TabIndex = 2;
			// 
			// labelCookies
			// 
			this.labelCookies.Location = new System.Drawing.Point(16, 52);
			this.labelCookies.Name = "labelCookies";
			this.labelCookies.Size = new System.Drawing.Size(152, 19);
			this.labelCookies.TabIndex = 3;
			this.labelCookies.Text = "Cookies (optional):";
			// 
			// textBoxCookies
			// 
			this.textBoxCookies.Location = new System.Drawing.Point(175, 52);
			this.textBoxCookies.Name = "textBoxCookies";
			this.textBoxCookies.Size = new System.Drawing.Size(394, 22);
			this.textBoxCookies.TabIndex = 4;
			// 
			// labelProxyList
			// 
			this.labelProxyList.Location = new System.Drawing.Point(16, 104);
			this.labelProxyList.Name = "labelProxyList";
			this.labelProxyList.Size = new System.Drawing.Size(134, 18);
			this.labelProxyList.TabIndex = 5;
			this.labelProxyList.Text = "Proxy list (optional):";
			// 
			// richTextBoxProxyList
			// 
			this.richTextBoxProxyList.Location = new System.Drawing.Point(16, 125);
			this.richTextBoxProxyList.Name = "richTextBoxProxyList";
			this.richTextBoxProxyList.Size = new System.Drawing.Size(554, 102);
			this.richTextBoxProxyList.TabIndex = 6;
			this.richTextBoxProxyList.Text = "";
			// 
			// buttonUsers
			// 
			this.buttonUsers.Location = new System.Drawing.Point(352, 250);
			this.buttonUsers.Name = "buttonUsers";
			this.buttonUsers.Size = new System.Drawing.Size(106, 28);
			this.buttonUsers.TabIndex = 7;
			this.buttonUsers.Text = "Users...";
			this.buttonUsers.UseVisualStyleBackColor = true;
			this.buttonUsers.Click += new System.EventHandler(this.ButtonUsersClick);
			// 
			// buttonExport
			// 
			this.buttonExport.Location = new System.Drawing.Point(464, 250);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(106, 28);
			this.buttonExport.TabIndex = 9;
			this.buttonExport.Text = "Export...";
			this.buttonExport.UseVisualStyleBackColor = true;
			this.buttonExport.Click += new System.EventHandler(this.ButtonExportClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.Filter = "CSV Files (*.csv) | *.csv";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Any file (*.*) | *.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 293);
			this.Controls.Add(this.buttonExport);
			this.Controls.Add(this.buttonUsers);
			this.Controls.Add(this.richTextBoxProxyList);
			this.Controls.Add(this.labelProxyList);
			this.Controls.Add(this.textBoxCookies);
			this.Controls.Add(this.labelCookies);
			this.Controls.Add(this.textBoxUserAgent);
			this.Controls.Add(this.labelUserAgent);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "InstAccountsManagerExport";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
