using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillTree
{
	public partial class SkillObject : UserControl
    {
		AmazonSkill PForm;
		public event Update OnUpdate;

		[Category("userProperty"), Description("Skill")]
        public Image SkillBackImage
        {
            get
            {
                return this.SkillImage.Image;
            }
            set
            {
                this.SkillImage.Image = value;
            }
        }

        [Category("userProperty"), Description("Skill")]
        public string SetSkillPoints
        {
            get { return this.SkillPointText.Text; }
            set { this.SkillPointText.Text = value; }
        }

       

        public SkillObject()
        {
            InitializeComponent();
        }

		public void setAmazonClass(AmazonSkill Form)
		{
            // 테스트용 // 사용안함
			this.PForm = Form;
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

            foreach (var item in Form1.SkillOfAmazon)
            {
                if (item.skillName == this.Name)
                {
                    this.toolTip1.ToolTipTitle = item.skillName;
                    this.toolTip1.IsBalloon = true;
                    this.toolTip1.SetToolTip(this.SkillImage, item.skillNotification);
                }
            }
            
            

        }

        private void SkillImage_MouseLeave(object sender, EventArgs e)
        {

        }

        public void setTextBoxColor()
        {
            SkillPointText.BackColor = Color.White;
        }

        private void SkillImage_MouseDown(object sender, MouseEventArgs e)
        {
            this.SkillImage.BorderStyle = BorderStyle.FixedSingle;

        }

        private void SkillImage_MouseUp(object sender, MouseEventArgs e)
        {
            this.SkillImage.BorderStyle = BorderStyle.None;

        }

        private void SkillImage_Click(object sender, EventArgs e)
        {
            if (Form1.playerStat.skillPoint > 0)
            {
                for (int i = 0; i < Form1.SkillOfAmazon.Length; i++)
                {
                    int parentsNumber = Form1.SkillOfAmazon[i].parentsSkillNumber;
                    if (Form1.SkillOfAmazon[i].skillName == this.Name 
                        && (parentsNumber == 9 || Form1.SkillOfAmazon[parentsNumber].skillLevel >= 1)
                        && Form1.SkillOfAmazon[i].skillLevel < 20)
                    {

                        Form1.SkillOfAmazon[i].damege = Form1.SkillOfAmazon[i].skillLevel + Form1.SkillOfAmazon[i].damege;
                        Form1.SkillOfAmazon[i].manaCost = Form1.SkillOfAmazon[i].skillLevel + Form1.SkillOfAmazon[i].manaCost;
                        Form1.SkillOfAmazon[i].skillLevel += 1;
                        SkillPointText.BackColor = Color.Yellow;
                 
                        if (Form1.playerStat.skillPoint > 0)
                        {
                            Form1.playerStat.skillPoint -= 1;
                        }
                    }
                }

                foreach (var item in Form1.SkillOfAmazon)
                {
                    if (item.skillName == this.Name)
                    {
                        this.SkillPointText.Text = item.skillLevel.ToString();
                    }
                }
            }

            if (OnUpdate != null)
            {
                OnUpdate(sender, e, this.Name);
            }

          



        }
		
        private void SkillObject_Load(object sender, EventArgs e)
        {
            if (OnUpdate != null)
            {
                OnUpdate(sender, e, SkillImage.Name);
            }
           
        }
    }
}
