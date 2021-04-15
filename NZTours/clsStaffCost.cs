using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZTours
{
    [Serializable]
    class clsStaffCost : clsCost
    {

        private static frmStaffCost _Form = new frmStaffCost();
        private string _Type;

        public string Type { get => _Type; set => _Type = value; }

        public override bool ViewEdit ()
        {
           return _Form.ShowDialog(this);
        }

        public override string typeOfCost => "Staff";

        public override decimal amount (clsTour prTour)
        {
            double numberOfDays = (prTour.EndDate - prTour.StartDate).TotalDays + 1;
            return InputAmmount * Convert.ToDecimal(numberOfDays);
        }
    }


}
//over ride viewEdit()
//over ride calCost(): decimal
//cost type(): string
//these will be for all 3 cost forms
