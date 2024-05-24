using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Application.Dtos;

namespace TalentAI.Application.Services
{
    public interface ISkillService
    {
        SkillDto GetById(Guid id);
        List<SkillDto> GetAll();
        void Add(SkillAddDto skillAddDto);
        void Update(int id, SkillUpdateDto skillUpdateDto);
        void Delete(int id);
    }
}
