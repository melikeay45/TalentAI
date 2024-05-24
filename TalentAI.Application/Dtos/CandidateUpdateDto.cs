using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Enums;

namespace TalentAI.Application.Dtos
{
    public class CandidateUpdateDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public CandidateStatus Status { get; set; }
        public List<WorkExperienceUpdateDTO> WorkExperiences { get; set; }
        public List<CertificationUpdateDTO> Certifications { get; set; }
    }
}
