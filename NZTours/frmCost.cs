using System;
using System.Windows.Forms;

namespace NZTours
{
    public partial class frmCost : Form
    {
        protected clsCost _Cost;

        public frmCost ()
        {
            InitializeComponent();
        }

        public bool ShowDialog (clsCost prCost)
        {

            _Cost = prCost;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay ()
        {
            txtInput.Text = _Cost.InputText;
            nupAmmount.Value = _Cost.InputAmmount;
        }

        protected virtual void pushData ()

        {
            _Cost.InputText = txtInput.Text;
            _Cost.InputAmmount = nupAmmount.Value;
        
        }

        private void btnOK_Click (object sender, EventArgs e)
        {
            pushData();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
