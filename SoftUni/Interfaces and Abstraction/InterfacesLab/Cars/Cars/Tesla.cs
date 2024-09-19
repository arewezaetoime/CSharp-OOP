
namespace Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        public int Battery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Tesla(int battery, string model, string color)
        {
            Battery = battery;
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla Model {this.Model} with {this.Battery} Batteries";
        }
    }
}
