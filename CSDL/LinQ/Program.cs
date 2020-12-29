using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> Contacts = new List<Contact>
            {
                new Contact{ Age = 11, FirstName = "Trump", LastName = "Donald", Address = "Ha Noi"},
                new Contact{ Age = 21, FirstName = "Omaba", LastName = "Barrack", Address = "Sai Gon"},
                new Contact{ Age = 31, FirstName = "Bush", LastName = "George", Address = "Ha Noi"},
                new Contact{ Age = 41, FirstName = "Bill", LastName = "Clinton", Address = "Da Nang"},
                new Contact{ Age = 51, FirstName = "Reagan", LastName = "Ronald", Address = "Da Nang"},
                new Contact{ Age = 61, FirstName = "Jimmy", LastName = "Carter", Address = "Sai Gon"},
                new Contact{ Age = 71, FirstName = "Gerald", LastName = "Ford", Address = "Ha Noi"},
                new Contact{ Age = 81, FirstName = "Nixon", LastName = "Richard", Address = "Ha Noi"},
            };
            List<TP> Thanhpho = new List<TP>
            {
                new TP("HN","Ha Noi"),
                new TP("DN","Da Nang"),
                new TP("SG","Sai Gon")
            };

            var query = from people in Contacts
                        //join tpp in Thanhpho on people.Address equals tpp.NameTP
                        //group tpp by new { people.FirstName, tpp.Id } into nh
                        //select new { nh.Key.FirstName, nh.Key.Id };
            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName + "\t" + item.Id);
            }
            
        }
    }
    public class Contact
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool Chudau(string a)
        {
            return FirstName.StartsWith(a);
        }
        public string Chucai()
        {
            return FirstName.Substring(0,1);
        }

    }
    public class TP
    {
        public string Id { get; set; }
        public string NameTP { get; set; }
        public TP(string a, string b)
        {
            Id = a;
            NameTP = b;
        }
    }
}
