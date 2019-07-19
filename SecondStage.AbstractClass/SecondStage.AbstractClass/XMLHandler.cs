using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.AbstractClass
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML file is Opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML file is Created");
        }
        public override void Change()
        {
            Console.WriteLine("XML file is Changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML file is Saved");
        }
    }
}
