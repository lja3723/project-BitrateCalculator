using System.Drawing;
using System.Windows.Forms;

namespace Bitrate_Calculator.src
{

    internal class ChildFormManager
    {
        public void Show_제작자_및_도움(Form parent)
        {
            if (_Form_제작자_정보.IsCreated) return;
            CreateChild(parent, new _Form_제작자_정보());
        }

        public void Show_프로그램_정보(Form parent)
        {
            if (Form_프로그램_정보.IsCreated) return;
            CreateChild(parent, new Form_프로그램_정보());
        }

        public void Show_소수점_설정(Main_Form parent)
        {
            if (_Form_SetDecimalPoint.IsCreated) return;
            CreateChild(parent, new _Form_SetDecimalPoint(parent));
        }

        private void CreateChild(Form parent, Form child)
        {
            child.Show(parent);
            int centerX = parent.Location.X + (parent.Size.Width - child.Size.Width) / 2;
            int centerY = parent.Location.Y + (parent.Size.Height - child.Size.Height) / 2;
            child.Location = new Point(centerX, centerY);
        }
    }
}
