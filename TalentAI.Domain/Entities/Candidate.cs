using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Common;
using TalentAI.Domain.Enums;

namespace TalentAI.Domain.Entities
{
    public class Candidate : EntityBase<Guid>
    {

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ApplicationDate { get; set; }
        public CandidateStatus Status { get; set; } 

        // İlişkisel bağlantılar
        public List<WorkExperience> WorkExperiences { get; set; }
        public List<Certification> Certifications { get; set; }

    }
}
