﻿using System;
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
        public List<WorkExperienceUpdateDto> WorkExperiences { get; set; }
        public List<CertificationUpdateDto> Certifications { get; set; }
        public List<SkillUpdateDto> Skills { get; set; }
    }
}
