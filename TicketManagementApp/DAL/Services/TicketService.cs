using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TicketManagementApp.DAL.Interfaces;
using TicketManagementApp.Model;

namespace TicketManagementApp.DAL.Services
{
    public class TicketService : Interfaces.ITicketService
    {
        private Interfaces.ITicketRepository _repository;

        public TicketService(Interfaces.ITicketRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}