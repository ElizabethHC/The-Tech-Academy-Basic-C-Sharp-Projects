using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda___Pg._140
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { fullName = "Joe Jones", Id = 55 },
                new Employee { fullName = "Ellen Ripley", Id = 3 },
                new Employee { fullName = "Joe Joestar", Id = 29 },
                new Employee { fullName = "Darwin Santos", Id = 16 },
                new Employee { fullName = "Eliora Vanna", Id = 13 },
                new Employee { fullName = "Bob Vance", Id = 199 },
                new Employee { fullName = "Dia Blut", Id = 1 },
                new Employee { fullName = "Jhin Virtuoso", Id = 4 },
                new Employee { fullName = "Aurinia Ripsa", Id = 31 },
                new Employee { fullName = "Shiloh Moore", Id = 147 }
            };

            foreach (var Joe in employees)
            {
                if (Joe.fullName.Contains("Joe"))
                    Console.WriteLine(Joe.fullName);
            }

            var newListJoes = employees.Where(x => x.fullName.Contains("Joe")).ToList();
            newListJoes.ForEach(i => Console.Write("-{0}\n", i.fullName));

            var id = employees.Where(x => x.Id > 5).ToList();
            id.ForEach(i => Console.Write("+{0}, Id: {1}\n", i.fullName, i.Id));

            Console.ReadLine();
        }
    }
}
