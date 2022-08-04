using Terminal.Gui;

namespace TGuiFrames;
public class Board : Window
{
    public List<PanelView> Panels { get; set; } = new();

    public Narrow ActiveLayout;

    public Board(string title) : base(title)
    {
        ColorScheme = new ColorScheme { Normal = new Terminal.Gui.Attribute(Color.Black,)}
        var label = new Label("Hello");
        var panelView1 = new PanelView(new Label("Label inside PanelView1"))
        {
            X = Pos.Percent(0),
            Y = Pos.Percent(0),
            Height = Dim.Percent(20),
            Width = Dim.Percent(20),
            LayoutStyle = LayoutStyle.Computed,
            Border = new Border() { BorderStyle = BorderStyle.Rounded },
            UsePanelFrame = true
        };
        var panelView2 = new PanelView(new Label("Label inside PanelView2"))
        {
            X = Pos.Percent(0),
            Y = Pos.Percent(20),
            Height = Dim.Percent(50),
            Width = Dim.Percent(40),
            LayoutStyle = LayoutStyle.Computed,
            Border = new Border() { BorderStyle = BorderStyle.Rounded },
            UsePanelFrame = true
        };
        Panels.Add(panelView1);
        Panels.Add(panelView2);
        Add(label);
        PopulatePanels();
    }

    private void PopulatePanels()
    {
        Panels.ForEach(p => Add(p));
    }

}
