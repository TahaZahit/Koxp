using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koxp
{
    public static class Addresses
    {

        //Pointers
        
        public static readonly IntPtr PTR_CHR = new IntPtr(0x93c98c);
        public static readonly IntPtr PTR_DLG = new IntPtr(0x93CC28);
        public static readonly IntPtr PTR_PKT = new IntPtr(0x93CBF4);
        public static readonly IntPtr SND_FNC = new IntPtr(0x45CAD0);
        public static readonly IntPtr FNCZ = new IntPtr(0x6660A0);

        public static readonly int OFF_NAME = 0x47C;
        public static readonly int OFF_CLASS = 0x494;
        public static readonly int OFF_ID = 0x473;
        public static readonly int OFF_HP = 0x4a0;
        public static readonly int OFF_MAXHP = 0x49c;
        public static readonly int OFF_MP = 0x80C;
        public static readonly int OFF_MAXMP = 0x808;
        public static readonly int OFF_WH = 0x4A4;
        public static readonly int OFF_MOB = 0x454;
        public static readonly int OFF_EXP = 0x81c;
        public static readonly int OFF_MAXEXP = 0x818;
        public static readonly int OFF_LVL = 0x5EC;
        public static readonly int OFF_SPEED = 0x510;
        public static readonly int PTR_ZONE = 0x7A9824;
        public static readonly int OFF_MONEY = 0x814;
        public static readonly int OFF_X = 0x98;
        public static readonly int OFF_Y = 0xA0;
        public static readonly int OFF_Z = 0x9C;

        public static readonly int OFF_PARTY_VALUE = 0x1a4;
        public static readonly int OFF_PARTY_OFFSET = 0x68;
        public static readonly int OFF_PARTY_HP = 0x14;//
        public static readonly int OFF_PARTY_MAXHP = 0x18;//
        public static readonly int OFF_PARTY_LEVEL = 0xC;//
        public static readonly int OFF_PARTY_CLASS = 0x10;//
        public static readonly int OFF_PARTY_NAME = 0x2c;
        public static readonly int OFF_PARTY_NUMBER = 0x1a8;
        public static readonly int OFF_PARTY_ID = 0x8;

        public static readonly int OFF_MOVTYPE = 0xb1c;
        public static readonly int OFF_GO_X = 0xB28;
        public static readonly int OFF_GO_Y = 0xB30;
        public static readonly int OFF_MVCHRTYP = 0x308;


        //otokutu
        public static readonly int PTR_VAR = 0x93cbf0;
        public static readonly int OFF_LOOT = 0x350;
        public static readonly int OFF_LOOT7 = 0x388;
        public static readonly int OFF_LOOT8 = 0x38C;
        public static readonly int OFF_LOOT4 = 0x398;
        public static readonly int OFF_LOOT5 = 0x39C;
        public static readonly int OFF_LOOT1 = 0x3A8;
        public static readonly int OFF_LOOT2 = 0x3AC;

    }
}
