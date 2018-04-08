﻿using FormControls.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetScaffolder.Components.Common.Contract
{
    public interface IDataType
    {
        IHierarchy ReturnNavigation();
        object AddConfigUI(object parameters);
    }
}
