/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 8/5/2022
 * Time: 2:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MyFirewall
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.newRuleBtn = new System.Windows.Forms.ToolStripButton();
			this.RemoveSelectedRowsBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ApplyRulesBtn = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.connectionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ruleSwitch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ruleGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ruleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.protocol = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.targetIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sourcePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.targetPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.masqueradeBox = new System.Windows.Forms.CheckBox();
			this.masqInterface = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton2,
									this.toolStripSeparator1,
									this.newRuleBtn,
									this.RemoveSelectedRowsBtn,
									this.toolStripSeparator2,
									this.ApplyRulesBtn});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(761, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "ConnectToBtn";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "disconnectBtn";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// newRuleBtn
			// 
			this.newRuleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newRuleBtn.Image = ((System.Drawing.Image)(resources.GetObject("newRuleBtn.Image")));
			this.newRuleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newRuleBtn.Name = "newRuleBtn";
			this.newRuleBtn.Size = new System.Drawing.Size(23, 22);
			this.newRuleBtn.Text = "New Rule";
			this.newRuleBtn.Click += new System.EventHandler(this.NewRuleBtnClick);
			// 
			// RemoveSelectedRowsBtn
			// 
			this.RemoveSelectedRowsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RemoveSelectedRowsBtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveSelectedRowsBtn.Image")));
			this.RemoveSelectedRowsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RemoveSelectedRowsBtn.Name = "RemoveSelectedRowsBtn";
			this.RemoveSelectedRowsBtn.Size = new System.Drawing.Size(23, 22);
			this.RemoveSelectedRowsBtn.Text = "Remove Rule";
			this.RemoveSelectedRowsBtn.Click += new System.EventHandler(this.RemoveSelectedRowsBtnClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ApplyRulesBtn
			// 
			this.ApplyRulesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ApplyRulesBtn.Image = ((System.Drawing.Image)(resources.GetObject("ApplyRulesBtn.Image")));
			this.ApplyRulesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ApplyRulesBtn.Name = "ApplyRulesBtn";
			this.ApplyRulesBtn.Size = new System.Drawing.Size(23, 22);
			this.ApplyRulesBtn.Text = "Apply Rules";
			this.ApplyRulesBtn.Click += new System.EventHandler(this.ApplyRulesBtnClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.connectionLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 405);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(761, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// connectionLabel
			// 
			this.connectionLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.connectionLabel.Name = "connectionLabel";
			this.connectionLabel.Size = new System.Drawing.Size(79, 17);
			this.connectionLabel.Text = "Disconnected";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ruleSwitch,
									this.ruleGroup,
									this.ruleName,
									this.protocol,
									this.targetIP,
									this.sourcePort,
									this.targetPort});
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(747, 342);
			this.dataGridView1.TabIndex = 0;
			// 
			// ruleSwitch
			// 
			this.ruleSwitch.HeaderText = "Enabled";
			this.ruleSwitch.Name = "ruleSwitch";
			this.ruleSwitch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ruleSwitch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// ruleGroup
			// 
			this.ruleGroup.HeaderText = "Group";
			this.ruleGroup.Name = "ruleGroup";
			// 
			// ruleName
			// 
			this.ruleName.HeaderText = "Rule Name";
			this.ruleName.Name = "ruleName";
			// 
			// protocol
			// 
			this.protocol.HeaderText = "Protocol";
			this.protocol.Items.AddRange(new object[] {
									"TCP",
									"UDP",
									"GRE"});
			this.protocol.Name = "protocol";
			this.protocol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.protocol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// targetIP
			// 
			this.targetIP.HeaderText = "Target IP";
			this.targetIP.Name = "targetIP";
			// 
			// sourcePort
			// 
			this.sourcePort.HeaderText = "Source Port";
			this.sourcePort.Name = "sourcePort";
			// 
			// targetPort
			// 
			this.targetPort.HeaderText = "Target Port";
			this.targetPort.Name = "targetPort";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(0, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(761, 374);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(753, 348);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Port Forwarding";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(753, 348);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "IP Restrictions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column4,
									this.Column1,
									this.Column2,
									this.Column3});
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(747, 342);
			this.dataGridView2.TabIndex = 0;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Enabled";
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Group";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Rule Name";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Address";
			this.Column3.Name = "Column3";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.dataGridView3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(753, 348);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Subnet Restrictions";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column5,
									this.Column6,
									this.Column7,
									this.Column8,
									this.Column9});
			this.dataGridView3.Location = new System.Drawing.Point(3, 3);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(747, 342);
			this.dataGridView3.TabIndex = 0;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Enabled";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Group";
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Rule Name";
			this.Column7.Name = "Column7";
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Source Subnet";
			this.Column8.Name = "Column8";
			this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Dest. Subnet";
			this.Column9.Name = "Column9";
			this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.masqueradeBox);
			this.tabPage4.Controls.Add(this.masqInterface);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(753, 348);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Masquerade";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// masqueradeBox
			// 
			this.masqueradeBox.Location = new System.Drawing.Point(275, 19);
			this.masqueradeBox.Name = "masqueradeBox";
			this.masqueradeBox.Size = new System.Drawing.Size(104, 24);
			this.masqueradeBox.TabIndex = 5;
			this.masqueradeBox.Text = "Enabled";
			this.masqueradeBox.UseVisualStyleBackColor = true;
			// 
			// masqInterface
			// 
			this.masqInterface.Location = new System.Drawing.Point(140, 21);
			this.masqInterface.Name = "masqInterface";
			this.masqInterface.Size = new System.Drawing.Size(118, 20);
			this.masqInterface.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Masquarade interface:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 427);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "MyFirewall";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.CheckBox masqueradeBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox masqInterface;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ToolStripStatusLabel connectionLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripButton ApplyRulesBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.DataGridViewComboBoxColumn protocol;
		private System.Windows.Forms.DataGridViewTextBoxColumn ruleGroup;
		private System.Windows.Forms.DataGridViewCheckBoxColumn ruleSwitch;
		private System.Windows.Forms.ToolStripButton RemoveSelectedRowsBtn;
		private System.Windows.Forms.ToolStripButton newRuleBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.DataGridViewTextBoxColumn targetPort;
		private System.Windows.Forms.DataGridViewTextBoxColumn sourcePort;
		private System.Windows.Forms.DataGridViewTextBoxColumn targetIP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ruleName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	
	}
}
