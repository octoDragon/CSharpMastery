using System;
namespace Hel.CreatingTypesinC
{
    public class Using_Deconstructors
    {
        int Width, Height;
        string Color;

        //Default Constructor
        public Using_Deconstructors(int width, int height)
        {
            Width = width;
            Height = height;
        }

        //Simplified Constructor, deconstructing assignment
        public Using_Deconstructors(int width, int height, string color) =>
            (Width, Height, Color) = (width, height, color);

        //Deconstruct
        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }

        //Deconstruct Overload, deconstructing assignment
        public void Deconstruct(out float width, out float height, out string color) =>
            (width, height, color) = (Width, Height, Color);

        public static void Program()
        {
            Using_Deconstructors myObject = new Using_Deconstructors(9, 5);
            // calling deconstructor variations
            //variation 1
            var (height, width) = myObject;
            Console.WriteLine(height + " " + width);

            //variation 2
            (float height2, float width2) = myObject;
            Console.WriteLine(height2 + " " + width2);

            //variation 3, using simplified constructor + Deconstructor with deconstructing assignment
            Using_Deconstructors myColoredObject = new Using_Deconstructors(3, 1, "blue");
            (float height3, float width3, string color1) = myColoredObject;
            Console.WriteLine(height3 + " " + width3 + " " + color1);

        }

    }
}
