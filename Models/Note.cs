using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService.Models
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get;  set; }
        public int CodeMIDI { get; set; }
        public string Name { get; set; }
        
        public List<DrumPart> DrumParts { get; set; }
    }
}