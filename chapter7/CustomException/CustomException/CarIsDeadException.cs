using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    class CarIsDeadException: ApplicationException
    {
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException() { }

        public CarIsDeadException(string message, string cause, DateTime time): base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

    }
}
