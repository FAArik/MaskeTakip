using Business.Concrete;
using Entities.Concrete;

namespace MaskeTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Fatih Ali";
            person1.LastName = "Arık";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 12312312312;//placeholder

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

           

            Console.ReadLine();
        }


    }
}
