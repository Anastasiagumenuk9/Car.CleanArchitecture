﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IGoogleAuthenticateService
    {
        Task<string> SignInGoogle(AuthenticateResult authResult);
    }
}
