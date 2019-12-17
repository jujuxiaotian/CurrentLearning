using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"D:\My_OwnData\jujuxiaotian\CurrentLearning\ClassLibrary1\ClassLibrary1\");//this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "ExitCopyKzjhAndOpen.bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
            }
            return;
        }
    }
    
}
