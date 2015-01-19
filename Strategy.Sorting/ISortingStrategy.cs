using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorting
{
    public interface ISortingStrategy
    {
        List<int> Sort(List<int> list);
    }
}
