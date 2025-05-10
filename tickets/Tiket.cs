using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickets
{
    internal class Tiket
    {
        private String tikname ;
        private double ticketfee;

        public Tiket (string tikname , double ticketfee)
        {
            this.tikname = tikname;
            this.ticketfee = ticketfee;
        }

        public string TikName
        {
            get { return tikname; }
            set { tikname = value; }
        }

        public double TicketfeeGet
        {
            get { return ticketfee; }
            set { ticketfee = value; }
        }

        public void TickSlaes(string ticket , int tik)
        {
            int sales = tik * 1000;
            Console.WriteLine($"Slae is {tik}");
            Console.WriteLine($"Revenue is RS.{sales}");
        }
    }
}
