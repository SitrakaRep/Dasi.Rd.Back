using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Dasi.Rd.Data.Dto;
using Dasi.Rd.Data.Entities;
using Dasi.Rd.Services.SynodaService;
using Microsoft.AspNetCore.Mvc;

namespace Dasi.Rd.Web.Controllers.API
{
    public class SynodaController : Controller
    {
        private readonly ISynodaService _synoda;
        private readonly IMapper mapper;
        public SynodaController(IMapper mapper, ISynodaService synoda)
        {
            this.mapper = mapper;
            this._synoda = synoda;
        }

        [HttpGet]
        [Route("~/synoda/")]
        public async Task<IActionResult> GetAllSynoda()
        {
            var query = await _synoda.GetAllAsyn();

            List<Synoda> synodaList = new List<Synoda>();

            foreach (var item in query)
            {
                synodaList.Add(item);
            }

            return Ok(mapper.Map<List<Synoda>, List<SynodaDto>>(synodaList));

        }
    }
}