using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ralid.Attendance.Model.Result ;

namespace Ralid.Attendance.Model
{
    public class ResultCodeDecription
    {
        /// <summary>
        /// 获取命令返回结果的文字描述
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static string GetDescription(ResultCode result)
        {
            switch (result)
            {
                case ResultCode.CannotConnectServer:
                    return Resource1.ResultCode_CannotConnectServer;
                case ResultCode.Fail:
                    return Resource1.ResultCode_Fail;
                case ResultCode.NoRecord:
                    return Resource1.ResultCode_NoRecord;
                case ResultCode.SaveDataError:
                    return Resource1.ResultCode_SaveDataError;
                case ResultCode.Successful:
                    return Resource1.ResultCode_Successfull;
                default:
                    return Resource1.ResultCode_Fail;
            }
        }
    }
}
