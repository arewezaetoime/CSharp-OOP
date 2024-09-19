

namespace Cars
{
    internal class BMW : ICar
    {

        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BMW(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{this.Color} BMW {this.Model}";
        }
    }
}
