﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public interface ISushiSetCollection
    {
        void AddSet(SushiSet sushiSet);

        List<SushiSet> GetSushiList();
    }
}