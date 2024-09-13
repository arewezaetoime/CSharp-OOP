namespace CMS.UI.Models
{
    public class Staff : Person
    {
        private string firstName;

        public int Id { get; private set; }
        public int WorkingHoursPerWeek { get; set; }

        public Staff(string firstName, string LastName) 
            : base(firstName, LastName)
        {
            WorkingHoursPerWeek = 40;
        }
      

        protected void CalculateFees(decimal electiveFees, ref decimal roughFees,
            out decimal finalFees)
            {
                electiveFees = 10000;
                roughFees = 10000;
                finalFees = 10000;
            }
        
        // public void UpdateInfo(string firstName)
        // {
        //     FirstName = firstName;
        // }

        private protected void UpdateInfo(string firstName, string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}