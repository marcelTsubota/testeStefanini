using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReaderTest.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}