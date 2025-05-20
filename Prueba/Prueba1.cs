using Core.Models;
using Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apps.Utils;

namespace prueba1
{
    
    public class Prueba1
    {
       
            static void Main()
            {
                // 1. Preparar datos de ejemplo
                var server1 = new Server
                {
                    Id = Guid.NewGuid(),
                    Name = "Servidor-Prueba",
                    IP = "192.168.1.100",
                    Username = "user",

                    EncryptedPassword = EncryptionHelper.Encrypt("password") // En la práctica usa EncryptionHelper.Encrypt("password")
                };
                server1.EncryptedPassword = "<password_encriptado>";

                var cmd = new comandos
                {
                    Id = Guid.NewGuid(),
                    ServerId = server1.Id,
                    Text = "uname -a"
                };
                server1.Comandos.Add(cmd);

                var servidores = new List<Server> { server1 };

                // 2. Ruta temporal para el XML
                var tempFile = Path.Combine(Directory.GetCurrentDirectory(), "servers_test.xml");

                // 3. Crear repositorio y guardar
                var repo = new XMLRepositorio(tempFile);
                repo.SaveAllServers(servidores);
                Console.WriteLine($"Servidores guardados en: {tempFile}");

                // 4. Cargar de nuevo
                var loaded = repo.LoadAllServers();
                Console.WriteLine($"Servidores cargados: {loaded.Count}");
                foreach (var s in loaded)
                {
                    Console.WriteLine($"- {s.Name} ({s.IP}), Comandos asociados: {s.Comandos.Count}");
                }



            }
        
    }
}
