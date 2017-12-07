using kpiWebApiMvc.Models;
using kpiWebApiMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kpiWebApiMvc.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
        //public Contact[] Get(int? id)
        //{
        //    var contacts = new Contact[]
        //        {
        //        new Contact
        //        {
        //            id = 1,
        //            name = "David Zingg"
        //        },
        //        new Contact
        //        {
        //            id = 2,
        //            name = "Raphael W"
        //        }
        //        };

        //    if (id != null)
        //    {
        //        return contacts.Where(x => x.id == id).ToArray();
        //    }
        //    return contacts;
        //}
    }
}
