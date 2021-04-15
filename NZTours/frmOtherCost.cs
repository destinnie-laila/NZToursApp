using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZTours
{
    public partial class frmOtherCost : frmCost
    {
        public frmOtherCost ()
        {
            InitializeComponent();
        }

        protected override void updateDisplay ()
        {
            base.updateDisplay();
            clsOtherCost lcCost = (clsOtherCost)_Cost;
            nupUnits.Value = lcCost.Units;
        }

        protected override void pushData ()
        {
            base.pushData();
            clsOtherCost lcCost = (clsOtherCost)_Cost;
            lcCost.Units = Convert.ToInt32(nupUnits.Value);
        }
    }
}
