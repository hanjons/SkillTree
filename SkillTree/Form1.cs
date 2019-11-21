using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum JobClass
{
	Amazon,
	Babarian,
	Sorceress,
}

public struct Skill
{
	public string skillName;
	public int skillNumber;
	public string skillNotification;
	public int skillLevel;
	public int damege;
	public int manaCost;
	public int parentsSkillNumber;

	public Skill(string skillName, int skillNumber, string skillNotification, int skillLevel, int damege, int manaCost, int parentsSkillNumber)
	{
		this.skillName = skillName;
		this.skillNumber = skillNumber;
		this.skillNotification = skillNotification;
		this.skillLevel = skillLevel;
		this.damege = damege;
		this.manaCost = manaCost;
		this.parentsSkillNumber = parentsSkillNumber;
	}
}



public struct status
{
    public int level;
    public int str;
    public int dex;
    public int vitalty;
    public int energy;
    public string jobclass;
    public int statPoint;
    public int skillPoint;
    public int Atk;
    public int AtkRating;
    public int helth;
    public int mana;
}

namespace SkillTree
{
	public delegate void Update(object sender, EventArgs e, string a_SkillName);

	public partial class Form1 : Form
    {
		public static status playerStat;
		public static Skill[] SkillOfAmazon = new Skill[10];
		public Form1 frm { get { return this; } }

