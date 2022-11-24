using BasicFirmSystem.Entities.Concretes;
using BasicFirmSystem.Persistence.Paging;
using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Application.CQRS.CurrentCards.Rules
{
    public class CurrentCardBusinessRule
    {
        private readonly ICurrentCardRepository _currentCardRepository;

        public CurrentCardBusinessRule( ICurrentCardRepository currentCardRepository)
        {
            this._currentCardRepository=currentCardRepository;
        }
        public async Task CurrentCardCanNotDuplicated(string name)
        {
            IPaginate<CurrentCard> result = await _currentCardRepository.GetListAsync(x => x.Name == name);
            if (result.Items.Any())
                throw new Exception("Cari Kart Zaten Var");
        }
    }
}

