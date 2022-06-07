using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainUI.Entities
{
   public class TicketInfo
    {
        string selectedTrain, trainName, departureTime, arrivalTime, ticketPrice, ticketType;
        int ticketbuy,userbalance;
      //  int counterSeat;

        public static string ticketNumber = "SN-XXX";
        public static   int id = 0;
        public string SelectedTrain
        {
            get
            {
                return selectedTrain;
            }

            set
            {
                selectedTrain = value;
            }
        }

        public string TrainName
        {
            get
            {
                return trainName;
            }

            set
            {
                trainName = value;
            }
        }

        public string DepartureTime
        {
            get
            {
                return departureTime;
            }

            set
            {
                departureTime = value;
            }
        }

        public string ArrivalTime
        {
            get
            {
                return arrivalTime;
            }

            set
            {
                arrivalTime = value;
            }
        }

        public string TicketType
        {
            get
            {
                return ticketType;
            }

            set
            {
                ticketType = value;
            }
        }

        public string TicketPrice
        {
            get
            {
                return ticketPrice;
            }

            set
            {
                ticketPrice = value;
            }
        }

        public int Ticketbuy
        {
            get
            {
                return ticketbuy;
            }

            set
            {
                ticketbuy = value;
            }
        }

        public int Userbalance
        {
            get
            {
                return userbalance;
            }

            set
            {
                userbalance = value;
            }
        }

        public TicketInfo() { }

        public TicketInfo(string[] value)
        {
            this.selectedTrain = value[0];
            this.trainName = value[1];
            this.departureTime = value[2];
            this.arrivalTime = value[3];
            this.ticketPrice = value[4];
            this.ticketType = value[5];
           // this.userbalance = Convert.ToInt32(value[6]);
        }
     //  public int abc ;
       public static  int i ;
        public int Capacity(int p)
        {
 
                 i=i+p;
            
              return  i;
                
        
         }
        public int TotalBalance()
        {
            int tk = 0;
            if (TicketType == "Normal")
            {
                 tk = Convert.ToInt32(ticketPrice) * ticketbuy;
                //  SeatDitails();
                //id++;
                //ticketNumber = "SN=" + id;
                //return tk;
            }
            else
            {
                if (TicketType != "")
                {

                    tk = Convert.ToInt32(ticketPrice) * ticketbuy * 2;

                    //id++;
                    //TicketInfo.ticketNumber = "SN=" + id;
                }
            }
            return tk;
        }

      
        public string SeatDitails()
        {
            id++;
            ticketNumber = "SN=" + id;
            return ticketNumber;
        }

    }
}
