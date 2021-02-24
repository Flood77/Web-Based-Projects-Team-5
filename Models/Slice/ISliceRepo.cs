using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Breaddit.Models
{
    public interface ISliceRepo
    {
        IEnumerable<Slice> GetAllSlices();

        bool addSlice(Slice slice);

        bool deleteSlice(int sliceID);

        bool updateSlice(Slice slice);
    }
}
