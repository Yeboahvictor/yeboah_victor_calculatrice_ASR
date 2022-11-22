using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
     public class Operation
    {

        public string Leftside { get; set; }


        public string Rightside { get; set; }



        public OperationType OperationType { get; set; }



        public OperationType InnerOperation
            { get; set; }





        //THIS IS THE PART FOR THE DEFAULT CONSTRUCTOR

        public Operation()
        {
            this.Leftside = string.Empty;
            this.Rightside = string.Empty;

        }
    }
}
