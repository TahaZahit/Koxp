using System;

namespace Koxp
{
    class Potion
    {
        public static Skill[] HpPotions = new Skill[]
        {
            new Skill("720", "014",1),
            new Skill("360", "013",1),
            new Skill("180", "012",1),
            new Skill("90","011",1),
            new Skill("45","010",1)
        };
        public static Skill[] MpPotions = new Skill[]
       {
            new Skill("1920", "020",1),
            new Skill("960","019",1),
            new Skill("480","018",1),
            new Skill("180","017",1),
            new Skill("90", "016",1)
       };
        public static void UseMp(Char _char, Client client, Skill skill)
        {
            client.Send(client.AttackOpCode+"03" + Converter.AlignDWORD(new IntPtr(int.Parse("490" + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Id + "000000000000000000000000");
        }
        public static void UseHp(Char _char, Client client, Skill skill)
        {
            client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse("490" + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Id + "000000000000000000000000");
        }
    }
}
