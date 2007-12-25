﻿namespace FFTPatcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.abilitiesPage = new System.Windows.Forms.TabPage();
            this.jobsPage = new System.Windows.Forms.TabPage();
            this.skillSetsPage = new System.Windows.Forms.TabPage();
            this.monsterSkillsTab = new System.Windows.Forms.TabPage();
            this.actionMenusTabPage = new System.Windows.Forms.TabPage();
            this.codesTab = new System.Windows.Forms.TabPage();
            this.statusEffectsTab = new System.Windows.Forms.TabPage();
            this.allAbilitiesEditor1 = new FFTPatcher.Editors.AllAbilitiesEditor();
            this.allJobsEditor1 = new FFTPatcher.Editors.AllJobsEditor();
            this.allSkillSetsEditor1 = new FFTPatcher.Editors.AllSkillSetsEditor();
            this.allMonsterSkillsEditor1 = new FFTPatcher.Editors.AllMonsterSkillsEditor();
            this.allActionMenusEditor1 = new FFTPatcher.Editors.AllActionMenusEditor();
            this.codeCreator1 = new FFTPatcher.Editors.CodeCreator();
            this.allStatusAttributesEditor1 = new FFTPatcher.Editors.AllStatusAttributesEditor();
            this.tabControl.SuspendLayout();
            this.abilitiesPage.SuspendLayout();
            this.jobsPage.SuspendLayout();
            this.skillSetsPage.SuspendLayout();
            this.monsterSkillsTab.SuspendLayout();
            this.actionMenusTabPage.SuspendLayout();
            this.codesTab.SuspendLayout();
            this.statusEffectsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add( this.abilitiesPage );
            this.tabControl.Controls.Add( this.jobsPage );
            this.tabControl.Controls.Add( this.skillSetsPage );
            this.tabControl.Controls.Add( this.monsterSkillsTab );
            this.tabControl.Controls.Add( this.actionMenusTabPage );
            this.tabControl.Controls.Add( this.statusEffectsTab );
            this.tabControl.Controls.Add( this.codesTab );
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point( 0, 0 );
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size( 691, 712 );
            this.tabControl.TabIndex = 1;
            // 
            // abilitiesPage
            // 
            this.abilitiesPage.Controls.Add( this.allAbilitiesEditor1 );
            this.abilitiesPage.Location = new System.Drawing.Point( 4, 22 );
            this.abilitiesPage.Name = "abilitiesPage";
            this.abilitiesPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.abilitiesPage.Size = new System.Drawing.Size( 683, 686 );
            this.abilitiesPage.TabIndex = 0;
            this.abilitiesPage.Text = "Abilities";
            this.abilitiesPage.UseVisualStyleBackColor = true;
            // 
            // jobsPage
            // 
            this.jobsPage.Controls.Add( this.allJobsEditor1 );
            this.jobsPage.Location = new System.Drawing.Point( 4, 22 );
            this.jobsPage.Name = "jobsPage";
            this.jobsPage.Padding = new System.Windows.Forms.Padding( 3 );
            this.jobsPage.Size = new System.Drawing.Size( 683, 686 );
            this.jobsPage.TabIndex = 1;
            this.jobsPage.Text = "Jobs";
            this.jobsPage.UseVisualStyleBackColor = true;
            // 
            // skillSetsPage
            // 
            this.skillSetsPage.Controls.Add( this.allSkillSetsEditor1 );
            this.skillSetsPage.Location = new System.Drawing.Point( 4, 22 );
            this.skillSetsPage.Name = "skillSetsPage";
            this.skillSetsPage.Size = new System.Drawing.Size( 683, 686 );
            this.skillSetsPage.TabIndex = 2;
            this.skillSetsPage.Text = "Skill Sets";
            this.skillSetsPage.UseVisualStyleBackColor = true;
            // 
            // monsterSkillsTab
            // 
            this.monsterSkillsTab.Controls.Add( this.allMonsterSkillsEditor1 );
            this.monsterSkillsTab.Location = new System.Drawing.Point( 4, 22 );
            this.monsterSkillsTab.Name = "monsterSkillsTab";
            this.monsterSkillsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.monsterSkillsTab.Size = new System.Drawing.Size( 683, 686 );
            this.monsterSkillsTab.TabIndex = 4;
            this.monsterSkillsTab.Text = "Monster Skills";
            this.monsterSkillsTab.UseVisualStyleBackColor = true;
            // 
            // actionMenusTabPage
            // 
            this.actionMenusTabPage.Controls.Add( this.allActionMenusEditor1 );
            this.actionMenusTabPage.Location = new System.Drawing.Point( 4, 22 );
            this.actionMenusTabPage.Name = "actionMenusTabPage";
            this.actionMenusTabPage.Size = new System.Drawing.Size( 683, 686 );
            this.actionMenusTabPage.TabIndex = 5;
            this.actionMenusTabPage.Text = "Action Menus";
            this.actionMenusTabPage.UseVisualStyleBackColor = true;
            // 
            // codesTab
            // 
            this.codesTab.Controls.Add( this.codeCreator1 );
            this.codesTab.Location = new System.Drawing.Point( 4, 22 );
            this.codesTab.Name = "codesTab";
            this.codesTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.codesTab.Size = new System.Drawing.Size( 683, 686 );
            this.codesTab.TabIndex = 3;
            this.codesTab.Text = "CWCheat";
            this.codesTab.UseVisualStyleBackColor = true;
            // 
            // statusEffectsTab
            // 
            this.statusEffectsTab.Controls.Add( this.allStatusAttributesEditor1 );
            this.statusEffectsTab.Location = new System.Drawing.Point( 4, 22 );
            this.statusEffectsTab.Name = "statusEffectsTab";
            this.statusEffectsTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.statusEffectsTab.Size = new System.Drawing.Size( 683, 686 );
            this.statusEffectsTab.TabIndex = 6;
            this.statusEffectsTab.Text = "Status Effects";
            this.statusEffectsTab.UseVisualStyleBackColor = true;
            // 
            // allAbilitiesEditor1
            // 
            this.allAbilitiesEditor1.AutoSize = true;
            this.allAbilitiesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allAbilitiesEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allAbilitiesEditor1.Name = "allAbilitiesEditor1";
            this.allAbilitiesEditor1.Size = new System.Drawing.Size( 677, 680 );
            this.allAbilitiesEditor1.TabIndex = 0;
            // 
            // allJobsEditor1
            // 
            this.allJobsEditor1.AutoScroll = true;
            this.allJobsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allJobsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allJobsEditor1.Name = "allJobsEditor1";
            this.allJobsEditor1.Size = new System.Drawing.Size( 677, 680 );
            this.allJobsEditor1.TabIndex = 0;
            // 
            // allSkillSetsEditor1
            // 
            this.allSkillSetsEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allSkillSetsEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allSkillSetsEditor1.Name = "allSkillSetsEditor1";
            this.allSkillSetsEditor1.Size = new System.Drawing.Size( 683, 686 );
            this.allSkillSetsEditor1.TabIndex = 0;
            // 
            // allMonsterSkillsEditor1
            // 
            this.allMonsterSkillsEditor1.AutoSize = true;
            this.allMonsterSkillsEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allMonsterSkillsEditor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.allMonsterSkillsEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allMonsterSkillsEditor1.Name = "allMonsterSkillsEditor1";
            this.allMonsterSkillsEditor1.Size = new System.Drawing.Size( 633, 680 );
            this.allMonsterSkillsEditor1.TabIndex = 0;
            // 
            // allActionMenusEditor1
            // 
            this.allActionMenusEditor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.allActionMenusEditor1.Location = new System.Drawing.Point( 0, 0 );
            this.allActionMenusEditor1.Name = "allActionMenusEditor1";
            this.allActionMenusEditor1.Size = new System.Drawing.Size( 617, 686 );
            this.allActionMenusEditor1.TabIndex = 0;
            // 
            // codeCreator1
            // 
            this.codeCreator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeCreator1.Location = new System.Drawing.Point( 3, 3 );
            this.codeCreator1.Name = "codeCreator1";
            this.codeCreator1.Size = new System.Drawing.Size( 677, 680 );
            this.codeCreator1.TabIndex = 0;
            // 
            // allStatusAttributesEditor1
            // 
            this.allStatusAttributesEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allStatusAttributesEditor1.Location = new System.Drawing.Point( 3, 3 );
            this.allStatusAttributesEditor1.Name = "allStatusAttributesEditor1";
            this.allStatusAttributesEditor1.Size = new System.Drawing.Size( 677, 680 );
            this.allStatusAttributesEditor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size( 691, 712 );
            this.Controls.Add( this.tabControl );
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout( false );
            this.abilitiesPage.ResumeLayout( false );
            this.abilitiesPage.PerformLayout();
            this.jobsPage.ResumeLayout( false );
            this.skillSetsPage.ResumeLayout( false );
            this.monsterSkillsTab.ResumeLayout( false );
            this.monsterSkillsTab.PerformLayout();
            this.actionMenusTabPage.ResumeLayout( false );
            this.codesTab.ResumeLayout( false );
            this.statusEffectsTab.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private FFTPatcher.Editors.AllAbilitiesEditor allAbilitiesEditor1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage abilitiesPage;
        private System.Windows.Forms.TabPage jobsPage;
        private FFTPatcher.Editors.AllJobsEditor allJobsEditor1;
        private System.Windows.Forms.TabPage skillSetsPage;
        private FFTPatcher.Editors.AllSkillSetsEditor allSkillSetsEditor1;
        private System.Windows.Forms.TabPage codesTab;
        private FFTPatcher.Editors.CodeCreator codeCreator1;
        private System.Windows.Forms.TabPage monsterSkillsTab;
        private FFTPatcher.Editors.AllMonsterSkillsEditor allMonsterSkillsEditor1;
        private System.Windows.Forms.TabPage actionMenusTabPage;
        private FFTPatcher.Editors.AllActionMenusEditor allActionMenusEditor1;
        private System.Windows.Forms.TabPage statusEffectsTab;
        private FFTPatcher.Editors.AllStatusAttributesEditor allStatusAttributesEditor1;
    }
}

