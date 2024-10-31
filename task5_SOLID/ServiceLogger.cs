using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_SOLID
{
    internal class ServiceLogger
    {
        private readonly ILogger _logger;
        public ServiceLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateMes(string mes)
        {
            _logger.Log($"Message '{mes}' recorded");
        }
    }
}
