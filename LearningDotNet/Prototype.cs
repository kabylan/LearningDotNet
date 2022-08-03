using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet.Prototype
{

    class Client
    {
        void Operation()
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();

        }
    }

    abstract class Prototype
    {
        public int Id { get; set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }




    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }


    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public IFigure Clone()
        {
            return new Rectangle(width, height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", height, width);
        }
    }

    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
