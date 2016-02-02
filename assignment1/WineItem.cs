using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace assignment1
{
    class WineItem
    {

        //Defines Each WineItem Object.


        //Backing Fields
        private String _id_Number;
        private String _description;
        private String _packaging;

        //Properties for the backing fields
        public String Id_Number
        {
            get { return _id_Number; }
            set { _id_Number = value; }
        }

        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public String Packaging
        {
            get { return _packaging; }
            set { _packaging = value; }
        }

        //ToString Override Method
        //Formats to chosen output
        public override string ToString()
        {
            return this._id_Number + " " + this._description + " " + this._packaging;
        }

        //Constructor - 3 Parameter
        public WineItem(String _id_Number, String _description, String _packaging)
        {
            this.Id_Number = _id_Number;
            this.Description = _description;
            this.Packaging = _packaging;
        }






    }
}
