using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Static
{
    /// <summary>
    /// Настройки для RabbitMQ
    /// </summary>
    public static class RabbitMqSettings
    {
        /// <summary>
        /// Имя хоста
        /// </summary>
        public static string? HostName { get; set; }
        /// <summary>
        /// Порт
        /// </summary>
        public static int Port { get; set; }
        /// <summary>
        /// Пароль для авторизации
        /// </summary>
        public static string? Password { get; set; }
        /// <summary>
        /// Имя пользователя для авторизации
        /// </summary>
        public static string? UserName { get; set;}
    }
}
