using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace DevAndEnv
{
    public class OpenClient
    {
        public static void Main(string[] args)
        {
            Process proc = null;
            try
            {
                string targetDir = string.Format(@"D:\My_OwnData\jujuxiaotian\CurrentLearning\ClassLibrary1\ClassLibrary1\ExitCopyKzjhAndOpen.bat");//this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = string.Format("/c "+ targetDir);//this is argument

                //proc.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                //proc.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                //proc.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                //proc.StartInfo.RedirectStandardError = true;//重定向标准错误输出

                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
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
