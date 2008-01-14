﻿/*
    Copyright 2007, Joe Davidson <joedavidson@gmail.com>

    This file is part of FFTPatcher.

    FFTPatcher is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FFTPatcher is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FFTPatcher.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows.Forms;
using FFTPatcher.Datatypes;

namespace FFTPatcher.Editors
{
    public partial class StatusesEditor : UserControl
    {
        private Statuses statuses;
        private bool ignoreChanges = false;

        public string Status { get { return statusGroupBox.Text; } set { statusGroupBox.Text = value; } }

        public Statuses Statuses
        {
            get { return statuses; }
            set
            {
                if( value == null )
                {
                    this.Enabled = false;
                    statuses = null;
                }
                else if( statuses != value )
                {
                    this.Enabled = true;
                    statuses = value;
                    UpdateView();
                }
            }
        }

        public StatusesEditor()
        {
            InitializeComponent();
            statusesCheckedListBox.ItemCheck += statusesCheckedListBox_ItemCheck;
        }

        private void statusesCheckedListBox_ItemCheck( object sender, ItemCheckEventArgs e )
        {
            if( !ignoreChanges )
            {
                Utilities.SetFlag( statuses, Statuses.FieldNames[e.Index], e.NewValue == CheckState.Checked );
            }
        }

        private void UpdateView()
        {
            this.SuspendLayout();
            statusesCheckedListBox.SuspendLayout();

            ignoreChanges = true;
            if( statuses.Default != null )
            {
                statusesCheckedListBox.SetValuesAndDefaults( Utilities.GetFieldsOrProperties<bool>( statuses, Statuses.FieldNames ), statuses.Default.ToBoolArray() );
            }

            ignoreChanges = false;
            statusesCheckedListBox.ResumeLayout();
            this.ResumeLayout();
        }
    }
}