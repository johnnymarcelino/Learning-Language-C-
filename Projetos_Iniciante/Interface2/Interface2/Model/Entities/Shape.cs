using Interface2.Model.Enums;


namespace Interface2.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
