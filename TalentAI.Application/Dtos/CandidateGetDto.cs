﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Domain.Enums;

namespace TalentAI.Application.Dtos
{
    public class CandidateGetDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime ApplicationDate { get; set; }
        public CandidateStatus Status { get; set; }
        public List<WorkExperienceDTO> WorkExperiences { get; set; }
        public List<CertificationDTO> Certifications { get; set; }
    }
}