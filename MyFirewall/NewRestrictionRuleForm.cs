﻿/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/15/2022
 * Time: 11:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace MyFirewall
{
	/// <summary>
	/// Description of NewRestrictionRuleForm.
	/// </summary>
	public partial class NewRestrictionRuleForm : Form
	{
		public DataGridView DATAGRIDVIEW;
		
		public NewRestrictionRuleForm(DataGridView myDG)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			DATAGRIDVIEW = myDG;
			
			List<String> groups = new List<String>();
			groups.Add("None");
			foreach (DataGridViewRow row in DATAGRIDVIEW.Rows) groups.Add(row.Cells[1].Value.ToString());
			groups = groups.Distinct().ToList();
			ruleGroup.Items.Clear();
			ruleGroup.Items.AddRange(groups.ToArray());
		}
		
		void SaveRuleBtnClick(object sender, EventArgs e)
		{
			DATAGRIDVIEW.Rows.Add(true, ruleGroup.Text, ruleName.Text.Replace(' ', '_'), ipAddress.Text);
			this.Close();			
		}
		
		void CancelBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
