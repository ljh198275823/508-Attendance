using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ralid.Attendance.Model.Result
{
    public class CommandResult
    {

        public CommandResult()
        {
        }

        public CommandResult(ResultCode code)
        {
            this._ret = code;
        }

        public CommandResult(ResultCode code, string msg)
        {
            this._ret = code;
            this._msg = msg;
        }

        private ResultCode _ret;
        public ResultCode Result
        {
            get
            {
                return this._ret;
            }
            set
            {
                this._ret = value;
            }
        }

        private string _msg;
        public string Message
        {
            get { return _msg; }
            set
            {
                _msg = value;
            }
        }
    }
}
