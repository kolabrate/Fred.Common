using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fred.Common.Logger.sinks
{
    public class Applicationinsightsink : ILogger
    {
        public Applicationinsightsink()
        {
            // to be done.
        }

        public void Verbose(string info)
        {
            throw new NotImplementedException();
        }

        public void Debug(string info)
        {
            throw new NotImplementedException();
        }

        public void Info(string info, params object[] data)
        {
            throw new NotImplementedException();
        }

        public void Error(dynamic properties, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Fatal(dynamic info, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
