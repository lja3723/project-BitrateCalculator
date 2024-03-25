using System;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    /// <summary>
    ///     자식 폼을 생성하고 보여준다.
    /// </summary>
    internal class ChildForm
    {
        private readonly Form parent;

        public ChildForm(Form parent)
        {
            this.parent = parent;
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

        public void Show_SetDecimalPoint(ResultPrecision precision, Action programRefresher)
        {
            if (Form_소수점_설정.IsCreated) return;
            CreateChild(new Form_소수점_설정(programRefresher, precision));
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
