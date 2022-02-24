using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Koxp
{
    public unsafe partial class MainWindow : Form
    {
        public Client client;
        
        public MainWindow()
        {
            InitializeComponent();
            cmbClientSelect.DisplayMember = "Text";
            cmbClientSelect.ValueMember = "Value";
            
            Process[] clients = Process.GetProcessesByName("KnightOnline");
            if (clients.Length == 1) Start(clients[0].Id);
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            WinApi.ReleaseCapture();
            WinApi.SendMessage(this.Handle, 0xa1, 0x2, 0);
        }
        private void ChkAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkAlwaysTop.Checked;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void CmbClientSelect_Click(object sender, EventArgs e)
        {

            cmbClientSelect.Items.Clear();
            Process[] clients = Process.GetProcessesByName("KnightOnline");
            foreach (var client in clients)
            {
                IntPtr handle = WinApi.OpenProcess(0x1f0fff, false, client.Id);
                string name = new Client(handle).Char.Name;
                cmbClientSelect.Items.Add(new {Text = name, Value = client.Id });
                WinApi.CloseHandle(handle);
            }
        }
        private void CmbClientSelect_SelectedValueChanged(object sender, EventArgs e)
        {
           if(cmbClientSelect.SelectedItem != null)
            {
                int pid = (cmbClientSelect.SelectedItem as dynamic).Value;
                Start(pid);
            }
        }
        private void Start(int pid)
        {
            IntPtr handle = WinApi.OpenProcess(0x1f0fff, false, pid);
            client = new Client(handle);
            chkAlwaysTop.Text = client.Char.Name;
            cmbClientSelect.Visible = false;
            tmrTargetInfo.Enabled = true;
            tmrCharInfo.Enabled = true;
            tmrParty.Enabled = true;
            tmrSelf.Enabled = true;

            cmbHpPot.Items.AddRange(Potion.HpPotions);
            cmbMpPot.Items.AddRange(Potion.MpPotions);
            if (client.Char.Job.Equals("Warrior"))
            {
                lstAttack.Items.AddRange(Warrior.AttackSkills);
                lstSelf.Items.AddRange(Warrior.Other);
            }
            else if (client.Char.Job.Equals("Mage"))
            {
                lstAttack.Items.AddRange(Mage.AttackSkills);
                lstSelf.Items.AddRange(Mage.Other);

            }
            else if (client.Char.Job.Equals("Priest"))
            {
                lstAttack.Items.AddRange(Priest.AttackSkills);
                lstSelf.Items.AddRange(Priest.Other);
            }
            else if (client.Char.Job.Equals("Rogue"))
            {
                lstAttack.Items.AddRange(Rogue.AttackSkills);
                lstSelf.Items.AddRange(Rogue.Other);
            }
            lstPriest.Items.AddRange(Priest.Other);
            if (client.Char.Job.Equals("Priest"))
            {
                cmbAc.Items.AddRange(Priest.AcSkills);
                cmbBuff.Items.AddRange(Priest.BuffSkills);
                cmbHeal.Items.AddRange(Priest.HealSkills);
                tmrPriest.Enabled = true;
            }

            LoadConfig();
            __ptrloot = Converter.ToInt32(client.ReadMemory(new IntPtr(Addresses.PTR_VAR)));
            txtLog.Text = Application.ExecutablePath + Environment.NewLine+"AttackOpCode: " + client.AttackOpCode + Environment.NewLine + "RattackOpcode: " + client.RAttackOpCode + Environment.NewLine + client.RAttackOpCode + "0101" + client.Char.Target.Id + "FF" + "000000" + Environment.NewLine +client.OpCode;
        }

        private void LoadConfig()
        {
            try
            {
                using (Stream stream = File.Open(Application.StartupPath + "\\" + chkAlwaysTop.Text + ".save", FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    Config config = (Config)binaryFormatter.Deserialize(stream);

                    chkHp.Checked = config.hp;
                    txtHp.Text = config.hpPercent;
                    for (int i = 0; (i < cmbHpPot.Items.Count) && config.hp; i++)
                    {
                        if (config.hpPot.Name == ((Skill)cmbHpPot.Items[i]).Name)
                        {
                            cmbHpPot.SelectedItem = cmbHpPot.Items[i];
                        }
                    }
                    

                    chkMp.Checked = config.mp;
                    txtMp.Text = config.mpPercent;
                    for (int i = 0; (i < cmbMpPot.Items.Count) && config.mp; i++)
                    {
                        if (config.mpPot.Name == ((Skill)cmbMpPot.Items[i]).Name)
                        {
                            cmbMpPot.SelectedItem = cmbMpPot.Items[i];
                        }
                    }

                    chkTs.Checked = config.ts;
                    for (int i = 0; (i < cmbTs.Items.Count)&&config.ts; i++)
                    {
                        if (config.tsSkill.Name == ((Skill)cmbTs.Items[i]).Name)
                        {
                            cmbTs.SelectedItem = cmbTs.Items[i];
                        }
                    }

                    chkLoot.Checked = config.loot;
                    chkMinor.Checked = config.minor;
                    txtMinor.Text = config.minorPercent;
                    txtMinorTime.Text = config.minorTime;

                    chkTP.Checked = config.tp;
                    txtTP.Text = config.tpText;
                    centerX = config.centerX;
                    centerY = config.centerY;

                    chkEscape.Checked = config.escape;
                    txtEscape.Text = config.escapePercent;

                    chkWallHack.Checked = config.wallHack;
                    chkAutoParty.Checked = config.autoParty;

                    foreach (Skill item in config.attackList)
                    {
                        for (int i = 0; i < lstAttack.Items.Count; i++)
                        {
                            if (((Skill)lstAttack.Items[i]).Name.Equals(item.Name))
                                lstAttack.SetItemChecked(i, true);
                        }
                    }
                    foreach (Skill item in config.selfList)
                    {
                        for (int i = 0; i < lstSelf.Items.Count; i++)
                        {

                            
                            if (((Skill)lstSelf.Items[i]).Name.Equals(item.Name))
                                lstSelf.SetItemChecked(i, true);
                        }
                    }
                    txtAttackSpeed.Text=config.attackTime;

                    chkRAttack.Checked = config.rAttack;
                    txtRAttack.Text = config.rAttackTime;
                    chkCz.Checked = config.Cz;
                    chkMobSelect.Checked = config.selectMob;
                    chkRunToMob.Checked = config.runToMob;
                    chkBackToCenter.Checked = config.backToCenter;
                    lblTakeCenter.Text = config.center;

                    foreach (Skill item in config.priestList)
                    {
                        for (int i = 0; i < lstPriest.Items.Count; i++)
                        {
                            
                            if (((Skill)lstPriest.Items[i]).Name.Equals(item.Name))
                                lstPriest.SetItemChecked(i, true);
                        }
                    }
                    chkHeal.Checked = config.heal;
                    txtHeal.Text = config.healPercent;
                    for (int i = 0; (i < cmbHeal.Items.Count) && config.heal; i++)
                    {
                        if (config.healSkill.Name == ((Skill)cmbHeal.Items[i]).Name)
                        {
                            cmbHeal.SelectedItem = cmbHeal.Items[i];
                        }
                    }

                    chkBuff.Checked = config.buff;
                    for (int i = 0; (i < cmbBuff.Items.Count)&&config.buff; i++)
                    {
                        if (config.buffSkill.Name == ((Skill)cmbBuff.Items[i]).Name)
                        {
                            cmbBuff.SelectedItem = cmbBuff.Items[i];
                        }
                    }
                    chkAc.Checked = config.ac;
                    for (int i = 0; (i < cmbAc.Items.Count)&&config.ac; i++)
                    {
                        if (config.acSkill.Name == ((Skill)cmbAc.Items[i]).Name)
                        {
                            cmbAc.SelectedItem = cmbAc.Items[i];
                        }
                    }
                    chkCure.Checked = config.cure;
                    chkLowerLife.Checked = config.lowLife;

                }

            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void SaveConfig()
        {
            Config config = new Config();
            config.loot = chkLoot.Checked;
            config.hp = chkHp.Checked;
            config.hpPercent = txtHp.Text;
            config.hpPot = (Skill)cmbHpPot.SelectedItem;

            config.mp = chkMp.Checked;
            config.mpPercent = txtMp.Text;
            config.mpPot = (Skill)cmbMpPot.SelectedItem;

            config.ts = chkTs.Checked;
            config.tsSkill = (Skill)cmbTs.SelectedItem;

            config.minor = chkMinor.Checked;
            config.minorPercent = txtMinor.Text;
            config.minorTime = txtMinorTime.Text;

            config.tp = chkTP.Checked;
            config.tpText = txtTP.Text;

            config.escape = chkEscape.Checked;
            config.escapePercent = txtEscape.Text;

            config.wallHack = chkWallHack.Checked;
            config.autoParty = chkAutoParty.Checked;

            config.attackList = new List<Skill>();
            config.selfList = new List<Skill>();
            config.attackTime = txtAttackSpeed.Text;

            foreach (Skill item in lstAttack.CheckedItems) config.attackList.Add(item);
            foreach (Skill item in lstSelf.CheckedItems) config.selfList.Add(item);
            config.rAttack = chkRAttack.Checked;
            config.rAttackTime = txtRAttack.Text;

            config.Cz = chkCz.Checked;
            config.selectMob = chkMobSelect.Checked;
            config.runToMob = chkRunToMob.Checked;
            config.backToCenter = chkBackToCenter.Checked;
            config.center = lblTakeCenter.Text;
            config.centerX = centerX;
            config.centerY = centerY;
            config.priestList = new List<Skill>();
            foreach (Skill item in lstPriest.CheckedItems) config.priestList.Add(item);
            config.heal = chkHeal.Checked;
            config.healPercent = txtHeal.Text;
            config.healSkill = (Skill)cmbHeal.SelectedItem;

            config.buff = chkBuff.Checked;
            config.buffSkill = (Skill)cmbBuff.SelectedItem;

            config.ac = chkAc.Checked;
            config.acSkill = (Skill)cmbAc.SelectedItem;
            config.cure = chkCure.Checked;
            config.lowLife = chkLowerLife.Checked;

            using (Stream stream = File.Open(Application.StartupPath + "\\" + chkAlwaysTop.Text+ ".save", FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, config);
            }
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            if(btnAttack.Text.Equals("Atak Başlat")){
                
                btnAttack.Text = "Atak Durdur";
                tmrAttack.Enabled = true;
                tmrSelectMob.Enabled = chkMobSelect.Checked;
            }
            else
            {
                btnAttack.Text = "Atak Başlat";
                tmrAttack.Enabled = false;
                tmrSelectMob.Enabled = false;

            }
        }


        private void TmrCharInfo_Tick(object sender, EventArgs e)
        {
            lblId.Text = "ID: " + client.Char.Id;
            lblName.Text = "Name: " + client.Char.Name;
            lblJob.Text = "Job: " + client.Char.Job;
            lblHp.Text = "Hp: " + client.Char.Hp + "/" + client.Char.MaxHp;
            lblMp.Text = "Mp: " + client.Char.Mp + "/" + client.Char.MaxMp;
            lblExp.Text = "Exp: " + client.Char.Exp + "/" + client.Char.RequiredExp;
            lblMoney.Text = "Money: " + client.Char.Money;
            lblRightDurability.Text = "RPR Right: " + client.Char.RightDurability;
            lblLeftDurability.Text = "RPR Left: " + client.Char.LeftDurability;
            lblWallHack.Text = "Wall Hack: " + client.Char.WallHack;
            lblCoordinate.Text = "Coordinate: " + client.Char.X + ", " + client.Char.Y + ", " + client.Char.Z + "( " + (Converter.AlignDWORD(new IntPtr(client.Char.X))).Substring(0, 4) + ", " + (Converter.AlignDWORD(new IntPtr(client.Char.Y))).Substring(0, 4) + ", " + (Converter.AlignDWORD(new IntPtr(client.Char.Z))).Substring(0, 4); ;
        }

        private void TmrTargetInfo_Tick(object sender, EventArgs e)
        {
            lblTargetId.Text ="ID: "+ client.Char.Target.Id;
            lblTargetHp.Text = "HP: " + client.Char.Target.Hp;
            lblTargetName.Text = "Name: " + client.Char.Target.Name;
            lblTargetCoordinate.Text = "XYZ: " + client.Char.Target.X+", "+client.Char.Target.Y+", "+client.Char.Target.Z+"( "+ (Converter.AlignDWORD(new IntPtr(client.Char.Target.X))).Substring(0, 4)+", "+ (Converter.AlignDWORD(new IntPtr(client.Char.Target.Y))).Substring(0, 4)+", "+ (Converter.AlignDWORD(new IntPtr(client.Char.Target.Z))).Substring(0, 4);
            lblTargetDistance.Text = "Dist: " + client.Char.Target.Distance;
        }

        private void TmrParty_Tick(object sender, EventArgs e)
        {
            gridParty.Rows.Clear();
            gridParty.RowCount = 8;
            for (int i = 0; i < client.Char.Party.MembersCount; i++)
            {
                gridParty[0, i].Value = client.Char.Party.Members[i].Name;
                gridParty[1, i].Value = client.Char.Party.Members[i].Hp;
                gridParty[2, i].Value = client.Char.Party.Members[i].MaxHp;
                gridParty[3, i].Value = client.Char.Party.Members[i].Level;
            }
        }

        private void TmrAttack_Tick(object sender, EventArgs e)
        {
            if (chkRunToMob.Checked && client.Char.Target.Hp!=0)
            {
                if(client.Char.Target.Distance>1)   
                    client.Char.GoTo(client.Char.Target.X, client.Char.Target.Y);
                else
                {
                    foreach (Skill skill in client.Char.AttackSkills)
                    {
                        if (client.Char.MakeAttack(skill, chkCz.Checked))
                        {
                            break;
                        }
                    }
                }
            }
            else if(!chkRunToMob.Checked)
            {
                foreach (Skill skill in client.Char.AttackSkills)
                {
                    if (client.Char.MakeAttack(skill, chkCz.Checked))
                    {
                        break;
                    }
                }
            }
           

        }

        private void LstAttack_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                client.Char.AttackSkills.Add((Skill)lstAttack.Items[e.Index]);
            }
            else
            {
                client.Char.AttackSkills.Remove((Skill)lstAttack.Items[e.Index]);
            }
            client.Char.AttackSkills = client.Char.AttackSkills.OrderBy(i => i.RecastTime).Reverse().ToList();
        }

        private void TmrSelectMob_Tick(object sender, EventArgs e)
        {
            if (tmrAttack.Enabled)
            {
                if ((client.Char.X != centerX && client.Char.Y != centerY) && chkBackToCenter.Checked && (client.Char.Target.Hp == 0))
                {
                    client.Char.GoTo(centerX, centerY);
                }
                else
                {
                    client.Char.SelectMob();
                }
            }
        }

        private void ChkMobSelect_CheckedChanged(object sender, EventArgs e)
        {
            if(tmrAttack.Enabled)
                tmrSelectMob.Enabled = chkMobSelect.Checked;
        }
        private int centerX=-1;
        private int centerY=-1;
      
        private void LblTakeCenter_Click(object sender, EventArgs e)
        {
            centerX = client.Char.X;
            centerY = client.Char.Y;
            lblTakeCenter.Text = centerX + ", " + centerY;
        }

        private void TxtAttackSpeed_TextChanged(object sender, EventArgs e)
        {
            tmrAttack.Interval = int.Parse(txtAttackSpeed.Text);
        }

        private void TmrRAttack_Tick(object sender, EventArgs e)
        {
            if (chkRAttack.Checked && tmrAttack.Enabled)
            {
                client.Char.RAttack(chkCz.Checked);
            }
        }

        private void ChkRAttack_CheckedChanged(object sender, EventArgs e)
        {
            tmrRAttack.Enabled = chkRAttack.Checked;
        }

        private void TxtRAttack_TextChanged(object sender, EventArgs e)
        {
            tmrRAttack.Interval = int.Parse(txtRAttack.Text);
        }

        private void TmrSelf_Tick(object sender, EventArgs e)
        {
            foreach (Skill skill in client.Char.TargetSkills)
            {
                if (client.Char.SkillUse(skill,client.Char.Id))
                {
                    break;
                }
            }
        }

        private void ChkWallHack_CheckedChanged(object sender, EventArgs e)
        {
            client.Char.WallHack = chkWallHack.Checked;
        }

        private void BtnSendCustomPacket_Click(object sender, EventArgs e)
        {
            client.Send(txtCustomPacket.Text);
        }

        private void TmrPotion_Tick(object sender, EventArgs e)
        {
            if (chkHp.Checked && client.Char.Hp < ((client.Char.MaxHp * int.Parse(txtHp.Text)) / 100))
                client.Char.PotionHp((Skill)cmbHpPot.SelectedItem);

            if (chkMp.Checked && client.Char.Mp < ((client.Char.MaxMp * int.Parse(txtMp.Text)) / 100))
                client.Char.PotionMp((Skill)cmbMpPot.SelectedItem);
        }

        private void LstSelf_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                client.Char.TargetSkills.Add((Skill)lstSelf.Items[e.Index]);
            }
            else
            {
                client.Char.TargetSkills.Remove((Skill)lstSelf.Items[e.Index]);
            }
            client.Char.TargetSkills = client.Char.TargetSkills.OrderBy(i => i.RecastTime).Reverse().ToList();
        }


        private int MyLife = 0;
        private int[] PartyLifes = new int[8];
        private void TmrPriest_Tick(object sender, EventArgs e)
        {
            int memberCount = client.Char.Party.MembersCount;
            if(memberCount==0)
            {
                if (chkHeal.Checked && !txtHeal.Text.Equals("") && !cmbHeal.Text.Equals(""))
                {
                    if(100*client.Char.Hp/client.Char.MaxHp < int.Parse(txtHeal.Text))
                        client.Char.SkillUse((Skill)cmbHeal.SelectedItem,client.Char.Id);
                }
                if (chkBuff.Checked && !cmbBuff.Text.Equals(""))
                {
                    if (client.Char.MaxHp != MyLife)
                    {
                        client.Char.SkillUse((Skill)cmbBuff.SelectedItem, client.Char.Id);
                        MyLife = client.Char.MaxHp;
                        if (chkAc.Checked && !cmbAc.Text.Equals(""))
                            client.Char.SkillUse((Skill)cmbAc.SelectedItem, client.Char.Id);
                    }
                }
                else MyLife = 0;

            }
            else
            {
                if (chkHeal.Checked && !txtHeal.Text.Equals("") && !cmbHeal.Text.Equals(""))
                {
                    if (chkLowerLife.Checked)
                    {
                        PartyMember member = null;

                        int LowerLife = 101;
                        for (int i = 0; i < memberCount; i++)
                        {
                            PartyMember temp = client.Char.Party.Members[i];
                            if ((temp.Hp * 100) / temp.MaxHp < LowerLife && temp.InRange)
                            {
                                LowerLife = (temp.Hp * 100) / temp.MaxHp;
                                member = temp;
                            }
                        }

                        if (member.Hp < ((member.MaxHp * int.Parse(txtHeal.Text)) / 100))
                        {
                            client.Char.SkillUse((Skill)cmbHeal.SelectedItem, member.Id);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < memberCount; i++)
                        {
                            PartyMember member = client.Char.Party.Members[i];
                            if ((member.Hp < ((member.MaxHp * int.Parse(txtHeal.Text)) / 100)) && member.InRange)
                            {
                                client.Char.SkillUse((Skill)cmbHeal.SelectedItem, member.Id);
                                break;
                            }
                        }

                    }
                }
                if (chkBuff.Checked && !cmbBuff.Text.Equals(""))
                {
                    for (int i = 0; i < memberCount; i++)
                    {
                        PartyMember member = client.Char.Party.Members[i];
                        if (member.MaxHp != PartyLifes[i])
                        {
                            client.Char.SkillUse((Skill)cmbBuff.SelectedItem, member.Id);

                            if (chkAc.Checked && !cmbAc.Text.Equals(""))
                                client.Char.SkillUse((Skill)cmbAc.SelectedItem, member.Id);

                            PartyLifes[i] = member.MaxHp;
                            break;
                        }
                    }
                        
                }
                else
                    PartyLifes = new int[8];
                
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            client.Char.Party.Invate(txtAdd.Text);
        }

        private bool __loot = true;
        private int __ptrloot;
        private void TmrLoot_Tick(object sender, EventArgs e)
        {
            if (chkLoot.Checked)
            {
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT8), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT7), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT5), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT4), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT2), __loot ? 1 : 0);
                client.WriteMemory(new IntPtr(__ptrloot + Addresses.OFF_LOOT1), __loot ? 1 : 0);
                __loot = !__loot;
            }
        }

        private void TmrDc_Tick(object sender, EventArgs e)
        {
            if (client.Char.DC)
            {
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void ChkRealize_CheckedChanged(object sender, EventArgs e)
        {
            client.Realize = chkRealize.Checked;
        }
    }
}
