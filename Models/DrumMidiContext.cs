using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace DrumMIDIWcfService.Models
{
    public class DrumMidiContext : DbContext
    {
        public DrumMidiContext(DbContextOptions<DrumMidiContext> options)
            : base(options)
        {
        }

        public DbSet<DrumPart> DrumParts { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Preset> Presets { get; set; }
        public DbSet<User> Users { get; set; }

    }

}