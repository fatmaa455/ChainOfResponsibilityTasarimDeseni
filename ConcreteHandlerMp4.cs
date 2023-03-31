using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ConcreteHandlerMp4 : PlayerHandler
    {
        public override void Play(string file)
        {
            if(file == "mp4")
            {
                Console.WriteLine("mp4 oynatılıyor");
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
