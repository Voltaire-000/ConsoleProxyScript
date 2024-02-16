using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProxyScript
{
    public interface IMath
    {
        double Abs(double x);
        double Sin(double x);
        double Sqrt(double x);
        double Pow(double x, double y);
        double Random();
    }
}
