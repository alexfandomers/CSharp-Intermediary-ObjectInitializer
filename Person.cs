using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryObjectInitializer
{
    public class Person
    {
        public int Id;
        public string? FirstName;
        public string? LastName;
        public DateTime Birthdate;
        
       //we create 4 constructors below (its messy and easily becomes out of control)
       //we used to this before 'object initializer concept' (it came to solve this problem)
       //we simply initialize an object like the exemple in program .cs
        /*public Person (int id)
        {
        }
        public Person (int id, string firstName)
        {
        }
        public Person (int id, string firstName, string lastName)
        {
        }
        public Person (int id, DateTime birthdate)
        {
        }*/
    }
}