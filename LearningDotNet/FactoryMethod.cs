using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet.FactoryMethod
{

    // Смысл - базовый класс дает возможность создавать объекты своим наследникам.

    // Много продуктов. Много фабрик.
    // Каждая фабрика создает и возвращает продукт.

    abstract class House {
    }

    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }

    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }


    class SteveJobsHouse : House
    {
        public SteveJobsHouse()
        {
            Console.WriteLine("Как у Стив Джобса дом построен");
        }
    }

    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string name)
        {
            Name = name;
        }

        abstract public House Create();
    }

    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }

    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }

    class SteveJobsHouseDeveloper : Developer
    {
        public SteveJobsHouseDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new SteveJobsHouse();
        }
    }



    abstract class Product
    {

    }

    class ConcreteProductA : Product
    {
    }

    class ConcreteProductB : Product
    {
    }

    abstract class Creator 
    {
        public abstract Product FactoryMethod();
    }


    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }



}
