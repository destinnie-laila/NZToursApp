using System;
using System.Windows.Forms;

namespace NZTours
{
    // frmTour is public partial'has code in another class for this'clsTour' Also inherits from .NET superclass
    public partial class frmTour : Form
    { 
        //member variable for a class type, frmTour depends on clsTour
        private clsTour _Tour; 
        private clsTour _TempTour = new clsTour();


        public frmTour ()

        { //Tutorial 4(StudentTypes)
            InitializeComponent();
            cboCostType.DataSource = clsCost.costType;
            cboCostType.SelectedIndex = 0;
        }



        public bool ShowDialog(clsTour prTour)

        {
            
            _Tour = prTour;

            _TempTour.CostList.Clear();//make sure empty

            foreach (clsCost cost in _Tour.CostList)
            {
                _TempTour.CostList.Add(cost);
            }


            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        
        //===========Updates Displays the values given for the tour=======//
        private void updateDisplay()
        {

            dtpStart.MaxDate = DateTimePicker.MaximumDateTime;
            dtpEnd.MinDate = DateTimePicker.MinimumDateTime;
            txtID.Text = _Tour.ID;
            txtDescription.Text = _Tour.TourDescription;
            nupDistance.Value = _Tour.Distance;
            nupPassanger.Value = _Tour.Passenger;
            dtpStart.Value = _Tour.StartDate;
            dtpEnd.Value = _Tour.EndDate;
            nupMarkup.Value = _Tour.MarkUp;
            txtID.Enabled = String.IsNullOrEmpty(_Tour.ID);
            updateLabels();
        }

        private void updateLabels() //acts as push data
        {
            _TempTour.ID = txtID.Text;
            _TempTour.TourDescription = txtDescription.Text;
            _TempTour.Passenger = nupPassanger.Value;
            _TempTour.Distance = nupDistance.Value;
            _TempTour.StartDate = dtpStart.Value;
            _TempTour.EndDate = dtpEnd.Value;

            dtpStart.MaxDate = _TempTour.EndDate;
            dtpEnd.MinDate = _TempTour.StartDate;

            _TempTour.MarkUp = nupMarkup.Value;

            lstCost.DataSource = null;
            lstCost.DataSource = _TempTour.CostList;

            //Read only feilds, will be changed once editing has been done
            lblTotalCost.Text = string.Format("{0:C}", _TempTour.calcTourCost());
            lblPricepp.Text = string.Format("{0:C}", _TempTour.Pricepp());

        }



        //========Sending all values and updating Lists========//

        private void btnOK_Click (object sender, EventArgs e)
        {
            _Tour.ID = txtID.Text;
            _Tour.TourDescription = txtDescription.Text;
            _Tour.Passenger = nupPassanger.Value;
            _Tour.Distance = nupDistance.Value;
            _Tour.StartDate = dtpStart.Value;
            _Tour.EndDate = dtpEnd.Value;
            _Tour.MarkUp = nupMarkup.Value;


            _Tour.CostList.Clear();//update tour list to be = with temp cost list

            foreach (clsCost cost in _TempTour.CostList)
            {
                _Tour.CostList.Add(cost);
            }


            if (txtID.Enabled && ClsTourCompany.TourList.ContainsKey(txtID.Text))
                MessageBox.Show("Sorry the I.D value already exists", "Duplicate ID");

            else
            {
                updateLabels();
                DialogResult = DialogResult.OK;
            }

          
            
        }


        //====== Discards editing/Adding/Deleting=================//


        private void btnCancel_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        //=====================Add, Edit, Delete Cost Usecases=============//

        private void btnAddCost_Click (object sender, EventArgs e)
        {
            clsCost lcCost = clsCost.newCost(cboCostType.SelectedIndex);

            if (lcCost != null && lcCost.ViewEdit())

            {

                _TempTour.CostList.Add(lcCost);

                updateLabels();

            }


        }

        private void btnDelete_Click (object sender, EventArgs e)
        {
            clsCost lcCost = (clsCost)lstCost.SelectedItem;  //cost currently selected

            if (lcCost != null && MessageBox.Show("This cost will be permanantly deleted, would you like to continue?", "Delete Costs",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.Yes)
            {
                _TempTour.CostList.Remove(lcCost);
                updateLabels();
            } 


        }


        private void btnEditCost_Click (object sender, EventArgs e)
        {
            clsCost lcCost = (clsCost)lstCost.SelectedItem;
            if (lcCost != null && lcCost.ViewEdit())
            {
                updateLabels();
            }

        }



        //==============================Updates the labels when values are edited====================//
        private void nupDistance_ValueChanged (object sender, EventArgs e)
        {
            updateLabels();
        }

        private void nupPassanger_ValueChanged (object sender, EventArgs e)
        {
            updateLabels();
        }

        private void dtpStart_ValueChanged (object sender, EventArgs e)
        {
            updateLabels();
        }

        private void dtpEnd_ValueChanged (object sender, EventArgs e)
        {
            updateLabels();
        }

        private void nupMarkup_ValueChanged (object sender, EventArgs e)
        {
            updateLabels();
        }






    }
}
