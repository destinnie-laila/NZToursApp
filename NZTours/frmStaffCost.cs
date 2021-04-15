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
    public partial class frmStaffCost : frmCost
    {
        public frmStaffCost ()
        {
            InitializeComponent();
        }

        protected override void updateDisplay ()
        {
            base.updateDisplay();
            clsStaffCost lcCost = (clsStaffCost)_Cost;
            txtStaffType.Text = lcCost.Type;
        }

        protected override void pushData ()
        {
            base.pushData();
            clsStaffCost lcCost = (clsStaffCost)_Cost;
            lcCost.Type = txtStaffType.Text;
        }
    }
}
