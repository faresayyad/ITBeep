using ITBeep.Models.HomeIndex.DTO;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace ITBeep.Models
{
    public static class Shared
    {
        private static string PopulateBody(EmailContentDto emailContentDto)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string body = string.Empty;

            using (StreamReader reader = new StreamReader(path + "EmailTemplate.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{UserName}", emailContentDto.username);
            body = body.Replace("{Email}", emailContentDto.email);
            body = body.Replace("{Mobile}", emailContentDto.mobile);
            body = body.Replace("{Services}", emailContentDto.serviceType);
            body = body.Replace("{intersted}", emailContentDto.schedule);

            return body;
        }

        private static void SendHtmlFormattedEmail(string recepientEmail, string subject, string body)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;


                var message = new MailMessage();
                // Fake email.
                message.From = new MailAddress("any@any.com");
                message.To.Add(recepientEmail);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    smtp.UseDefaultCredentials = false;
                    //smtp.EnableSsl = true;
                    NetworkCredential credentials = new NetworkCredential
                        ("any@any.com", "123", "any.jo");
                    smtp.Host = "any.jo";
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.EnableSsl = true;
                    smtp.Port = 25;

                    smtp.Credentials = credentials;
                    smtp.Timeout = 600000;
                    smtp.Send(message);

                }
            }
            catch (SmtpException ex)
            {
            }

            catch (Exception ex)
            {
            }
        }

        public static void SendEmailMsg(EmailContentDto emailContentDto)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string body = PopulateBody(emailContentDto);
                SendHtmlFormattedEmail(emailContentDto.email, "ITBeep", body);
            }
            catch (SmtpException ex)
            {
            }
            catch (Exception ex)
            {

            }
        }
    }
}