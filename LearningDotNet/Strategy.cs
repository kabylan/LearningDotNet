using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet.Strategy
{
    // Движение. Два типа движения - бенза, электро.
    // Машина. Можно тип движения поменять, не меняя машину.
    // Это как гибрид.

    // На языке программирования - это алгоритм, вместо тип движения.

    interface IMovable
    {
        void Move();
    }

    class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }

    class ElectricMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }

    class Car
    {
        protected string markModelGenre;
        protected int hp;
        protected double engineCapacity;

        public IMovable Movable { get; set; }

        public Car(string markModelGenre, int hp, double engineCapacity, IMovable mov)
        {
            this.markModelGenre= markModelGenre;
            this.hp = hp;
            this.engineCapacity = engineCapacity;
            Movable = mov;
        }

        public void Move()
        {
            Movable.Move();
        }
    }




    public interface IStrategy
    {
        void Algorithm();
    }

    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm() { }
    }

    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm() { }
    }

    public class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }


}
