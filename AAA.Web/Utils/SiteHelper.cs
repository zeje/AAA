using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AAA.Web.Utils
{

    public static class SiteHelper
    {
        public static FileVersionInfo GetFileVersionInfo()
        {
            //typeof(Program).GetTypeInfo().Assembly;
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            return FileVersionInfo.GetVersionInfo(assembly.Location);
        }
    }
}
