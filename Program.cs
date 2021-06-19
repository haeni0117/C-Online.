using System;

namespace UNITY_Game_Development
{
    class Program
    {
        public static int average;
        public static int total;
        public static int sum_(int a, int b, int c, int d){
            return total = a+b+c+d;

        }
        public  static void Average(int total){
            average = total/4;
            Console.WriteLine("total : {0}  avaerage : {1}",total,average);
        }
        static void Main(string[] args)
        {
            int kor = 90;
            int eng = 45;
            int math = 44;
            int sci = 90;
            Console.WriteLine("성적 프로그램 시작");
            Average(sum_(kor,eng,math,sci));


            
            

        }
    }
}
