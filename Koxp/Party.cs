using System;
using System.Text;

namespace Koxp
{
    public class Party
    {
        private Client client;
        
        public Party(Client _client)
        {
            client = _client;
            for (int i = 0; i < 8; i++)
                Members[i] = new PartyMember(this,i);
        }

        public int MembersCount { get => PartyMembers(); }
        public PartyMember[] Members = new PartyMember[8];


        private int PartyBase(int Member)
        {
            int pBase = ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + Addresses.OFF_PARTY_OFFSET))) + Addresses.OFF_PARTY_VALUE)));
            switch (Member)
            {
                case 0: return ToInt32(ReadMemory(new IntPtr(pBase + 0x0)));
                case 1: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0)));
                case 2: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0)));
                case 3: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 4: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 5: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 6: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                case 7: return ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(pBase + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0))) + 0x0)));
                default: return 0;
            }

        }
        public string PartyID(int Member)=>AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_ID))))).Substring(0, 4).ToUpper();
        public int PartyHP(int Member)=>ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_HP)));
        public int PartyMaxHP(int Member) => ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_MAXHP)));
        public int PartyLevel(int Member) => ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_LEVEL)));
        public int PartyClass(int Member)=>ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_CLASS)));
        public int PartyMembers()=>ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + Addresses.OFF_PARTY_OFFSET))) + Addresses.OFF_PARTY_NUMBER)));
        public int PartyPosition(string Nick)
        {
            for (int i = 1; i <= PartyMembers(); i++)
                if (PartyName(i).ToUpper().Equals(Nick.ToUpper()))
                    return i;
            return -1;
        }
        public string PartyName(int Member)
        {
            byte[] pBytes = new byte[25];
            string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(PartyBase(Member) + Addresses.OFF_PARTY_NAME))) + 0x0), pBytes, 25L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }

        public void Invate(string name)
        {
            if (!name.Equals(""))
            {
                client.Send("2F03" + AlignDWORD(new IntPtr(name.Length)).Substring(0, 2) + "00" + Converter.ToHex(name));
                client.Send("2F01" + AlignDWORD(new IntPtr(name.Length)).Substring(0, 2) + "00" + Converter.ToHex(name));
            }
        }
        public bool InRange(int member)
        {
            ///TODO: implement edilecek
            return true;
        }
        #region Helper
        public int WriteMemory(IntPtr Address, int Value) => client.WriteMemory(Address, Value);
        private byte[] ReadMemory(IntPtr Address) => client.ReadMemory(Address);
        private byte[] ReadMemory(IntPtr Address, bool Float) => client.ReadMemory(Address, Float);
        private byte[] ReadMemory(IntPtr Address, byte[] ReadBytes, long nSize) => client.ReadMemory(Address, ReadBytes, nSize);
        private int ToInt32(byte[] pBytes) => Converter.ToInt32(pBytes);
        private string AlignDWORD(IntPtr intPtr) => Converter.AlignDWORD(intPtr);
        #endregion

       
    }
    public class PartyMember
    {
        private Party party;
        public string Id { get => party.PartyID(index); }
        public int Hp { get => party.PartyHP(index); }
        public int MaxHp { get => party.PartyMaxHP(index); }
        public int Level { get => party.PartyLevel(index); }
        public int Class { get => party.PartyClass(index); }
        public string Name { get => party.PartyName(index); }
        public int Position { get => party.PartyPosition(Name); }
        public bool InRange { get => party.InRange(index); }
        private int index;
        public PartyMember(Party _party,int _index)
        {
            party = _party;
            index = _index;
        }

    }

}