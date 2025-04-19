using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class Events
    {
        private string name;
        private string date;
        private string location;
        private string des;
        //private Tiket eventtik;

        public Events(string name, string date, string location, string des)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.des = des;
            //Tiket eventtik , this.eventtik = eventtik;
        }

        public string Nameget
        {
            get { return name; }
            set { name = value; }
        }
        public string Dateget
        {
            get { return date; }
            set { date = value; }
        }
        public string Locget
        {
            get { return location; }
            set { location = value; }
        }

        public string Desget
        {
            get { return des; }
            set { des = value; }
        }

        //public Tiket EventtikGet
        //{
        //    get { return eventtik; }
        //    set { eventtik = value; }
        //}

        public void ViewEvents()
        {
            Console.WriteLine($"Event is {Nameget}.Date is {Dateget}.Location is {Locget}.It is a {Desget}.");
        }
        public void EditEvent()
        {

            Console.WriteLine("1.Name, 2.Date, 3.Location,4.Description,5.Non ");
            Console.WriteLine("What do you want to change|Enter the number: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.WriteLine("Enter the new name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Name is changed to {Nameget = name}");
            }else if (answer == 2)
            {
                Console.WriteLine("Enter the new date: ");
                string date = Console.ReadLine();
                Console.WriteLine($"Name is changed to {Dateget = date}");
            }
            else if (answer == 3)
            {
                Console.WriteLine("Enter the new location: ");
                string loc = Console.ReadLine();
                Console.WriteLine($"Name is changed to {Locget = loc}");
            }
            else if (answer == 4)
            {
                Console.WriteLine("Enter the new date: ");
                string des = Console.ReadLine();
                Console.WriteLine($"Name is changed to {Dateget = des}");
            }
            else if (answer == 5)
            {
                return;
            }

        }

    }
}
