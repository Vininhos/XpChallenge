using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Repositories;

namespace Xp.Services.Service
{
    public class CorretoraService
    {
       private readonly ICorretoraRepository _corretoraRepository;

        public CorretoraService(ICorretoraRepository corretoraRepository)
        {
            _corretoraRepository = corretoraRepository;
        }

        public List<Corretora> GetAll()
        {
            return _corretoraRepository.GetAll();
        }

        public Corretora SearchById(int id)
        {
            return _corretoraRepository.SearchById(id);
        }

        public void Save(Corretora corretora)
        {
            _corretoraRepository.Save(corretora);
        }

        public void Update(Corretora corretora)
        {
            _corretoraRepository.Update(corretora);
        }

        public void Delete(int id)
        {
            _corretoraRepository.Delete(id);
        }
    }
}
