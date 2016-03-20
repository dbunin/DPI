﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CCalculator));
            host.Open();
            Console.WriteLine("The service is being  hosted");
            Console.WriteLine("Press <ENTER> to stop hosting.");
            Console.ReadLine();
            host.Close();
        }
    }
}
