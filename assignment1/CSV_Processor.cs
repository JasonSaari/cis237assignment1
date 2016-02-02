using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace assignment1
{
    class CSV_Processor
    {
       
        public bool Load_CSV(String path_CSV, WineItem[] collection)
        {

            //StreamReader
            StreamReader streamreader = null;

            try
            {
                //Used to read in data 
                String raw_Data = String.Empty;

                //Create new StreamReader
                streamreader = new StreamReader(path_CSV);

                //Counter for indexing
                Int32 counter = 0;

                //Read in data, and stop when a null is found
                while((raw_Data = streamreader.ReadLine()) != null)
                {
                    Process_Data(raw_Data, collection, counter);
                    counter++;
                }
                return true;
            }
            catch (Exception ex)
            {
                //Print any exceptions thrown
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(streamreader != null)
                {
                    //close streamReader 
                    streamreader.Close();
                }
            }
            return false;
        }
        
        //accecpts data and breaks it into the parts needed to define a WineItem
        private void Process_Data(String raw_Data, WineItem[] collection, Int32 index)
        {
            //Holder for the split data
            String[] spliter = raw_Data.Split(',');

            //local holder for each data part
            String id_number = spliter[0];
            String description = spliter[1];
            String packaging = spliter[2];

            //Fill array with WineItems
            collection[index] = new WineItem(id_number, description, packaging);
            

        }
                   
    }
}
