using System;

namespace NZTours
{
    [Serializable]
    class clsOtherCost : clsCost
    {
        private static frmOtherCost _Form = new frmOtherCost();
        private int _Units;

        public int Units { get => _Units; set => _Units = value; }

        public override bool ViewEdit ()
        {
          return  _Form.ShowDialog(this);
        }

        public override string typeOfCost => "Other";

        public override decimal amount (clsTour prTour)
        {
            return InputAmmount;
        }
    }
}
