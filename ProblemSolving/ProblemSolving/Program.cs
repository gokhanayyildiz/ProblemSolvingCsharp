using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //BirthdayCakeCandlesMain(); //Sorunun çözümü çağırılıyor.

            //AngryProfessorMain(); //Sorunun Çözümü çağırılıyor.

            //BeautifulDaysAtTheMoviesMain(); //Sorunun Çözümü çağırılıyor.

            //UtopianTreeMain(); //Sorunun Çözümü çağırılıyor.

            SaveThePrisonerMain(); //Sorunun Çözümü çağırılıyor.

            Console.ReadKey();
        }

        //Birthday Cake Canles
        public static void BirthdayCakeCandlesMain()
        {
            List<int> Candles = new List<int>() { 3, 2, 1, 3 };
            int countOfLongest;

            BirthdayCakeCandles birthdayCakeCandles = new BirthdayCakeCandles();
            countOfLongest = birthdayCakeCandles.SolBirthdayCakeCandles(Candles);

            Console.WriteLine(countOfLongest);
        }



        //Angry Professor
        public static void AngryProfessorMain()
        {
            int k = 2; //Threshol value
            List<int> a = new List<int>() { 0, -1, 2, 1 };
            string result;

            AngryProfessor angryProfessor = new AngryProfessor();
            result = angryProfessor.SolAngryProfessor(k, a);

            Console.WriteLine(result);
        }


        //Beautiful Days at the Movies
        public static void BeautifulDaysAtTheMoviesMain()
        {
            int i, j, k;
            int beautifulDaysCount;
            i = 20;
            j = 23;
            k = 6;

            BeautifulDaysAtTheMovies beautifulDaysAtTheMovies = new BeautifulDaysAtTheMovies();
            beautifulDaysCount = beautifulDaysAtTheMovies.SolBeautifulDaysAtTheMovies(i, j, k);

            Console.WriteLine(beautifulDaysCount);


        }

        public static void UtopianTreeMain()
        {
            int n = 5; //Numbers of Cylcle
            int height;

            UtopianTree utopianTree = new UtopianTree();
            height = utopianTree.SolUtopianTree(n);

            Console.WriteLine(height);
        }

        public static void SaveThePrisonerMain()
        {
            int n = 715950220; //number of prisoner
            int m = 876882456; //number of candy
            int s = 195550680; //starting chair number

            int unluckyPrisoner;

            SaveThePrisoner saveThePrisoner = new SaveThePrisoner();
            unluckyPrisoner = saveThePrisoner.SolSaveThePrisoner(n, m, s);

            Console.WriteLine(unluckyPrisoner);
        }


    }
}
