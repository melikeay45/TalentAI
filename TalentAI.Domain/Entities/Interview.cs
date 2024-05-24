using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Common;

namespace TalentAI.Domain.Entities
{
    public class Interview:EntityBase<Guid>
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Interviewer { get; set; }
        public string Feedback { get; set; }
    }
}
