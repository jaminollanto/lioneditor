﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    LionEditor is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LionEditor is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LionEditor.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class FFTPatchEditor : UserControl
    {
        public static ToolTip ToolTip { get; private set; }

        static FFTPatchEditor()
        {
            ToolTip = new ToolTip();
        }

        public FFTPatchEditor()
        {
            InitializeComponent();
            FFTPatch.DataChanged += FFTPatch_DataChanged;
            this.Enabled = false;

            allAbilitiesEditor1.InflictStatusClicked += InflictStatusClicked;
            allItemsEditor1.InflictStatusClicked += InflictStatusClicked;
            allItemsEditor1.ItemAttributesClicked += ItemAttributesClicked;
            allJobsEditor1.SkillSetClicked += SkillSetClicked;
        }

        private void SkillSetClicked( object sender, LabelClickedEventArgs e )
        {
            if( e.Value >= 0xE0 )
            {
                allSkillSetsEditor1.SelectedIndex = e.Value - 0xE0 + 0xB0;
                tabControl.SelectedTab = skillSetsPage;
            }
            else if( e.Value >= 0xB0 )
            {
                allMonsterSkillsEditor1.SelectedIndex = e.Value - 0xB0;
                tabControl.SelectedTab = monsterSkillsTab;
            }
            else
            {
                allSkillSetsEditor1.SelectedIndex = e.Value;
                tabControl.SelectedTab = skillSetsPage;
            }
        }

        private void ItemAttributesClicked( object sender, LabelClickedEventArgs e )
        {
            allItemAttributesEditor1.SelectedIndex = e.Value;
            tabControl.SelectedTab = itemAttributesTabPage;
        }

        private void InflictStatusClicked( object sender, LabelClickedEventArgs e )
        {
            allInflictStatusesEditor1.SelectedIndex = e.Value;
            tabControl.SelectedTab = inflictStatusesTabPage;
        }

        private void FFTPatch_DataChanged( object sender, System.EventArgs e )
        {
            this.Enabled = true;
            allAbilitiesEditor1.UpdateView( FFTPatch.Abilities );
            allActionMenusEditor1.UpdateView( FFTPatch.ActionMenus );
            allInflictStatusesEditor1.UpdateView( FFTPatch.InflictStatuses );
            allItemAttributesEditor1.UpdateView( FFTPatch.ItemAttributes );
            allItemsEditor1.UpdateView( FFTPatch.Items );
            allJobsEditor1.UpdateView( FFTPatch.Jobs );
            allMonsterSkillsEditor1.UpdateView( FFTPatch.MonsterSkills );
            allPoachProbabilitiesEditor1.UpdateView( FFTPatch.PoachProbabilities );
            allSkillSetsEditor1.UpdateView( FFTPatch.SkillSets );
            allStatusAttributesEditor1.UpdateView( FFTPatch.StatusAttributes );
            jobLevelsEditor1.UpdateView( FFTPatch.JobLevels );
            entdEditor1.UpdateView( FFTPatch.ENTDs );
            codeCreator1.UpdateView();
            codesTab.Text = FFTPatch.Context == Context.US_PSP ? "CWCheat" : "Gameshark";
        }
    }
}
