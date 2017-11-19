using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService.Models
{
    public class DrumPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Intensity { get; set; }
        public int AnalogPort { get; set; }

        public int NoteId { get; set; }
        public Note Note { get; set; }

    }
}