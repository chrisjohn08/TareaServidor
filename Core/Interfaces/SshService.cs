using Apps2.Utils2;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Interfaces
{
    public class SshService  
    {
        private readonly ISSHClientFactory _factory;
        public SshService(ISSHClientFactory factory)
        {
            _factory = factory;
        }

        public string ExecuteCommand(Server server, string commandText)
        {
           
            Apps2.Utils2.EncryptionHelper2 des = new Apps2.Utils2.EncryptionHelper2();
            var password = des.Decrypt(server.EncryptedPassword);
            using var client = _factory.Create(server.IP, server.Username, password);
            client.Connect();
            var cmd = client.CreateCommand(commandText);
            var result = cmd.Execute();
            var error = cmd.Error;
            client.Disconnect();
            return string.IsNullOrEmpty(error) ? result : $"ERROR: {error}{ result}";
        }
    }

}
