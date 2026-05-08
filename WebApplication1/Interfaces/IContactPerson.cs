using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.RequestApiModels;

namespace WebApplication1.Interfaces
{
    public interface IContactPerson
    {
        Response AddContactPerson(ContactPersonRequestAPI requestAPI);
        Response UpdateContactPerson(ContactPersonRequestAPI requestAPI);
        Response GetAllContactPersons(ContactPersonRequestAPI requestAPI);
        Response GetContactPersonById(ContactPersonRequestAPI requestAPI);
        Response GetContactPersonByPhone(ContactPersonRequestAPI requestAPI);
        Response UpdateContactPersonStatus(ContactPersonRequestAPI requestAPI);
        Response SearchContactPersons(ContactPersonRequestAPI requestAPI);
        Response GetContactPersonByEmail(ContactPersonRequestAPI requestAPI);
        Response GetActiveContactPersons(ContactPersonRequestAPI requestAPI);
    }
}

