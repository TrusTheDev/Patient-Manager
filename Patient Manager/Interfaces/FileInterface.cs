﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Patient_Manager.Interfaces
{
    internal interface FileInterface<formatFile>
    {
        string CreationDate { get; set; }
        string MonthName { get; set; }
        string Format { get; set; }
        string Source { get; set; }

        formatFile RepairFile();
    }
}
