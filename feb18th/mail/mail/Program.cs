using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace mail
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  SmtpClient smtp = new SmtpClient("smtp.gmail.com");
              smtp.EnableSsl = true;
              smtp.Port = 587;
              smtp.Credentials = new NetworkCredential("aleenajohnson12@gmail.com",
                 " ");
              smtp.Send("aleenajohnson12@gmail.com", "akshaiksabu@gmail.com",
                 "  ", "Love is greate emotion,that keeps us going strong, i love u with my heart ,my body and mu soul, i love the way i keep loving, like a love i cannot control.... u r alwayson my mind and all the time i keep o thinking yyou. come to me, hold my hand and then never leave it..  ");  

            */

            string myGmailAddress = "aleenajohnson12@gmail.com";
            string appSpecificPassword = "  mUNDACKAL1@";

            SmtpClient smtp =
               new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new
               NetworkCredential(myGmailAddress,
               appSpecificPassword);

            MailMessage message = new MailMessage();
            message.Sender = new MailAddress(myGmailAddress,
               " unknown");
            message.From = new MailAddress(myGmailAddress,
               "unknown");

            message.To.Add(new MailAddress("aleenajohnson12@gmail.com",
   "Recipient Number 1"));
           message.To.Add(new MailAddress("divz368@gmail.com",
               "Recipient Number 2"));
            message.CC.Add(new MailAddress("afsana1098@gmail.com",
               "A CC Person"));
            message.Bcc.Add(new MailAddress("kjarya8@gmail.com.com",
               "A BCC Person"));   

            message.Subject = " YOUR SALARY ACCOUNT HAS BEEN HACKED!!!!!!!!!!!!!!!!!!!";
            message.Body = " 5000 RS is deducted from your salary account. Block your atm card. Its urgent";
            


message.IsBodyHtml = true;
            smtp.Send(message);  

        }
    }
}
