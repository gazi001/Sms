using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSapi.Request
{
    /// <summary>
    /// 支持单条和批量发送, 适用于不同号码、不同内容的批量。采用号码和内容放在 XML 报文格式提交。
    /// </summary>
    public class SendRequset
    {
        private string _epid;
        /// <summary>
        /// 企业账号
        /// </summary>
        public string Epid
        {
            get { return _epid; }
            set { _epid = value; }
        }

        private string _username;
        /// <summary>
        /// 账户名称
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _content;
        /// <summary>
        /// 短信内容
        /// 发送数据包(必填) ，
        /// 报文格式：
        /// <SmsList><row phone="手机号码" info="发送内容" spnumber="拓展码" /></SmsList>
        /// 注：1、最多可以有50 个<row>节点,每个<row>最多含 50 个号码，号码间用英文“,”分割.
        ///       2、拓展码参数，非必填，非空必须为数字，如有需要请咨询客户经理。
        ///       3、对于短信内容中<、>、&、”、’ 等特殊字符需要转义提交
        /// </summary>
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        private string _password;
        /// <summary>
        /// 密码MD5字符串（16位小写）
        /// </summary>
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}