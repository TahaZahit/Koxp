using System;

namespace Koxp
{
    [Serializable]
    public class Skill
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public TimeSpan RecastTime;
        private DateTime lastUsage;

        public Skill(string name, string code, int seconds,int type =0)
        {
            Name = name;
            Code = code;
            RecastTime = new TimeSpan(0,seconds/60,seconds%60);
            Type = type;
        }
        public bool isUsable() =>((DateTime.Now - lastUsage) >= RecastTime);
        public override string ToString()=>Name;
        public void Use()=>lastUsage = DateTime.Now;
        

    }
}
