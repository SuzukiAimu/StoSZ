using System;
using modules.basement;




namespace Processer{
    class Load_and_Reshape{
        public static _logger logger = StoSZ.Program.logger;


        private static string[] serch_file(){

            string[] files = Directory.GetFiles("./port/", "*.s*p");

            if(files.Length == 0){
                logger.ERR("there is no file in directory");
                throw new Exception("NO FILE FOUND");
            }

            // ファイルをログに出力
            foreach(string file in files){
                logger.DEB(string.Format("found file: {0}", file));
            }

            return files;

        }
        private static double[] toS(string[] raw_data , int port_count){


            // データをログに出力し，コメントアウトの行を検知してポートを確認する
            for (int i = 0; i != raw_data.Length; i++){
                logger.DEB(string.Format("raw_data[{0}]: {1}", i, raw_data[i]));

                if(raw_data[i].Contains("!") || raw_data[i].Contains("#")){
                    logger.DEB(string.Format("comment: {0}", raw_data[i]));
                }
                else{
                    break;
                }
            }

            double[] result = new double[port_count];

            // [周波数,Sパラ]のような配列を返す
            return result;
        }
        private static double[] toZ(string[] S_data , double Reference_impedance){
            double[] result = new double[S_data.Length];

            // [周波数,Zパラ]のような配列を返す
            return result;
        }

        public static void toSZ(){

            string[] files = serch_file();

            //foreach(string file in files){
            string file = files[0];
                try{
                    string[] raw_data = File.ReadAllText(file).Split('\n');
                    double[] S_data = toS(raw_data, 2);
                    //double[] Z_data = toZ(S_data, 50);
                    //output_data(S_data, Z_data);
                }
                catch(Exception e){
                    logger.ERR(string.Format("error: {0}", e.Message));
                }
            //}


            return;
        }
        
    }
    class Output_data{
        private void output_data(){

            // toSZ()で返されたデータをファイルに書き込む
        }
    }
}



namespace StoSZ
{
    class Program
    {
        public static _logger logger = new _logger("log.txt");
        private static void Main()
        {
            logger.LOG("lunching program");
            Processer.Load_and_Reshape.toSZ();

            logger.LOG("program finished");
            return;
        }
    }
}
