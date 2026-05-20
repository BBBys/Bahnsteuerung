using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using MQTTnet.Diagnostics.Logger;
using MQTTnet.Protocol;
using MQTTnet.Server;
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace PMqttServer
{
  internal class Program
  {
    static void Main(string[] args)
    {
      MQTTServer server;
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      _ = fvi.CompanyName;
      string productName = fvi.ProductName;//Assemblyinfo -> Produkt
      string programmName = fvi.FileDescription; //Assemblyinfo -> Titel
      string productVersion = fvi.ProductVersion; //Version  1.2.3.4 
      Console.WriteLine($"{programmName} V{productVersion}");
      server = new MQTTServer();
    }
  }
}