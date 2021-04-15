using System;
using System.Linq;
using System.Windows.Forms;

namespace NZTours
{
    // Public Partial class is so that it can be seen by other gui classes
    public partial class frmMain : Form
    {

        //private clsTour _Tour;

        private frmTour _TourForm = new frmTour();



        //the forms constructor
        public frmMain ()
        {
            InitializeComponent();

        }




        //==========Serialize=====Save=======Retrieve===========//Usecase Save,Retrive
        private void frmMain_Load (object sender, EventArgs e)
        {
            try

            {

                ClsTourCompany.Retrieve();
                updateDisplay();

             
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

        }

 

        // ============btnClose form==========================//

        private void btnClose_Click (object sender, EventArgs e)
        {
            ClsTourCompany.Save();
            MessageBox.Show("Are you sure you want to close?");
            
            Close();

        }


        //============ Add a Tour - Tutorial 2 ==================//
        private void btnAdd_Click (object sender, EventArgs e)

        {

            clsTour lcTour = new clsTour();

            if (lcTour != null && lcTour.ViewEdit())



            {

                ClsTourCompany.TourList.Add(lcTour.ID, lcTour);

                updateDisplay();

            }


        }

        //========================Edit a tour===========================//

        private void EditTour ()

        {

            clsTour lcTour = (clsTour)lstTour.SelectedItem;

            if (lcTour != null &&

            lcTour.ViewEdit())

            {

                updateDisplay();

            }

        }

        private void btnEdit_Click (object sender, EventArgs e)
        {
            EditTour();
        }



        //===============Update display tourlist information from dictionary ToString()===========// 

        private void updateDisplay ()
        {
            lstTour.DataSource = null;
            lstTour.DataSource = ClsTourCompany.TourList.Values.ToList(); //tutorial 6
        }





        //==============Tutorial 6 {not asked for} FindTour=====================//
        private void btnFind_Click (object sender, EventArgs e)
        {
            clsTour lcTour;

            if (ClsTourCompany.TourList.TryGetValue(txtDescription.Text, out lcTour))

            {

                lstTour.SelectedItem = lcTour;

            }
        }

        //========== Usecase Delete a Tour================//

        private void btnDelete_Click (object sender, EventArgs e)
        {
            {
                clsTour lcTour = (clsTour)lstTour.SelectedItem;  
                ClsTourCompany.TourList.Remove(lcTour.ID.ToString());
                if (lcTour != null && MessageBox.Show("This Tour will be permanantly deleted, would you like to continue?", "Delete Tour", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    
                    updateDisplay();
                }


            }
        }

       
    }
}

