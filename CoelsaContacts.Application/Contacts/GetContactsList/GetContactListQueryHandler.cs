using AutoMapper;
using CoelsaContacts.Application.Contacts.DTO;
using CoelsaContacts.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoelsaContacts.Application.Contacts.GetContactsList
{
    class GetContactListQueryHandler : IRequestHandler<GetContactListQuery, List<ContactDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetContactListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ContactDto>> Handle(GetContactListQuery request, CancellationToken cancellationToken)
        {
            List<ContactDto> contactsList = new List<ContactDto>();
            var paginatedContact = await _unitOfWork.Contacts.GetByCompany(request.Company, request.PageIndex, request.PageSize);

            foreach ( var c in paginatedContact)
            {
                var dto = _mapper.Map<Domain.Entities.Contacts, ContactDto>(c);
                contactsList.Add(dto);

            }

            return contactsList;

        }
    }
}
