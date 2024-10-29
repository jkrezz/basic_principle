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

        // Конструктор принимает ILogger, что позволяет использовать любую реализацию
        public ServiceLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateMes(string mes)
        {
            // Логика создания пользователя
            _logger.Log($"Message '{mes}' recorded");
        }
    }
}
