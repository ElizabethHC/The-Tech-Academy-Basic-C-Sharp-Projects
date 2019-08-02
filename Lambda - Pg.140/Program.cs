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
            //Employee employee1 = new Employee();
            //employee1.fullName = "Joe Jones";
            //employee1.Id = 55;
            //Employee employee2 = new Employee();
            //employee2.fullName = "Ellen Ripley";
            //employee2.Id = 3;
            //Employee employee3 = new Employee();
            //employee3.fullName = "Joe Joestar";
            //employee3.Id = 29;
            //Employee employee4 = new Employee();
            //employee4.fullName = "Darwin Santos";
            //employee4.Id = 16;
            //Employee employee5 = new Employee();
            //employee5.fullName = "Eliora Vanna";
            //employee5.Id = 13;
            //Employee employee6 = new Employee();
            //employee6.fullName = "Bob Vance";
            //employee6.Id = 199;
            //Employee employee7 = new Employee();
            //employee7.fullName = "Dia Blut";
            //employee7.Id = 1;
            //Employee employee8 = new Employee();
            //employee8.fullName = "Jhin Virtuoso";
            //employee8.Id = 4;
            //Employee employee9 = new Employee();
            //employee9.fullName = "Aurinia Ripsa";
            //employee9.Id = 31;
            //Employee employee10 = new Employee();
            //employee10.fullName = "Shiloh Moore";
            //employee10.Id = 147;

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
                if (Joe.Contains("Joe"))
                    Console.WriteLine("-" + Joe);
            }

            var newListJoes = employees.Where(x => x.Contains("Joe")).ToList();
            newListJoes.ForEach(i => Console.Write("{0}\n", i));

            var id = employees.Where(x => x.Id > 5).ToList();
            id.ForEach(i => Console.Write("{0}\n", i));

            Console.ReadLine();

            //Employee employee1 = new Employee();
            //employee1.fullName = "Joe Jones";
            //employee1.Id = 55;
            //Employee employee2 = new Employee();
            //employee2.fullName = "Ellen Ripley";
            //employee2.Id = 3;
            //Employee employee3 = new Employee();
            //employee3.fullName = "Joe Joestar";
            //employee3.Id = 29;
            //Employee employee4 = new Employee();
            //employee4.fullName = "Darwin Santos";
            //employee4.Id = 16;
            //Employee employee5 = new Employee();
            //employee5.fullName = "Eliora Vanna";
            //employee5.Id = 13;
            //Employee employee6 = new Employee();
            //employee6.fullName = "Bob Vance";
            //employee6.Id = 199;
            //Employee employee7 = new Employee();
            //employee7.fullName = "Dia Blut";
            //employee7.Id = 1;
            //Employee employee8 = new Employee();
            //employee8.fullName = "Jhin Virtuoso";
            //employee8.Id = 4;
            //Employee employee9 = new Employee();
            //employee9.fullName = "Aurinia Ripsa";
            //employee9.Id = 31;
            //Employee employee10 = new Employee();
            //employee10.fullName = "Shiloh Moore";
            //employee10.Id = 147;

            //List<Employee> employees = new List<Employee>();
            //employees.Add(employee1);
            //employees.Add(employee2);
            //employees.Add(employee3);
            //employees.Add(employee4);
            //employees.Add(employee5);
            //employees.Add(employee6);
            //employees.Add(employee7);
            //employees.Add(employee8);
            //employees.Add(employee9);
            //employees.Add(employee10);

        }
    }
}
