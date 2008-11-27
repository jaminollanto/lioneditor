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

using System.Collections.Generic;

using FFTPatcher.Datatypes;

namespace FFTPatcher.TextEditor.Files.PSP
{
    /// <summary>
    /// Represents a sectioned file in the PSP version.
    /// </summary>
    public abstract class BasePSPSectionedFile : AbstractStringSectioned
    {

        #region Properties (1)


        /// <summary>
        /// Gets the character map that is used for this file.
        /// </summary>
        /// <value></value>
        public override GenericCharMap CharMap { get { return TextUtilities.PSPMap; } }


        #endregion Properties

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePSPSectionedFile"/> class.
        /// </summary>
        protected BasePSPSectionedFile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePSPSectionedFile"/> class.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        protected BasePSPSectionedFile( IList<byte> bytes )
            : base( bytes )
        {
        }

        #endregion Constructors

        public override IList<PatchedByteArray> GetAllPatches()
        {
            var result = new List<PatchedByteArray>();
            byte[] bytes = ToByteArray();
            foreach( var kvp in Locations )
            {
                result.Add( new PatchedByteArray( (FFTPack.Files)kvp.Key, kvp.Value, bytes ) );
            }
            return result;
        }

    }
}