using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koxp
{
    [Serializable]
    public class Config
    {
        public bool hp;
        public string hpPercent;
        public Skill hpPot;

        public bool mp;
        public string mpPercent;
        public Skill mpPot;

        public bool ts;
        public Skill tsSkill;

        public bool minor;
        public string minorPercent;
        public string minorTime;

        public bool tp;
        public string tpText;

        public bool escape;
        public string escapePercent;

        public bool wallHack;
        public bool autoParty;

        public List<Skill> attackList;
        public string attackTime;
        public bool rAttack;
        public string rAttackTime;
        public bool Cz;
        public bool selectMob;
        public bool runToMob;
        public bool backToCenter;
        public string center;

        public List<Skill> selfList;

        public List<Skill> priestList;
        public bool heal;
        public string healPercent;
        public Skill healSkill;
        public bool buff;
        public Skill buffSkill;
        public bool ac;
        public Skill acSkill;
        public bool cure;
        public bool lowLife;
        internal int centerX;
        internal int centerY;
        internal bool loot;
    }
}
