using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TicketManagementApp.DAL.Interfaces;

namespace TicketManagementApp.DAL.Services
{
    public class TicketRepository : Interfaces.ITicketRepository
    {
        private TicketDbContext _context;

        public TicketRepository(TicketDbContext context)
        {
            _context = context;
        }

        public Model.TicketModel GetById(int id)
        {
            //write your code here
            throw new NotImplementedException();
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