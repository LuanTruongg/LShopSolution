﻿using System.Collections.Generic;

namespace LShopSolution.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items {get; set;}
    }
}
