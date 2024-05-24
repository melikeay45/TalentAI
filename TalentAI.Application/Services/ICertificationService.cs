using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentAI.Application.Dtos;

namespace TalentAI.Application.Services
{
    public interface ICertificationService
    {
        CertificationDto GetById(Guid id);
        List<CertificationDto> GetAll();
        void Add(CertificationAddDto certificationAddDto);
        void Update(int id, CertificationUpdateDto certificationUpdateDto);
        void Delete(int id);
    }
}
