/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/15/2022
 * Time: 12:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyFirewall
{
	partial class NewForwardRuleForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForwardRuleForm));
			this.label1 = new System.Windows.Forms.Label();
			this.ipAddress = new System.Windows.Forms.TextBox();
			this.sourcePort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.targetPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ruleGroup = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.saveRuleBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.ruleName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.protocol = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Target IP Address";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ipAddress
			// 
			this.ipAddress.Location = new System.Drawing.Point(128, 65);
			this.ipAddress.Name = "ipAddress";
			this.ipAddress.Size = new System.Drawing.Size(124, 20);
			this.ipAddress.TabIndex = 3;
			// 
			// sourcePort
			// 
			this.sourcePort.Location = new System.Drawing.Point(128, 91);
			this.sourcePort.Name = "sourcePort";
			this.sourcePort.Size = new System.Drawing.Size(68, 20);
			this.sourcePort.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Source Port";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// targetPort
			// 
			this.targetPort.Location = new System.Drawing.Point(128, 117);
			this.targetPort.Name = "targetPort";
			this.targetPort.Size = new System.Drawing.Size(68, 20);
			this.targetPort.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Target Port";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ruleGroup
			// 
			this.ruleGroup.FormattingEnabled = true;
			this.ruleGroup.Location = new System.Drawing.Point(128, 12);
			this.ruleGroup.Name = "ruleGroup";
			this.ruleGroup.Size = new System.Drawing.Size(124, 21);
			this.ruleGroup.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Rule Group";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// saveRuleBtn
			// 
			this.saveRuleBtn.Location = new System.Drawing.Point(128, 181);
			this.saveRuleBtn.Name = "saveRuleBtn";
			this.saveRuleBtn.Size = new System.Drawing.Size(75, 23);
			this.saveRuleBtn.TabIndex = 7;
			this.saveRuleBtn.Text = "Save";
			this.saveRuleBtn.UseVisualStyleBackColor = true;
			this.saveRuleBtn.Click += new System.EventHandler(this.SaveRuleBtnClick);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(47, 181);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 8;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
			// 
			// ruleName
			// 
			this.ruleName.Location = new System.Drawing.Point(128, 39);
			this.ruleName.Name = "ruleName";
			this.ruleName.Size = new System.Drawing.Size(124, 20);
			this.ruleName.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Rule Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Rule Group";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// protocol
			// 
			this.protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.protocol.FormattingEnabled = true;
			this.protocol.Items.AddRange(new object[] {
									"TCP",
									"UDP"});
			this.protocol.Location = new System.Drawing.Point(128, 143);
			this.protocol.Name = "protocol";
			this.protocol.Size = new System.Drawing.Size(68, 21);
			this.protocol.TabIndex = 6;
			// 
			// NewForwardRuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 221);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.protocol);
			this.Controls.Add(this.ruleName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.saveRuleBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ruleGroup);
			this.Controls.Add(this.targetPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sourcePort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ipAddress);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewForwardRuleForm";
			this.Text = "New Forward Rule";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox protocol;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ruleName;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button saveRuleBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox ruleGroup;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox targetPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox sourcePort;
		private System.Windows.Forms.TextBox ipAddress;
		private System.Windows.Forms.Label label1;
	}
}
