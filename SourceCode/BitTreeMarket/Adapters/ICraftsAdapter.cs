﻿using BitTreeMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitTreeMarket.Adapters
{
    public interface ICraftsAdapter
    {
        CraftsVm GetCrafts();
    }
}