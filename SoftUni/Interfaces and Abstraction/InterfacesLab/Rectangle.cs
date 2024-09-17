

namespace InterfacesLab
{
    internal class Rectangle : IDrawable
    {

        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void Draw()
        {
            DrawLine(this.width, '*', '*');
            for (int i = 1; i < this.height - 1; ++i)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }

        public void DrawLine(int width, char end, char mid)
        {
            Console.WriteLine(end);
            for (int i = 0; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
