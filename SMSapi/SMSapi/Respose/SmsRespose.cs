using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSapi.Respose
{
    public abstract class SmsRespose
    {
        private string code;
        private string msg;
        private object body;

        /// <summary>
        /// 错误码
        /// 对应 ErrCode
        /// </summary>
      
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// 错误信息
        /// 对应 ErrMsg
        /// </summary>
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public object Body
        {
            get { return body; }
            set { body = value; }
        }

       
    }
}