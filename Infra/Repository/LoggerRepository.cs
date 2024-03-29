﻿using Infra.Contexts;
using Infro.InfroService;
using Infro.Model;


namespace Infra.Repository
{
    public class LoggerRepository : ILogger
    {
        private readonly MyContext _context;

        public LoggerRepository(MyContext context)
        {
            _context = context;
        }

        public void RequestInformation(Logger Request)
        {
            _context.Logs.Add(Request);
            _context.SaveChanges();
        }
    }
}
