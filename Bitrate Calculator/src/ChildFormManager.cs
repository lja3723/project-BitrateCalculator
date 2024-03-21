using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{

    internal class ChildFormManager
    {
        private Form parent;
        private ResultPrecisionManager resultPrecisionManager;

        public ChildFormManager(Form parent, ResultPrecisionManager resultPrecisionManager)
        {
            this.parent = parent;
            this.resultPrecisionManager = resultPrecisionManager;
        }

        public void Show_제작자_정보()
        {
            if (_Form_제작자_정보.IsCreated) return;
            CreateChild(new _Form_제작자_정보());
        }

        public void Show_프로그램_정보()
        {
            if (Form_프로그램_정보.IsCreated) return;
            CreateChild(new Form_프로그램_정보());
        }

        public void Show_SetDecimalPoint(Action programRefresher)
        {
            if (_Form_SetDecimalPoint.IsCreated) return;
            CreateChild(new _Form_SetDecimalPoint(programRefresher, resultPrecisionManager));
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
