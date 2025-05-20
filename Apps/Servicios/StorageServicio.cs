using Core.Models;
using Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Servicios
{
    public class StorageServicio
    {
        private readonly IStorageRepository _repo;
        public StorageServicio(IStorageRepository repo)
        {
            _repo = repo;
        }

        public List<Server> LoadServers() => _repo.LoadAllServers().ToList();
        public void SaveServers(IEnumerable<Server> servers) => _repo.SaveAllServers(servers);
    }
}
