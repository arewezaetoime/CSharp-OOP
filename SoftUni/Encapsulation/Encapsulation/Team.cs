

namespace Encapsulation
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name { get; private set; }
        public IReadOnlyCollection<Person> FirstTeam => firstTeam.AsReadOnly();
        public IReadOnlyCollection<Person> ReserveTeam => reserveTeam.AsReadOnly();

        public void AddPlayer(Person p)
        {
            if (p.Age < 40)
            {
                firstTeam.Add(p);
            }
            else
            {
                reserveTeam.Add(p); 
            }
        }
    }

}
