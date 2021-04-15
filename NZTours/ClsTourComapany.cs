using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace NZTours
{

    public class ClsTourCompany
    {
        //public static List<clsTour> _TourList = new List<clsTour>();
        private static Dictionary<string, clsTour> _TourList = new Dictionary<string, clsTour>();
        static string filename = "C:\\Users\\Dee\\Desktop\\NZTours\\NZTours.txt";
        public static Dictionary<string, clsTour> TourList
        {
            get { return _TourList; }
        }




        //=======Serializable=============Save and retrive - usecase, Tutorial 7=====//
        public static void Save ()

        {
              
            using (FileStream lcFileStream = new FileStream(filename, FileMode.Create))

            {

                BinaryFormatter lcFormatter = new BinaryFormatter();

                lcFormatter.Serialize(lcFileStream, _TourList);

            }

        }



        public static void Retrieve ()
        {

            using (FileStream lcFileStream = new FileStream(filename, FileMode.Open))

            {

                BinaryFormatter lcFormatter = new BinaryFormatter();

                _TourList = (Dictionary<string, clsTour>)lcFormatter.Deserialize(lcFileStream);

            }
        }
    }
}





