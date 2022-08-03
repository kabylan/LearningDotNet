using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
//using LearningDotNet.Prototype;
//using LearningDotNet.AbstractFactory;
using LearningDotNet.Singleton;
using LearningDotNet.Builder;
using LearningDotNet.Strategy;
using LearningDotNet.FactoryMethod;
using LearningDotNet.Observer;
using LearningDotNet.AsyncAwait;
using LearningDotNet.Linq;

namespace LearningDotNet
{
    internal class LearnProccess
    {
        public async Task Display()
        {

            LinqClass linq = new LinqClass();

            linq.Test();


            //AsyncAwaitCl asyncAwait = new AsyncAwaitCl();
            //asyncAwait.PrintName("A");
            //asyncAwait.PrintName("B");
            //asyncAwait.PrintName("C");

            //await asyncAwait.PrintNameAsync("D");
            //await asyncAwait.PrintNameAsync("X");
            //await asyncAwait.PrintNameAsync("S");



            //Process process = Process.GetCurrentProcess();

            //Console.WriteLine(process.MachineName);
            //Console.WriteLine(process.ProcessName);
            //Console.WriteLine(process.Id);
            //Console.WriteLine(process.Handle);
            //Console.WriteLine(process.MainModule);
            //Console.WriteLine(process.Modules);
            //Console.WriteLine(process.StartTime);
            //Console.WriteLine(process.PagedMemorySize64);
            //Console.WriteLine(Process.GetProcesses());


            //foreach(Process p in Process.GetProcesses())
            //{
            //    Console.WriteLine(p.ProcessName);


            //    // Можно закрыть запущенные программы!
            //    // notepad, mspaint
            //    if (p.ProcessName == "notepad" || p.ProcessName == "mspaint")
            //    {
            //        p.Kill(); 
            //    }
            //}

            //// Можно запускать!
            //Process process = new Process();
            //process.StartInfo.FileName = "notepad";
            //process.Start();


            // можно узнать какие dll файлы используется для этой программы
            //Process process1 = Process.GetProcessesByName("notepad")[0];

            //ProcessModuleCollection pm = process1.Modules;

            //foreach(ProcessModule module in pm)
            //{
            //    Console.WriteLine(module.ModuleName + " " + module.FileName);
            //}


            //Computer comp = new Computer();

            //comp.Launch("Ubuntu 20.04");
            //Console.WriteLine(comp.OS.Name);

            //comp.OS = OS.getInstance("Windows 7");
            //Console.WriteLine(comp.OS.Name);


            //IFigure figure = new Rectangle(30, 40);
            //IFigure clonedFigure = figure.Clone();

            //figure.GetInfo();
            //clonedFigure.GetInfo();

            //figure = new Circle(30);
            //clonedFigure = figure.Clone();
            //figure.GetInfo();
            //clonedFigure.GetInfo();

            //// содаем объект пекаря
            //Baker baker = new Baker();
            //// создаем билдер для ржаного хлеба
            //BreadBuilder builder = new RyeBreadBuilder();
            //// выпекаем
            //Bread ryeBread = baker.Bake(builder);
            //Console.WriteLine(ryeBread.ToString());
            //// оздаем билдер для пшеничного хлеба
            //builder = new WheatBreadBuilder();
            //Bread wheatBread = baker.Bake(builder);
            //Console.WriteLine(wheatBread.ToString());


            //Hero elf = new Hero(new ElfFactory());
            //elf.Hit();
            //elf.Run();

            //Hero voin = new Hero(new VoinFactory());
            //voin.Hit();
            //voin.Run();


            //Car auto = new Car("BMW F10", 350, 2.5, new PetrolMove());

            //auto.Move();

            //auto.Movable = new ElectricMove();

            //auto.Move();


            //Developer dev = new PanelDeveloper("ООО ПанельСтройМагнат");
            //House house = dev.Create();

            //dev = new WoodDeveloper("АО ДеревоСтройОлимп");
            //house = dev.Create();

            //dev = new SteveJobsHouseDeveloper("ИП СтивДжобсОрижиналс");
            //house = dev.Create();


            //Stock stock = new Stock();
            //Bank bank = new Bank("ЮнитБанк", stock);
            //Broker broker = new Broker("Иван Иваныч", stock);
            //// имитация торгов
            //stock.Market();
            //// брокер прекращает наблюдать за торгами
            //broker.StopTrade();
            //// имитация торгов
            //stock.Market();

        }
    }
}
