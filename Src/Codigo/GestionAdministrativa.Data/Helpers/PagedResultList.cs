﻿using System.Collections.Generic;
using System.Linq;
using GestionAdministrativa.Data.Helpers;

namespace GestionAdministrativa.Data.Helpers
{
    public class PagedResultList<T>
    {
        public PagedMetadata PagedMetadata { get; set; }

        public IQueryable<T> Entities { get; set; }
    }
}
