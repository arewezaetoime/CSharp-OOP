namespace CMS.UI.Models
{
    public interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        static int MaxBooksAllowed = 6;

        string GetFullName()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }


        static string WhoAmI()
        {
            return "Student studentov testoviden";
        }
    }
}