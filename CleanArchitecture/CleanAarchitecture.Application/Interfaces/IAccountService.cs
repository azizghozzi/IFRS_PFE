﻿using CleanAarchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanAarchitecture.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<accountViewModel> Getaccounts { get; set; }
    }
}
