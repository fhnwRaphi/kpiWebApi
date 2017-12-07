using kpiWebApiMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kpiWebApiMvc.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
            {
            new Contact
            {
                id = 1,
                name = "Glenn Block"
            },
            new Contact
            {
                id = 2,
                name = "Dan Roth"
            }
            };
        }
    }
}