using System;
using System.Collections.Generic;
using static Basket.Ag;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using static Basket.OrientedObject.Infrastructure.Log.WriteLog;

namespace Basket.OrientedObject.Infrastructure
{
    /// <summary>
    /// 46 61 69 74 20 70 61 72 20 41 64 72 69 61 6E 20 47 61 6E 64 6F 6E
    /// </summary>
    public class ExternalLogger
    {
        public static void LogInformation(string message)
        {
            Thread.Sleep(300);
            Write($"Information: {message}{Environment.NewLine}");
        }
        public static void LogError(Exception exception, string message)
        {
            Thread.Sleep(700);
            Write($"Error: {message} {exception}");
        }
    }
}
