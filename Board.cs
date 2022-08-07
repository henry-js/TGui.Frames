using Terminal.Gui;

namespace TGuiFrames;
public class Board : Window
{
    public List<DashPanel> Panels { get; set; } = new();

    public NarrowLayout ActiveLayout;

    public Board(string title) : base(title)
    {
        ActiveLayout = new NarrowLayout();
        ActiveLayout.InitializeLayout(Panels);
        var label = new Label("Hello");
        Add(label);
        PopulatePanels();
    }

    private void PopulatePanels()
    {
        Panels.ForEach(p => Add(p));
    }
}
