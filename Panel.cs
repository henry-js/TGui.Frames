using Terminal.Gui;

namespace TGuiFrames;

public class DashPanel : PanelView
{
    public DashPanel(View child) : base(child)
    {
        LayoutStyle = LayoutStyle.Computed;
    }

    public DashPanel() : base()
    {
        LayoutStyle = LayoutStyle.Computed;
    }
}
