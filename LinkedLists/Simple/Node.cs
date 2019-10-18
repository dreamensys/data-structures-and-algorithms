using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Simple
{
    public class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }

        public Node(object _data) {
            Data = _data;
        }

    }
}
