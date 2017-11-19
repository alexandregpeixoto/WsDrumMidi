using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace DrumMIDIWcfService.Models
{
    public class DrumMidiContextInitializer
    {
        private DrumMidiContext _context;

        public DrumMidiContextInitializer(DrumMidiContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Notes.Any())
            {
                _context.AddRange(_defaultNotes);
                await _context.SaveChangesAsync();
            }

            if (!_context.Users.Any())
            {
                _context.AddRange(_defaultUsers);
                await _context.SaveChangesAsync();
            }

        }

        List<Note> _defaultNotes = new List<Note>
        {
             new Note() {CodeMIDI = 35,Name ="Bombo 2"},
             new Note() {CodeMIDI = 36,Name ="Bombo 1"},
             new Note() {CodeMIDI = 37,Name ="Batida no Aro"},
             new Note() {CodeMIDI = 38,Name ="Tarola 1 Pele"},
             new Note() {CodeMIDI = 39,Name ="Palmas"},
             new Note() {CodeMIDI = 40,Name ="Tarola 2 Aro"},
             new Note() {CodeMIDI = 41,Name ="Timbalão grave 2"},
             new Note() {CodeMIDI = 42,Name ="Pratos de choque fechados"},
             new Note() {CodeMIDI = 43,Name ="Timbalão grave 1"},
             new Note() {CodeMIDI = 44,Name ="Pratos de choque fechados pedal"},
             new Note() {CodeMIDI = 45,Name ="Timbalão médio 2"},
             new Note() {CodeMIDI = 46,Name ="Pratos de choque abertos"},
             new Note() {CodeMIDI = 47,Name ="Timbalão médio 1"},
             new Note() {CodeMIDI = 48,Name ="Timbalão agudo 2"},
             new Note() {CodeMIDI = 49,Name ="Prato de ataque crash 1"},
             new Note() {CodeMIDI = 50,Name ="Timbalão agudo 1"},
             new Note() {CodeMIDI = 51,Name ="Prato de condução 1"},
             new Note() {CodeMIDI = 52,Name ="Prato de ataque china"},
             new Note() {CodeMIDI = 53,Name ="Prato de condução"},
             new Note() {CodeMIDI = 54,Name ="Pandeirola"},
             new Note() {CodeMIDI = 55,Name ="Prato de ataque splash"},
             new Note() {CodeMIDI = 56,Name ="Caneca"},
             new Note() {CodeMIDI = 57,Name ="Prato de ataque crash 2"},
             new Note() {CodeMIDI = 58,Name ="Vibraslap"},
             new Note() {CodeMIDI = 59,Name ="Prato de condução 2"},
             new Note() {CodeMIDI = 60,Name ="Bongo agudo"},
             new Note() {CodeMIDI = 61,Name ="Bongo grave"},
             new Note() {CodeMIDI = 62,Name ="Conga aguda abafada"},
             new Note() {CodeMIDI = 63,Name ="Conga aguda"},
             new Note() {CodeMIDI = 64,Name ="Conga grave"},
             new Note() {CodeMIDI = 65,Name ="Timbale agudo"},
             new Note() {CodeMIDI = 66,Name ="Timbale grave"},
             new Note() {CodeMIDI = 67,Name ="Agogô"},
             new Note() {CodeMIDI = 68,Name ="Agogô grave"},
             new Note() {CodeMIDI = 69,Name ="Afoxé"},
             new Note() {CodeMIDI = 70,Name ="Maracas"},
             new Note() {CodeMIDI = 71,Name ="Apito curto"},
             new Note() {CodeMIDI = 72,Name ="Apito longo"},
             new Note() {CodeMIDI = 73,Name ="Reco-reco curto"},
             new Note() {CodeMIDI = 74,Name ="Reco-reco longo"},
             new Note() {CodeMIDI = 75,Name ="Clavas"},
             new Note() {CodeMIDI = 76,Name ="Bloco de madeira agudo"},
             new Note() {CodeMIDI = 77,Name ="Bloco de madeira grave"},
             new Note() {CodeMIDI = 78,Name ="Cuíca abafada"},
             new Note() {CodeMIDI = 79,Name ="Cuíca"},
             new Note() {CodeMIDI = 80,Name ="Triângulo abafado"},
             new Note() {CodeMIDI = 81,Name ="Triângulo"}
        };

        List<User> _defaultUsers = new List<User>
        {
            new User()
            {
               Name ="TESTE",
               Password = "teste"
            }
        };


    }



}