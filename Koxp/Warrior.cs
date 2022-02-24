using System;

namespace Koxp
{
    internal class Warrior
    {
        public static Skill[] AttackSkills = new Skill[]
        {
            new Skill("Slash", "003",3) ,
            new Skill("Crash", "005",3) ,
            new Skill("Piercing", "009",3) ,
            new Skill("Whipping", "010",3) ,
            new Skill("Hash", "500",0) ,
            new Skill("Hoodwink", "505",3) ,
            new Skill("Shear", "510",0) ,
            new Skill("Pierce", "515",0) ,
            new Skill("Carwing", "525",3) ,
            new Skill("Sever", "530",0) ,
            new Skill("Prick", "535",0) ,
            new Skill("Multiple Shock", "540",3) ,
            new Skill("Cleave", "545",0) ,
            new Skill("Mangling", "550",3) ,
            new Skill("Thrust", "555",0) ,
            new Skill("Sword Aura", "557",0) ,
            new Skill("Sword Dancing", "560",0) ,
            new Skill("Howling Sword", "570",1) ,
            new Skill("Blooding", "575",21) ,
            new Skill("Hell Blade", "580",1)
        };
        public static Skill[] Other = new Skill[]
        {
            new Skill("Sprint", "002",10) ,
            new Skill("Defense", "007",15),
            new Skill("Gain", "705",300)
        };

        internal static void MakeAttack(Char _char, Client client, Skill skill)
        {
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "5D020600B6019BFF0000F0000A00");
        }

        internal static void TargetSkill(Char _char, Client client, Skill skill, string id = null)
        {
            client.Send(client.AttackOpCode + "06" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + (id ?? _char.Id) + "000000000000000000000000");
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + (id ?? _char.Id) + "000000000000000000000000");

        }
    }
}
