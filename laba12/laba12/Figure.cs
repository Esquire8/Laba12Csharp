using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    public enum Visible { Видимый, Невидимый }
    internal abstract class Figure
    {
        public string Color;
        public Visible visible;
        public double X;
        public double Y;

        public void MoveY(int move) { Y += move; }
        public void MoveX(int move) { X += move; }
        public void ChangeColor(string newColor) { Color = newColor; }
        public void ChangeVisible(Visible newVisible) { visible = newVisible; }
        public Visible GetVisible() { return visible; }
        public string GetInfo() { return $"X: {X}, Y: {Y}, Color: {Color}, Visible: {visible}"; }
    }
    internal class Point : Figure { }

    internal class Circle : Point
    {
        public double radius { get; set; }
        public double Area() { return Math.PI * Math.Pow(radius, 2); }
    }

    internal class Rectangle : Point
    {
        public double height { get; set; }
        public double width { get; set; }
        public double Area() { return height * width; }
    }
}
