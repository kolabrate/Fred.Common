using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fred.Common.Logger
{
    public interface ILogger
    {
        void Verbose(string info); //example : calcuated 
        void Debug(string info); // example : retrieved 
        void Info(string info, params object[] data); // example : finsihed 
        void Error(dynamic properties, Exception ex); //error : something went wrong
        void Fatal(dynamic info, Exception ex); // error : terminating.

    } 
}
