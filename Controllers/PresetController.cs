using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrumMIDIWcfService.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;

namespace WsDrumMidi.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    public class PresetController : Controller
    {
        private readonly DrumMidiContext _context;

        public PresetController(DrumMidiContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Preset> GetAll()
        {
            return _context.Presets
                        .Include(p => p.DrumPart1)
                        .Include(p => p.DrumPart2)
                        .Include(p => p.DrumPart3)
                        .Include(p => p.DrumPart4)
                        .Include(p => p.DrumPart5)
                        .ToList();
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetPreset")]
        public IActionResult GetById(int id)
        {
            var item = _context.Presets.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Preset item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = 0;
            item.DrumPart1.AnalogPort = 1;
            item.DrumPart2.AnalogPort = 2;
            item.DrumPart3.AnalogPort = 3;
            item.DrumPart4.AnalogPort = 4;
            item.DrumPart5.AnalogPort = 5;

            _context.Presets.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetPreset", new { id = item.Id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Preset item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var preset = _context.Presets
                        .Include(p => p.DrumPart1)
                        .Include(p => p.DrumPart2)
                        .Include(p => p.DrumPart3)
                        .Include(p => p.DrumPart4)
                        .Include(p => p.DrumPart5)
                        .FirstOrDefault(t => t.Id == id);
            if (preset == null)
            {
                return NotFound();
            }

            preset.Name = item.Name;
            preset.DrumPart1.NoteId = item.DrumPart1.NoteId;
            preset.DrumPart2.NoteId = item.DrumPart2.NoteId;
            preset.DrumPart3.NoteId = item.DrumPart3.NoteId;
            preset.DrumPart4.NoteId = item.DrumPart4.NoteId;
            preset.DrumPart5.NoteId = item.DrumPart5.NoteId;

            preset.DrumPart1.Intensity = item.DrumPart1.Intensity;
            preset.DrumPart2.Intensity = item.DrumPart2.Intensity;
            preset.DrumPart3.Intensity = item.DrumPart3.Intensity;
            preset.DrumPart4.Intensity = item.DrumPart4.Intensity;
            preset.DrumPart5.Intensity = item.DrumPart5.Intensity;

            _context.Presets.Update(preset);
            _context.SaveChanges();
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var preset = _context.Presets.FirstOrDefault(t => t.Id == id);
            if (preset == null)
            {
                return NotFound();
            }

            _context.Presets.Remove(preset);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
