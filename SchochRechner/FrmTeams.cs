using SchochRechner.Logic;
using SchochRechner.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchochRechner
{
    public partial class FrmTeams : Form
    {
        private readonly SchochManager schochManager;
        private readonly ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private bool refreshingGroups;

        public FrmTeams()
        {
            this.InitializeComponent();
            this.schochManager = new SchochManager();

            this.LvwTeams.ListViewItemSorter = lvwColumnSorter;
        }

        public FrmTeams(SchochManager schochManager) : this()
        {
            this.schochManager = schochManager;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var frmTeam = new FrmTeam(this.schochManager.Groups, selectedGroupName: this.schochManager.SelectedGroupName);
            if (frmTeam.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.schochManager.AddTeam(frmTeam.Id, frmTeam.TeamName, frmTeam.GroupName);
                    this.LoadTeams();
                    this.schochManager.CalculateRanking();
                    this.schochManager.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.LvwTeams.SelectedItems.Count == 0) { return; }

            var team = (Team)this.LvwTeams.SelectedItems[0].Tag;
            var frmTeam = new FrmTeam(this.schochManager.Groups, team);
            if (this.schochManager.HasEntries(team))
            {
                frmTeam.SetGroupSelectionEnabled(false);
            }

            if (frmTeam.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.schochManager.UpdateTeam(team, frmTeam.Id, frmTeam.TeamName, frmTeam.GroupName);
                    this.LoadTeams();
                    this.schochManager.CalculateRanking();
                    this.schochManager.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.LvwTeams.SelectedItems.Count == 0) { return; }

            var team = (Team)this.LvwTeams.SelectedItems[0].Tag;
            this.schochManager.DeleteTeam(team);
            this.LoadTeams();
            this.schochManager.CalculateRanking();
            this.schochManager.Save();
        }

        private void FrmTeams_Load(object sender, EventArgs e)
        {
            this.RefreshGroups();
            this.LoadTeams();
        }

        private void RefreshGroups()
        {
            this.refreshingGroups = true;
            this.CbxGroup.Items.Clear();
            this.CbxGroup.Items.AddRange(this.schochManager.Groups.Cast<object>().ToArray());
            this.CbxGroup.SelectedItem = this.schochManager.SelectedGroupName;
            this.BtnDeleteGroup.Enabled = this.schochManager.Groups.Count > 1;
            this.refreshingGroups = false;
        }

        private void CbxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.refreshingGroups || this.CbxGroup.SelectedItem is not string groupName)
            {
                return;
            }

            this.schochManager.SelectGroup(groupName);
            this.LoadTeams();
        }

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            var groupName = this.PromptForGroupName("Neue Gruppe", string.Empty);
            if (groupName == null)
            {
                return;
            }

            try
            {
                this.schochManager.AddGroup(groupName);
                this.schochManager.SelectGroup(groupName);
                this.RefreshGroups();
                this.LoadTeams();
                this.schochManager.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRenameGroup_Click(object sender, EventArgs e)
        {
            var oldName = this.schochManager.SelectedGroupName;
            var newName = this.PromptForGroupName("Gruppe umbenennen", oldName);
            if (newName == null)
            {
                return;
            }

            try
            {
                this.schochManager.RenameGroup(oldName, newName);
                this.RefreshGroups();
                this.LoadTeams();
                this.schochManager.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteGroup_Click(object sender, EventArgs e)
        {
            var groupName = this.schochManager.SelectedGroupName;
            var teamCount = this.schochManager.GetTeams(groupName).Count;
            var entryCount = this.schochManager.GetEntries(groupName).Count;
            var message = $"Gruppe \"{groupName}\" und alle zugehörigen Daten löschen?\r\n\r\nTeams: {teamCount}\r\nResultate: {entryCount}\r\n\r\nDieser Vorgang kann nicht rückgängig gemacht werden.";
            if (MessageBox.Show(this, message, "Gruppe löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                this.schochManager.DeleteGroup(groupName);
                this.RefreshGroups();
                this.LoadTeams();
                this.schochManager.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? PromptForGroupName(string title, string initialName)
        {
            using var dialog = new Form { Text = title, FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent, ClientSize = new Size(300, 100), MinimizeBox = false, MaximizeBox = false };
            var nameInput = new TextBox { Location = new Point(12, 12), Width = 276, Text = initialName };
            var okButton = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(132, 58), Width = 75 };
            var cancelButton = new Button { Text = "Abbrechen", DialogResult = DialogResult.Cancel, Location = new Point(213, 58), Width = 75 };
            dialog.Controls.Add(nameInput);
            dialog.Controls.Add(okButton);
            dialog.Controls.Add(cancelButton);
            dialog.AcceptButton = okButton;
            dialog.CancelButton = cancelButton;
            return dialog.ShowDialog(this) == DialogResult.OK ? nameInput.Text : null;
        }

        private void LoadTeams()
        {
            this.LvwTeams.Items.Clear();

            foreach (var team in this.schochManager.CurrentTeams)
            {
                var item = new ListViewItem(team.Id.ToString());
                item.Tag = team;
                item.SubItems.Add(team.Name);
                this.LvwTeams.Items.Add(item);
            }

            this.groupBox1.Text = this.schochManager.SelectedGroupName + " – Teams (" + this.LvwTeams.Items.Count + ")";
        }

        private void LvwTeams_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }

        private void LvwTeams_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void LvwTeams_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.LvwTeams.Sort();
            this.LvwTeams.Refresh();
        }
    }
}
