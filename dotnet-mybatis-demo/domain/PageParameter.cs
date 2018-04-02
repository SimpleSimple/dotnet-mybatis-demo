using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class PageParameter
    {
        public PageParameter(int start, int page_size)
        {
            this.start = start;
            this.page_size = page_size;
        }
        public int start { get; set; }
        public int page_size { get; set; }
    }
}
