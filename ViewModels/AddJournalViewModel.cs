﻿using Astro.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Astro.ViewModels
{
    public class AddJournalViewModel
    {
        public string JournalText { get; set; }
        public MoonPhaseInfo MoonPhase { get; set; }
        public AddJournalViewModel() { }
    }
}
