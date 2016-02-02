using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace assignment1
{
    class User_Interface
    {

        //Needs no backing felids

        //Uses Default Constructor

        //Method to print Main Menu
        public void Display_Main_Menu()
        {
            //Main Menu Display
            Console.WriteLine("Wine Collection Utility");
            Console.WriteLine("");
            Console.WriteLine("Choose one of the options below.");
            Console.WriteLine("1. Display entire Collection.");
            Console.WriteLine("2. Search for a single entry by ID Number");
            Console.WriteLine("3. Add a New Item to the _collection.");
            Console.WriteLine("4. Exit");
        }

        //Prints Menu for user search
        public void Search_Menu(out String search_Term)
        {
            
        
            //Prints Menu for user search
            Console.WriteLine("");
            Console.WriteLine("Enter the Id Number you would like to searc for.");
            search_Term = Console.ReadLine();
            Console.WriteLine("Searching for: " + search_Term);

        }

        //Method to print Add New Item Menu
        public void Add_New_Item()
        {


        }

        String selected_File = string.Empty;

        //Method to print file loading dialog.
        public void Load_File_Dialog(out String selected_File)
        {
            //Set inital directory
            OpenFileDialog Open = new OpenFileDialog();
            Open.InitialDirectory = Application.StartupPath;
                       
            
            //Allow user to select file to read.
            if(Open.ShowDialog() == DialogResult.OK)
            {
                selected_File = Open.FileName;
                
            }
            else
            {
                selected_File = string.Empty;
                Console.WriteLine("Please select a valid file to read from.");
            }
        }

        //Method to get data from the user.
        public void Query_User(out Int32 user_Int)
        {
            this.Display_Main_Menu();
            

            String user_Input = Console.ReadLine();           
            
            bool result = Int32.TryParse(user_Input, out user_Int);

            if(result == false)
            {
                Console.WriteLine("That is not a valid selection.");
                Console.WriteLine("Please try again.");
                Console.WriteLine();
                //Reprint Main Menu
                this.Display_Main_Menu();
                //Grab user input again
                user_Input = Console.ReadLine();
                
            }                                    
        }

        //Method to display output - Used to make future design changes easier.
        public void Print_Data(String data)
        {
            Console.WriteLine(data);
        }

    }
}
