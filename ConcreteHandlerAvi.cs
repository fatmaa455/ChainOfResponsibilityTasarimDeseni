using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandlerAvi:PlayerHandler
    {
        public override void Play(string file)
        {
            if (file == "avi")
            {
                Console.WriteLine("avi oynatılıyor");
            }
            else
            {
                Console.WriteLine("geçersiz dosya formatı");
            }
        }
    }
}
