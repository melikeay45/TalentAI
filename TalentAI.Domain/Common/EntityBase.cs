﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentAI.Domain.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

    }
}
