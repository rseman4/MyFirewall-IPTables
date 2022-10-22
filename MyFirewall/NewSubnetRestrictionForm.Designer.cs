/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/21/2022
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyFirewall
{
	partial class NewSubnetRestrictionForm
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
			this.cancelBtn = new System.Windows.Forms.Button();
			this.saveRuleBtn = new System.Windows.Forms.Button();
			this.ruleName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ruleGroup = new System.Windows.Forms.ComboBox();
			this.sourceAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.destAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(60, 134);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 20;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			// 
			// saveRuleBtn
			// 
			this.saveRuleBtn.Location = new System.Drawing.Point(141, 134);
			this.saveRuleBtn.Name = "saveRuleBtn";
			this.saveRuleBtn.Size = new System.Drawing.Size(75, 23);
			this.saveRuleBtn.TabIndex = 19;
			this.saveRuleBtn.Text = "Save";
			this.saveRuleBtn.UseVisualStyleBackColor = true;
			this.saveRuleBtn.Click += new System.EventHandler(this.SaveRuleBtnClick);
			// 
			// ruleName
			// 
			this.ruleName.Location = new System.Drawing.Point(141, 38);
			this.ruleName.Name = "ruleName";
			this.ruleName.Size = new System.Drawing.Size(124, 20);
			this.ruleName.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(26, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "Rule Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(26, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "Rule Group";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ruleGroup
			// 
			this.ruleGroup.FormattingEnabled = true;
			this.ruleGroup.Location = new System.Drawing.Point(141, 11);
			this.ruleGroup.Name = "ruleGroup";
			this.ruleGroup.Size = new System.Drawing.Size(124, 21);
			this.ruleGroup.TabIndex = 15;
			// 
			// sourceAddress
			// 
			this.sourceAddress.Location = new System.Drawing.Point(141, 64);
			this.sourceAddress.Name = "sourceAddress";
			this.sourceAddress.Size = new System.Drawing.Size(124, 20);
			this.sourceAddress.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 20;
			this.label1.Text = "Source Subnet";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// destAddress
			// 
			this.destAddress.Location = new System.Drawing.Point(141, 90);
			this.destAddress.Name = "destAddress";
			this.destAddress.Size = new System.Drawing.Size(124, 20);
			this.destAddress.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(26, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Destination Subnet";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NewSubnetRestrictionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 173);
			this.Controls.Add(this.destAddress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.saveRuleBtn);
			this.Controls.Add(this.ruleName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ruleGroup);
			this.Controls.Add(this.sourceAddress);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewSubnetRestrictionForm";
			this.Text = "New Subnet Restriction Rule";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox destAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sourceAddress;
		private System.Windows.Forms.ComboBox ruleGroup;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ruleName;
		private System.Windows.Forms.Button saveRuleBtn;
		private System.Windows.Forms.Button cancelBtn;
	}
}
