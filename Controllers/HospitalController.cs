using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using webapi.Data;

namespace Hospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        // private static readonly string[] Hospials = new[]
        // {
        //     "Bowring & Lady Curzon Hospital", "Central Leprosorium", "E.S.I Hospital", "Epidemic Diseases Hospial", "Haji Sir Ismail Sait Ghosha Hospital", "Indira Gandhi Institute of Child Health Hospital", "Jayadeva Institute of Cardiology", "K C General Hospital", "Kidwai Memorial Institute of Oncology", "Lady Willington State T.B Centre"
        // };

        // private readonly ILogger<HospitalController> _logger;

        // public HospitalController(ILogger<HospitalController> logger)
        // {
        //     _logger = logger;
        // }
        private readonly Datacontext _datacontext;

        public HospitalController(Datacontext datacontext)
        {
            _datacontext = datacontext;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var value = await _datacontext.Value.ToListAsync();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Getid(string id)
        {
            var value = await _datacontext.Value.FirstOrDefaultAsync(x => x.Id==id);
            return Ok(value);
        }

        

    }
}
