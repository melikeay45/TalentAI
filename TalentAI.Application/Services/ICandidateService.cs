﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Application.Dtos;

namespace TalentAI.Application.Services
{
    public interface ICandidateService
    {
        CandidateGetDto GetById(int id);
        List<CandidateGetDto> GetAll();
        void Add(CandidateAddDto candidateAddDto);
        void Update(int id, CandidateUpdateDTO candidateUpdateDto);
        void Delete(int id);
    }
}
