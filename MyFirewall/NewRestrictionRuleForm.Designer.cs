/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/15/2022
 * Time: 11:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyFirewall
{
	partial class NewRestrictionRuleForm
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
			this.ruleName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ruleGroup = new System.Windows.Forms.ComboBox();
			this.ipAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.saveRuleBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ruleName
			// 
			this.ruleName.Location = new System.Drawing.Point(139, 38);
			this.ruleName.Name = "ruleName";
			this.ruleName.Size = new System.Drawing.Size(124, 20);
			this.ruleName.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Rule Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Rule Group";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ruleGroup
			// 
			this.ruleGroup.FormattingEnabled = true;
			this.ruleGroup.Location = new System.Drawing.Point(139, 11);
			this.ruleGroup.Name = "ruleGroup";
			this.ruleGroup.Size = new System.Drawing.Size(124, 21);
			this.ruleGroup.TabIndex = 1;
			// 
			// ipAddress
			// 
			this.ipAddress.Location = new System.Drawing.Point(139, 64);
			this.ipAddress.Name = "ipAddress";
			this.ipAddress.Size = new System.Drawing.Size(124, 20);
			this.ipAddress.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "IP Address";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(58, 99);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 5;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
			// 
			// saveRuleBtn
			// 
			this.saveRuleBtn.Location = new System.Drawing.Point(139, 99);
			this.saveRuleBtn.Name = "saveRuleBtn";
			this.saveRuleBtn.Size = new System.Drawing.Size(75, 23);
			this.saveRuleBtn.TabIndex = 4;
			this.saveRuleBtn.Text = "Save";
			this.saveRuleBtn.UseVisualStyleBackColor = true;
			this.saveRuleBtn.Click += new System.EventHandler(this.SaveRuleBtnClick);
			// 
			// NewRestrictionRuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 133);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.saveRuleBtn);
			this.Controls.Add(this.ruleName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ruleGroup);
			this.Controls.Add(this.ipAddress);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewRestrictionRuleForm";
			this.Text = "New Restriction Rule";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button saveRuleBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ipAddress;
		private System.Windows.Forms.ComboBox ruleGroup;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ruleName;
	}
}
