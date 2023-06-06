using FluentEmail.Core;
using System;
using System.Net.Mail;
using TrackerLibrary;

//using FluentEmail.Smtp;

namespace TrackerLibrary
{
    public static class EmailLogic
    {
        public static void SendEmail(string sender,string to, string subject, string body)
        {
            /*
            var smtpClient = new SmtpSender(() => new SmtpClient(sender,25)
            {
                EnableSsl = false,
                UseDefaultCredentials = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
            });

            SmtpSender is currently not working, i've installed the nugget package
            but "using FluentEmail.Smtp" line is red 

            I've tried to solve it but i couldn't

            

            var email = Email
                .From(sender)
                .To(to)
                .Subject(subject)
                .Body(body,true)
                .SendAsync();

            */

            
            
            Console.Write($"Email From {sender} Sent To {to} With This Subject: {subject} \n\n Message Says: \n {body}");
            
        }



    }
}
