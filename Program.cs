namespace IntermediaryObjectInitializer
{
     public class Program
    {
        static void Main(string[] args)
        {  
            var person = new Person
            {
                FirstName = "Mosh",
                LastName = "Hamedani"
            };
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}