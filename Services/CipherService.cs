using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;

namespace samples.Services
{
    public class CipherService
    {
        IDataProtector _IPro;
        public CipherService(IDataProtectionProvider dataProtectionProvider, string key)
        {
            _IPro = dataProtectionProvider.CreateProtector(key);
        }
        public string Encrypt(string input)
        {
            return _IPro.Protect(input);
        }
        public string Decrypt(string input)
        {
            return _IPro.Unprotect(input);
        }
    }
}
