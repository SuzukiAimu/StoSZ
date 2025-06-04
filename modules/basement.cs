using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text;

namespace modules.basement
{
    // 自作ロギングシステム
    public class _logger
    {
        private const string VERSION = "1.0.0";
        private string path_of_log;

        // コンストラクタ
        public _logger(string path_of_log)
        {
            this.path_of_log = path_of_log;
        }
        

        // ログをコンソールに表示するかどうか
        public bool print_DEB = true, print_MSG = true, print_LOG = true, print_ERR = true;
        public bool print_ALL = true;

        // ログをファイルに書き込むかどうか
        public bool write_DEB = true, write_MSG = true, write_LOG = true, write_ERR = true;
        public bool write_ALL = true;

        // デバッグ
        public string DEB(string message)
        {
            string result = reshaper(message,"DEB");

            if(write_DEB && write_ALL){write_log(result);}
            if(print_DEB && print_ALL){Console.WriteLine(result);}

            return result;
        }
        // メッセージ
        public string MSG(string message)
        {
            string result = reshaper(message,"MSG");

            if(write_MSG && write_ALL){write_log(result);}
            if(print_MSG && print_ALL){Console.WriteLine(result);}

            return result;
        }
        // ログ
        public string LOG(string message)
        {
            string result = reshaper(message,"LOG");

            if(write_LOG && write_ALL){write_log(result);}
            if(print_LOG && print_ALL){Console.WriteLine(result);}

            return result;
        }
        // エラー
        public string ERR(string message)
        {
            string result = reshaper(message,"ERR");

            if(write_ERR && write_ALL){write_log(result);}
            if(print_ERR && print_ALL){Console.WriteLine(result);}

            return result;
        }   
    
        //　メッセージを成型する
        private string reshaper(string message , string header)
        {
            return string.Format("[{0}] {1} {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), header, message);
        }
        private void write_log(string message)
        {
            try
            {
                // ファイルに追記モードで書き込み
                using (StreamWriter writer = new StreamWriter(path_of_log, true, Encoding.UTF8))
                {
                    writer.WriteLine(message);
                }
            }
            catch (Exception)
            {
                // ファイルが存在しない場合は新規作成
                using (FileStream fs = new FileStream(path_of_log, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(Encoding.UTF8.GetBytes(message), 0, message.Length);
                }
            }
        }
    }





















}



