using SMSapi.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RM.Common.DotNetJson;
namespace SMSapi.Api
{
    /// <summary>
    /// SendSms 的摘要说明
    /// 发送单条或批量的相同内容的短信接口
    /// </summary>
    public class SendSms : IHttpHandler
    {
        
        public void ProcessRequest(HttpContext context)
        {
            //接收调用接口信息
            var RequestData = context.Request.Params["PostData"];
            try
            {
                //序列化实体
                SendSmsRequset smsRequest = JsonHelper.ScriptDeserialize<SendSmsRequset>(RequestData);
                var sendsms = new SmsPort.SmsPortSoapClient("SmsPortSoap");
                var result= sendsms.SendSms(smsRequest.Epid, smsRequest.UserName, smsRequest.PassWord, smsRequest.Phone, smsRequest.Content);
                context.Response.Write(result);
            }
            catch (Exception)
            {
                
                throw;
            }
            
           


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}