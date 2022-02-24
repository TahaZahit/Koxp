using System;
using System.Threading;

namespace Koxp
{
    internal class Priest
    {
        public static Skill[] AttackSkills = new Skill[]
        {

                new Skill( "Stroke", "001",0 ),
                new Skill( "Holy Attack", "006",0 ),
                new Skill( "Wrath", "611",0 ),
                new Skill( "Wield", "620",0 ),
                new Skill( "Harsh", "641",2 ),
                new Skill( "Collapse","650",3),
                new Skill( "Collision", "511",0),
                new Skill( "Shuddering", "520",0 ),
                new Skill( "Ruin", "542", 2),
                new Skill( "Helish", "551", 3),
                new Skill( "Tilt", "712", 0),
                new Skill( "Bloody", "721",0 ),
                new Skill( "Raving Edge", "739",2 ),
                new Skill( "Hades", "750", 3),
                new Skill( "Judgement", "802", 0)
        };
        public static Skill[] Other = new Skill[]
        {

                new Skill( "Strenght", "004", 0),
                new Skill( "Blasting", "802", 0),
                new Skill( "Wildness", "802", 0),
        };
        public static Skill[] BuffSkills = new Skill[]
        {

                new Skill( "60", "606",0),
                new Skill( "240", "615",0),
                new Skill( "360", "624",0),
                new Skill( "720", "633",0),
                new Skill( "960", "642",0),
                 new Skill( "1200", "655",0),
                 new Skill( "Undy", "654",0),
                 new Skill( "1500", "657",0),
                 new Skill( "2000", "670",0),
                 new Skill( "2500", "678",0)
        };
        public static Skill[] AcSkills = new Skill[]
        {

                new Skill("20" ,"603",0),
                new Skill("40" ,"612",0),
                new Skill("80" ,"621",0),
                new Skill("120","630",0),
                new Skill("160","639",0),
                new Skill("200","651",0),
                new Skill("300","660",0),
                new Skill("350","676",0)
        };
        public static Skill[] HealSkills = new Skill[]
        {

                new Skill( "60"  , "500",0),
                new Skill( "240" , "509",0),
                new Skill( "360" , "518",0),
                new Skill( "720" , "527",0),
                new Skill( "960" , "536",0),
                new Skill( "1920", "545",0)
        };
        internal static void MakeAttack(Char _char, Client client, Skill skill)
        {
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "010001000000000000000000");
        }
      
        public static void Malice(Char _char, Client client)
        {
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + "703"))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
        }

        internal static void TargetSkill(Char _char, Client client, Skill skill, string id)
        {
            client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + (id) + "000000000000000000000000");
            if (client.Realize) Thread.Sleep(1000);
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + (id) + "000000000000000000000000");
        }
        
    }
}