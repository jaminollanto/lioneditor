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

namespace FFTPatcher.TextEditor.Files.PSX
{
    public class SNPLMESBIN : BasePSXPartitionedFile
    {
        private const int numberOfSections = 6;
        private const int sectionLength = 0xA000;
        private static string[] sectionNames;
        private static string[][] entryNames;

        private static Dictionary<string, long> locations;
        public override IDictionary<string, long> Locations
        {
            get
            {
                if( locations == null )
                {
                    locations = new Dictionary<string, long>();
                    locations.Add( "WORLD/SNPLMES.BIN", 0x00 );
                }

                return locations;
            }
        }

        public override int NumberOfSections { get { return numberOfSections; } }
        public override int SectionLength { get { return sectionLength; } }
        public override IList<string> SectionNames { get { return sectionNames; } }
        public override IList<IList<string>> EntryNames { get { return entryNames; } }

        static SNPLMESBIN()
        {
            sectionNames = new string[numberOfSections];
            entryNames = new string[numberOfSections][];
            entryNames[0] = new string[204];
            entryNames[1] = new string[168];
            entryNames[2] = new string[186];
            entryNames[3] = new string[217];
            entryNames[4] = new string[39];
            entryNames[5] = new string[14];
        }

        public SNPLMESBIN( IList<byte> bytes )
            : base( bytes )
        {
        }
    }
}