using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbolesavl
{
    public class AVLNode
    {
        public int? Value { get; set; }
        public AVLNode? Left { get; set; }
        public AVLNode? Right { get; set; }
        public int Height { get; set; }
        public AVLNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Height = 1;
        }
    }
}
