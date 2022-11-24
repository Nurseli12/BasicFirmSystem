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

namespace BasicFirmSystem.Application.CQRS.CurrentCards.Commands.CreateCurrentCard
{
    public class CreateCurrentCard_Handler : IRequestHandler<CreateCurrentCard_Request, CreateCurrentCardDto>
    {
        private readonly ICurrentCardRepository _currentCardRepository;
        private readonly CurrentCardBusinessRule _currentCardBusinessRule;
        private readonly IMapper _mapper;

        public CreateCurrentCard_Handler(
            ICurrentCardRepository currentCardRepository,
            IMapper mapper,
            CurrentCardBusinessRule currentCardBusinessRule
            )
        {
            _currentCardRepository=currentCardRepository;
            _currentCardBusinessRule=currentCardBusinessRule;
            _mapper=mapper;
        }


        public async Task<CreateCurrentCardDto> Handle(CreateCurrentCard_Request request, CancellationToken cancellationToken)
        {
            await _currentCardBusinessRule.CurrentCardCanNotDuplicated(request.Name);
            CreateCurrentCardDto createdCurrentCard =_mapper.Map<CreateCurrentCardDto>(await _currentCardRepository.AddAsync(_mapper.Map<CurrentCard>(request)));
            return createdCurrentCard;
              
        }
    }
}

