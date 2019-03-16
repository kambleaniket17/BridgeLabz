using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure.Test
{
    internal class LinkListStack
    {
        Node top;
        public LinkListStack()
        {
            this.Top = null;
        }

        internal Node Top { get => top; set => top = value; }
    }
}
