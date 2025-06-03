using System;



namespace Processer{
    class Load_and_Reshape{
        private void serch_file(){
            Console.WriteLine("ファイルを検索しています...");
        }
        private static double[] toS(string[] raw_data , int port_count){


            double[] result = new double[port_count];

            // [周波数,Sパラ]のような配列を返す
            return result;
        }
        private static double[] toZ(string[] S_data , double Reference_impedance){
            double[] result = new double[S_data.Length];

            // [周波数,Zパラ]のような配列を返す
            return result;
        }

        public static double[] toSZ(){

            double[] result = new double[10];

            // [周波数,[Sパラ],[Zパラ]]のような配列を返し，これを外部で使用する
            return result;
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
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
