﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    interface ICompany
    {
        string Logo { get; set; }
        bool HasMultipleModels { get; set; }
    }
}
