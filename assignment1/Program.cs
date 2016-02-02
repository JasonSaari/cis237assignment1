///Programed by: Jason Saari
///Date:         2/1/16
///  Assignment 1 - Classes Review - Wine List
/// 
///I should have started much much earlier, but I did not. 
/// And there is no way to finish this now, so I am submitting it as ususally something will score better than nothing. 
/// But I get that this is pretty close to nothing.  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace assignment1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
           
            User_Interface UI = new User_Interface();
            CSV_Processor cSV = new CSV_Processor();
            

            String file_Selection = string.Empty;
            Int32 user_Choice = 0;
            String search_Term = string.Empty;

            //creating an array of WineItems
            //I know this should be in a class, but I cannot make it work.  
            //Something is usually better than nothing.
            WineItem[] collection = new WineItem[4000];
            Int32 i = 0;


            //Have user select the file to read from.
            UI.Load_File_Dialog(out file_Selection);

            cSV.Load_CSV(file_Selection, collection);

            UI.Query_User(out user_Choice);



            

            switch (user_Choice)
            {
                case 1:
                    {
                        foreach(WineItem item in collection)
                        {

                            if (collection != null)
                            {
                                Console.WriteLine((collection[i]));
                                i++;
                            }
                        }
                        Console.ReadLine();
                        UI.Query_User(out user_Choice);
                        break;
                    }
                case 2:
                    {

                        UI.Search_Menu(out search_Term);
                        break;

                    }




            }
            
            

        }

      //static string Seach_List(WineItem[] collection, String search_Term)
      //  {

      //      for(Int32 index = 1; index < 4000; index++)
      //      {
      //          if (collection[index] == search_Term)
      //      }

      //  }



    }
}
