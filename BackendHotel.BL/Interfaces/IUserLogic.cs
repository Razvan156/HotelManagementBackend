﻿using BackendHotel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendHotel.BL.Interfaces
{
    public interface IUserLogic
    {
        void Register(string username);
    }
}
