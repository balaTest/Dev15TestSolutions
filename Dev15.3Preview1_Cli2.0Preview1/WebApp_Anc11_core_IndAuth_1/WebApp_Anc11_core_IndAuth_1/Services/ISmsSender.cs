﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Anc11_core_IndAuth_1.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
