using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Net.Mime;

namespace XianShou.bcyoo.Common.Helper
{
    public class EmailHelper
    {
        /// <summary>
        /// 发送邮件；后续：设定编码，HTML方式发送，邮件编码，帐号用户名可配置，可批量发送，可抄送，暗送。
        /// </summary>
        public static bool SendEmail(string mailTo, string mailSubject, string mailContent)
        {
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.mxhichina.com"; //SMTP服务器
            string mailFrom = "postmaster@osmws.com"; //登陆用户名
            string userPassword = "Aa13499865";//登陆密码

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码

            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
            mailMessage.Subject = mailSubject;//主题
            mailMessage.Body = mailContent;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级

            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException ex)
            {
                return false;
            }
        }
        public static bool SendMail(string mailTo)
        {
            string mailSubject = "欧诗漫微商";
            string mailContent = "";
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.mxhichina.com"; //SMTP服务器
            string mailFrom = "postmaster@osmws.com"; //登陆用户名
            string userPassword = "Aa13499865";//登陆密码

            // 邮件服务设置
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            smtpClient.Host = smtpServer; //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码

            // 发送邮件设置        
            MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
            mailMessage.Subject = mailSubject;//主题
            mailMessage.Body = mailContent;//内容
            mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
            mailMessage.IsBodyHtml = true;//设置为HTML格式
            mailMessage.Priority = MailPriority.Low;//优先级

            try
            {
                smtpClient.Send(mailMessage); // 发送邮件
                return true;
            }
            catch (SmtpException ex)
            {
                return false;
            }
        }
        public static bool SendMailWithMaterial(string mailTo)
        {
            string mailSubject = "欧诗漫微商新手素材包";
            string mailContent = "您好，请您下载后解压查看。";
            // 设置发送方的邮件信息,例如使用网易的smtp
            string smtpServer = "smtp.mxhichina.com"; //SMTP服务器
            string mailFrom = "postmaster@osmws.com"; //登陆用户名
            string userPassword = "Aa13499865";//登陆密码
            var smtp = new SmtpClient
            {
                Host = smtpServer,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(mailFrom, userPassword)
            };
            MailMessage email = new MailMessage(mailFrom, mailTo);
            email.Subject = mailSubject;
            email.IsBodyHtml = true;
            string attachmentPath = @"D:\\Material\素材包.rar";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            //inline.ContentId = "1"; 
            //inline.ContentType.MediaType = "image/png"; 
            inline.ContentType.Name = Path.GetFileName(attachmentPath);
            email.Attachments.Add(inline);
            email.Body = mailContent;
            smtp.Timeout = 6000000;
            smtp.Send(email);

            email.Dispose();
            return true;
        }
        //public static void _SendMail(string form, string pw, string subject, string[] to, string[] cc, string body, string attachmentName, byte[] attachment)
        //{
        //    SmtpClient client = new SmtpClient("smtp.mxhichina.com");
        //    client.UseDefaultCredentials = true;
        //    client.Credentials = new NetworkCredential(form, pw); // 验证信息要与邮件发送源地址一致，否则无法发送
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;

        //    MailMessage message = new MailMessage();
        //    message.From = new MailAddress(form);
        //    foreach (string toItem in to)
        //    {
        //        message.To.Add(toItem);
        //    }
        //    foreach (string ccItem in cc)
        //    {
        //        message.CC.Add(ccItem);
        //    }
        //    message.Subject = subject;
        //    message.SubjectEncoding = Encoding.UTF8;
        //    message.Body = body;
        //    message.BodyEncoding = Encoding.UTF8;
        //    message.IsBodyHtml = true;
        //    message.Priority = MailPriority.High;

        //    Stream stream = null;
        //    Attachment data = null;
        //    try
        //    {
        //        if (attachment != null && attachment.Length > 0)
        //        {
        //            stream = new MemoryStream(attachment);
        //            data = new Attachment(stream, attachmentName, System.Net.Mime.MediaTypeNames.Application.Octet);
        //            message.Attachments.Add(data);
        //        }
        //        client.Send(message);
        //    }
        //    finally
        //    {
        //        if (null != stream)
        //        {
        //            stream.Close();
        //        }
        //    }
        //}
    }

}
