﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IndirectlyApp.Models;

namespace IndirectlyApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Mosaic> Mosaics { get; set; }
    }
}