using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Zeje.Utils
{
    /// <summary>基于system.net.mail发送邮件，支持附件
    /// </summary>
    public class Mail_
    {
        /// <summary>发送
        /// </summary>
        /// <param name="mailFrom">发送人姓名</param>
        /// <param name="mailFromAccount">发送邮箱</param>
        /// <param name="mailFromPwd">发送邮箱密码</param>
        /// <param name="mailSmtpServer">SMTP服务器地址</param>
        /// <param name="mailTo">接收人邮箱</param>
        /// <param name="mailCC">抄送人邮箱</param>
        /// <param name="mailBCC">暗抄送人邮箱</param>
        /// <param name="mailTitle">邮件标题</param>
        /// <param name="mailContent">邮件内容</param>
        /// <param name="mailAttachments">附件路径</param>
        /// <param name="encoding">编码</param>
        /// <param name="isBodyHtml">是否Html格式</param>
        public static void Send(string mailFrom,
            string mailFromAccount, 
            string mailFromPwd, 
            string mailSmtpServer, 
            IList<string> mailTo, 
            IList<string> mailCC, 
            IList<string> mailBCC, 
            string mailTitle, 
            string mailContent, 
            IList<string> mailAttachments, 
            System.Text.Encoding encoding, 
            bool isBodyHtml)
        {
            MailMessage message = new MailMessage();
            if (!string.IsNullOrWhiteSpace(mailFrom))
            {
                throw new Exception("发送邮件不可以为空");
            }
            message.From = new MailAddress(mailFrom);
            if (mailTo.Count <= 0)
            {
                throw new Exception("接收邮件不可以为空");
            }
            foreach (string s in mailTo)
            {
                message.To.Add(new MailAddress(s));
            }
            if (mailCC.Count > 0)
            {
                foreach (string s in mailCC)
                {
                    message.CC.Add(new MailAddress(s));
                }
            }
            if (mailBCC.Count > 0)
            {
                foreach (string s in mailBCC)
                {
                    message.Bcc.Add(new MailAddress(s));
                }
            }
            message.Subject = mailTitle;
            message.Body = mailContent;
            message.BodyEncoding = encoding;   //邮件编码
            message.IsBodyHtml = isBodyHtml;      //内容格式是否是html
            message.Priority = MailPriority.High;  //设置发送的优先集
            //附件
            foreach (string att in mailAttachments)
            {
                message.Attachments.Add(new Attachment(att));
            }
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = mailSmtpServer;
            smtpClient.Credentials = new NetworkCredential(mailFromAccount, mailFromPwd);
            smtpClient.Timeout = 1000;
            smtpClient.EnableSsl = false;        //不使用ssl连接
            smtpClient.Send(message);
        }
        /// <summary>发送邮件——内容为文本
        /// </summary>
        /// <param name="mailFrom">发送人姓名</param>
        /// <param name="mailFromAccount">发送邮箱</param>
        /// <param name="mailFromPwd">发送邮箱密码</param>
        /// <param name="mailSmtpServer">SMTP服务器地址</param>
        /// <param name="mailTo">接收人邮箱</param>
        /// <param name="mailCC">抄送人邮箱</param>
        /// <param name="mailBCC">暗抄送人邮箱</param>
        /// <param name="mailTitle">邮件标题</param>
        /// <param name="mailContent">邮件内容</param>
        public static void SendText(string mailFrom, string mailFromAccount, string mailFromPwd, string mailSmtpServer, IList<string> mailTo, IList<string> mailCC, IList<string> mailBCC, string mailTitle, string mailContent)
        {
            List<string> attList = new List<string>();
            Send(mailFrom, mailFromAccount, mailFromPwd, mailSmtpServer, mailTo, mailCC, mailBCC, mailTitle, mailContent, attList, Encoding.UTF8, false);
        }
        /// <summary>发送邮件——内容为网页
        /// </summary>
        /// <param name="mailFrom">发送人姓名</param>
        /// <param name="mailFromAccount">发送邮箱</param>
        /// <param name="mailFromPwd">发送邮箱密码</param>
        /// <param name="mailSmtpServer">SMTP服务器地址</param>
        /// <param name="mailTo">接收人邮箱</param>
        /// <param name="mailCC">抄送人邮箱</param>
        /// <param name="mailBCC">暗抄送人邮箱</param>
        /// <param name="mailTitle">邮件标题</param>
        /// <param name="mailContent">邮件内容</param>
        public static void SendHTML(string mailFrom, string mailFromAccount, string mailFromPwd, string mailSmtpServer, IList<string> mailTo, IList<string> mailCC, IList<string> mailBCC, string mailTitle, string mailContent)
        {
            List<string> attList = new List<string>();
            Send(mailFrom, mailFromAccount, mailFromPwd, mailSmtpServer, mailTo, mailCC, mailBCC, mailTitle, mailContent, attList, Encoding.UTF8, true);
        }
    }
}
