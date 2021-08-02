using AutoMapper;
using CoelsaContacts.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoelsaContacts.Application.Contacts.AddContact
{
    public class AddContactCommandHandler : IRequestHandler<AddContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(AddContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Add(_mapper.Map<Domain.Entities.Contacts>(request));
            return result;
        }
    }
}
