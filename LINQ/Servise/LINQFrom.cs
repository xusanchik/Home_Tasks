using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Servise
{
    public class LINQFrom
    {
        public static List<Lenguage> ModelProgram()
        {
            var Programming = new List<Lenguage>
            {
                new Lenguage { Id = 1, Name_p = "C#" },
                new Lenguage { Id = 2, Name_p = "Java" },
                new Lenguage { Id = 3, Name_p = "C" },
                new Lenguage { Id = 4, Name_p = "C#" },
                new Lenguage { Id = 5, Name_p = "Go" },
                new Lenguage { Id = 6, Name_p = "C#" },
                new Lenguage { Id = 7, Name_p = "Python" },
                new Lenguage { Id = 8, Name_p = "Java" },
                new Lenguage { Id = 9, Name_p = "C#" },
                new Lenguage { Id = 10, Name_p = "C" }


            };
            return Programming;
        }

        public static List<Bugalter> ModelBugalter()
        {
            var Buxgalter = new List<Bugalter>
            {
                new Bugalter { Id = 1, Name_b = "Akromjon", Programming_id = 7},
                new Bugalter { Id = 2, Name_b = "Tohirjon", Programming_id = 4},
                new Bugalter { Id = 3, Name_b = "MuhammadAbdulloh", Programming_id = 8},
                new Bugalter { Id = 4, Name_b = "Ozodbek", Programming_id = 3},
                new Bugalter { Id = 5, Name_b = "Elyor", Programming_id = 5},
                new Bugalter { Id = 6, Name_b = "Mahsud", Programming_id = 1},
                new Bugalter { Id = 7, Name_b = "Xusan", Programming_id = 2},
                new Bugalter { Id = 8, Name_b = "Xasan", Programming_id = 9},
                new Bugalter { Id = 9, Name_b = "Abdulloh", Programming_id = 10},
                new Bugalter { Id = 10, Name_b = "Abduxoliq", Programming_id = 6},
            };

            return Buxgalter;
        }

        public static void Task1()
        {
            var result = ModelProgram().Join(ModelBugalter(), p => p.Id, b => b.Programming_id, (p, b)
                    => new { p.Name_p, b.Name_b });

            foreach (var item in result)
            {
                Console.WriteLine(item.Name_b + " " + "->" + " " + item.Name_p);
            }
            Console.WriteLine();
        }


        public static void Task2(string Program_Name)
        {
            var result = ModelProgram().Join(ModelBugalter(), p => p.Id, b => b.Programming_id, (p, b)
                    => new { p.Name_p, b.Name_b }).Where(p => p.Name_p == Program_Name);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name_b + " " + "->" + " " + item.Name_p);
            }
        }
    }
}