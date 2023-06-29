﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LShopSolution.ViewModels.Authen.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItems> Roles { get; set; } = new List<SelectItems>();
    }
}