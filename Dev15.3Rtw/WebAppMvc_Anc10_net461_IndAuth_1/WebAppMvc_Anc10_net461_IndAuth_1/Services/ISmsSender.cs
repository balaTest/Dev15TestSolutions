﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvc_Anc10_net461_IndAuth_1.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
