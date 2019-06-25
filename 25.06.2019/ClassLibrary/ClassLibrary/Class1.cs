using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Plant { }
    internal class Flower : Plant { }
    public class Tree : Plant
    {
        private Flower flower;
        public string Type;
    }
}
