using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.AbstractClass
{
    class DOCHandler : AbstractHandler
    {

        public override void Open()
        {
            Console.WriteLine("DOC file is Opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC file is Created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC file is Changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC file is Saved");
        }
    }
}
