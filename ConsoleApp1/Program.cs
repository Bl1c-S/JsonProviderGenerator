namespace programMain;

partial class Program
{
     public const string URL = "http://torgsoft.dyndns.org/api/Test/GetCountries";
     public const string URL1 = "https://jsonplaceholder.typicode.com/posts";

     static void Main(string[] args)
     {
          Console.WriteLine("Loading");

          FetchCountries<TestDomainObj>(URL1, ShowList);
          Console.ReadKey();
     }
     public static void ShowList(IEnumerable<IReturnToString> list)
     {
          if (IsValidList(list))
          {
               foreach (var item in list)
                    Console.WriteLine(item.ToString());

               Console.WriteLine("\r\nloaded");
          }
          else { Console.WriteLine("list null or empty"); }
     }
     private static bool IsValidList(IEnumerable<IReturnToString> list)
     {
          if (list != null && list.FirstOrDefault()?.Id != null)
               return true;
          return false;
     }
     static partial void FetchCountries<T>(string link, Action<T[]> onResponse) where T : IReturnToString;
}