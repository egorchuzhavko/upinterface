﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd2
{
    internal interface iFigure
    {
        double X { get; set; }
        double Y { get; set; }

        double Square();
    }
}
