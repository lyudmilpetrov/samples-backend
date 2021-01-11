using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samples.Services
{
    public class Connections
    {
        private readonly string _con_1 = "";
        private readonly string _con_2 = "";
        private readonly string _empty_1 = "";
        private ServiceProvider _SerPro;
        private ServiceCollection _SCollection = new ServiceCollection();
        public Connections()
        {
            _SCollection.AddDataProtection();
            _SerPro = _SCollection.BuildServiceProvider();
        }
        public string Get_Connection(string key, string option)
        {
            var instance = ActivatorUtilities.CreateInstance<CipherService>(_SerPro, key);
            try
            {
                return option switch
                {
                    "" +
                    "_con_1" => instance.Decrypt(_con_1),
                    "_con_2" => instance.Decrypt(_con_2),
                    _ => instance.Decrypt(_empty_1)
                };
            }
            catch
            {
                return "invalid key or option";
            }
        }

    }
}
