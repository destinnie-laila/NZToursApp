using System;

namespace NZTours
{
    //Abstarct due to no use other than what the frmCosts DO, needs to be public so the cost forms can see it

    [Serializable]
    public abstract class clsCost
    {
        private string _InputText;
        private decimal inputAmmount;
        public static string[] costType = { "staff", "vehicle", "other" };




        //Name of Inout text depending on form chosen
        public string InputText

        { get => _InputText; set => _InputText = value; }


        //The input ammout depending on form chosen

        public decimal InputAmmount

        { get => inputAmmount; set => inputAmmount = value; }


        //choice parametre for picking a cost type

        public static clsCost newCost (int prChoice)
        {
            if (prChoice == 0)//Staff Form
            {
                return new clsStaffCost();
            }

            else if (prChoice == 1)//Vehicle Form
            {
                return new clsVehicleCost();
            }

            else //Othercost Form
            {
                return new clsOtherCost();  
            }

            
        }

        public abstract string typeOfCost
        {
            get;
        }

        //ViewEdit method which is overridden in each corresponding Cost form

        public abstract bool ViewEdit (); //tutorial 4


        public override string ToString () //tutorial 4
        {
            return _InputText + "     \t     " + typeOfCost + "    \t    " + InputAmmount; 
        }



        public abstract decimal amount(clsTour prTour); 
        



        //class cost list<abstract>

        // cost will have they will protected and visibal so subclases can see them
        //#name: string
        //#input ammount: decimal - references the cost of things like distance and daily charge
        //#CostType():String <abstarct> what do you want to return there? they will respond there own way

    }
}

//input ammount multiplied by xxx

    //variable called tour in class tour to have access to ..
    //viewEdit() - also be over ridden in the sub classes
    // do not store cost ammount make it dynamic - +calcCost():decimal - <make abstract> means calculation will happen in sub classes

    //you want a to string() method in here as well
    //+ToString():string
    //NewCost(prChoice:int):clsCost -static-
    //pass a choice into the facotry
