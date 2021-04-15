using System;
using System.Collections.Generic;

//Bussiness class

namespace NZTours
{

    [Serializable]

    //Must be public so frmTour can read it
    public class clsTour
    {
        private string _ID;
        private string _TourDescription;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        private Decimal _Distance;
        private Decimal _Passengers = 1; //default value set
        private decimal _MarkUp;


        private static frmTour _Form = new frmTour();
        private List<clsCost> _costList = new List<clsCost>();

       // Represents a added tour as a string 
    public override string ToString ()

    {

            return _ID + "  \t  " + _TourDescription + "        \t        " + _StartDate.ToShortDateString() + "     \t     " + Pricepp() ;

    }

        public  bool ViewEdit ()

        {

            return _Form.ShowDialog(this);

        }


        //Properties or access methods

        public string ID

    {

        get { return _ID; }

        set { _ID = value; }
    }


        public string TourDescription

        {
            get { return _TourDescription; }

            set { _TourDescription = value; }
        }

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value;}
        }


        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        public decimal Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }
        
        public decimal Passenger
        {
            get { return _Passengers; }
            set { _Passengers = value; }

        }

        public decimal MarkUp
        {
            get { return _MarkUp; }
            set { _MarkUp = value; }
        }

      
        //Cost functions -----

            //Method that calculates all cost using a loop

            public decimal calcTourCost()
        {
            decimal lcTourCost = 0;
            foreach (clsCost lcCost in CostList)
            {
                lcTourCost += lcCost.amount(this); //is going to return the Tour cost as the ammount method from clsCost
                
            }
            return lcTourCost;
        }

        public decimal Pricepp()
        {
            decimal pricepp = calcTourCost() / _Passengers;
            return pricepp + MarkUp / 100 * pricepp;
        }
      


        // CostList Property
        public List<clsCost> CostList { get => _costList; set => _costList = value; }
    }
}
 

