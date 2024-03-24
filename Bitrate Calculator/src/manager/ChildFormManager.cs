using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{

    internal class ChildFormManager
    {
        private readonly Form parent;
        private readonly ResultPrecisionManager resultPrecisionManager;

        public ChildFormManager(Form parent, ResultPrecisionManager resultPrecisionManager)
        {
            this.parent = parent;
            this.resultPrecisionManager = resultPrecisionManager;
        }

        public void Show_제작자_정보()
        {
            if (Form_제작자_정보.IsCreated) return;
            CreateChild(new Form_제작자_정보());
        }

        public void Show_프로그램_정보()
        {
            if (Form_프로그램_정보.IsCreated) return;
            CreateChild(new Form_프로그램_정보());
        }

        public void Show_SetDecimalPoint(Action programRefresher)
        {
            if (Form_소수점_설정.IsCreated) return;
            CreateChild(new Form_소수점_설정(programRefresher, resultPrecisionManager));
        }

        private void CreateChild(Form child)
        {
            child.Show(parent);
            int centerX = parent.Location.X + (parent.Size.Width - child.Size.Width) / 2;
            int centerY = parent.Location.Y + (parent.Size.Height - child.Size.Height) / 2;
            child.Location = new System.Drawing.Point(centerX, centerY);
        }
    }
}
