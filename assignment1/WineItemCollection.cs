using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace assignment1
{
    class WineItemCollection
    {
        //Array of WineItems


        //Backing fields
        private WineItem[] collection;


        //Constructor
        public WineItemCollection()
        {
            //Instanciate array
            collection = new WineItem[4000];
            

        }


       //Method to add Items to the array.
        public void Add_To(String id_Numer, String description, String packaging, Int32 index)
        {

            WineItem newItem = new WineItem(id_Numer, description, packaging);
            collection[index] = newItem;

        }
       


    }
}
