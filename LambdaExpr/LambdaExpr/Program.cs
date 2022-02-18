using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpr
{
    public class Program
    {
         static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            //IterateOverList(list);
            //Uc1
            AddPersonDetailsIntoList(list);
            IterateOverList(list);
            //Uc2
            RetrievePersonLessThan60(list);
            FindAgeBet13to18(list);
            FindTenageAgeRecords(list);
            FindAverageAge(list,"Shweta");
            SearcgPersonBasedOnName(list,"Shubham");
            SearchPersonNameUsingException(list, "Shubham");
            RetrievePersonAgeGreaterThan60(list);
            Console.ReadLine();
        }
        public static void AddPersonDetailsIntoList(List<Person> list)
        {
            Person p = new Person() { Address = "Satara", Age = 30, Name = "Shweta" };//Object initializer
            list.Add(new Person() { SSN = 1, Age = 14, Address = "Satara", Name = "Shweta" });
            list.Add(new Person() { SSN = 2, Age = 22, Address = "Nagpur", Name = "Shivani" });
            list.Add(new Person() { SSN = 3, Age = 46, Address = "Sangli", Name = "Pooja" });
            list.Add(new Person() { SSN = 4, Age = 70, Address = "Mahableshwar", Name = "Swagata" });
            list.Add(new Person(){ SSN=5,Age=63,Address="Chennai",Name="Arun"});
            list.Add(new Person() { SSN = 6, Age = 19, Address = "Pune", Name = "Pooja" });
        }
        public static void IterateOverList(List<Person> list)
        {
            foreach(Person person in list)
            {
                Console.WriteLine(person);
            }
        }
        public static void RetrievePersonLessThan60(List<Person> list)
        {
            List<Person> res=list.FindAll(p => p.Age < 60).OrderBy(a=>a.Age).Take(2).ToList();
            Console.WriteLine("Sorted top two:");
            IterateOverList(res);
            //Another way by doing step by step
            var personLessThan60=list.Where(p=>p.Age<60).ToList();  //We using list collection so end with ToList
            var sortedResults=personLessThan60.OrderBy(p=>p.Age).ToList();
            Console.WriteLine();
            Console.WriteLine("Sorted results based on Age");
            IterateOverList(sortedResults);
            Console.WriteLine();
            var topTwoRecords = sortedResults.Take(2).ToList();
        }
        //UC3
        public static void FindAgeBet13to18(List<Person> list)
        {
            List<Person> res = list.FindAll(p => p.Age>=13 && p.Age<=18).OrderBy(a => a.Age).Take(2).ToList();
            Console.WriteLine("People who's Age between 13 to 18 ");
            IterateOverList(res);
        }
        public static void FindTenageAgeRecords(List<Person> list)
        {
            List<Person> tenageRecords = list.FindAll(person => person.Age >= 13 && person.Age <= 18);
            Console.WriteLine("\nDisplaying Tenage Age records: \n");
            IterateOverList(tenageRecords);
        }
        public static void FindAverageAge(List<Person> list,string name)
        {
            double averageResult = list.Average<Person>(p => p.Age);
            Console.WriteLine("\nAverage result is:");
            Console.WriteLine(averageResult);
        }
        public static void SearcgPersonBasedOnName(List<Person> list,string name)
        {
            var nameResult=list.Find(Person=>Person.Name==name);
            Console.WriteLine("\nDisplay Average result");
            if(nameResult!=null)
            Console.WriteLine(nameResult.Name+" present in list");
            else
                Console.WriteLine("Person not exist in the list");
        }
        public static void SearchPersonNameUsingException(List<Person>list,string name)
        {
            try
            {
                Person personResult=list.FindLast(person=>person.Name==name);
                if(personResult!=null)
                    Console.WriteLine(personResult);

                else
                    Console.WriteLine("Person not exist in the list");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void RetrievePersonAgeGreaterThan60(List<Person> list)
        {
            List<Person> result = list.FindAll(person => person.Age > 60).Skip(1).ToList();
            Console.WriteLine("Age greater than 60 people Are:");
            IterateOverList(result);
        }
    }
}
