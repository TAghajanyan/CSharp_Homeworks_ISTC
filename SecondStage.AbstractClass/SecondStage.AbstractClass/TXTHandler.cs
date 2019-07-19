using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.AbstractClass
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file is Opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT file is Created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT file is Changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT file is Saved");
        }
    }
}
