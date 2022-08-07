using Terminal.Gui;

namespace TGuiFrames;

public abstract class NewBaseType
{
    protected virtual List<Position>[] Positions { get; set; }
    protected abstract float ColumnWidth { get; }
    protected abstract float ColumnHeight { get; }
    protected abstract int PanelsPerColumn { get; }
    protected virtual int MAXPANELS => 6;
    protected abstract int NumberOfPanels { get; }
    protected abstract int NumberOfColumns { get; }
    protected virtual float XPos { get; set; } = 0;
    protected virtual float YPos { get; set; } = 0;
    public abstract void InitializeLayout(List<DashPanel> panels);
}

public class NarrowLayout : NewBaseType
{
    protected override List<Position>[] Positions { get; set; } = new List<Position>[2].Select(_ => new List<Position>()).ToArray();
    protected override float ColumnWidth { get; }
    protected override float ColumnHeight { get; }
    protected override int PanelsPerColumn { get; }
    protected override int NumberOfPanels { get; }
    protected override int NumberOfColumns { get; }

    public NarrowLayout(int numberOfPanels = 4)
    {
        numberOfPanels = (numberOfPanels % 2 == 0) ? numberOfPanels : numberOfPanels + 1;
        NumberOfPanels = (numberOfPanels > MAXPANELS) ? MAXPANELS : numberOfPanels;
        PanelsPerColumn = numberOfPanels / 2;
        ColumnWidth = 1 / (float)NumberOfColumns * 100;
        ColumnHeight = 1 / (float)PanelsPerColumn * 100;
        for (int i = 0; i < NumberOfColumns; i++)
        {
            for (int j = 0; j < PanelsPerColumn; j++)
            {
                Positions[i].Add(new Position(Pos.Percent(XPos), Pos.Percent(YPos), Dim.Percent(ColumnHeight), Dim.Percent(ColumnWidth)));
                YPos += ColumnHeight;
            }
            YPos = 0;
            XPos += ColumnWidth;
        }
        XPos = 0;
    }
    public override void InitializeLayout(List<DashPanel> panels)
    {
        if (panels.Count > 0) throw new ArgumentOutOfRangeException(nameof(panels), "InitializeLayout function should receive an empty List<DashPanel>");
        for (int i = 0; i < Positions.Length; i++)
        {
            foreach (var position in Positions[i])
            {
                panels.Add(new DashPanel(new Label($"Inside Panel Col: {i}, Panel: {Positions[i].IndexOf(position)}"))
                {
                    X = position.X,
                    Y = position.Y,
                    Height = position.Height,
                    Width = position.Width,
                    Border = new Border() { BorderStyle = BorderStyle.Rounded },
                    UsePanelFrame = true
                });
            }
        }
    }

    public void ResetLayout(List<DashPanel> panels) { }

    void CreateLayout(int numberOfPanels)
    {
        for (int i = 0; i <= numberOfPanels; i++)
        {
        }
    }
}

// public abstract class LayoutCreator
// {
//     protected int[] PanelsPerCol = new int[2];
//     protected LayoutCreator(int numberOfPanels)
//     {
//         this.CreateLayout(numberOfPanels);
//     }

// }
