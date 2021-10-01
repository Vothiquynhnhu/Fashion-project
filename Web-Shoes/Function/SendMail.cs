using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Function
{
    public class SendMail
    {
        String mailnhan = "thaibao0225@gmail.com";
        String mailgui = "bookshare005@gmail.com";
        String chude = "Kiểm tra email gửi đi";
        String noidung = @"<h1>Xin chào XuanThuLab</h1><p>Đây là mail gửi sử dụng gmail</p>";

        string smtpacount = "bookshare005@gmail.com";
        string smtppassword = "riseofBao";
        public SendMail(string _mailnhan, string _chude, string _noidung)
        {
            mailnhan = _mailnhan;
            chude = _chude;
            noidung = _noidung;
        }



        public void Send()
        {
            StaticFile.MailUtils.SendMailGoogleSmtp(
                mailgui,
                mailnhan,
                chude,
                noidung,
                smtpacount,
                smtppassword

            ).Wait();
        }
    }
}
