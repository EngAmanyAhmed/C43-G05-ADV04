namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non_Generic Collection_Hashtable
            // // Collection : Built_in  DS in C#

            // // Non Generic Hashtables  :  Hashtable

            // Hashtable PhoneBook = new Hashtable();
            // PhoneBook.Add("Ahmed", 1111111);
            // PhoneBook.Add("Ali", 222222);
            // PhoneBook.Add("Amr", 3333333);
            // PhoneBook.Add(2222222, "Ahmed");

            // //  PhoneBook.Add(null, 111111);

            // //Console.WriteLine(PhoneBook.IsFixedSize);
            // //Console.WriteLine(PhoneBook.IsReadOnly);

            // //foreach (var item in PhoneBook.Values)
            // //{
            // //    Console.WriteLine(item);
            // ////}
            // //PhoneBook["Ahmedss"] = 2211133;
            // //Console.WriteLine(PhoneBook["Ahmed"]);
            // //PhoneBook.Clear();

            // //var Flag = PhoneBook.Contains("Ahmed");
            // //Console.WriteLine(Flag);

            // //var Flag = PhoneBook.ContainsValue("Ahmed");
            // //Console.WriteLine(Flag);

            //// PhoneBook.Remove(null);



            // Console.WriteLine();
            // Console.WriteLine("===============");
            // foreach (DictionaryEntry item in PhoneBook) 
            // {
            //   Console.WriteLine(item);
            // } 
            #endregion

            #region Generic Collection_Dictionary

            //Dictionary<string,long> PhoneBook = new Dictionary<string,long>();
            //PhoneBook.Add("Ahmed", 1111111);
            //PhoneBook.Add("Ali", 222222);
            //// PhoneBook.Add(null, 3333333);
            ////PhoneBook.Add("Amr", 3333333);


            ////var Flag = PhoneBook.Remove("Ahmedddd" , out long result);
            ////Console.WriteLine(Flag);
            ////Console.WriteLine(result);

            ////PhoneBook.TryAdd("Ahmed", 1111111,);
            //PhoneBook.TryGetValue("Ahmeddd", out long result);
            //Console.WriteLine(result);

            //Console.WriteLine("==========================");
            //foreach (KeyValuePair<string,long> item in PhoneBook)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Generic Collection_HashSet
            //// Generic Hashtable : HashSet

            //HashSet<string> Names = new HashSet<string>();

            //Names.Add("Ahmed");
            //Names.Add("Ahmed");
            //Names.Add("Ali");
            //Names.Add("Amr");

            //Names.Contains
            //foreach (var item in Names) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Generic Collection_Sorted DS_SortedDictionary

            // SortedDictionary<int , string> pairs = new SortedDictionary<int , string>();
            // pairs.Add(23, "Ahmed");
            // pairs.Add(13, "Omar");
            // pairs.Add(20, "Amr");
            // pairs.Add(1, "Amr");

            //// pairs.
            // foreach (var item in pairs)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion

            #region  Generic Collection_Sorted DS_SortedList_SortedSet
            //SortedList<int , string > pairs = new SortedList<int , string>();

            //// pairs.SetValueAtIndex(1);

            //pairs.Add(1,"Ahmed");
            //pairs.Add(2, value: "Ali");
            //pairs.Add(3, "Omar");


            ////SortedList<int , string> values = new SortedList<int , string>();

            #endregion

            #region Event Overview

            // Delegate : C# Feature 
            // C# pure OOP 

            // Event :
            // 1. Functional Programming
            // 2. Event-Driven Programming

            #endregion

            #region Event Ex01
            //Ball ball = new Ball() { Id = 1 };

            //Console.WriteLine(ball);
            //ball.Location= new Location() { X = 1 , Y = 1  , Z  = 1};
            //Console.WriteLine(ball);

            //Players P01 = new Players() { Name = "Messi", TeamName = "Inter Miami" };
            //Players P02 = new Players() { Name = "Alba", TeamName = "Inter Miami" };

            //Players P03 = new Players() { Name = "Pedri", TeamName = "Barcelona" };
            //Players P04 = new Players() { Name = "Gavi", TeamName = "Barcelona" };
            //Players P05 = new Players() { Name = "Lamin Yamal", TeamName = "Barcelona" };

            //Refree R01 = new Refree() { Name = "Ibrahim Nour El_Din" };

            //Coach C01 = new Coach() { Name = "Hansi Flek", TeamName = "Barcelona" };

            ////ball.players.Add(P01);
            ////ball.players.Add(P02);
            ////ball.players.Add(P03);
            ////ball.players.Add(P04);
            ////ball.refree.Add(R01);

            //ball.BallLocationChange += P01.Run;
            //ball.BallLocationChange += P02.Run;
            //ball.BallLocationChange += P03.Run;
            //ball.BallLocationChange += P04.Run;
            //ball.BallLocationChange += R01.Look;
            //ball.BallLocationChange += C01.Order;

            //ball.Location = new Location() { X = 2, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //Console.WriteLine();
            //Console.WriteLine("After Change Pedri with Lamin Yamal");
            //Console.WriteLine();

            //ball.BallLocationChange -= P03.Run;
            //ball.BallLocationChange += P05.Run;

            //ball.Location = new Location() { X = 3, Y = 1, Z = 1 };
            //Console.WriteLine(ball); 
            #endregion

            #region Event Ex02

            //Channel channel = new Channel() { Title = " ABC" } ;
            //channel.AddVideo(new Video() { Title = "Tital01", Description = "Des 01 " });

            //subscriber S01 = new subscriber() { Name = " Ahmed" };
            //subscriber S02 = new subscriber() { Name = " Ali " };
            //subscriber S03 = new subscriber() { Name = " Mona " };
            //subscriber S04 = new subscriber() { Name = " Mohamed " };
            //subscriber S05 = new subscriber() { Name = " Mariam " };

            //channel.AddVideo(new Video() { Title = "Tital02", Description = "Des 02 " });

            //channel.Uploaded += S01.Notify;
            //channel.Uploaded += S02.Notify;
            //channel.Uploaded += S03.Notify;
            //channel.Uploaded += S04.Notify;

            //channel.AddVideo(new Video() { Title = "Tital02", Description = "Des 02 " });

            //Console.WriteLine();
            //Console.WriteLine("After Ahmed up subscriber");
            //Console.WriteLine();

            //channel.Uploaded -= S01.Notify;
            //channel.Uploaded += S05.Notify;

            //channel.AddVideo(new Video() { Title = "Tital03", Description = "Des 03 " }); 
            #endregion


        }
    }
}
