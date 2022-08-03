using System;
using System.Threading;
using System.Threading.Tasks;
namespace LearningDotNet
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            LearnProccess learnProccess = new LearnProccess();

            await learnProccess.Display();

        }
    }

}
