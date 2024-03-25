using System.Windows.Forms;

namespace Bitrate_Calculator.src
{
    /// <summary>
    ///     버튼이 기능에 접근할 수 있도록 한다.
    /// </summary>
    public class ButtonFunctionAccessor
    {
        private readonly ToolStripMenuItem applyConvertResolutionMenu;
        private readonly Button applyConvertResolutionButton;
        private readonly ToolStripMenuItem clearOriginVidFieldMenu;
        private readonly Button clearOriginVidFieldButton;
        private readonly ToolStripMenuItem clearAllMenu;
        private readonly Button clearAllButton;

        public bool ApplyConvertResolutionEnabled
        {
            get { return applyConvertResolutionMenu.Enabled; }
            set
            {
                applyConvertResolutionMenu.Enabled = value;
                applyConvertResolutionButton.Enabled = value;
            }
        }

        public bool ClearOriginVidFieldEnabled
        {
            get { return clearOriginVidFieldMenu.Enabled; }
            set
            {
                clearOriginVidFieldMenu.Enabled = value;
                clearOriginVidFieldButton.Enabled = value;
            }
        }
        public bool ClearAllEnabled
        {
            get { return clearAllMenu.Enabled; }
            set
            {
                clearAllMenu.Enabled = value;
                clearAllButton.Enabled = value;
            }
        }

        public ButtonFunctionAccessor(ToolStripMenuItem applyConvertResolutionMenu, Button applyConvertResolutionButton, ToolStripMenuItem clearOriginVidFieldMenu, Button clearOriginVidFieldButton, ToolStripMenuItem clearAllMenu, Button clearAllButton)
        {
            this.applyConvertResolutionMenu = applyConvertResolutionMenu;
            this.applyConvertResolutionButton = applyConvertResolutionButton;
            this.clearOriginVidFieldMenu = clearOriginVidFieldMenu;
            this.clearOriginVidFieldButton = clearOriginVidFieldButton;
            this.clearAllMenu = clearAllMenu;
            this.clearAllButton = clearAllButton;
        }
    }
}
