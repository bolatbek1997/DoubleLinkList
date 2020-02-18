using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
    public class Node
    {
        public string Title { get; set; }
        public Node PreviousLink { get; set; }
        public Node NextLink { get; set; }

        public Node(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