		public Form1()
        {
            InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
        {
			AmazonSkill1.Visible = false;
			babarianSkill1.Visible = false;
			sorceressSkill1.Visible = false;
			playerStat.level = 1;
			InitAmazonSkilltree();
			AmazonSkill1.OnUpdate += new Update(this.UpdateHandler);
            babarianSkill1.OnUpdate += new Update(this.UpdateHandler);
		}
	

		private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
		{
            UpdateSkill(a_SkillName);
            statUpdate();
        }

        public void UpdateSkill(string a_SkillName)
		{
            for (int i = 0; i < SkillOfAmazon.Length; i++)
            {
                if (SkillOfAmazon[i].skillName == a_SkillName)
                {
                    
                    SkillDamegePoint.Text = (SkillOfAmazon[i].damege * playerStat.dex).ToString();
                    CostbySkill.Text = (playerStat.mana / SkillOfAmazon[i].manaCost).ToString();
                   
                }
            }
        }

        public void InitAmazonSkilltree()
		{
			SkillOfAmazon[0] = (new Skill("MagicArrow", 1, "마법화살발사", 0, 2, 2, 9));
			SkillOfAmazon[1] = (new Skill("FireArrow", 2, "화염화살발사", 0, 2, 2, 9));
			SkillOfAmazon[2] = (new Skill("ColdArrow", 3, "얼음화살발사", 0, 2, 2, 9));
			SkillOfAmazon[3] = (new Skill("MultyArrow", 4, "다발사격", 0, 4, 3, 0));
			SkillOfAmazon[4] = (new Skill("ExplodingArrow", 5, "폭발화살발사", 0, 4, 3, 1));
			SkillOfAmazon[5] = (new Skill("IceArrow", 6, "다중얼음화살발사", 0, 4, 3, 2));
			SkillOfAmazon[6] = (new Skill("GuideArrow", 7, "유도화살발사", 0, 5, 4, 3));
			SkillOfAmazon[7] = (new Skill("FireWallArrow", 8, "화염벽화살발사", 0, 10, 4, 4));
			SkillOfAmazon[8] = (new Skill("SplitArrow", 9, "빠르게여러발사격", 0, 10, 10, 6));
			SkillOfAmazon[9] = (new Skill("FrozenArrow", 10, "주변의모든것을얼림", 0, 10, 10, 5));
			// 2 → 5 → 8        // 파이어스킬트리 순서
			// 1 → 4 → 7 → 9    //물리스킬트리 순서
			// 3 → 6 → 10       //아이스 스킬트리 순서
		}

		

		private void SetSkillTree(JobClass jobName)
		{
			switch (jobName)
			{
				case JobClass.Amazon:
                    AmazonSkill1.Visible = true;
					babarianSkill1.Visible = false;
					sorceressSkill1.Visible = false;
					Initstat(jobName);
                    InitAmazonSkilltree();
					break;
				case JobClass.Babarian:
                    AmazonSkill1.Visible = false;
					babarianSkill1.Visible = true;
					sorceressSkill1.Visible = false;
                    InitAmazonSkilltree();

                    Initstat(jobName);
					break;
				case JobClass.Sorceress:
                    AmazonSkill1.Visible = false;
					babarianSkill1.Visible = false;
					sorceressSkill1.Visible = true;
                    InitAmazonSkilltree();

                    Initstat(jobName);
					break;
				default:
					break;
			}
		}
	
		public void statUpdate()
		{
			//화면에 텍스트에 업데이트
			StrPoint.Text = playerStat.str.ToString();
			DexPoint.Text = playerStat.dex.ToString();
			VitalPoint.Text = playerStat.vitalty.ToString();
			EnergyPoint.Text = playerStat.energy.ToString();
			StatPoint.Text = playerStat.statPoint.ToString();
			SkillPoint.Text = playerStat.skillPoint.ToString();
			DamegePoint.Text = playerStat.Atk.ToString();
			AttRationPoint.Text = playerStat.AtkRating.ToString();
			SurvivePoint.Text = playerStat.helth.ToString();
			ManaPoint.Text = playerStat.mana.ToString();
			Level.Text = playerStat.level.ToString();
            
            
		}


		private void Initstat(JobClass jobName)
		{
            // 스텟 리셋 part1
			switch (jobName)
			{
				case JobClass.Amazon:
					resetStat(15, 25, 10, 5);
					statUpdate();
					break;
				case JobClass.Babarian:
					resetStat(25, 20, 10, 5);
					statUpdate();
					break;
				case JobClass.Sorceress:
					resetStat(5, 10, 10, 25);
					statUpdate();
					break;
				default:
					break;
			}
		}

		private void resetStat(int str, int dex, int vital, int energy)
		{
            //스텟 리셋 part2
			playerStat.str = str;
			playerStat.dex = dex;
			playerStat.vitalty = vital;
			playerStat.energy = energy;
			playerStat.level = 1;
			playerStat.skillPoint = 0;
			playerStat.statPoint = 0;
			setResultPoint();
            
		}

		private void setResultPoint()
		{
            //resultPoint 계산
			playerStat.Atk = playerStat.str * playerStat.dex;
			playerStat.AtkRating = playerStat.dex * 2;
			playerStat.helth = playerStat.vitalty * playerStat.dex;
			playerStat.mana = playerStat.energy * 3;
            
		}

		private void setStatPoint(int str, int dex, int vita, int energy)
		{
            //스탯 찍으면 포인트 반영
			if (playerStat.statPoint != 0)
			{
				playerStat.str += str;
				playerStat.dex += dex;
				playerStat.vitalty += vita;
				playerStat.energy += energy;
				playerStat.statPoint -= 1;
				setResultPoint();
				statUpdate();
			}
		}

        private void LevelUpButton_Click(object sender, EventArgs e)
		{
			if (playerStat.level < 99)
			{
				playerStat.skillPoint += 1;
				playerStat.statPoint += 5;
				playerStat.level += 1;
				statUpdate();
            }
			
		}

		private void strPlusbutton_Click(object sender, EventArgs e)
		{
			setStatPoint(1, 0, 0, 0);
		}

		private void dexPlusbutton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 1, 0, 0);
		}

		private void vitaPlusButton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 0, 1, 0);
		}

		private void EnergyPlusButton_Click(object sender, EventArgs e)
		{
			setStatPoint(0, 0, 0, 1);
		}


		private void SelectButtonAmazon_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Amazon);
		}

		private void SelectButtonBabarian_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Babarian);
		}

		private void SelectButtonSor_CheckedChanged(object sender, EventArgs e)
		{
			SetSkillTree(JobClass.Sorceress);
		}

     
    }


}
