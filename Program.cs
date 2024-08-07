// & "C:/Program Files (x86)/Microsoft Visual Studio/2022/BuildTools/MSBuild/Current/Bin/MSBuild.exe" .\resximagetest.csproj


using System;
using System.Drawing;
using System.Resources;
namespace ResX
{
    public class Program
    {
        public static void Main()
        {
            Image img = Image.FromFile("happy.jpg");
            ResXResourceWriter rsxw = 
                new ResXResourceWriter("happy.resx");
            rsxw.AddResource("happy", (Bitmap)img);
            rsxw.Close();
        }
    }
}