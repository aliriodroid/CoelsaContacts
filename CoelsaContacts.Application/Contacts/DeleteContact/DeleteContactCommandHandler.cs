using CoelsaContacts.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoelsaContacts.Application.Contacts.DeleteContact
{
    class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteContactCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Contacts.Delete(request.Id);
            return result;
        }
    }
}
