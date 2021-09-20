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

            //SaveThePrisonerMain(); //Sorunun Çözümü çağırılıyor.

            //StringAnagramMain();  //Sorunun Çözümü çağırılıyor.

            //FindDigitsMain(); //Sorunun Çözümü Çağırılıyor.

            //RepeatedStringMain();  12/07/2021

            //BetweenTwoSetsMain();  14/09/2021
            ///5 test case gecilemedi

            //TimeConversionMain();  14/09/2021
            ///ÇÖZÜMÜ BEĞENMEDİM :(

            //DayOfTheProgrammerMain();  14/09/2021

            //DesignerPdfViewerMain();  //15/09/2021

            //ViralAdvertisingMain();  //16/09/2021

            //CircularArrayRotationMain();  //17/09/2021
            ///7 test case gecilemedi

            //LibraryFineMain();  //18/09/2021

            //AppendAndDeleteMain();  //19/09/2021

            ScherlockAndSquaresMain(); //19/09/2021
            //time hatası almıştım test case geçemeyenleri inceleyerek buna göre vaziyet al... a = 465868129, b = 988379794 mesela

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

        //Utopian Tree
        public static void UtopianTreeMain()
        {
            int n = 5; //Numbers of Cylcle
            int height;

            UtopianTree utopianTree = new UtopianTree();
            height = utopianTree.SolUtopianTree(n);

            Console.WriteLine(height);
        }

        //Save The Prisoner
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

        //String Anagram
        public static void StringAnagramMain()
        {
            List<string> dictionary = new List<string>() {"hack","a","rank","khac","ackh","kran","rankhacker","a","ab","ba","stairs","raits"};
            List<string> query = new List<string>() {"a","nark","bs","hack","stair"};

            List<int> numbers = new List<int>();

            StringAnagram stringAnagram = new StringAnagram();
            numbers = stringAnagram.SolStringAnagram(dictionary, query);

            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }

        //FindDigitsMain
        public static void FindDigitsMain()
        {
            int number = 123456789;
            int digits;

            int girilecekSayi;

            Console.Write("Girilecek Sayiyi Girin : ");
            girilecekSayi = Convert.ToInt32(Console.ReadLine());

            FindDigits findDigits = new FindDigits();

            for (int i = 1; i <= girilecekSayi; i++ )
            {
                Console.Write("Sayi : ");
                number = Convert.ToInt32(Console.ReadLine());

                digits = findDigits.SolFindDigits(number);

                Console.WriteLine("Bolen dijitler : " + digits);
            } 
        }

        //Repeated String
        public static void RepeatedStringMain()
        {
            long n = 736778906400;
            string s = "kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm";
            //long result;

            RepeatedString repeatedString = new RepeatedString();
            //result = repeatedString.RepeatedStringSol(s, n);

            //Console.WriteLine(result);

            repeatedString.RepeatedStringSol2(s, n);
        }

        public static void BetweenTwoSetsMain()
        {
            int allFactors;

            List<int> a = new List<int>();
            a.Add(2);
            a.Add(4);

            List<int> b = new List<int>();
            b.Add(16);
            b.Add(32);
            b.Add(96);

            BetweenTwoSets betweenTwoSets = new BetweenTwoSets();
            allFactors = betweenTwoSets.BetweentTwoSetsSol(a, b);

            Console.WriteLine(allFactors);

        }
        
        //Time Conversion
        public static void TimeConversionMain()
        {
            string s = "12:40:22AM";
            
            TimeConversion timeConversion = new TimeConversion();
            string result = timeConversion.TimeConversionSol(s);

            Console.WriteLine(result);
        }

        //Day Of The Programmer
        public static void DayOfTheProgrammerMain()
        {
            int year = 1800;

            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();
            string result = dayOfTheProgrammer.DayOfTheProgrammerSol(year);

            Console.WriteLine(result);
        }

        //Designer Pdf Viewer
        public static void DesignerPdfViewerMain()
        {
            List<int> h = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 1, 1, 5, 5, 1, 5, 2, 5, 5, 5, 5, 5, 5, };
            string word = "torn";
            int result;

            DesignerPdfViewer designerPdfViewer = new DesignerPdfViewer();
            result = designerPdfViewer.DesignerPdfViewerSol(h, word);

            Console.WriteLine(result);

        }
        
        //Viral Advertising
        public static void ViralAdvertisingMain()
        {
            int n = 5;
            int result;

            ViralAdvertising viralAdvertising = new ViralAdvertising();
            result = viralAdvertising.ViralAdvertisingSol(n);

            Console.WriteLine(result);

        }

        //Circular Array Rotation
        public static void CircularArrayRotationMain()
        {
            List<int> a = new List<int>() { 1, 2, 3 };
            int k = 2;
            List<int> queries = new List<int>() { 0, 1,2 };

            List<int> result = new List<int>();
            Console.WriteLine("\n");

            CircularArrayRotation circularArrayRotation = new CircularArrayRotation();

            result = circularArrayRotation.CircularArrayRotationSol(a, k, queries);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //Library Fine
        public static void LibraryFineMain()
        {
            //iade edilen tarih
            int d1 = 14;
            int m1 = 7;
            int y1 = 2018;

            //Kitabın iade tarihi
            int d2 = 5;
            int m2 = 7;
            int y2 = 2018;

            int result;

            LibraryFine libraryFine = new LibraryFine();
            result = libraryFine.LibrariyFineSol(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }

        //Append And Delete
        public static void AppendAndDeleteMain()
        {
            string s = "y";
            string t = "yu";
            int k = 2;
            string result;

            AppendAndDelete appendAndDelete = new AppendAndDelete();
            result = appendAndDelete.AppendAndDeleteSol(s, t, k);

            Console.WriteLine(result);
        }

        //Scherlock and Squares
        public static void ScherlockAndSquaresMain()
        {
            int a = 24;
            int b = 49;

            int result;

            ScherlockAndSquares scherlockAndSquares = new ScherlockAndSquares();
            result = scherlockAndSquares.ScherlockAndSquaresSol(a, b);

            Console.WriteLine(result);
        }


    }
}
