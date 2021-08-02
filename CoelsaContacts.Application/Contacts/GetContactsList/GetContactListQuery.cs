using CoelsaContacts.Application.Contacts.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoelsaContacts.Application.Contacts.GetContactsList
{
    public class GetContactListQuery :  IRequest<List<ContactDto>>
    {
        public GetContactListQuery(string company, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Company = company;
        }

        public int PageIndex { get; }

        public int PageSize { get; }
        public string Company { get; }
    }
}

