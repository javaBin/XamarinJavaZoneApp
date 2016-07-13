using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaZone.Pcl.Utils
{
    public class Grouping<T, TV> : ObservableRangeCollection<TV>
    {
        public T Key { get; private set; }

        public Grouping(T key, IEnumerable<TV> items)
        {
            Key = key;
            AddRange(items);
        }
    }
}
