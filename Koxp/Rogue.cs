using System;

namespace Koxp
{
    internal class Rogue
    {

        public static Skill[] AttackSkills = new Skill[]
        {
                   new Skill("Stab","005",6,1),
                   new Skill("Stab2","006",6,1),
                   new Skill("Jab","600",6,1),
                   new Skill("Pierce","615",11,1),
                   new Skill("Shock","620",6,1),
                   new Skill("Thrust","635",11,1),
                   new Skill("Cut","640",6,1),
                   new Skill("Spike","655",12,1),
                   new Skill("Blody Beast","670",6,1),
                   new Skill("Blinding","675",60,1),
                   new Skill("Archery","003",0),
                   new Skill("Through Shot","500",0),
                   new Skill("Fire Arrow","505",3),
                   new Skill("Poison Arrow","510",3),
                   new Skill("Multiple Shot","515",0),
                   new Skill("Guided Arrow","520",0),
                   new Skill("Perfect Shot","525",0),
                   new Skill("Fire Shot","530",4),
                   new Skill("Poison Shot","535",4),
                   new Skill("Arc Shot","540",0),
                   new Skill("Explosive Shot","545",0),
                   new Skill("Viper","550",0),
                   new Skill("Counter Strike","552",0),
                   new Skill("Arrow Shower","555",0),
                   new Skill("Shadow Shot","557",0),
                   new Skill("Shadow Hunter","560",0),
                   new Skill("Ice Shot","562",6),
                   new Skill("Lightning Shot","566",6),
                   new Skill("Dark Pursuer","570",0),
                   new Skill("Blow Arrow","572",0),
                   new Skill("Blinding Strafe","580",60),
                   new Skill("Super Archer","",0)
        };

        public static Skill[] Other = new Skill[]
        {
           new Skill(  "Wolf","030", 120),
           new Skill( "Swift","010", 600),
           new Skill( "Light Feet","725", 10),
           new Skill( "Evade","710", 30),
           new Skill( "Safely","730", 30),
           new Skill( "Skaled Skin","760", 30),
           new Skill( "Lupin Eyes","735", 50),
           new Skill( "Hide","700", 40)

        };
        public static Skill Minor = new Skill("Minor", "705", 0);
         private static string nthArrow(Client client) => Converter.ToInt32(client.ReadMemory(new IntPtr(Converter.ToInt32(client.ReadMemory(new IntPtr(Converter.ToInt32(client.ReadMemory(Addresses.PTR_DLG)) + 0x48))))+0x174) ).ToString("X");
        public static void MakeAttack(Char _char, Client client, Skill skill)
        {
            if (skill.Type == 1)
            {
                
                client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "010001000000000000000000");
            }
            else
            {
                if (skill.Name.Equals("Multiple Shot"))
                {
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF" + nthArrow(client) + "000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF" + nthArrow(client) + "000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF" + nthArrow(client) + "000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF" + nthArrow(client) + "000000");

                }
                else if (skill.Name.Equals("Arrow Shower"))
                {
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                }
                else if (skill.Name.Equals("Super Archer"))
                {
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "515"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "555"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                }
                else
                {
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000" + nthArrow(client) + "0000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF" + nthArrow(client) + "000000");

                }
            }
        }
        public static void TargetSkill(Char _char, Client client, Skill skill, string id=null)
        {
            
                if (skill.Name.Equals("Wolf"))
                {
                    client.Send(client.AttackOpCode+"01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "030"))).Substring(0, 6) + "00" + _char.Id + "FFFF" + Converter.AlignDWORD(new IntPtr(_char.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Y)).Substring(0, 4) + "000000000000");
                    client.Send(client.AttackOpCode+"03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "030"))).Substring(0, 6) + "00" + _char.Id + "FFFF" + Converter.AlignDWORD(new IntPtr(_char.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Y)).Substring(0, 4) + "000000000000");
                }
                else
                {
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + (id??_char.Id) + "000000000000000000000000");
                }
           
        }

    }
}