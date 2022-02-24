using System;
using System.Collections.Generic;
using System.Text;

namespace Koxp
{
    public class Char
    {
        public int CharBase;
        public Target Target;
        public Party Party;
        public List<Skill> AttackSkills;
        public List<Skill> TargetSkills;

        private Client client;
        public Char(Client _client)
        {
            client = _client;
            CharBase = ToInt32(ReadMemory(Addresses.PTR_CHR));
            Target = new Target(_client, this);
            Party = new Party(_client);
            AttackSkills = new List<Skill>();
            TargetSkills = new List<Skill>();
            
        }
       
        public string Id { get => CharId(); }
        public string Name { get => CharName(); }
        public int Level { get => CharLevel(); }
        public long Exp { get => CharExp(); }
        public long RequiredExp { get => CharRequiredExp(); }
        public int Hp { get => CharHp(); }
        public int MaxHp { get => CharMaxHp(); }
        public int Mp { get => CharMp(); }
        public string Job { get => CharJob(); }
        public int MaxMp { get => CharMaxMp(); }
        public int Money { get => CharMoney(); }
        public int Zone { get => CharZone(); }
        public int X { get => CharX(); }
        public int Y { get => CharY(); }
        public int Z { get => CharZ(); }
        public bool WallHack
        {
            get => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_WH)))==0;
            set => WriteMemory(new IntPtr(CharBase + Addresses.OFF_WH), value?0:1);   
        }
        public int Class { get => FindClass(); }
        public int RightDurability { get => RightDurabilty(); }
        public int LeftDurability { get => LeftDurabilty(); }
        public bool DC{ get => CharDc(); }

        #region Getter Methods
        private bool CharDc() => 0 == ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_PKT)) + 0x40020)));
        public int RightDurabilty() => ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x170))) + 0xE8)));
        public int LeftDurabilty() => ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(ToInt32(ReadMemory(Addresses.PTR_DLG)) + 0x170))) + 0xE4)));
        private int CharMoney() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_MONEY)));
        private string CharId() => AlignDWORD(new IntPtr(ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_ID))))).Substring(2, 4).ToUpper();
        private int CharLevel() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_LVL)));
        private long CharExp() => long.Parse(ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_EXP))).ToString());
        private long CharRequiredExp() => long.Parse(ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_MAXEXP))).ToString());
        private int CharHp() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_HP)));
        private int CharMaxHp() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_MAXHP)));
        private int CharMp() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_MP)));
        private int CharMaxMp() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_MAXMP)));
        private int FindClass() => ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_CLASS)));
        private int CharZone() => ToInt32(ReadMemory(new IntPtr(Addresses.PTR_ZONE)));
        private int CharX() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(CharBase + Addresses.OFF_X)), 0));
        private int CharY() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(CharBase + Addresses.OFF_Y)), 0));
        private int CharZ() => Convert.ToInt32(BitConverter.ToSingle(ReadMemory(new IntPtr(CharBase + Addresses.OFF_Z)), 0));
        private string CharJob()
        {
            switch (FindClass())
            {
                case 102: return "Rogue";
                case 107: return "Rogue";
                case 108: return "Rogue";
                case 202: return "Rogue";
                case 207: return "Rogue";
                case 208: return "Rogue";
                case 104: return "Priest";
                case 111: return "Priest";
                case 112: return "Priest";
                case 204: return "Priest";
                case 211: return "Priest";
                case 212: return "Priest";
                case 101: return "Warrior";
                case 105: return "Warrior";
                case 106: return "Warrior";
                case 201: return "Warrior";
                case 205: return "Warrior";
                case 206: return "Warrior";
                case 103: return "Mage";
                case 109: return "Mage";
                case 110: return "Mage";
                case 203: return "Mage";
                case 209: return "Mage";
                case 210: return "Mage";
                default: return "Undefined";
            }
        }
        private string CharName()
        {
            byte[] pBytes = new byte[25];
            string Name = Convert.ToString(ASCIIEncoding.ASCII.GetString(ReadMemory(new IntPtr(ToInt32(ReadMemory(new IntPtr(CharBase + Addresses.OFF_NAME)))), pBytes, 25L)));
            for (int i = 0; i < Name.Length; i++)
                if ((int)Name[i] == 0)
                    return Name.Substring(0, i);
            return "";
        }
        #endregion

        public void GoTo(int x, int y)
        {
            client.WriteMemory(new IntPtr(CharBase + Addresses.OFF_MOVTYPE), 1);
            client.WriteMemory(new IntPtr(CharBase + Addresses.OFF_GO_X), float.Parse(x.ToString()));
            client.WriteMemory(new IntPtr(CharBase + Addresses.OFF_GO_Y), float.Parse(y.ToString()));
            client.WriteMemory(new IntPtr(CharBase + Addresses.OFF_MVCHRTYP), 2);
        }
        public bool MakeAttack(Skill skill, bool Cz)
        {
            
            if (Target.Distance<10&&Target.Hp>0&&(!Target.Id.Equals("FFFF"))&&((Converter.FormatDec(Target.Id, 4) > 9999)||Cz))
            {
                if(skill.isUsable())
                {
                    if (Job.Equals("Warrior"))
                        Warrior.MakeAttack(this, client, skill);
                    else if (Job.Equals("Mage"))
                        Mage.MakeAttack(this, client, skill);
                    else if (Job.Equals("Rogue"))
                        Rogue.MakeAttack(this, client, skill);
                    else if (Job.Equals("Priest"))
                        Priest.MakeAttack(this, client, skill);
                    skill.Use();
                    return true;
                }
            }
            return false;


        }
        public void SelectMob()
        {
            byte[] xCode;
            string xStr = "60" + "8B0D" + AlignDWORD(Addresses.PTR_DLG) + "BF" + AlignDWORD(Addresses.FNCZ) + "FFD761C3";
            xCode = Converter.ToByteArray(xStr);
            client.ExecuteRemoteCode(xCode);
        }
        public bool SkillUse(Skill skill, string Id)
        {
            if (Id.Equals(this.Id))
            {
                if (skill.isUsable())
                {
                    if (Job.Equals("Warrior"))
                        Warrior.TargetSkill(this, client, skill);
                    else if (Job.Equals("Mage"))
                        Mage.TargetSkill(this, client, skill);
                    else if (Job.Equals("Rogue"))
                        Rogue.TargetSkill(this, client, skill);
                    else if (Job.Equals("Priest"))
                        Priest.TargetSkill(this, client, skill,Id);
                    skill.Use();
                    return true;
                }
            }
            else
            {
                if (Job.Equals("Warrior"))
                    Warrior.TargetSkill(this, client, skill,Id);
                else if (Job.Equals("Mage"))
                    Mage.TargetSkill(this, client, skill, Id);
                else if (Job.Equals("Rogue"))
                    Rogue.TargetSkill(this, client, skill, Id);
                else if (Job.Equals("Priest"))
                    Priest.TargetSkill(this, client, skill, Id);
                skill.Use();
                return true;
            }
            return false;
        }
        public void RAttack(bool Cz)
        {
            if (!client.Char.Target.Id.Equals("FFFF") && client.Char.Target.Hp != 0 && client.Char.Target.Distance <=2 && ((Converter.FormatDec(Target.Id, 4) > 9999) || Cz))
                //client.Send(client.RAttackOpCode + "0101" + client.Char.Target.Id + "FF" + "000000");
                client.Send(client.RAttackOpCode + "0101" + client.Char.Target.Id + "77" + "000000");
        }
        public void PotionHp(Skill skill)
        {
            Potion.UseMp(this, client, skill);
        }
        public void PotionMp(Skill skill)
        {
            Potion.UseMp(this, client, skill);
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
}
