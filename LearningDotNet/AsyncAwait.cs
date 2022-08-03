using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LearningDotNet.AsyncAwait
{
    // ассинхронное выполнение не блокирует основной поток, а освобождает.
    // из основного потока выносит на отдельные ассинхронные методы.
    // ассинхронные методы выполняются в отдельных потоках.
    // поток ассинхронного метода будет возвращаеться в пул потоков и будет переиспользоваться.
    // 

    class AsyncAwaitCl
    {
        public void PrintName(string name)
        {
            Thread.Sleep(3000);     // имитация продолжительной работы
            Console.WriteLine(name);
        }
        // определение асинхронного метода
        public async Task PrintNameAsync(string name)
        {
            await Task.Delay(3000);     // имитация продолжительной работы
            Console.WriteLine(name);
        }
    }
}
