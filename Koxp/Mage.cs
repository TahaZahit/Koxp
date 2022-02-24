using System;
using System.Collections.Generic;

namespace Koxp
{
    public class Mage
    {
        public static Skill[] AttackSkills =
        {
            //1 tipi havada süzülmeyenler
            //2 tipi havada süzülenler
            //3 tipi staff //SEND-->WIZ_UNKNOW (BE)--   >BE03863203006C003036010001000000000000000000
                           //                           >BE03863203006C002C36010001000000000000000000
            //10 alan süzülen fire burst gibi
            //11 alan direk inferno gibi

                new Skill( "Burn","503",1, 1),
                new Skill( "Ignition","518",1, 1),
                new Skill( "Specter Of Fire","543",1, 1),
                new Skill( "Manes Of Fire","556",1, 1),
                new Skill( "Fire Blast","535",5, 2),
                new Skill( "Blaze","509",6, 1),
                new Skill( "Fire Spear","527",5, 2),
                new Skill( "Hell Fire","539",5, 1),
                new Skill( "Pillar Of Fire","551",6, 2),
                new Skill( "Fire Thorn","554",6, 2),
                new Skill( "Fire Impact","557",21, 2),
                new Skill( "Fire Ball","509",5, 2),
                new Skill( "Flame Staff","542",1, 3),
                new Skill( "Glacier Staff","642",1, 3),
                new Skill( "Lightining Staff","742",1, 3),
                new Skill( "Freeze","603",1, 1),
                new Skill( "Chill","609",6, 1),
                new Skill( "Solid","618",1, 1),
                new Skill( "Frostbite","639",5, 1),
                new Skill( "Frozen Blade","642",1, 1),
                new Skill( "Specter Of Ice","643",1, 1),
                new Skill( "Ice Comet","651",6, 1),
                new Skill( "Ice Orb","627",5, 2),
                new Skill( "Manes Of Ice","656",1, 1),
                new Skill( "Ice Impact","657",21, 2),
                new Skill( "Ice Staff","672",1, 3),
                new Skill( "Charge","703",15, 1),////self?
                new Skill( "Counter Spell","709",5, 1),
                new Skill( "Lightining","715",5, 1),
                new Skill( "Static Hemispher","718",1, 2),
                new Skill( "Thunder","727",5, 1),
                new Skill( "Thunder Blast","735",5, 1),
                new Skill( "Charged Blade","742",1, 1),
                new Skill( "Specter Of Thund","743",1, 1),
                new Skill( "Static Orb","751",6, 1),
                new Skill( "Static Thorn","754",6, 1),
                new Skill( "Manes Of Thunder","756",1, 1),
                new Skill( "Thunder Impact","757",21, 1),
                new Skill( "Inferno","545",16, 11),
                new Skill( "Blizzard","645",16, 11),
                new Skill( "Thundercloud","745",16, 11),
                new Skill( "Super Nova","560",16, 11),
                new Skill( "Frost Nova","660",16, 11),
                new Skill( "Static Nova","760",16, 11),
                new Skill( "Meteor Fall","571",19, 11),
                new Skill( "Ice Storm","671",19, 11),
                new Skill( "Chain Lightning","771",19,11),
                new Skill( "Fire Burst","533",1,10),
                new Skill( "Ice Burst","733",1,10),
                new Skill( "Incineration","570",22, 1)
        };
        public static Skill[] Other = new Skill[]
       {
           
       };
        internal static void MakeAttack(Char _char, Client client, Skill skill)
        {
            switch (skill.Type)
            {
                case 1:
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    break;
                case 2:
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF00000000");
                    break;
                case 3:
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + "000000000000000000000000");
                    break;
             
                case 10:
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "000000000000");
                    client.Send(client.AttackOpCode + "02" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "000000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "000000000000");
                    client.Send(client.AttackOpCode + "04" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + _char.Target.Id + Converter.AlignDWORD(new IntPtr(_char.Target.X)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Y)).Substring(0, 4) + "9BFF00000000");

                    break;
                case 11:
                    client.Send(client.AttackOpCode + "01" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + "FFFF" + (Converter.AlignDWORD(new IntPtr(_char.Target.X))).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + (Converter.AlignDWORD(new IntPtr(_char.Target.Y))).Substring(0, 4) + "000000000000");
                    client.Send(client.AttackOpCode + "03" + Converter.AlignDWORD(new IntPtr(int.Parse(_char.Class.ToString() + skill.Code))).Substring(0, 6) + "00" + _char.Id + "FFFF" + (Converter.AlignDWORD(new IntPtr(_char.Target.X))).Substring(0, 4) + Converter.AlignDWORD(new IntPtr(_char.Target.Z)).Substring(0, 4) + (Converter.AlignDWORD(new IntPtr(_char.Target.Y))).Substring(0, 4) + "000000000000");
                    break;
                default:
                    break;
            }
        }

        internal static void TargetSkill(Char _char, Client client, Skill skill, string id=null)
        {
            throw new NotImplementedException();
        }
    }
}