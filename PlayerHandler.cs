using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class PlayerHandler
    {
        // Handler
        public PlayerHandler sonraki;
        public PlayerHandler Sonraki
        {
            set
            {
                sonraki = value;
            }
        }

        public abstract void Play(string file);
    }
}
