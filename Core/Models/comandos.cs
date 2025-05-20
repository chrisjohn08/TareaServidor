using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [Serializable]
    public class comandos
    {
        public Guid Id { get; set; }
        public Guid ServerId { get; set; }          // Relación al servidor
        public string Text { get; set; }
    }
}
