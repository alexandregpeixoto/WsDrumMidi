using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DrumMIDIWcfService.Models
{
    public class Preset
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public int DrumPart1Id { get; set; }
        public DrumPart DrumPart1 { get; set; }

        public int DrumPart2Id { get; set; }
        public DrumPart DrumPart2 { get; set; }

        public int DrumPart3Id { get; set; }
        public DrumPart DrumPart3 { get; set; }

        public int DrumPart4Id { get; set; }
        public DrumPart DrumPart4 { get; set; }

        public int DrumPart5Id { get; set; }
        public DrumPart DrumPart5 { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}