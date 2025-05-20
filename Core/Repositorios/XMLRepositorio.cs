using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Core.Models;

namespace Core.Repositorios
{
    public interface IStorageRepository
    {
        IReadOnlyList<Server> LoadAllServers();
        void SaveAllServers(IEnumerable<Server> servers);
    }
    public  class XMLRepositorio : IStorageRepository
    {
        private readonly string _filePath;
        public XMLRepositorio(string filePath)
        {
            _filePath = filePath;
        }

        public IReadOnlyList<Server> LoadAllServers()
        {
            // Aquí se implementa la lógica para leer un archivo XML y convertirlo en objetos Server
            if (!File.Exists(_filePath))
                return new List<Server>();

            try
            {
                var serializer = new XmlSerializer(typeof(List<Server>));
                using var stream = File.OpenRead(_filePath);
                return (List<Server>)serializer.Deserialize(stream);
            }
            catch (Exception ex)
            {
                // Podemos loguear el error o relanzar con más contexto
                throw new InvalidOperationException("Error cargando servidores desde XML", ex);
            }
        }

        public void SaveAllServers(IEnumerable<Server> servers)
        {
            // Aquí se implementa la lógica para convertir una lista de Server a XML y guardarla
            try
            {
                var list = servers.ToList();
                var serializer = new XmlSerializer(typeof(List<Server>));
                using var writer = new StreamWriter(_filePath, false);
                serializer.Serialize(writer, list);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error guardando servidores en XML", ex);
            }
        }

        // También se puede hacer un JsonRepository similar si se desea usar JSON
    }
}
