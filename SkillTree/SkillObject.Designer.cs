namespace SkillTree
{
    partial class SkillObject
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SkillImage = new System.Windows.Forms.PictureBox();
            this.SkillPointText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SkillImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SkillImage
            // 
            this.SkillImage.Image = global::SkillTree.Properties.Resources.AmazonMagicArrow;
            this.SkillImage.Location = new System.Drawing.Point(0, 0);
            this.SkillImage.Name = "SkillImage";
            this.SkillImage.Size = new System.Drawing.Size(47, 39);
            this.SkillImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SkillImage.TabIndex = 0;
            this.SkillImage.TabStop = false;
            this.SkillImage.Click += new System.EventHandler(this.SkillImage_Click);
            this.SkillImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SkillImage_MouseDown);
            this.SkillImage.MouseLeave += new System.EventHandler(this.SkillImage_MouseLeave);
            this.SkillImage.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.SkillImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SkillImage_MouseUp);
            // 
            // SkillPointText
            // 
            this.SkillPointText.Font = new System.Drawing.Font("HY견고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SkillPointText.Location = new System.Drawing.Point(46, 38);
            this.SkillPointText.Name = "SkillPointText";
            this.SkillPointText.Size = new System.Drawing.Size(24, 22);
            this.SkillPointText.TabIndex = 1;
            this.SkillPointText.Text = "0";
            // 
            // SkillObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkillPointText);
            this.Controls.Add(this.SkillImage);
            this.Name = "SkillObject";
            this.Size = new System.Drawing.Size(72, 61);
            this.Load += new System.EventHandler(this.SkillObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkillImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SkillPointText;
        public System.Windows.Forms.PictureBox SkillImage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
