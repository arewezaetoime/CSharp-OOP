using Encapsulation;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            //var persons = new List<Person>();

            var team = new Team("Arewe");

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(' ');
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
                team.AddPlayer(person);
            }

            Console.WriteLine(team.FirstTeam.Count());
            Console.WriteLine(team.ReserveTeam.Count());



            //foreach (var p in persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList())
            //{
            //    Console.WriteLine(p.ToString());


            //    var lines = int.Parse(Console.ReadLine());
            //    var persons = new List<Person>();
            //    for (int i = 0; i < lines; i++)
            //    {
            //        var cmdArgs = Console.ReadLine().Split();
            //        var person = new Person(cmdArgs[0],
            //                                cmdArgs[1],
            //                                int.Parse(cmdArgs[2]),
            //                                decimal.Parse(cmdArgs[3]));

            //        persons.Add(person);
            //    }
            //    var parcentage = decimal.Parse(Console.ReadLine());
            //    persons.ForEach(p => p.IncreaseSalary(parcentage));
            //    persons.ForEach(p => Console.WriteLine(p.ToString()));




        }
        }
}
