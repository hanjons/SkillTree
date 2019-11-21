namespace SkillTree
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SelectButtonAmazon = new System.Windows.Forms.RadioButton();
            this.SelectButtonBabarian = new System.Windows.Forms.RadioButton();
            this.SelectButtonSor = new System.Windows.Forms.RadioButton();
            this.GroupSkillTree = new System.Windows.Forms.GroupBox();
            this.PlayerStatGroup = new System.Windows.Forms.GroupBox();
            this.EnergyPlusButton = new System.Windows.Forms.Button();
            this.vitaPlusButton = new System.Windows.Forms.Button();
            this.dexPlusbutton = new System.Windows.Forms.Button();
            this.strPlusbutton = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.LevelUpButton = new System.Windows.Forms.Button();
            this.EnergyPoint = new System.Windows.Forms.Label();
            this.VitalPoint = new System.Windows.Forms.Label();
            this.DexPoint = new System.Windows.Forms.Label();
            this.StatPoint = new System.Windows.Forms.Label();
            this.SkillPoint = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.StrPoint = new System.Windows.Forms.Label();
            this.labelStatPoint = new System.Windows.Forms.Label();
            this.labelSkillPoint = new System.Windows.Forms.Label();
            this.labelEnergy = new System.Windows.Forms.Label();
            this.labelVital = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.GameDataGroup = new System.Windows.Forms.GroupBox();
            this.labelMana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectSkillDamege = new System.Windows.Forms.Label();
            this.labelDamege = new System.Windows.Forms.Label();
            this.ManaPoint = new System.Windows.Forms.Label();
            this.labelAttRating = new System.Windows.Forms.Label();
            this.SurvivePoint = new System.Windows.Forms.Label();
            this.labelSurvive = new System.Windows.Forms.Label();
            this.AttRationPoint = new System.Windows.Forms.Label();
            this.CostbySkill = new System.Windows.Forms.Label();
            this.SkillDamegePoint = new System.Windows.Forms.Label();
            this.DamegePoint = new System.Windows.Forms.Label();
            this.Testlabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AmazonSkill1 = new SkillTree.AmazonSkill();
            this.sorceressSkill1 = new SkillTree.SorceressSkill();
            this.babarianSkill1 = new SkillTree.BabarianSkill();
            this.GroupSkillTree.SuspendLayout();
            this.PlayerStatGroup.SuspendLayout();
            this.GameDataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectButtonAmazon
            // 
            this.SelectButtonAmazon.AutoSize = true;
            this.SelectButtonAmazon.Location = new System.Drawing.Point(24, 23);
            this.SelectButtonAmazon.Name = "SelectButtonAmazon";
            this.SelectButtonAmazon.Size = new System.Drawing.Size(70, 16);
            this.SelectButtonAmazon.TabIndex = 0;
            this.SelectButtonAmazon.TabStop = true;
            this.SelectButtonAmazon.Text = "Amazon";
            this.SelectButtonAmazon.UseVisualStyleBackColor = true;
            this.SelectButtonAmazon.CheckedChanged += new System.EventHandler(this.SelectButtonAmazon_CheckedChanged);
            // 
            // SelectButtonBabarian
            // 
            this.SelectButtonBabarian.AutoSize = true;
            this.SelectButtonBabarian.Location = new System.Drawing.Point(100, 23);
            this.SelectButtonBabarian.Name = "SelectButtonBabarian";
            this.SelectButtonBabarian.Size = new System.Drawing.Size(73, 16);
            this.SelectButtonBabarian.TabIndex = 1;
            this.SelectButtonBabarian.TabStop = true;
            this.SelectButtonBabarian.Text = "Babarian";
            this.SelectButtonBabarian.UseVisualStyleBackColor = true;
            this.SelectButtonBabarian.CheckedChanged += new System.EventHandler(this.SelectButtonBabarian_CheckedChanged);
            // 
            // SelectButtonSor
            // 
            this.SelectButtonSor.AutoSize = true;
            this.SelectButtonSor.Location = new System.Drawing.Point(179, 22);
            this.SelectButtonSor.Name = "SelectButtonSor";
            this.SelectButtonSor.Size = new System.Drawing.Size(81, 16);
            this.SelectButtonSor.TabIndex = 4;
            this.SelectButtonSor.TabStop = true;
            this.SelectButtonSor.Text = "Sorceress";
            this.SelectButtonSor.UseVisualStyleBackColor = true;
            this.SelectButtonSor.CheckedChanged += new System.EventHandler(this.SelectButtonSor_CheckedChanged);
            // 
            // GroupSkillTree
            // 
            this.GroupSkillTree.Controls.Add(this.AmazonSkill1);
            this.GroupSkillTree.Controls.Add(this.sorceressSkill1);
            this.GroupSkillTree.Controls.Add(this.babarianSkill1);
            this.GroupSkillTree.Location = new System.Drawing.Point(34, 59);
            this.GroupSkillTree.Name = "GroupSkillTree";
            this.GroupSkillTree.Size = new System.Drawing.Size(485, 562);
            this.GroupSkillTree.TabIndex = 6;
            this.GroupSkillTree.TabStop = false;
            this.GroupSkillTree.Text = "SkillTree";
            // 
            // PlayerStatGroup
            // 
            this.PlayerStatGroup.Controls.Add(this.EnergyPlusButton);
            this.PlayerStatGroup.Controls.Add(this.vitaPlusButton);
            this.PlayerStatGroup.Controls.Add(this.dexPlusbutton);
            this.PlayerStatGroup.Controls.Add(this.strPlusbutton);
            this.PlayerStatGroup.Controls.Add(this.labelLevel);
            this.PlayerStatGroup.Controls.Add(this.LevelUpButton);
            this.PlayerStatGroup.Controls.Add(this.EnergyPoint);
            this.PlayerStatGroup.Controls.Add(this.VitalPoint);
            this.PlayerStatGroup.Controls.Add(this.DexPoint);
            this.PlayerStatGroup.Controls.Add(this.StatPoint);
            this.PlayerStatGroup.Controls.Add(this.SkillPoint);
            this.PlayerStatGroup.Controls.Add(this.Level);
            this.PlayerStatGroup.Controls.Add(this.StrPoint);
            this.PlayerStatGroup.Controls.Add(this.labelStatPoint);
            this.PlayerStatGroup.Controls.Add(this.labelSkillPoint);
            this.PlayerStatGroup.Controls.Add(this.labelEnergy);
            this.PlayerStatGroup.Controls.Add(this.labelVital);
            this.PlayerStatGroup.Controls.Add(this.labelDex);
            this.PlayerStatGroup.Controls.Add(this.labelStr);
            this.PlayerStatGroup.Location = new System.Drawing.Point(544, 59);
            this.PlayerStatGroup.Name = "PlayerStatGroup";
            this.PlayerStatGroup.Size = new System.Drawing.Size(305, 178);
            this.PlayerStatGroup.TabIndex = 7;
            this.PlayerStatGroup.TabStop = false;
            this.PlayerStatGroup.Text = "PlayerStat";
            // 
            // EnergyPlusButton
            // 
            this.EnergyPlusButton.BackColor = System.Drawing.Color.Red;
            this.EnergyPlusButton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnergyPlusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnergyPlusButton.Location = new System.Drawing.Point(150, 83);
            this.EnergyPlusButton.Name = "EnergyPlusButton";
            this.EnergyPlusButton.Size = new System.Drawing.Size(28, 22);
            this.EnergyPlusButton.TabIndex = 9;
            this.EnergyPlusButton.Text = "+";
            this.EnergyPlusButton.UseVisualStyleBackColor = false;
            this.EnergyPlusButton.Click += new System.EventHandler(this.EnergyPlusButton_Click);
            // 
            // vitaPlusButton
            // 
            this.vitaPlusButton.BackColor = System.Drawing.Color.Red;
            this.vitaPlusButton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vitaPlusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vitaPlusButton.Location = new System.Drawing.Point(150, 55);
            this.vitaPlusButton.Name = "vitaPlusButton";
            this.vitaPlusButton.Size = new System.Drawing.Size(28, 22);
            this.vitaPlusButton.TabIndex = 9;
            this.vitaPlusButton.Text = "+";
            this.vitaPlusButton.UseVisualStyleBackColor = false;
            this.vitaPlusButton.Click += new System.EventHandler(this.vitaPlusButton_Click);
            // 
            // dexPlusbutton
            // 
            this.dexPlusbutton.BackColor = System.Drawing.Color.Red;
            this.dexPlusbutton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dexPlusbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dexPlusbutton.Location = new System.Drawing.Point(22, 83);
            this.dexPlusbutton.Name = "dexPlusbutton";
            this.dexPlusbutton.Size = new System.Drawing.Size(28, 22);
            this.dexPlusbutton.TabIndex = 9;
            this.dexPlusbutton.Text = "+";
            this.dexPlusbutton.UseVisualStyleBackColor = false;
            this.dexPlusbutton.Click += new System.EventHandler(this.dexPlusbutton_Click);
            // 
            // strPlusbutton
            // 
            this.strPlusbutton.BackColor = System.Drawing.Color.Red;
            this.strPlusbutton.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.strPlusbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strPlusbutton.Location = new System.Drawing.Point(22, 55);
            this.strPlusbutton.Name = "strPlusbutton";
            this.strPlusbutton.Size = new System.Drawing.Size(28, 22);
            this.strPlusbutton.TabIndex = 8;
            this.strPlusbutton.Text = "+";
            this.strPlusbutton.UseVisualStyleBackColor = false;
            this.strPlusbutton.Click += new System.EventHandler(this.strPlusbutton_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(50, 26);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(35, 12);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "Level";
            // 
            // LevelUpButton
            // 
            this.LevelUpButton.Location = new System.Drawing.Point(186, 20);
            this.LevelUpButton.Name = "LevelUpButton";
            this.LevelUpButton.Size = new System.Drawing.Size(83, 24);
            this.LevelUpButton.TabIndex = 6;
            this.LevelUpButton.Text = "LevelUP";
            this.LevelUpButton.UseVisualStyleBackColor = true;
            this.LevelUpButton.Click += new System.EventHandler(this.LevelUpButton_Click);
            // 
            // EnergyPoint
            // 
            this.EnergyPoint.AutoSize = true;
            this.EnergyPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EnergyPoint.Location = new System.Drawing.Point(250, 90);
            this.EnergyPoint.Name = "EnergyPoint";
            this.EnergyPoint.Size = new System.Drawing.Size(19, 12);
            this.EnergyPoint.TabIndex = 5;
            this.EnergyPoint.Text = "20";
            // 
            // VitalPoint
            // 
            this.VitalPoint.AutoSize = true;
            this.VitalPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VitalPoint.Location = new System.Drawing.Point(250, 60);
            this.VitalPoint.Name = "VitalPoint";
            this.VitalPoint.Size = new System.Drawing.Size(19, 12);
            this.VitalPoint.TabIndex = 5;
            this.VitalPoint.Text = "20";
            // 
            // DexPoint
            // 
            this.DexPoint.AutoSize = true;
            this.DexPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DexPoint.Location = new System.Drawing.Point(119, 90);
            this.DexPoint.Name = "DexPoint";
            this.DexPoint.Size = new System.Drawing.Size(19, 12);
            this.DexPoint.TabIndex = 5;
            this.DexPoint.Text = "20";
            // 
            // StatPoint
            // 
            this.StatPoint.AutoSize = true;
            this.StatPoint.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StatPoint.Location = new System.Drawing.Point(112, 139);
            this.StatPoint.Name = "StatPoint";
            this.StatPoint.Size = new System.Drawing.Size(17, 16);
            this.StatPoint.TabIndex = 5;
            this.StatPoint.Text = "1";
            // 
            // SkillPoint
            // 
            this.SkillPoint.AutoSize = true;
            this.SkillPoint.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SkillPoint.Location = new System.Drawing.Point(240, 139);
            this.SkillPoint.Name = "SkillPoint";
            this.SkillPoint.Size = new System.Drawing.Size(17, 16);
            this.SkillPoint.TabIndex = 5;
            this.SkillPoint.Text = "1";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Level.Location = new System.Drawing.Point(101, 26);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(17, 16);
            this.Level.TabIndex = 5;
            this.Level.Text = "1";
            // 
            // StrPoint
            // 
            this.StrPoint.AutoSize = true;
            this.StrPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StrPoint.Location = new System.Drawing.Point(119, 60);
            this.StrPoint.Name = "StrPoint";
            this.StrPoint.Size = new System.Drawing.Size(19, 12);
            this.StrPoint.TabIndex = 5;
            this.StrPoint.Text = "20";
            // 
            // labelStatPoint
            // 
            this.labelStatPoint.AutoSize = true;
            this.labelStatPoint.Location = new System.Drawing.Point(32, 143);
            this.labelStatPoint.Name = "labelStatPoint";
            this.labelStatPoint.Size = new System.Drawing.Size(65, 12);
            this.labelStatPoint.TabIndex = 4;
            this.labelStatPoint.Text = "스탯포인트";
            // 
            // labelSkillPoint
            // 
            this.labelSkillPoint.AutoSize = true;
            this.labelSkillPoint.Location = new System.Drawing.Point(160, 143);
            this.labelSkillPoint.Name = "labelSkillPoint";
            this.labelSkillPoint.Size = new System.Drawing.Size(65, 12);
            this.labelSkillPoint.TabIndex = 4;
            this.labelSkillPoint.Text = "스킬포인트";
            // 
            // labelEnergy
            // 
            this.labelEnergy.AutoSize = true;
            this.labelEnergy.Location = new System.Drawing.Point(184, 88);
            this.labelEnergy.Name = "labelEnergy";
            this.labelEnergy.Size = new System.Drawing.Size(41, 12);
            this.labelEnergy.TabIndex = 3;
            this.labelEnergy.Text = "에너지";
            // 
            // labelVital
            // 
            this.labelVital.AutoSize = true;
            this.labelVital.Location = new System.Drawing.Point(184, 60);
            this.labelVital.Name = "labelVital";
            this.labelVital.Size = new System.Drawing.Size(41, 12);
            this.labelVital.TabIndex = 2;
            this.labelVital.Text = "생명력";
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Location = new System.Drawing.Point(56, 90);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(29, 12);
            this.labelDex.TabIndex = 1;
            this.labelDex.Text = "민첩";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(68, 60);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(17, 12);
            this.labelStr.TabIndex = 0;
            this.labelStr.Text = "힘";
            // 
            // GameDataGroup
            // 
            this.GameDataGroup.Controls.Add(this.labelMana);
            this.GameDataGroup.Controls.Add(this.label1);
            this.GameDataGroup.Controls.Add(this.labelSelectSkillDamege);
            this.GameDataGroup.Controls.Add(this.labelDamege);
            this.GameDataGroup.Controls.Add(this.ManaPoint);
            this.GameDataGroup.Controls.Add(this.labelAttRating);
            this.GameDataGroup.Controls.Add(this.SurvivePoint);
            this.GameDataGroup.Controls.Add(this.labelSurvive);
            this.GameDataGroup.Controls.Add(this.AttRationPoint);
            this.GameDataGroup.Controls.Add(this.CostbySkill);
            this.GameDataGroup.Controls.Add(this.SkillDamegePoint);
            this.GameDataGroup.Controls.Add(this.DamegePoint);
            this.GameDataGroup.Location = new System.Drawing.Point(548, 269);
            this.GameDataGroup.Name = "GameDataGroup";
            this.GameDataGroup.Size = new System.Drawing.Size(300, 191);
            this.GameDataGroup.TabIndex = 8;
            this.GameDataGroup.TabStop = false;
            this.GameDataGroup.Text = "result";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Location = new System.Drawing.Point(46, 149);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(29, 12);
            this.labelMana.TabIndex = 3;
            this.labelMana.Text = "마나";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "연속사용횟수";
            // 
            // labelSelectSkillDamege
            // 
            this.labelSelectSkillDamege.AutoSize = true;
            this.labelSelectSkillDamege.Location = new System.Drawing.Point(165, 56);
            this.labelSelectSkillDamege.Name = "labelSelectSkillDamege";
            this.labelSelectSkillDamege.Size = new System.Drawing.Size(113, 12);
            this.labelSelectSkillDamege.TabIndex = 0;
            this.labelSelectSkillDamege.Text = "현재선택스킬데미지";
            // 
            // labelDamege
            // 
            this.labelDamege.AutoSize = true;
            this.labelDamege.Location = new System.Drawing.Point(16, 56);
            this.labelDamege.Name = "labelDamege";
            this.labelDamege.Size = new System.Drawing.Size(65, 12);
            this.labelDamege.TabIndex = 0;
            this.labelDamege.Text = "평타데미지";
            // 
            // ManaPoint
            // 
            this.ManaPoint.AutoSize = true;
            this.ManaPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManaPoint.Location = new System.Drawing.Point(103, 149);
            this.ManaPoint.Name = "ManaPoint";
            this.ManaPoint.Size = new System.Drawing.Size(19, 12);
            this.ManaPoint.TabIndex = 5;
            this.ManaPoint.Text = "20";
            // 
            // labelAttRating
            // 
            this.labelAttRating.AutoSize = true;
            this.labelAttRating.Location = new System.Drawing.Point(40, 86);
            this.labelAttRating.Name = "labelAttRating";
            this.labelAttRating.Size = new System.Drawing.Size(41, 12);
            this.labelAttRating.TabIndex = 1;
            this.labelAttRating.Text = "명중률";
            // 
            // SurvivePoint
            // 
            this.SurvivePoint.AutoSize = true;
            this.SurvivePoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SurvivePoint.Location = new System.Drawing.Point(103, 119);
            this.SurvivePoint.Name = "SurvivePoint";
            this.SurvivePoint.Size = new System.Drawing.Size(19, 12);
            this.SurvivePoint.TabIndex = 5;
            this.SurvivePoint.Text = "20";
            // 
            // labelSurvive
            // 
            this.labelSurvive.AutoSize = true;
            this.labelSurvive.Location = new System.Drawing.Point(40, 119);
            this.labelSurvive.Name = "labelSurvive";
            this.labelSurvive.Size = new System.Drawing.Size(41, 12);
            this.labelSurvive.TabIndex = 2;
            this.labelSurvive.Text = "생존력";
            // 
            // AttRationPoint
            // 
            this.AttRationPoint.AutoSize = true;
            this.AttRationPoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AttRationPoint.Location = new System.Drawing.Point(103, 86);
            this.AttRationPoint.Name = "AttRationPoint";
            this.AttRationPoint.Size = new System.Drawing.Size(19, 12);
            this.AttRationPoint.TabIndex = 5;
            this.AttRationPoint.Text = "20";
            // 
            // CostbySkill
            // 
            this.CostbySkill.AutoSize = true;
            this.CostbySkill.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CostbySkill.Location = new System.Drawing.Point(235, 141);
            this.CostbySkill.Name = "CostbySkill";
            this.CostbySkill.Size = new System.Drawing.Size(22, 21);
            this.CostbySkill.TabIndex = 5;
            this.CostbySkill.Text = "0";
            // 
            // SkillDamegePoint
            // 
            this.SkillDamegePoint.AutoSize = true;
            this.SkillDamegePoint.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SkillDamegePoint.Location = new System.Drawing.Point(208, 78);
            this.SkillDamegePoint.Name = "SkillDamegePoint";
            this.SkillDamegePoint.Size = new System.Drawing.Size(22, 21);
            this.SkillDamegePoint.TabIndex = 5;
            this.SkillDamegePoint.Text = "0";
            // 
            // DamegePoint
            // 
            this.DamegePoint.AutoSize = true;
            this.DamegePoint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DamegePoint.Location = new System.Drawing.Point(103, 56);
            this.DamegePoint.Name = "DamegePoint";
            this.DamegePoint.Size = new System.Drawing.Size(19, 12);
            this.DamegePoint.TabIndex = 5;
            this.DamegePoint.Text = "20";
            // 
            // Testlabel
            // 
            this.Testlabel.AutoSize = true;
            this.Testlabel.Location = new System.Drawing.Point(311, 27);
            this.Testlabel.Name = "Testlabel";
            this.Testlabel.Size = new System.Drawing.Size(0, 12);
            this.Testlabel.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.OwnerDraw = true;
            // 
            // AmazonSkill1
            // 
            this.AmazonSkill1.Location = new System.Drawing.Point(20, 38);
            this.AmazonSkill1.Name = "AmazonSkill1";
            this.AmazonSkill1.Size = new System.Drawing.Size(440, 492);
            this.AmazonSkill1.TabIndex = 0;
            // 
            // sorceressSkill1
            // 
            this.sorceressSkill1.Location = new System.Drawing.Point(20, 38);
            this.sorceressSkill1.Name = "sorceressSkill1";
            this.sorceressSkill1.Size = new System.Drawing.Size(440, 492);
            this.sorceressSkill1.TabIndex = 2;
            // 
            // babarianSkill1
            // 
            this.babarianSkill1.Location = new System.Drawing.Point(20, 26);
            this.babarianSkill1.Name = "babarianSkill1";
            this.babarianSkill1.Size = new System.Drawing.Size(440, 492);
            this.babarianSkill1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 633);
            this.Controls.Add(this.Testlabel);
            this.Controls.Add(this.GameDataGroup);
            this.Controls.Add(this.PlayerStatGroup);
            this.Controls.Add(this.GroupSkillTree);
            this.Controls.Add(this.SelectButtonSor);
            this.Controls.Add(this.SelectButtonBabarian);
            this.Controls.Add(this.SelectButtonAmazon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupSkillTree.ResumeLayout(false);
            this.PlayerStatGroup.ResumeLayout(false);
            this.PlayerStatGroup.PerformLayout();
            this.GameDataGroup.ResumeLayout(false);
            this.GameDataGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SelectButtonAmazon;
        private System.Windows.Forms.RadioButton SelectButtonBabarian;
        private System.Windows.Forms.RadioButton SelectButtonSor;
        private System.Windows.Forms.GroupBox GroupSkillTree;
        private System.Windows.Forms.GroupBox PlayerStatGroup;
        private System.Windows.Forms.Button LevelUpButton;
        private System.Windows.Forms.Label EnergyPoint;
        private System.Windows.Forms.Label VitalPoint;
        private System.Windows.Forms.Label DexPoint;
        private System.Windows.Forms.Label StrPoint;
        private System.Windows.Forms.Label labelSkillPoint;
        private System.Windows.Forms.Label labelEnergy;
        private System.Windows.Forms.Label labelVital;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label SkillPoint;
        private System.Windows.Forms.Label StatPoint;
        private System.Windows.Forms.Label labelStatPoint;
        private System.Windows.Forms.GroupBox GameDataGroup;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelDamege;
        private System.Windows.Forms.Label ManaPoint;
        private System.Windows.Forms.Label labelAttRating;
        private System.Windows.Forms.Label SurvivePoint;
        private System.Windows.Forms.Label labelSurvive;
        private System.Windows.Forms.Label AttRationPoint;
        private System.Windows.Forms.Label DamegePoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelectSkillDamege;
        private System.Windows.Forms.Label CostbySkill;
        private System.Windows.Forms.Label SkillDamegePoint;
		private AmazonSkill AmazonSkill1;
		private BabarianSkill babarianSkill1;
		private System.Windows.Forms.Label Testlabel;
		private SorceressSkill sorceressSkill1;
		private System.Windows.Forms.Button EnergyPlusButton;
		private System.Windows.Forms.Button vitaPlusButton;
		private System.Windows.Forms.Button dexPlusbutton;
		private System.Windows.Forms.Button strPlusbutton;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

