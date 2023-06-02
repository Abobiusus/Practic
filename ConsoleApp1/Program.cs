using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");

            string[] valueNames= subKeyNames.GetValueNames();
            foreach (var item in valueNames)
            {
                Console.WriteLine(item);
                string value = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", item, null);
                Console.WriteLine(value);
            }
        }
    }
}
