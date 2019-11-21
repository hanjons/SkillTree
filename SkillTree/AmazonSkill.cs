using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SkillTree
{
	public partial class AmazonSkill : UserControl
	{
      
		public event Update OnUpdate;

		public AmazonSkill()
		{
			InitializeComponent();
		}

		private void AmazonSkill_Load(object sender, EventArgs e)
		{
			MagicArrow.OnUpdate += new Update(UpdateHandler);
			FireArrow.OnUpdate += new Update(UpdateHandler);
            ColdArrow.OnUpdate += new Update(UpdateHandler);
            MultyArrow.OnUpdate += new Update(UpdateHandler);
            ExplodingArrow.OnUpdate += new Update(UpdateHandler);
            IceArrow.OnUpdate += new Update(UpdateHandler);
            GuideArrow.OnUpdate += new Update(UpdateHandler);
            FireWallArrow.OnUpdate += new Update(UpdateHandler);
            SplitArrow.OnUpdate += new Update(UpdateHandler);
            FrozenArrow.OnUpdate += new Update(UpdateHandler);
            
        }
        private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
		{
			if (OnUpdate != null)
			{
				OnUpdate(sender, e, a_SkillName);
			}
		}

        private void AmazonSkill_VisibleChanged(object sender, EventArgs e)
        {
            MagicArrow.SetSkillPoints = "0";
            FireArrow.SetSkillPoints = "0";
            ColdArrow.SetSkillPoints = "0";
            MultyArrow.SetSkillPoints = "0";
            ExplodingArrow.SetSkillPoints = "0";
            IceArrow.SetSkillPoints = "0";
            GuideArrow.SetSkillPoints = "0";
            FireWallArrow.SetSkillPoints = "0";
            SplitArrow.SetSkillPoints = "0";
            FrozenArrow.SetSkillPoints = "0";

            MagicArrow.setTextBoxColor();
            FireArrow.setTextBoxColor();
            ColdArrow.setTextBoxColor();
            MultyArrow.setTextBoxColor();
            ExplodingArrow.setTextBoxColor();
            IceArrow.setTextBoxColor();
            GuideArrow.setTextBoxColor();
            FireWallArrow.setTextBoxColor();
            SplitArrow.setTextBoxColor();
            FrozenArrow.setTextBoxColor();
        }
    }
}
