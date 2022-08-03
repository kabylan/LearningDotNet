using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDotNet.Linq
{

    public class LinqClass
    {
        public void Test()
        {
            string[] peoples = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Temirbek" };

            var selectedPeople = from p in peoples
                                 where p.ToUpper().StartsWith("T")
                                 orderby p
                                 select p;

            foreach(var people in selectedPeople)
                Console.WriteLine(people);

        }
    }
}
