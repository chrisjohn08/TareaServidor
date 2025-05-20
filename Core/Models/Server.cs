using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [Serializable]
    public class Server
    {
        public Guid Id { get; set; }
        public string Name { get; set; }            // Nombre descriptivo del servidor
        public string IP { get; set; }              // Dirección IP del servidor
        public string Username { get; set; }        // Usuario de conexión SSH
        public string EncryptedPassword { get; set; } // Contraseña encriptada

        public List<comandos> Comandos { get; set; } = new List<comandos>(); // Lista de comandos asociados
    }
}
