using AutoMapper;
using BasicFirmSystem.Application.CQRS.CurrentCards.Dtos;
using BasicFirmSystem.Application.CQRS.CurrentCards.Rules;
using BasicFirmSystem.Entities.Concretes;
using BasicFirmSystem.Persistence.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Application.CQRS.CurrentCards.Commands.UpdateCurrentCard
{
    public class UpdateCurrentCard_Handler : IRequestHandler<UpdateCurrentCard_Request, CreateCurrentCardDto>
    {

        private readonly ICurrentCardRepository _currentCardRepository;
        private readonly CurrentCardBusinessRule _currentCardBusinessRule;
        private readonly IMapper _mapper;

        public UpdateCurrentCard_Handler(
            ICurrentCardRepository currentCardRepository,
            IMapper mapper,
            CurrentCardBusinessRule currentCardBusinessRule
            )
        {
            _currentCardRepository=currentCardRepository;
            _currentCardBusinessRule=currentCardBusinessRule;
            _mapper=mapper;
        }

        public async Task<CreateCurrentCardDto> Handle(UpdateCurrentCard_Request request, CancellationToken cancellationToken)
        {
            if (request.ID == null)
                throw new Exception("ID boş olamaz");
            var update = _mapper.Map<CreateCurrentCardDto>(await _currentCardRepository.UpdateAsyncWithID(_mapper.Map<CurrentCard>(request),request.ID));
            return update;

        }
    }
}
