﻿using Deliverit.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deliverit.Models.Abstract
{
    public class Entity : IEntity
    {
        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }
    }
}
