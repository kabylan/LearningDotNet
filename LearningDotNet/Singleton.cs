using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet.Singleton
{
    // Гарантия создания только одного экземпляра класса
    class Computer
    {
        public OS OS { get; set; }

        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }

    class OS
    {
        private static OS instance;

        public string Name { get; set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            
            return instance;
        }
    }


    class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {

        }


        public static Singleton getInstance()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
    }
}
