using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZTours



    //clsVehilce inherits from clsCost
{
    [Serializable]
    class clsVehicleCost : clsCost
    {
        //Instantiates a new object
        private static frmVehicle _Form = new frmVehicle();


        public override bool ViewEdit ()
        {
           return _Form.ShowDialog(this);
        }

        public override string typeOfCost => "Vehicle";



        //Cost Per kilometre from overriden Inputammount X Distance in ClsTour 
        public override decimal amount (clsTour prTour)
        {
            return InputAmmount * prTour.Distance;
        }
    }
}
