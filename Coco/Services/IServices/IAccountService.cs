﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coco.Services.IServices
{
    public interface IAccountService
    {
        int CreateAccount();

        dynamic CheckBalance();
        string ShowAll();
    }
}
