using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Core.Interfaces;



namespace Apps.Servicios
{
    public class SshClientFactory : ISSHClientFactory
    {
        public Core.Interfaces.ISshClient Create(string host, string username, string password)
        {
            return new RenciSshClientWrapper(new SshClient(host, username, password));
        }

       
    }

}
