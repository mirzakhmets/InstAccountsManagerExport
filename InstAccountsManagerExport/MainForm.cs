/*
 * Created by SharpDevelop.
 * User: mspma
 * Date: 5/23/2024
 * Time: 3:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace InstAccountsManagerExport
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string usersFileName = null;
		Random random = new Random();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonUsersClick(object sender, EventArgs e)
		{
			if (this.openFileDialog.ShowDialog() == DialogResult.OK) {
				this.usersFileName = this.openFileDialog.FileName;
			}
		}
		void ButtonExportClick(object sender, EventArgs e)
		{
			if (this.saveFileDialog.ShowDialog() == DialogResult.OK && this.usersFileName != null) {
				string outputFileName = this.saveFileDialog.FileName;
				
				CSVFile csvFile = new CSVFile(new ParsingStream(new FileStream(this.usersFileName, FileMode.Open)), "csvFile");
				
				foreach (CSVLine csvLine in csvFile.lines) {
					string output = "";
					
					string login = csvFile.namesIndex.ContainsKey("login") ? csvLine.values[csvFile.namesIndex["login"]] : "";
					string password = csvFile.namesIndex.ContainsKey("password") ? csvLine.values[csvFile.namesIndex["password"]] : "";
					string userAgent = csvFile.namesIndex.ContainsKey("UserAgent") ? csvLine.values[csvFile.namesIndex["UserAgent"]] : "";
					string cookies = csvFile.namesIndex.ContainsKey("cookies") ? csvLine.values[csvFile.namesIndex["cookies"]] : "";
					string proxy = csvFile.namesIndex.ContainsKey("proxy") ? csvLine.values[csvFile.namesIndex["proxy"]] : "";
					string mailLogin = csvFile.namesIndex.ContainsKey("MailLogin") ? csvLine.values[csvFile.namesIndex["MailLogin"]] : "";
					string mailPassword = csvFile.namesIndex.ContainsKey("MailPassword") ? csvLine.values[csvFile.namesIndex["MailPassword"]] : "";
					
					if (this.textBoxUserAgent.Text.Length > 0) {
						userAgent = this.textBoxUserAgent.Text;
					}
					
					if (this.textBoxCookies.Text.Length > 0) {
						cookies = this.textBoxCookies.Text;
					}
					
					if (this.richTextBoxProxyList.Lines.Length > 0) {
						proxy = this.richTextBoxProxyList.Lines[random.Next(0, this.richTextBoxProxyList.Lines.Length)];
					}
					
					if (login.Length > 0 && password.Length > 0) {
						output += login + ":" + password;
					}
					
					output += "|" + userAgent + "|" + cookies + "|" + proxy + "|";
					
					if (mailLogin.Length > 0 && mailPassword.Length > 0) {
						output += mailLogin + ":" + mailPassword;
					}
					
					File.AppendAllLines(outputFileName, new string[] { output });
				}
			}
		}
	}
}
