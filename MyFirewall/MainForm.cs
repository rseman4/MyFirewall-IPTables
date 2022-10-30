/*
 * Created by SharpDevelop.
 * User: rseman
 * Date: 8/5/2022
 * Time: 2:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyFirewall
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public String newFileContent = "";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// good stuff here: https://www.c-sharpcorner.com/UploadFile/deveshomar/adding-checkbox-column-in-datagridview-in-C-Sharp-window-forms/
			
			//dataGridView1.Rows.Add(true, "Web", "HTTP","TCP","10.10.10.100","80","80");
			FillPortForwardingTable();
			FillIpRestrictionTable();
			FillSubnetRestrictionTable();
			FillMasquarade();
		}
		
		void NewRuleBtnClick(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
		    {
		        Form NewForwardRuleForm = new NewForwardRuleForm(this.dataGridView1);
				NewForwardRuleForm.ShowDialog();
		    }
			else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
		    {
		        Form NewRestrictionRuleForm = new NewRestrictionRuleForm(this.dataGridView2);
				NewRestrictionRuleForm.ShowDialog();
		    }
			else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
		    {
		        Form NewRestrictionRuleForm = new NewSubnetRestrictionForm(this.dataGridView3);
				NewRestrictionRuleForm.ShowDialog();
		    }
		}
		
		void RemoveSelectedRowsBtnClick(object sender, System.EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count == 0 && dataGridView2.SelectedRows.Count == 0 && dataGridView3.SelectedRows.Count == 0) return;
			
			String messageText = "";
			if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
				messageText = "Do you wish to remove "+ dataGridView1.SelectedRows.Count.ToString() +" rule(s)?";
			else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
				messageText = "Do you wish to remove "+ dataGridView2.SelectedRows.Count.ToString() +" rule(s)?";
			else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
				messageText = "Do you wish to remove "+ dataGridView3.SelectedRows.Count.ToString() +" rule(s)?";
						
			DialogResult dialogResult = MessageBox.Show(messageText, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dialogResult == DialogResult.Yes)
			{
				if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
					foreach (DataGridViewRow row  in dataGridView1.SelectedRows) dataGridView1.Rows.RemoveAt(row.Index);
				else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
					foreach (DataGridViewRow row  in dataGridView2.SelectedRows) dataGridView2.Rows.RemoveAt(row.Index);
				else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
					foreach (DataGridViewRow row  in dataGridView3.SelectedRows) dataGridView3.Rows.RemoveAt(row.Index);
			}
			else if (dialogResult == DialogResult.No)
			{
			    return;
			}
		}
		
		void ApplyRulesBtnClick(object sender, EventArgs e)
		{
			GenerateNewFile();
		}
		
		void FillPortForwardingTable()
		{
			bool startProcessingRules = false;
			bool foundGroup = false;
			
			String ruleGroupName = "";
			
			foreach (string line in File.ReadLines(@"config.txt"))
			{
				if(line.Equals("### STARTGROUP - PORT FORWARDING"))
				{
					startProcessingRules = true;
					continue;
				}
				else if(line.Equals("### ENDGROUP - PORT FORWARDING")) break;
					
				if(startProcessingRules)
				{
					if(line.Contains("## START -"))
					{
						foundGroup = true;
						String[] ruleGroupStringArr = line.Split(new[] { "## START -" }, StringSplitOptions.None);
						ruleGroupName = ruleGroupStringArr[1].Trim();
						continue;
					}
					else if(line.Contains("## END -"))
					{
						foundGroup = false;
						continue;
					}
					
					if(foundGroup)
					{
						String[] ruleRow = line.Split(' ');
						try
						{
							bool ruleEnabled = true;
							if(ruleRow[0].Equals("#"))
							{
								ruleEnabled = false;
								ruleRow = ruleRow.Skip(1).ToArray();
							}
							
							
							if(ruleRow[5].Equals("gre"))
							{
								dataGridView1.Rows.Add(ruleEnabled, ruleGroupName, ruleRow[11], ruleRow[5].ToUpper(), ruleRow[9], "none", "none");
							}
							else
							{
								String[] ipAndPort = ruleRow[13].Split(':');
								dataGridView1.Rows.Add(ruleEnabled, ruleGroupName, ruleRow[15], ruleRow[5].ToUpper(), ipAndPort[0], ruleRow[9], ipAndPort[1]);
							}
						}
						catch (Exception excpt)
						{
							MessageBox.Show(excpt.ToString() + "\n" + String.Join(" ", ruleRow));
							MessageBox.Show("Your file is probably messed up.");
						}
					}
				}
			}
		}
		
		void FillIpRestrictionTable()
		{
			bool startProcessingRules = false;
			bool foundGroup = false;
			
			String ruleGroupName = "";
			
			foreach (string line in File.ReadLines(@"config.txt"))
			{
				if(line.Equals("### STARTGROUP - IP Restriction"))
				{
					startProcessingRules = true;
					continue;
				}
				else if(line.Equals("### ENDGROUP - IP Restriction")) break;
					
				if(startProcessingRules)
				{
					if(line.Contains("## START -"))
					{
						foundGroup = true;
						String[] ruleGroupStringArr = line.Split(new[] { "## START -" }, StringSplitOptions.None);
						ruleGroupName = ruleGroupStringArr[1].Trim();
						continue;
					}
					else if(line.Contains("## END -"))
					{
						foundGroup = false;
						continue;
					}
					
					if(foundGroup)
					{
						String[] ruleRow = line.Split(' ');
						try
						{
							bool ruleEnabled = true;
							if(ruleRow[0].Equals("#"))
							{
								ruleEnabled = false;
								ruleRow = ruleRow.Skip(1).ToArray();
							}
							
							dataGridView2.Rows.Add(ruleEnabled, ruleGroupName, ruleRow[7], ruleRow[3]);
						}
						catch (Exception excpt)
						{
							MessageBox.Show(excpt.ToString() + "\n" + String.Join(" ", ruleRow));
							MessageBox.Show("Your file is probably messed up.");
						}
					}
				}
			}
		}
		
		void FillSubnetRestrictionTable()
		{
			bool startProcessingRules = false;
			bool foundGroup = false;
			
			String ruleGroupName = "";
			
			foreach (string line in File.ReadLines(@"config.txt"))
			{
				if(line.Equals("### STARTGROUP - Subnet Restriction"))
				{
					startProcessingRules = true;
					continue;
				}
				else if(line.Equals("### ENDGROUP - Subnet Restriction")) break;
					
				if(startProcessingRules)
				{
					if(line.Contains("## START -"))
					{
						foundGroup = true;
						String[] ruleGroupStringArr = line.Split(new[] { "## START -" }, StringSplitOptions.None);
						ruleGroupName = ruleGroupStringArr[1].Trim();
						continue;
					}
					else if(line.Contains("## END -"))
					{
						foundGroup = false;
						continue;
					}
					
					if(foundGroup)
					{
						String[] ruleRow = line.Split(' ');
						try
						{
							bool ruleEnabled = true;
							if(ruleRow[0].Equals("#"))
							{
								ruleEnabled = false;
								ruleRow = ruleRow.Skip(1).ToArray();
							}
							
							dataGridView3.Rows.Add(ruleEnabled, ruleGroupName, ruleRow[9], ruleRow[3], ruleRow[5]);
						}
						catch (Exception excpt)
						{
							MessageBox.Show(excpt.ToString() + "\n" + String.Join(" ", ruleRow));
							MessageBox.Show("Your file is probably messed up.");
						}
					}
				}
			}
		}
		
		void FillMasquarade()
		{
			bool startProcessingRules = false;

			foreach (string line in File.ReadLines(@"config.txt"))
			{
				if(line.Equals("### STARTGROUP - MASQUERADE"))
				{
					startProcessingRules = true;
					continue;
				}
				else if(line.Equals("### ENDGROUP - MASQUERADE")) break;
					
				if(startProcessingRules)
				{
					String[] ruleRow = line.Split(' ');
					try
					{
						if(!line.Equals(""))
						{
							bool ruleEnabled = true;
							if(ruleRow[0].Equals("#"))
							{
								ruleEnabled = false;
								ruleRow = ruleRow.Skip(1).ToArray();
							}
							
							//dataGridView2.Rows.Add(ruleEnabled, ruleGroupName, ruleRow[7], ruleRow[3]);
							masqueradeBox.Checked = ruleEnabled;
							masqInterface.Text = ruleRow[3];
						}
					}
					catch (Exception excpt)
					{
						MessageBox.Show(excpt.ToString() + "\n" + String.Join(" ", ruleRow));
						MessageBox.Show("Your file is probably messed up.");
					}
				}
			}
		}
		
		void GenerateNewFile()
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to generate new configuration file?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.No) return;
			
			if(masqueradeBox.Checked && masqInterface.Text.Equals(""))
			{
				MessageBox.Show("Masquerade was enabled but no interface was entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			newFileContent = "";
			
			bool dontAddLines = false;
			
			String portGroup = "";
			
			// -A PREROUTING -i eth0 -p tcp -m tcp --dport 80 -j DNAT --to-destination 10.10.10.100:80
			
			foreach (string line in File.ReadLines(@"config.txt"))
			{
				
				if(line.Equals("### STARTGROUP - PORT FORWARDING"))
				{
					dontAddLines = true;
					newFileContent += line + "\n";
					
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						//-A PREROUTING -i eth0 -p gre -j DNAT --to-destination 10.10.10.206 # 
						if(portGroup.Equals(""))
						{
							portGroup = row.Cells[1].Value.ToString();
							newFileContent += "## START - " + row.Cells[1].Value + "\n";
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							if(!row.Cells[3].Value.ToString().Equals("GRE"))
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -m "+ row.Cells[3].Value.ToString().ToLower() +" --dport "+ row.Cells[5].Value +" -j DNAT --to-destination "+ row.Cells[4].Value +":" + row.Cells[5].Value + " # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
							else
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -j DNAT --to-destination "+ row.Cells[4].Value +" # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
						}
						else if(portGroup.Equals(row.Cells[1].Value))
						{
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							if(!row.Cells[3].Value.ToString().Equals("GRE"))
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -m "+ row.Cells[3].Value.ToString().ToLower() +" --dport "+ row.Cells[5].Value +" -j DNAT --to-destination "+ row.Cells[4].Value +":" + row.Cells[5].Value + " # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
							else
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -j DNAT --to-destination "+ row.Cells[4].Value +" # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
						}
						else if(!portGroup.Equals(row.Cells[1].Value))
						{
							newFileContent += "## END - " + portGroup + "\n";
							portGroup = row.Cells[1].Value.ToString();
							newFileContent += "## START - " + portGroup + "\n";
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							if(!row.Cells[3].Value.ToString().Equals("GRE"))
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -m "+ row.Cells[3].Value.ToString().ToLower() +" --dport "+ row.Cells[5].Value +" -j DNAT --to-destination "+ row.Cells[4].Value +":" + row.Cells[5].Value + " # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
							else
								newFileContent += "-A PREROUTING -i eth0 -p "+ row.Cells[3].Value.ToString().ToLower() +" -j DNAT --to-destination "+ row.Cells[4].Value +" # "+ row.Cells[2].Value.ToString().Replace(' ', '_') + "\n";
						}
					}
					if(dataGridView1.Rows.Count > 0) newFileContent += "## END - " + portGroup + "\n";
					else newFileContent += "\n";
					portGroup = "";
				}
				else if(line.Equals("### ENDGROUP - PORT FORWARDING"))
				{
					dontAddLines = false;
				}
				
				if(line.Equals("### STARTGROUP - IP Restriction"))
				{
					dontAddLines = true;
					newFileContent += line + "\n";
					
					foreach (DataGridViewRow row in dataGridView2.Rows)
					{
						if(portGroup.Equals(""))
						{
							portGroup = row.Cells[1].Value.ToString();
							newFileContent += "## START - " + row.Cells[1].Value + "\n";
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "-A INPUT -s "+ row.Cells[3].Value +" -j DROP # "+ row.Cells[2].Value + "\n";
						}
						else if(portGroup.Equals(row.Cells[1].Value))
						{
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "-A INPUT -s "+ row.Cells[3].Value +" -j DROP # "+ row.Cells[2].Value + "\n";
						}
						else if(!portGroup.Equals(row.Cells[1].Value))
						{
							newFileContent += "## END - " + portGroup + "\n";
							portGroup = row.Cells[1].Value.ToString();
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "## START - " + portGroup + "\n";
							newFileContent += "-A INPUT -s "+ row.Cells[3].Value +" -j DROP # "+ row.Cells[2].Value + "\n";
						}
					}
					if(dataGridView2.Rows.Count > 0) newFileContent += "## END - " + portGroup + "\n";
					else newFileContent += "\n";
					portGroup = "";
				}
				else if(line.Equals("### ENDGROUP - IP Restriction"))
				{
					dontAddLines = false;
				}
				
				// Subnet Restriction
				
				if(line.Equals("### STARTGROUP - Subnet Restriction"))
				{
					dontAddLines = true;
					newFileContent += line + "\n";
					
					// -A FORWARD -s " + row.Cells[3].Value + " -d " + row.Cells[4].Value + " -j DROP # " + row.Cells[2].Value + ";
					foreach (DataGridViewRow row in dataGridView3.Rows)
					{
						if(portGroup.Equals(""))
						{
							portGroup = row.Cells[1].Value.ToString();
							newFileContent += "## START - " + row.Cells[1].Value + "\n";
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "-A FORWARD -s " + row.Cells[3].Value + " -d " + row.Cells[4].Value + " -j DROP # " + row.Cells[2].Value + "\n";
						}
						else if(portGroup.Equals(row.Cells[1].Value))
						{
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "-A FORWARD -s " + row.Cells[3].Value + " -d " + row.Cells[4].Value + " -j DROP # " + row.Cells[2].Value + "\n";
						}
						else if(!portGroup.Equals(row.Cells[1].Value))
						{
							newFileContent += "## END - " + portGroup + "\n";
							portGroup = row.Cells[1].Value.ToString();
							newFileContent += "## START - " + portGroup + "\n";
							if(row.Cells[0].Value.ToString().Equals("False")) newFileContent += "# ";
							newFileContent += "-A FORWARD -s " + row.Cells[3].Value + " -d " + row.Cells[4].Value + " -j DROP # " + row.Cells[2].Value + "\n";
						}
					}
					if(dataGridView3.Rows.Count > 0) newFileContent += "## END - " + portGroup + "\n";
					else newFileContent += "\n";
					portGroup = "";
				}
				else if(line.Equals("### ENDGROUP - Subnet Restriction"))
				{
					dontAddLines = false;
				}
				
				// Masquerade
				
				if(line.Equals("### STARTGROUP - MASQUERADE")) // NEED TO READ VALUES FIRST!!!
				{
					dontAddLines = true;
					newFileContent += line + "\n";
					
					if(!masqueradeBox.Checked)
						newFileContent += "# ";
							
					if(!masqueradeBox.Checked)
						newFileContent += "-A POSTROUTING -o "+ masqInterface.Text +" -j MASQUERADE \n";
					else
						newFileContent += "\n";
				}
				else if(line.Equals("### ENDGROUP - MASQUERADE"))
				{
					dontAddLines = false;
				}
					
				if(!dontAddLines)
				{
					newFileContent += line + "\n";
				}
			}
			
			try
			{
				File.WriteAllText(@"config.txt", newFileContent);
				Process.Start("notepad.exe", @"config.txt");
				
			}
			catch(Exception excpt)
			{
				MessageBox.Show(excpt.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
