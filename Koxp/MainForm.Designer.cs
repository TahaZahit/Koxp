namespace Koxp
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkAlwaysTop = new System.Windows.Forms.CheckBox();
            this._Close = new System.Windows.Forms.Label();
            this._Minimize = new System.Windows.Forms.Label();
            this.cmbClientSelect = new System.Windows.Forms.ComboBox();
            this.tabGenel = new System.Windows.Forms.TabPage();
            this.chkLoot = new System.Windows.Forms.CheckBox();
            this.pnlCharInfo = new System.Windows.Forms.Panel();
            this.lblCoordinate = new System.Windows.Forms.Label();
            this.lblLeftDurability = new System.Windows.Forms.Label();
            this.lblWallHack = new System.Windows.Forms.Label();
            this.lblRightDurability = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblMp = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbMpPot = new System.Windows.Forms.ComboBox();
            this.cmbHpPot = new System.Windows.Forms.ComboBox();
            this.cmbTs = new System.Windows.Forms.ComboBox();
            this.chkAutoParty = new System.Windows.Forms.CheckBox();
            this.chkWallHack = new System.Windows.Forms.CheckBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtMinorTime = new System.Windows.Forms.TextBox();
            this.txtTP = new System.Windows.Forms.TextBox();
            this.txtMinor = new System.Windows.Forms.TextBox();
            this.chkTP = new System.Windows.Forms.CheckBox();
            this.txtEscape = new System.Windows.Forms.TextBox();
            this.chkMinor = new System.Windows.Forms.CheckBox();
            this.chkTs = new System.Windows.Forms.CheckBox();
            this.chkEscape = new System.Windows.Forms.CheckBox();
            this.txtMp = new System.Windows.Forms.TextBox();
            this.chkMp = new System.Windows.Forms.CheckBox();
            this.txtHp = new System.Windows.Forms.TextBox();
            this.chkHp = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAttack = new System.Windows.Forms.TabPage();
            this.pnlTargetInfo = new System.Windows.Forms.Panel();
            this.lblTargetDistance = new System.Windows.Forms.Label();
            this.lblTargetCoordinate = new System.Windows.Forms.Label();
            this.lblTargetHp = new System.Windows.Forms.Label();
            this.lblTargetName = new System.Windows.Forms.Label();
            this.lblTargetId = new System.Windows.Forms.Label();
            this.chkBackToCenter = new System.Windows.Forms.CheckBox();
            this.lblTakeCenter = new System.Windows.Forms.Label();
            this.txtRAttack = new System.Windows.Forms.TextBox();
            this.txtAttackSpeed = new System.Windows.Forms.TextBox();
            this.chkCz = new System.Windows.Forms.CheckBox();
            this.chkRAttack = new System.Windows.Forms.CheckBox();
            this.chkRunToMob = new System.Windows.Forms.CheckBox();
            this.chkMobSelect = new System.Windows.Forms.CheckBox();
            this.lstSelf = new System.Windows.Forms.CheckedListBox();
            this.lstAttack = new System.Windows.Forms.CheckedListBox();
            this.tabPriest = new System.Windows.Forms.TabPage();
            this.gridParty = new System.Windows.Forms.DataGridView();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyMaxHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAc = new System.Windows.Forms.ComboBox();
            this.cmbBuff = new System.Windows.Forms.ComboBox();
            this.cmbHeal = new System.Windows.Forms.ComboBox();
            this.chkAc = new System.Windows.Forms.CheckBox();
            this.txtHeal = new System.Windows.Forms.TextBox();
            this.chkBuff = new System.Windows.Forms.CheckBox();
            this.chkRealize = new System.Windows.Forms.CheckBox();
            this.chkLowerLife = new System.Windows.Forms.CheckBox();
            this.chkCure = new System.Windows.Forms.CheckBox();
            this.chkHeal = new System.Windows.Forms.CheckBox();
            this.lstPriest = new System.Windows.Forms.CheckedListBox();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtCustomPacket = new System.Windows.Forms.TextBox();
            this.btnSendCustomPacket = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tmrAttack = new System.Windows.Forms.Timer(this.components);
            this.tmrPotion = new System.Windows.Forms.Timer(this.components);
            this.tmrCharInfo = new System.Windows.Forms.Timer(this.components);
            this.tmrTargetInfo = new System.Windows.Forms.Timer(this.components);
            this.tmrParty = new System.Windows.Forms.Timer(this.components);
            this.tmrSelectMob = new System.Windows.Forms.Timer(this.components);
            this.tmrRAttack = new System.Windows.Forms.Timer(this.components);
            this.tmrSelf = new System.Windows.Forms.Timer(this.components);
            this.tmrPriest = new System.Windows.Forms.Timer(this.components);
            this.tmrLoot = new System.Windows.Forms.Timer(this.components);
            this.tmrDc = new System.Windows.Forms.Timer(this.components);
            this.tabGenel.SuspendLayout();
            this.pnlCharInfo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAttack.SuspendLayout();
            this.pnlTargetInfo.SuspendLayout();
            this.tabPriest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParty)).BeginInit();
            this.tabOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAlwaysTop
            // 
            this.chkAlwaysTop.AutoSize = true;
            this.chkAlwaysTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAlwaysTop.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAlwaysTop.Location = new System.Drawing.Point(12, 8);
            this.chkAlwaysTop.Name = "chkAlwaysTop";
            this.chkAlwaysTop.Size = new System.Drawing.Size(29, 17);
            this.chkAlwaysTop.TabIndex = 0;
            this.chkAlwaysTop.Text = "X";
            this.chkAlwaysTop.UseVisualStyleBackColor = true;
            this.chkAlwaysTop.CheckedChanged += new System.EventHandler(this.ChkAlwaysTop_CheckedChanged);
            // 
            // _Close
            // 
            this._Close.AutoSize = true;
            this._Close.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._Close.Location = new System.Drawing.Point(322, 8);
            this._Close.Name = "_Close";
            this._Close.Size = new System.Drawing.Size(16, 18);
            this._Close.TabIndex = 1;
            this._Close.Text = "x";
            this._Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // _Minimize
            // 
            this._Minimize.AutoSize = true;
            this._Minimize.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._Minimize.Location = new System.Drawing.Point(300, 9);
            this._Minimize.Name = "_Minimize";
            this._Minimize.Size = new System.Drawing.Size(16, 18);
            this._Minimize.TabIndex = 2;
            this._Minimize.Text = "-";
            this._Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // cmbClientSelect
            // 
            this.cmbClientSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClientSelect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbClientSelect.FormattingEnabled = true;
            this.cmbClientSelect.Location = new System.Drawing.Point(28, 5);
            this.cmbClientSelect.Name = "cmbClientSelect";
            this.cmbClientSelect.Size = new System.Drawing.Size(255, 21);
            this.cmbClientSelect.TabIndex = 3;
            this.cmbClientSelect.Text = "Select a client";
            this.cmbClientSelect.SelectedValueChanged += new System.EventHandler(this.CmbClientSelect_SelectedValueChanged);
            this.cmbClientSelect.Click += new System.EventHandler(this.CmbClientSelect_Click);
            // 
            // tabGenel
            // 
            this.tabGenel.Controls.Add(this.chkLoot);
            this.tabGenel.Controls.Add(this.pnlCharInfo);
            this.tabGenel.Controls.Add(this.btnAdd);
            this.tabGenel.Controls.Add(this.cmbMpPot);
            this.tabGenel.Controls.Add(this.cmbHpPot);
            this.tabGenel.Controls.Add(this.cmbTs);
            this.tabGenel.Controls.Add(this.chkAutoParty);
            this.tabGenel.Controls.Add(this.chkWallHack);
            this.tabGenel.Controls.Add(this.txtAdd);
            this.tabGenel.Controls.Add(this.txtMinorTime);
            this.tabGenel.Controls.Add(this.txtTP);
            this.tabGenel.Controls.Add(this.txtMinor);
            this.tabGenel.Controls.Add(this.chkTP);
            this.tabGenel.Controls.Add(this.txtEscape);
            this.tabGenel.Controls.Add(this.chkMinor);
            this.tabGenel.Controls.Add(this.chkTs);
            this.tabGenel.Controls.Add(this.chkEscape);
            this.tabGenel.Controls.Add(this.txtMp);
            this.tabGenel.Controls.Add(this.chkMp);
            this.tabGenel.Controls.Add(this.txtHp);
            this.tabGenel.Controls.Add(this.chkHp);
            this.tabGenel.Location = new System.Drawing.Point(4, 25);
            this.tabGenel.Margin = new System.Windows.Forms.Padding(0);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.Size = new System.Drawing.Size(342, 507);
            this.tabGenel.TabIndex = 1;
            this.tabGenel.Text = "Genel";
            // 
            // chkLoot
            // 
            this.chkLoot.AutoSize = true;
            this.chkLoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLoot.Location = new System.Drawing.Point(225, 102);
            this.chkLoot.Name = "chkLoot";
            this.chkLoot.Size = new System.Drawing.Size(71, 17);
            this.chkLoot.TabIndex = 10;
            this.chkLoot.Text = "Oto Kutu";
            this.chkLoot.UseVisualStyleBackColor = true;
            // 
            // pnlCharInfo
            // 
            this.pnlCharInfo.Controls.Add(this.lblCoordinate);
            this.pnlCharInfo.Controls.Add(this.lblLeftDurability);
            this.pnlCharInfo.Controls.Add(this.lblWallHack);
            this.pnlCharInfo.Controls.Add(this.lblRightDurability);
            this.pnlCharInfo.Controls.Add(this.lblJob);
            this.pnlCharInfo.Controls.Add(this.lblMp);
            this.pnlCharInfo.Controls.Add(this.lblMoney);
            this.pnlCharInfo.Controls.Add(this.lblHp);
            this.pnlCharInfo.Controls.Add(this.lblExp);
            this.pnlCharInfo.Controls.Add(this.lblName);
            this.pnlCharInfo.Controls.Add(this.lblId);
            this.pnlCharInfo.Location = new System.Drawing.Point(0, 207);
            this.pnlCharInfo.Name = "pnlCharInfo";
            this.pnlCharInfo.Size = new System.Drawing.Size(342, 304);
            this.pnlCharInfo.TabIndex = 9;
            // 
            // lblCoordinate
            // 
            this.lblCoordinate.AutoSize = true;
            this.lblCoordinate.Location = new System.Drawing.Point(22, 278);
            this.lblCoordinate.Name = "lblCoordinate";
            this.lblCoordinate.Size = new System.Drawing.Size(73, 13);
            this.lblCoordinate.TabIndex = 8;
            this.lblCoordinate.Text = "Coordinate:";
            // 
            // lblLeftDurability
            // 
            this.lblLeftDurability.AutoSize = true;
            this.lblLeftDurability.Location = new System.Drawing.Point(34, 228);
            this.lblLeftDurability.Name = "lblLeftDurability";
            this.lblLeftDurability.Size = new System.Drawing.Size(61, 13);
            this.lblLeftDurability.TabIndex = 8;
            this.lblLeftDurability.Text = "RPR Left:";
            // 
            // lblWallHack
            // 
            this.lblWallHack.AutoSize = true;
            this.lblWallHack.Location = new System.Drawing.Point(28, 253);
            this.lblWallHack.Name = "lblWallHack";
            this.lblWallHack.Size = new System.Drawing.Size(67, 13);
            this.lblWallHack.TabIndex = 8;
            this.lblWallHack.Text = "Wall Hack:";
            // 
            // lblRightDurability
            // 
            this.lblRightDurability.AutoSize = true;
            this.lblRightDurability.Location = new System.Drawing.Point(28, 203);
            this.lblRightDurability.Name = "lblRightDurability";
            this.lblRightDurability.Size = new System.Drawing.Size(67, 13);
            this.lblRightDurability.TabIndex = 8;
            this.lblRightDurability.Text = "RPR Right:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(64, 78);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(31, 13);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "Job:";
            // 
            // lblMp
            // 
            this.lblMp.AutoSize = true;
            this.lblMp.Location = new System.Drawing.Point(70, 128);
            this.lblMp.Name = "lblMp";
            this.lblMp.Size = new System.Drawing.Size(25, 13);
            this.lblMp.TabIndex = 8;
            this.lblMp.Text = "MP:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(52, 178);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(43, 13);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "Money:";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(70, 103);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(25, 13);
            this.lblHp.TabIndex = 8;
            this.lblHp.Text = "HP:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(64, 153);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(31, 13);
            this.lblExp.TabIndex = 8;
            this.lblExp.Text = "Exp:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(70, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(8, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmbMpPot
            // 
            this.cmbMpPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMpPot.FormattingEnabled = true;
            this.cmbMpPot.Location = new System.Drawing.Point(106, 46);
            this.cmbMpPot.Name = "cmbMpPot";
            this.cmbMpPot.Size = new System.Drawing.Size(111, 21);
            this.cmbMpPot.TabIndex = 6;
            // 
            // cmbHpPot
            // 
            this.cmbHpPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHpPot.FormattingEnabled = true;
            this.cmbHpPot.Location = new System.Drawing.Point(106, 19);
            this.cmbHpPot.Name = "cmbHpPot";
            this.cmbHpPot.Size = new System.Drawing.Size(111, 21);
            this.cmbHpPot.TabIndex = 6;
            // 
            // cmbTs
            // 
            this.cmbTs.Enabled = false;
            this.cmbTs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTs.FormattingEnabled = true;
            this.cmbTs.Location = new System.Drawing.Point(73, 73);
            this.cmbTs.Name = "cmbTs";
            this.cmbTs.Size = new System.Drawing.Size(144, 21);
            this.cmbTs.TabIndex = 4;
            // 
            // chkAutoParty
            // 
            this.chkAutoParty.AutoSize = true;
            this.chkAutoParty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoParty.Location = new System.Drawing.Point(225, 75);
            this.chkAutoParty.Name = "chkAutoParty";
            this.chkAutoParty.Size = new System.Drawing.Size(77, 17);
            this.chkAutoParty.TabIndex = 3;
            this.chkAutoParty.Text = "Oto Party";
            this.chkAutoParty.UseVisualStyleBackColor = true;
            // 
            // chkWallHack
            // 
            this.chkWallHack.AutoSize = true;
            this.chkWallHack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWallHack.Location = new System.Drawing.Point(225, 48);
            this.chkWallHack.Name = "chkWallHack";
            this.chkWallHack.Size = new System.Drawing.Size(77, 17);
            this.chkWallHack.TabIndex = 2;
            this.chkWallHack.Text = "Wall Hack";
            this.chkWallHack.UseVisualStyleBackColor = true;
            this.chkWallHack.CheckedChanged += new System.EventHandler(this.ChkWallHack_CheckedChanged);
            // 
            // txtAdd
            // 
            this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdd.Location = new System.Drawing.Point(73, 152);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(144, 20);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Name";
            // 
            // txtMinorTime
            // 
            this.txtMinorTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinorTime.Location = new System.Drawing.Point(106, 100);
            this.txtMinorTime.Name = "txtMinorTime";
            this.txtMinorTime.Size = new System.Drawing.Size(111, 20);
            this.txtMinorTime.TabIndex = 1;
            this.txtMinorTime.Text = "250";
            // 
            // txtTP
            // 
            this.txtTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTP.Enabled = false;
            this.txtTP.Location = new System.Drawing.Point(73, 126);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(144, 20);
            this.txtTP.TabIndex = 1;
            this.txtTP.Text = "44";
            // 
            // txtMinor
            // 
            this.txtMinor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinor.Location = new System.Drawing.Point(73, 100);
            this.txtMinor.Name = "txtMinor";
            this.txtMinor.Size = new System.Drawing.Size(27, 20);
            this.txtMinor.TabIndex = 1;
            this.txtMinor.Text = "90";
            // 
            // chkTP
            // 
            this.chkTP.AutoSize = true;
            this.chkTP.Enabled = false;
            this.chkTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTP.Location = new System.Drawing.Point(11, 128);
            this.chkTP.Name = "chkTP";
            this.chkTP.Size = new System.Drawing.Size(35, 17);
            this.chkTP.TabIndex = 0;
            this.chkTP.Text = "TP";
            this.chkTP.UseVisualStyleBackColor = true;
            // 
            // txtEscape
            // 
            this.txtEscape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEscape.Enabled = false;
            this.txtEscape.Location = new System.Drawing.Point(299, 18);
            this.txtEscape.Name = "txtEscape";
            this.txtEscape.Size = new System.Drawing.Size(27, 20);
            this.txtEscape.TabIndex = 1;
            this.txtEscape.Text = "1";
            // 
            // chkMinor
            // 
            this.chkMinor.AutoSize = true;
            this.chkMinor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMinor.Location = new System.Drawing.Point(11, 102);
            this.chkMinor.Name = "chkMinor";
            this.chkMinor.Size = new System.Drawing.Size(53, 17);
            this.chkMinor.TabIndex = 0;
            this.chkMinor.Text = "Minor";
            this.chkMinor.UseVisualStyleBackColor = true;
            // 
            // chkTs
            // 
            this.chkTs.AutoSize = true;
            this.chkTs.Enabled = false;
            this.chkTs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTs.Location = new System.Drawing.Point(11, 75);
            this.chkTs.Name = "chkTs";
            this.chkTs.Size = new System.Drawing.Size(35, 17);
            this.chkTs.TabIndex = 0;
            this.chkTs.Text = "TS";
            this.chkTs.UseVisualStyleBackColor = true;
            // 
            // chkEscape
            // 
            this.chkEscape.AutoSize = true;
            this.chkEscape.Enabled = false;
            this.chkEscape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEscape.Location = new System.Drawing.Point(225, 21);
            this.chkEscape.Name = "chkEscape";
            this.chkEscape.Size = new System.Drawing.Size(65, 17);
            this.chkEscape.TabIndex = 0;
            this.chkEscape.Text = "İntihar";
            this.chkEscape.UseVisualStyleBackColor = true;
            // 
            // txtMp
            // 
            this.txtMp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMp.Location = new System.Drawing.Point(73, 46);
            this.txtMp.Name = "txtMp";
            this.txtMp.Size = new System.Drawing.Size(27, 20);
            this.txtMp.TabIndex = 1;
            this.txtMp.Text = "50";
            // 
            // chkMp
            // 
            this.chkMp.AutoSize = true;
            this.chkMp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMp.Location = new System.Drawing.Point(11, 48);
            this.chkMp.Name = "chkMp";
            this.chkMp.Size = new System.Drawing.Size(35, 17);
            this.chkMp.TabIndex = 0;
            this.chkMp.Text = "MP";
            this.chkMp.UseVisualStyleBackColor = true;
            // 
            // txtHp
            // 
            this.txtHp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHp.Location = new System.Drawing.Point(73, 19);
            this.txtHp.Name = "txtHp";
            this.txtHp.Size = new System.Drawing.Size(27, 20);
            this.txtHp.TabIndex = 1;
            this.txtHp.Text = "50";
            // 
            // chkHp
            // 
            this.chkHp.AutoSize = true;
            this.chkHp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHp.Location = new System.Drawing.Point(11, 21);
            this.chkHp.Name = "chkHp";
            this.chkHp.Size = new System.Drawing.Size(35, 17);
            this.chkHp.TabIndex = 0;
            this.chkHp.Text = "HP";
            this.chkHp.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabGenel);
            this.tabControl.Controls.Add(this.tabAttack);
            this.tabControl.Controls.Add(this.tabPriest);
            this.tabControl.Controls.Add(this.tabOther);
            this.tabControl.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(77, 21);
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(350, 536);
            this.tabControl.TabIndex = 4;
            // 
            // tabAttack
            // 
            this.tabAttack.Controls.Add(this.pnlTargetInfo);
            this.tabAttack.Controls.Add(this.chkBackToCenter);
            this.tabAttack.Controls.Add(this.lblTakeCenter);
            this.tabAttack.Controls.Add(this.txtRAttack);
            this.tabAttack.Controls.Add(this.txtAttackSpeed);
            this.tabAttack.Controls.Add(this.chkCz);
            this.tabAttack.Controls.Add(this.chkRAttack);
            this.tabAttack.Controls.Add(this.chkRunToMob);
            this.tabAttack.Controls.Add(this.chkMobSelect);
            this.tabAttack.Controls.Add(this.lstSelf);
            this.tabAttack.Controls.Add(this.lstAttack);
            this.tabAttack.Location = new System.Drawing.Point(4, 25);
            this.tabAttack.Name = "tabAttack";
            this.tabAttack.Size = new System.Drawing.Size(342, 507);
            this.tabAttack.TabIndex = 2;
            this.tabAttack.Text = "Atak";
            // 
            // pnlTargetInfo
            // 
            this.pnlTargetInfo.Controls.Add(this.lblTargetDistance);
            this.pnlTargetInfo.Controls.Add(this.lblTargetCoordinate);
            this.pnlTargetInfo.Controls.Add(this.lblTargetHp);
            this.pnlTargetInfo.Controls.Add(this.lblTargetName);
            this.pnlTargetInfo.Controls.Add(this.lblTargetId);
            this.pnlTargetInfo.Location = new System.Drawing.Point(151, 3);
            this.pnlTargetInfo.Name = "pnlTargetInfo";
            this.pnlTargetInfo.Size = new System.Drawing.Size(188, 148);
            this.pnlTargetInfo.TabIndex = 5;
            // 
            // lblTargetDistance
            // 
            this.lblTargetDistance.AutoSize = true;
            this.lblTargetDistance.Location = new System.Drawing.Point(3, 121);
            this.lblTargetDistance.Name = "lblTargetDistance";
            this.lblTargetDistance.Size = new System.Drawing.Size(37, 13);
            this.lblTargetDistance.TabIndex = 0;
            this.lblTargetDistance.Text = "Dist:";
            // 
            // lblTargetCoordinate
            // 
            this.lblTargetCoordinate.AutoSize = true;
            this.lblTargetCoordinate.Location = new System.Drawing.Point(9, 93);
            this.lblTargetCoordinate.Name = "lblTargetCoordinate";
            this.lblTargetCoordinate.Size = new System.Drawing.Size(31, 13);
            this.lblTargetCoordinate.TabIndex = 0;
            this.lblTargetCoordinate.Text = "XYZ:";
            // 
            // lblTargetHp
            // 
            this.lblTargetHp.AutoSize = true;
            this.lblTargetHp.Location = new System.Drawing.Point(15, 65);
            this.lblTargetHp.Name = "lblTargetHp";
            this.lblTargetHp.Size = new System.Drawing.Size(25, 13);
            this.lblTargetHp.TabIndex = 0;
            this.lblTargetHp.Text = "HP:";
            // 
            // lblTargetName
            // 
            this.lblTargetName.AutoSize = true;
            this.lblTargetName.Location = new System.Drawing.Point(3, 37);
            this.lblTargetName.Name = "lblTargetName";
            this.lblTargetName.Size = new System.Drawing.Size(37, 13);
            this.lblTargetName.TabIndex = 0;
            this.lblTargetName.Text = "Name:";
            // 
            // lblTargetId
            // 
            this.lblTargetId.AutoSize = true;
            this.lblTargetId.Location = new System.Drawing.Point(15, 9);
            this.lblTargetId.Name = "lblTargetId";
            this.lblTargetId.Size = new System.Drawing.Size(25, 13);
            this.lblTargetId.TabIndex = 0;
            this.lblTargetId.Text = "ID:";
            // 
            // chkBackToCenter
            // 
            this.chkBackToCenter.AutoSize = true;
            this.chkBackToCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBackToCenter.Location = new System.Drawing.Point(237, 206);
            this.chkBackToCenter.Name = "chkBackToCenter";
            this.chkBackToCenter.Size = new System.Drawing.Size(89, 17);
            this.chkBackToCenter.TabIndex = 1;
            this.chkBackToCenter.Text = "Merkeze Dön";
            this.chkBackToCenter.UseVisualStyleBackColor = true;
            // 
            // lblTakeCenter
            // 
            this.lblTakeCenter.AutoSize = true;
            this.lblTakeCenter.Location = new System.Drawing.Point(238, 226);
            this.lblTakeCenter.Name = "lblTakeCenter";
            this.lblTakeCenter.Size = new System.Drawing.Size(79, 13);
            this.lblTakeCenter.TabIndex = 4;
            this.lblTakeCenter.Text = "Koordinat Al";
            this.lblTakeCenter.Click += new System.EventHandler(this.LblTakeCenter_Click);
            // 
            // txtRAttack
            // 
            this.txtRAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRAttack.Location = new System.Drawing.Point(237, 158);
            this.txtRAttack.Name = "txtRAttack";
            this.txtRAttack.Size = new System.Drawing.Size(80, 20);
            this.txtRAttack.TabIndex = 2;
            this.txtRAttack.Text = "900";
            this.txtRAttack.TextChanged += new System.EventHandler(this.TxtRAttack_TextChanged);
            // 
            // txtAttackSpeed
            // 
            this.txtAttackSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackSpeed.Location = new System.Drawing.Point(0, 235);
            this.txtAttackSpeed.Name = "txtAttackSpeed";
            this.txtAttackSpeed.Size = new System.Drawing.Size(145, 20);
            this.txtAttackSpeed.TabIndex = 2;
            this.txtAttackSpeed.Text = "1500";
            this.txtAttackSpeed.TextChanged += new System.EventHandler(this.TxtAttackSpeed_TextChanged);
            // 
            // chkCz
            // 
            this.chkCz.AutoSize = true;
            this.chkCz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCz.Location = new System.Drawing.Point(151, 183);
            this.chkCz.Name = "chkCz";
            this.chkCz.Size = new System.Drawing.Size(77, 17);
            this.chkCz.TabIndex = 1;
            this.chkCz.Text = "Karşı Irk";
            this.chkCz.UseVisualStyleBackColor = true;
            // 
            // chkRAttack
            // 
            this.chkRAttack.AutoSize = true;
            this.chkRAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRAttack.Location = new System.Drawing.Point(151, 160);
            this.chkRAttack.Name = "chkRAttack";
            this.chkRAttack.Size = new System.Drawing.Size(59, 17);
            this.chkRAttack.TabIndex = 1;
            this.chkRAttack.Text = "R Atak";
            this.chkRAttack.UseVisualStyleBackColor = true;
            this.chkRAttack.CheckedChanged += new System.EventHandler(this.ChkRAttack_CheckedChanged);
            // 
            // chkRunToMob
            // 
            this.chkRunToMob.AutoSize = true;
            this.chkRunToMob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRunToMob.Location = new System.Drawing.Point(237, 183);
            this.chkRunToMob.Name = "chkRunToMob";
            this.chkRunToMob.Size = new System.Drawing.Size(71, 17);
            this.chkRunToMob.TabIndex = 1;
            this.chkRunToMob.Text = "Moba Koş";
            this.chkRunToMob.UseVisualStyleBackColor = true;
            // 
            // chkMobSelect
            // 
            this.chkMobSelect.AutoSize = true;
            this.chkMobSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMobSelect.Location = new System.Drawing.Point(151, 206);
            this.chkMobSelect.Name = "chkMobSelect";
            this.chkMobSelect.Size = new System.Drawing.Size(65, 17);
            this.chkMobSelect.TabIndex = 1;
            this.chkMobSelect.Text = "Mob Seç";
            this.chkMobSelect.UseVisualStyleBackColor = true;
            this.chkMobSelect.CheckedChanged += new System.EventHandler(this.ChkMobSelect_CheckedChanged);
            // 
            // lstSelf
            // 
            this.lstSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSelf.FormattingEnabled = true;
            this.lstSelf.Location = new System.Drawing.Point(0, 278);
            this.lstSelf.Name = "lstSelf";
            this.lstSelf.Size = new System.Drawing.Size(145, 227);
            this.lstSelf.TabIndex = 0;
            this.lstSelf.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LstSelf_ItemCheck);
            // 
            // lstAttack
            // 
            this.lstAttack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAttack.FormattingEnabled = true;
            this.lstAttack.Location = new System.Drawing.Point(0, 0);
            this.lstAttack.Name = "lstAttack";
            this.lstAttack.Size = new System.Drawing.Size(145, 227);
            this.lstAttack.TabIndex = 0;
            this.lstAttack.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LstAttack_ItemCheck);
            // 
            // tabPriest
            // 
            this.tabPriest.Controls.Add(this.gridParty);
            this.tabPriest.Controls.Add(this.cmbAc);
            this.tabPriest.Controls.Add(this.cmbBuff);
            this.tabPriest.Controls.Add(this.cmbHeal);
            this.tabPriest.Controls.Add(this.chkAc);
            this.tabPriest.Controls.Add(this.txtHeal);
            this.tabPriest.Controls.Add(this.chkBuff);
            this.tabPriest.Controls.Add(this.chkRealize);
            this.tabPriest.Controls.Add(this.chkLowerLife);
            this.tabPriest.Controls.Add(this.chkCure);
            this.tabPriest.Controls.Add(this.chkHeal);
            this.tabPriest.Controls.Add(this.lstPriest);
            this.tabPriest.Location = new System.Drawing.Point(4, 25);
            this.tabPriest.Name = "tabPriest";
            this.tabPriest.Size = new System.Drawing.Size(342, 507);
            this.tabPriest.TabIndex = 4;
            this.tabPriest.Text = "Priest";
            this.tabPriest.UseVisualStyleBackColor = true;
            // 
            // gridParty
            // 
            this.gridParty.AllowUserToAddRows = false;
            this.gridParty.AllowUserToDeleteRows = false;
            this.gridParty.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridParty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridParty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartyName,
            this.PartyHp,
            this.PartyMaxHp,
            this.PartyLevel});
            this.gridParty.Location = new System.Drawing.Point(0, 274);
            this.gridParty.MultiSelect = false;
            this.gridParty.Name = "gridParty";
            this.gridParty.ReadOnly = true;
            this.gridParty.RowHeadersVisible = false;
            this.gridParty.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridParty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridParty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParty.ShowCellErrors = false;
            this.gridParty.ShowCellToolTips = false;
            this.gridParty.ShowEditingIcon = false;
            this.gridParty.Size = new System.Drawing.Size(339, 230);
            this.gridParty.TabIndex = 10;
            // 
            // PartyName
            // 
            this.PartyName.FillWeight = 150F;
            this.PartyName.HeaderText = "İsim";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            this.PartyName.Width = 150;
            // 
            // PartyHp
            // 
            this.PartyHp.FillWeight = 70F;
            this.PartyHp.HeaderText = "HP";
            this.PartyHp.Name = "PartyHp";
            this.PartyHp.ReadOnly = true;
            this.PartyHp.Width = 70;
            // 
            // PartyMaxHp
            // 
            this.PartyMaxHp.FillWeight = 70F;
            this.PartyMaxHp.HeaderText = "MaxHP";
            this.PartyMaxHp.Name = "PartyMaxHp";
            this.PartyMaxHp.ReadOnly = true;
            this.PartyMaxHp.Width = 70;
            // 
            // PartyLevel
            // 
            this.PartyLevel.FillWeight = 50F;
            this.PartyLevel.HeaderText = "Level";
            this.PartyLevel.Name = "PartyLevel";
            this.PartyLevel.ReadOnly = true;
            this.PartyLevel.Width = 50;
            // 
            // cmbAc
            // 
            this.cmbAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAc.FormattingEnabled = true;
            this.cmbAc.Location = new System.Drawing.Point(211, 71);
            this.cmbAc.Name = "cmbAc";
            this.cmbAc.Size = new System.Drawing.Size(123, 21);
            this.cmbAc.TabIndex = 9;
            // 
            // cmbBuff
            // 
            this.cmbBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBuff.FormattingEnabled = true;
            this.cmbBuff.Location = new System.Drawing.Point(211, 44);
            this.cmbBuff.Name = "cmbBuff";
            this.cmbBuff.Size = new System.Drawing.Size(123, 21);
            this.cmbBuff.TabIndex = 9;
            // 
            // cmbHeal
            // 
            this.cmbHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHeal.FormattingEnabled = true;
            this.cmbHeal.Location = new System.Drawing.Point(254, 17);
            this.cmbHeal.Name = "cmbHeal";
            this.cmbHeal.Size = new System.Drawing.Size(80, 21);
            this.cmbHeal.TabIndex = 9;
            // 
            // chkAc
            // 
            this.chkAc.AutoSize = true;
            this.chkAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAc.Location = new System.Drawing.Point(155, 75);
            this.chkAc.Name = "chkAc";
            this.chkAc.Size = new System.Drawing.Size(35, 17);
            this.chkAc.TabIndex = 7;
            this.chkAc.Text = "AC";
            this.chkAc.UseVisualStyleBackColor = true;
            // 
            // txtHeal
            // 
            this.txtHeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeal.Location = new System.Drawing.Point(211, 17);
            this.txtHeal.Name = "txtHeal";
            this.txtHeal.Size = new System.Drawing.Size(37, 20);
            this.txtHeal.TabIndex = 8;
            this.txtHeal.Text = "70";
            // 
            // chkBuff
            // 
            this.chkBuff.AutoSize = true;
            this.chkBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBuff.Location = new System.Drawing.Point(155, 46);
            this.chkBuff.Name = "chkBuff";
            this.chkBuff.Size = new System.Drawing.Size(47, 17);
            this.chkBuff.TabIndex = 7;
            this.chkBuff.Text = "Buff";
            this.chkBuff.UseVisualStyleBackColor = true;
            // 
            // chkRealize
            // 
            this.chkRealize.AutoSize = true;
            this.chkRealize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRealize.Location = new System.Drawing.Point(155, 144);
            this.chkRealize.Name = "chkRealize";
            this.chkRealize.Size = new System.Drawing.Size(77, 17);
            this.chkRealize.TabIndex = 7;
            this.chkRealize.Text = "Anti Koxp";
            this.chkRealize.UseVisualStyleBackColor = true;
            this.chkRealize.CheckedChanged += new System.EventHandler(this.ChkRealize_CheckedChanged);
            // 
            // chkLowerLife
            // 
            this.chkLowerLife.AutoSize = true;
            this.chkLowerLife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLowerLife.Location = new System.Drawing.Point(155, 121);
            this.chkLowerLife.Name = "chkLowerLife";
            this.chkLowerLife.Size = new System.Drawing.Size(137, 17);
            this.chkLowerLife.TabIndex = 7;
            this.chkLowerLife.Text = "Düşük Can Öncelikli";
            this.chkLowerLife.UseVisualStyleBackColor = true;
            // 
            // chkCure
            // 
            this.chkCure.AutoSize = true;
            this.chkCure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCure.Location = new System.Drawing.Point(155, 98);
            this.chkCure.Name = "chkCure";
            this.chkCure.Size = new System.Drawing.Size(71, 17);
            this.chkCure.TabIndex = 7;
            this.chkCure.Text = "Oto Cure";
            this.chkCure.UseVisualStyleBackColor = true;
            // 
            // chkHeal
            // 
            this.chkHeal.AutoSize = true;
            this.chkHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHeal.Location = new System.Drawing.Point(155, 19);
            this.chkHeal.Name = "chkHeal";
            this.chkHeal.Size = new System.Drawing.Size(47, 17);
            this.chkHeal.TabIndex = 7;
            this.chkHeal.Text = "Heal";
            this.chkHeal.UseVisualStyleBackColor = true;
            // 
            // lstPriest
            // 
            this.lstPriest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPriest.FormattingEnabled = true;
            this.lstPriest.Location = new System.Drawing.Point(0, 0);
            this.lstPriest.Name = "lstPriest";
            this.lstPriest.Size = new System.Drawing.Size(145, 227);
            this.lstPriest.TabIndex = 1;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.txtLog);
            this.tabOther.Controls.Add(this.txtCustomPacket);
            this.tabOther.Controls.Add(this.btnSendCustomPacket);
            this.tabOther.Location = new System.Drawing.Point(4, 25);
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size(342, 507);
            this.tabOther.TabIndex = 3;
            this.tabOther.Text = "Diğer";
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(0, 50);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(342, 454);
            this.txtLog.TabIndex = 6;
            // 
            // txtCustomPacket
            // 
            this.txtCustomPacket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomPacket.Location = new System.Drawing.Point(62, 0);
            this.txtCustomPacket.Multiline = true;
            this.txtCustomPacket.Name = "txtCustomPacket";
            this.txtCustomPacket.Size = new System.Drawing.Size(280, 46);
            this.txtCustomPacket.TabIndex = 0;
            // 
            // btnSendCustomPacket
            // 
            this.btnSendCustomPacket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCustomPacket.Location = new System.Drawing.Point(0, 1);
            this.btnSendCustomPacket.Margin = new System.Windows.Forms.Padding(1);
            this.btnSendCustomPacket.Name = "btnSendCustomPacket";
            this.btnSendCustomPacket.Size = new System.Drawing.Size(58, 45);
            this.btnSendCustomPacket.TabIndex = 5;
            this.btnSendCustomPacket.Text = "Send";
            this.btnSendCustomPacket.UseVisualStyleBackColor = true;
            this.btnSendCustomPacket.Click += new System.EventHandler(this.BtnSendCustomPacket_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(4, 566);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(1);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(217, 33);
            this.btnAttack.TabIndex = 5;
            this.btnAttack.Text = "Atak Başlat";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(223, 566);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tmrAttack
            // 
            this.tmrAttack.Interval = 1500;
            this.tmrAttack.Tick += new System.EventHandler(this.TmrAttack_Tick);
            // 
            // tmrPotion
            // 
            this.tmrPotion.Enabled = true;
            this.tmrPotion.Interval = 2000;
            this.tmrPotion.Tick += new System.EventHandler(this.TmrPotion_Tick);
            // 
            // tmrCharInfo
            // 
            this.tmrCharInfo.Interval = 1000;
            this.tmrCharInfo.Tick += new System.EventHandler(this.TmrCharInfo_Tick);
            // 
            // tmrTargetInfo
            // 
            this.tmrTargetInfo.Interval = 1000;
            this.tmrTargetInfo.Tick += new System.EventHandler(this.TmrTargetInfo_Tick);
            // 
            // tmrParty
            // 
            this.tmrParty.Tick += new System.EventHandler(this.TmrParty_Tick);
            // 
            // tmrSelectMob
            // 
            this.tmrSelectMob.Interval = 500;
            this.tmrSelectMob.Tick += new System.EventHandler(this.TmrSelectMob_Tick);
            // 
            // tmrRAttack
            // 
            this.tmrRAttack.Interval = 900;
            this.tmrRAttack.Tick += new System.EventHandler(this.TmrRAttack_Tick);
            // 
            // tmrSelf
            // 
            this.tmrSelf.Interval = 1300;
            this.tmrSelf.Tick += new System.EventHandler(this.TmrSelf_Tick);
            // 
            // tmrPriest
            // 
            this.tmrPriest.Interval = 2000;
            this.tmrPriest.Tick += new System.EventHandler(this.TmrPriest_Tick);
            // 
            // tmrLoot
            // 
            this.tmrLoot.Enabled = true;
            this.tmrLoot.Interval = 1000;
            this.tmrLoot.Tick += new System.EventHandler(this.TmrLoot_Tick);
            // 
            // tmrDc
            // 
            this.tmrDc.Interval = 1000;
            this.tmrDc.Tick += new System.EventHandler(this.TmrDc_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 603);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cmbClientSelect);
            this.Controls.Add(this._Minimize);
            this.Controls.Add(this._Close);
            this.Controls.Add(this.chkAlwaysTop);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.tabGenel.ResumeLayout(false);
            this.tabGenel.PerformLayout();
            this.pnlCharInfo.ResumeLayout(false);
            this.pnlCharInfo.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabAttack.ResumeLayout(false);
            this.tabAttack.PerformLayout();
            this.pnlTargetInfo.ResumeLayout(false);
            this.pnlTargetInfo.PerformLayout();
            this.tabPriest.ResumeLayout(false);
            this.tabPriest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParty)).EndInit();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAlwaysTop;
        private System.Windows.Forms.Label _Close;
        private System.Windows.Forms.Label _Minimize;
        private System.Windows.Forms.ComboBox cmbClientSelect;
        private System.Windows.Forms.TabPage tabGenel;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAttack;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Timer tmrAttack;
        private System.Windows.Forms.TextBox txtMp;
        private System.Windows.Forms.CheckBox chkMp;
        private System.Windows.Forms.TextBox txtHp;
        private System.Windows.Forms.CheckBox chkHp;
        private System.Windows.Forms.Timer tmrPotion;
        private System.Windows.Forms.TextBox txtEscape;
        private System.Windows.Forms.CheckBox chkEscape;
        private System.Windows.Forms.ComboBox cmbTs;
        private System.Windows.Forms.CheckBox chkAutoParty;
        private System.Windows.Forms.CheckBox chkWallHack;
        private System.Windows.Forms.TextBox txtAttackSpeed;
        private System.Windows.Forms.CheckBox chkCz;
        private System.Windows.Forms.CheckBox chkRAttack;
        private System.Windows.Forms.CheckBox chkMobSelect;
        private System.Windows.Forms.CheckedListBox lstAttack;
        private System.Windows.Forms.ComboBox cmbMpPot;
        private System.Windows.Forms.ComboBox cmbHpPot;
        private System.Windows.Forms.Label lblTakeCenter;
        private System.Windows.Forms.CheckBox chkBackToCenter;
        private System.Windows.Forms.CheckBox chkRunToMob;
        private System.Windows.Forms.CheckedListBox lstSelf;
        private System.Windows.Forms.TabPage tabPriest;
        private System.Windows.Forms.ComboBox cmbHeal;
        private System.Windows.Forms.TextBox txtHeal;
        private System.Windows.Forms.CheckBox chkHeal;
        private System.Windows.Forms.CheckedListBox lstPriest;
        private System.Windows.Forms.CheckBox chkTs;
        private System.Windows.Forms.TextBox txtMinorTime;
        private System.Windows.Forms.TextBox txtMinor;
        private System.Windows.Forms.CheckBox chkMinor;
        private System.Windows.Forms.ComboBox cmbAc;
        private System.Windows.Forms.ComboBox cmbBuff;
        private System.Windows.Forms.CheckBox chkAc;
        private System.Windows.Forms.CheckBox chkBuff;
        private System.Windows.Forms.CheckBox chkCure;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtCustomPacket;
        private System.Windows.Forms.Button btnSendCustomPacket;
        private System.Windows.Forms.DataGridView gridParty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyMaxHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyLevel;
        private System.Windows.Forms.Panel pnlCharInfo;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCoordinate;
        private System.Windows.Forms.Label lblLeftDurability;
        private System.Windows.Forms.Label lblWallHack;
        private System.Windows.Forms.Label lblRightDurability;
        private System.Windows.Forms.Label lblMp;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Timer tmrCharInfo;
        private System.Windows.Forms.Panel pnlTargetInfo;
        private System.Windows.Forms.Label lblTargetId;
        private System.Windows.Forms.Label lblTargetDistance;
        private System.Windows.Forms.Label lblTargetCoordinate;
        private System.Windows.Forms.Label lblTargetHp;
        private System.Windows.Forms.Label lblTargetName;
        private System.Windows.Forms.Timer tmrTargetInfo;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.CheckBox chkTP;
        private System.Windows.Forms.Timer tmrParty;
        private System.Windows.Forms.Timer tmrSelectMob;
        private System.Windows.Forms.TextBox txtRAttack;
        private System.Windows.Forms.Timer tmrRAttack;
        private System.Windows.Forms.Timer tmrSelf;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer tmrPriest;
        private System.Windows.Forms.CheckBox chkLowerLife;
        private System.Windows.Forms.CheckBox chkLoot;
        private System.Windows.Forms.Timer tmrLoot;
        private System.Windows.Forms.Timer tmrDc;
        private System.Windows.Forms.CheckBox chkRealize;
    }
}

