using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net;

namespace App.Utils
{
    public static class ValidationHelper
    {
        public static bool IsValidIp(string ip) => IPAddress.TryParse(ip, out _);
    }
}
