﻿using SchochRechner.Logic;
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

        public FrmTeams()
        {
            this.InitializeComponent();
            this.schochManager = new SchochManager();
        }

        public FrmTeams(SchochManager schochManager) : this()
        {
            this.schochManager = schochManager;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            var frmTeam = new FrmTeam();
            if (frmTeam.ShowDialog() == DialogResult.OK)
            {
                this.schochManager.AddTeam(frmTeam.Id, frmTeam.TeamName);
                this.LoadTeams();
                this.schochManager.CalculateRanking();
                this.schochManager.Save();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.LvwTeams.SelectedItems.Count == 0) { return; }

            var team = (Team)this.LvwTeams.SelectedItems[0].Tag;
            var frmTeam = new FrmTeam(team);
            if (frmTeam.ShowDialog() == DialogResult.OK)
            {
                team.Id = frmTeam.Id;
                team.Name = frmTeam.TeamName;
                this.LoadTeams();
                this.schochManager.CalculateRanking();
                this.schochManager.Save();
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
            this.LoadTeams();
        }

        private void LvwTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadTeams()
        {
            this.LvwTeams.Items.Clear();

            foreach (var team in this.schochManager.Teams)
            {
                var item = new ListViewItem(team.Id.ToString());
                item.Tag = team;
                item.SubItems.Add(team.Name);
                this.LvwTeams.Items.Add(item);
            }
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
    }
}
