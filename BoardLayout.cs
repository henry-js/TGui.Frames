using Terminal.Gui;

namespace TGuiFrames
{
    public interface IBoardLayout
    {
        Pos X { get; }
        Pos Y { get; }
        Dim Height { get; init; }
        Dim Width { get; init; }

        void Deconstruct(out Pos X, out Pos Y, out Dim Height, out Dim Width);
        bool Equals(object? obj);
        bool Equals(Narrow? other);
        int GetHashCode();
        string ToString();
    }

    public class Narrow : IBoardLayout
    {
        public Pos X => Pos.Percent(50);
        public Pos Y => Pos.Percent(50);
        public Dim Height { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
        public Dim Width { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        public void Deconstruct(out Pos X, out Pos Y, out Dim Height, out Dim Width)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Narrow? other)
        {
            throw new NotImplementedException();
        }
    }
}
