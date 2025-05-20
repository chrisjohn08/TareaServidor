using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;

namespace App.Servicios
{
    // Adaptador entre Renci.SshNet.SshClient y nuestra interfaz ISshClient
    public class RenciSshClientWrapper : Core.Interfaces.ISshClient
    {
        private readonly SshClient _inner;
        public RenciSshClientWrapper(SshClient inner) => _inner = inner;
        public void Connect() => _inner.Connect();
        public SshCommand CreateCommand(string commandText) => _inner.CreateCommand(commandText);
        public void Disconnect() => _inner.Disconnect();
        public void Dispose() => _inner.Dispose();
    }
}
