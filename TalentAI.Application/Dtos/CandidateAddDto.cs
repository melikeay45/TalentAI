using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Entities;
using TalentAI.Domain.Enums;

namespace TalentAI.Application.Dtos
{
    public class CandidateAddDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ApplicationDate { get; set; }
        public CandidateStatus Status { get; set; }
        public List<WorkExperienceAddDto> WorkExperiences { get; set; }
        public List<CertificationAddDto> Certifications { get; set; }
        public List<SkillAddDto> Skills { get; set; }


    }
}
