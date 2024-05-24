using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Application.Dtos;

namespace TalentAI.Application.Services
{
    public interface IWorkExperienceService
    {
        WorkExperienceDto GetById(Guid id);
        List<WorkExperienceDto> GetAll();
        void Add(WorkExperienceAddDto workExperienceAddDto);
        void Update(int id, WorkExperienceUpdateDto workExperienceUpdateDto);
        void Delete(int id);
    }
}
