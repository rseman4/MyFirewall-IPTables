/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 10/21/2022
 * Time: 3:00 PM
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
	/// Description of NewSubnetRestrictionForm.
	/// </summary>
	public partial class NewSubnetRestrictionForm : Form
	{
		public DataGridView DATAGRIDVIEW;
		public NewSubnetRestrictionForm(DataGridView myDG)
		{
			InitializeComponent();
			
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
			if(ruleGroup.Text.Trim().Equals(""))
			{
				MessageBox.Show("Rule Group cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DATAGRIDVIEW.Rows.Add(true, ruleGroup.Text, ruleName.Text.Replace(' ', '_'), sourceAddress.Text, destAddress.Text);
			this.Close();
		}
	}
}
