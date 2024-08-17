using Humanizer;
using System;
namespace CAFacebook { 
internal class Program
{
        private static void Main(string[] args)
        {
            var comments = new List<FBComment>
            {
                new FBComment
                {
                    Owner = " Rand F.",
                    Comment = "I Think ASP NET Core is the most powerfull Web Framework ",
                    CreatedAt= new DateTime(2021,01,01,10,30,00)
                },
                  new FBComment
                {
                    Owner = " Rania F.",
                    Comment = "Personally I Prefer Using C# with it",
                    CreatedAt= new DateTime(2021,02,01,10,30,00)
                },
                  new FBComment
                {
                    Owner = " Zaina A",
                    Comment = "Have you Tried Using Blazor? ",
                    CreatedAt= new DateTime(2021,06,01,10,30,00)
                },
                    new FBComment
                {
                    Owner = " Tara D.",
                    Comment = "I Prefer VB over C#.",
                    CreatedAt= new DateTime(2021,07,11,10,30,00)
                },
                      new FBComment
                {
                    Owner = " Ayla M.",
                    Comment = "VB is not from c family languages, It's hard for  me  ",
                    CreatedAt= DateTime.Now.AddMinutes(-5)
                }
            };
            foreach(var comment in comments)
                Console.WriteLine(comment);
        Console.ReadKey();
    }
}
    class FBComment
    {
        public string Owner {  get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"{Owner} says: \n"+
                $"\"{Comment}\""+
                $"\n\t\t\t\t {CreatedAt.Humanize()}";
        }
    }
}