using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandlerMpg : PlayerHandler
    {
        public override void Play(string file)
        {
            if(file == "mpg")
            {
                Console.WriteLine("mpg oynatılıyor");
            }
            else
            {
                if(sonraki != null)
                {
                    sonraki.Play(file);
                }
            }
        }
    }
}
