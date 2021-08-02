using AutoMapper;
using CoelsaContacts.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoelsaContacts.Application.Contacts.UpdateContact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Update(_mapper.Map<Domain.Entities.Contacts>(request));
            return result;
        }
    }
}
