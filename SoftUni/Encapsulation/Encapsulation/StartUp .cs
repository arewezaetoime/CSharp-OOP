using Encapsulation;

namespace PersonsInfo
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split(' ');
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            foreach (var p in persons.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList())
            {
                Console.WriteLine(p.ToString());
            };
        }
    }
}
