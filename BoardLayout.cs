using Terminal.Gui;

namespace TGuiFrames
{
    public interface IBoardLayout
    {
        public List<DashPanel> Apply(List<DashPanel> panels, Dim height, Dim width);
    }
}
