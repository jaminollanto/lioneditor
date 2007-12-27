﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FFTPatcher.Datatypes
{
    public class Weapon : Item
    {
        public byte Range { get; set; }

        public bool Striking;
        public bool Lunging;
        public bool Direct;
        public bool Arc;
        public bool TwoSwords;
        public bool TwoHands;
        public bool Blank;
        public bool Force2Hands;

        public byte Formula { get; set; }
        public byte Unknown { get; set; }
        public byte WeaponPower { get; set; }
        public byte EvadePercentage { get; set; }
        public Elements Elements { get; private set; }
        public byte SpellStatus { get; set; }

        public Weapon( UInt16 offset, SubArray<byte> itemBytes, SubArray<byte> weaponBytes )
            : base( offset, itemBytes )
        {
            Range = weaponBytes[0];
            Utilities.CopyByteToBooleans( weaponBytes[1], ref Striking, ref Lunging, ref Direct, ref Arc, ref TwoSwords, ref TwoHands, ref Blank, ref Force2Hands );
            Formula = weaponBytes[2];
            Unknown = weaponBytes[3];
            WeaponPower = weaponBytes[4];
            EvadePercentage = weaponBytes[5];
            Elements = new Elements( weaponBytes[6] );
            SpellStatus = weaponBytes[7];
        }

        public byte[] ToItemByteArray()
        {
            return base.ToByteArray().ToArray();
        }

        public byte[] ToWeaponByteArray()
        {
            byte[] result = new byte[8];
            result[0] = Range;
            result[1] = Utilities.ByteFromBooleans( Striking, Lunging, Direct, Arc, TwoSwords, TwoHands, Blank, Force2Hands );
            result[2] = Formula;
            result[3] = Unknown;
            result[4] = WeaponPower;
            result[5] = EvadePercentage;
            result[6] = Elements.ToByte();
            result[7] = SpellStatus;
            return result;
        }

        public override byte[] ToFirstByteArray()
        {
            return ToItemByteArray();
        }

        public override byte[] ToSecondByteArray()
        {
            return ToWeaponByteArray();
        }
    }
}