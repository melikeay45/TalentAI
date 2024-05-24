using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Common;

namespace TalentAI.Domain.Entities
{
    public class JobPosition:EntityBase<Guid>
    {
            public string Title { get; set; }
            public string Description { get; set; }

            //ilişkiler
            public List<Requirement> Requirements { get; set; }
            public List<Candidate> Candidates { get; set; }
        
    }
}
