using System;
using Microsoft.Owin.Hosting;

namespace KnockApi
{
    internal class Program
    {
        private static IDisposable _owinHost;

        private static void Main(string[] args)
        {
            _owinHost = WebApp.Start<OwinBootstrapper>("http://*:80");
            Console.ReadKey();
            _owinHost.Dispose();
        }
    }
}