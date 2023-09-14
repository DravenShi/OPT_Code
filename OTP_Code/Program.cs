using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
using System.Net;
using System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace OTP_Code
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //var secretKey = KeyGeneration.GenerateRandomKey(20); // 生成隨機的密鑰
            var secretKey = Encoding.UTF8.GetBytes("0912345678");
            Console.WriteLine(Base32Encoding.ToString(secretKey));
   
            var totp = new Totp(secretKey, step: 30); // 創建TOTP對象
                                                     
            Console.WriteLine(DateTime.UtcNow);
            var otp = totp.ComputeTotp(DateTime.UtcNow); // 生成TOTP

            Console.WriteLine(otp);
        }   
    }
}
