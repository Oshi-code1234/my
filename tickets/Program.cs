// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;
using System.Xml.Linq;
using tickets;

//Console.WriteLine("Hello, World!");
//*Events CRUD * (Create, Edit, Delete, View)
//- *Event Details * (Name, Date, Location, Description)
//- *Admin Dashboard * (Track ticket sales & revenue)  

//Event arrey and driver arrey
Events[] eventArrey = new Events[1];
Tiket[] tiketArrey = new Tiket[1];

Events e1 = new Events("MyEvent", "1.2.2028", "Ghampha", "Musical Event");
Tiket t1 = new Tiket("VIP", 8000);



List<Events> eventlist = new List<Events>();



e1.ViewEvents();
Console.WriteLine();

//event1.EditEvent();
//Console.WriteLine();

//Console.WriteLine("New Things are: ");
//event1.ViewEvents();

//create new event
//Events[] eventArrey = new Events[1];
//for (int i = 0; i < eventArrey.Length; i++)
//{
//    Console.WriteLine("Event");
//    Console.WriteLine("Enter the Event name: ");
//    string ename = Console.ReadLine();
//    Console.WriteLine();

//    Console.WriteLine("Enter the Date: ");
//    string edate = Console.ReadLine();
//    Console.WriteLine();

//    Console.WriteLine("Enter the location: ");
//    string eloc = Console.ReadLine();
//    Console.WriteLine();

//    Console.WriteLine("Enter the Des: ");
//    string edes = Console.ReadLine();
//    Console.WriteLine();

//    Events newevent = new Events(ename, edate, eloc, edes);
//    eventArrey[i] = newevent;
//    i.ViewEvents();
//}

//foreach (Events newevent in eventArrey)
//{
//    newevent.ViewEvents();
//    Console.WriteLine();

//    newevent.EditEvent();
//    Console.WriteLine();

//    Console.WriteLine("New Things are: ");
//    newevent.ViewEvents();
//}

//ticket fee
Tiket ticket1 = new Tiket("Mytiket", 1000);
Console.WriteLine("How many tickets you want a: ");
int tik = Convert.ToInt32(Console.ReadLine());

//ticket1.TickSlaes(ticket1.TikName, tik);


//int[] array = { 1, 2, 3, 4, 5 };
//array = array.Where(val => val != 4).ToArray();

//string[] array1 = {"me" , "miine" , "mera" };
//eventArrey = eventArrey.Where(val => val != "mine").ToArray();

//foreach (string va in eventArrey)
//{
//    Console.WriteLine($"{va}");
//}
