using Dasi.Rd.Core.Service;
using Dasi.Rd.Data.Context;
using Dasi.Rd.Data.Entities;
using System;
using System.Linq;

namespace Dasi.Rd.Services.SynodaService
{
    public class SynodaService : GenericService<Synoda, ApplicationContext, ISynodaService>, ISynodaService
    {
        private readonly ApplicationContext context;
        public SynodaService(ApplicationContext context) : base(context)
        {
            Console.Write(" ==================> NEW INSTANCE <================== ");
            this.context = context;
        }
    }
}