using AutoMapper;
using CoelsaContacts.Application.Contacts.AddContact;
using CoelsaContacts.Application.Contacts.DTO;
using CoelsaContacts.Application.Contacts.UpdateContact;

namespace CoelsaContacts.Application.Tasks.MappingProfiles
{
    public class TaskMappingProfile : Profile
    {
        public TaskMappingProfile()
        {
            CreateMap<AddContactCommand, Domain.Entities.Contacts>();
            CreateMap<UpdateContactCommand, Domain.Entities.Contacts>();
            CreateMap<Domain.Entities.Contacts, ContactDto>();
        }
    }
}
