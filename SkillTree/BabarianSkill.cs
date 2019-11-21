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
	public partial class BabarianSkill : UserControl
	{
        public event Update OnUpdate;
        public BabarianSkill()
		{
			InitializeComponent();
		}

        private void UpdateHandler(object sender, EventArgs e, string a_SkillName)
        {
            if (OnUpdate != null)
            {
                OnUpdate(sender, e, a_SkillName);
            }
        }
    }
}
