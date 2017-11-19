using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrumMIDIWcfService.Models;
using Microsoft.AspNetCore.Cors;

namespace WsDrumMidi.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class NoteController : Controller
    {
        private readonly DrumMidiContext _context;

        public NoteController(DrumMidiContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult  GetAll()
        {
            var notes = _context.Notes.ToList();
            
            return Ok( notes);
        }
    }
}
