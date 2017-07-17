using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSapi.Request
{

    /// <summary>
    /// 请求实体支持单条和批量发送，适用于相同内容批量发送
    /// </summary>
    public class SendSmsRequset
    {
        private string _epid;
        private string _username;
        private string _phone;
        private string _content;
        private string _password;

        /// <summary>
        /// 密码MD5字符串（16位小写）
        /// </summary>
        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// 企业账号
        /// </summary>
        public string Epid
        {
            get { return _epid; }
            set { _epid = value; }
        }
        /// <summary>
        /// 账户名称
        /// </summary>
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// 目标号码最大一次发送50个号码，用英文逗号分隔
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set { _phone = value; }
        }
        /// <summary>
        /// 短信内容
        /// </summary>
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}