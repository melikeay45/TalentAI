using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Common;

namespace TalentAI.Domain.Entities
{
    public class Requirement:EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
