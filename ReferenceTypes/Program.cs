using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int s1 = 10;
            //int s2 = 20;
            //s1 = s2;
            //s2 = 100;
            //Console.WriteLine(s1);


            //int[] sayilar = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20,30};
            //sayilar = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine(sayilar[0]);



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Mustafa";
            person2 = person1;
            person1.FirstName = "Önder";
            Console.WriteLine(person2.FirstName);

            Person person3= new Person();
            person3.FirstName = "Kemal";

            Customer customer1 = new Customer();
              
            customer1.FirstName = "Salih";
            customer1.CreditCardNumber = "19724568742";
 
            //Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager1 = new PersonManager();
            personManager1.Add(customer1);

            Console.ReadKey();
        }
    }
}

class Person { 

public int id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

//BaseClass : Person  
class Customer:Person { 

    public string CreditCardNumber { get; set; }
}
class Employee:Person 
{


    public int EmployeeNumber { get; set; }
}
class PersonManager {

    public void Add(Person person ) {
    
    
    Console.WriteLine(person.FirstName);
    
    }


}
