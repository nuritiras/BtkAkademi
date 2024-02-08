namespace BtkAkademi.Models
{
    public class Repository
    {
        private static List<Candidate> applications=new();
        public static IEnumerable<Candidate> Applications => applications; 
    }   
}