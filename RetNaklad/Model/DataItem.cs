using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace RetNaklad.Model
{
    public class DataItem
    {
        public DataItem(ReturnNaklad returnNaklad)
        {
            Naklad = returnNaklad;
        }

        public ReturnNaklad Naklad
        {
            get;
            private set;
        }
    }
}
