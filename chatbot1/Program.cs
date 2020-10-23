using System;
using System.Diagnostics;

namespace chatbot
{
 class Program
 {
  public static void Main()
  {
   Console.WriteLine("Hello I'm new Chat-bot. Was made by 1niciat1v3");
   Console.WriteLine("I m writed on garage");
   Console.Write("Do you Wanna speak with me? (Y/N) ");
   string ans = Console.ReadLine();
   switch (ans)
   {
    case "N":
     Console.Write("Are you sure? (Y/N) ");
     string ansN = Console.ReadLine();
     switch (ansN)
     {
      case "Y":
       Console.WriteLine("Ok Good Bye");
       break;
      case "N" :
       Console.WriteLine("OK, restart the application");
       break;
     }
     break;
    case "n":
     Console.Write("Are you sure? (Y/N) ");
     string ansn = Console.ReadLine();
     switch (ansn)
     {
      case "Y":
       Console.WriteLine("Ok Good Bye");
       break;
      case "y":
       Console.WriteLine("Ok Good Bye");
       break;
      case "n":
       Console.WriteLine("OK, restart the application");
       break;
      case "N" :
       Console.WriteLine("OK, restart the application");
       break;
     }
     break;
    case "y":
      Console.WriteLine("Nice... Lets start");
     Console.Write("What is your name? ");
     string name1 = Console.ReadLine();
     Console.Write("Ohh... Nice {0}, my father gimme name - ARTHUR. How old are you? ", name1);
     int age1 = Convert.ToInt32(Console.ReadLine());
     switch (age1)
     {
      case 18:
       Console.Write("Ohh... I'm like this... Do you wanna drink with me? xd (Y/N) - ");
       string ansDrink = Console.ReadLine();
       switch (ansDrink)
       {
        case "Y":
        Console.WriteLine("Some sounds...");
         Console.WriteLine("Some sounds again");
         Console.WriteLine("Wife: Ohh ARTHUR what are you doing little sheet? ");
         Console.Write("Bot : Ohh sorry. (Do you wanna sorry Bot (Y/N)");
        string ansWife1 = Console.ReadLine();
        switch (ansWife1)
        {
         case "Y":
          Console.WriteLine("Thank you. You liked me");
          Console.WriteLine("...");
          break;
         case "N" :
          Console.WriteLine("Ok... ,{0}, sorry man again...", name1);
          break;
        }

        break;
       case "N":
        Console.WriteLine("It's sounds stupid, but OK...");
        break;
       }

       break;
      default:
       Console.WriteLine("It's sounds good...");
       break;
     }
     Console.Write("Do you have some friends? (Y/N)");
     string andFriend1 = Console.ReadLine();
     switch (andFriend1)
     {
      case "Y":
       Console.WriteLine("Its sounds good");
       Console.Write("What is him name? - ");
       string nameFriend1 = Console.ReadLine();
       switch (nameFriend1)
       {
        default:
         Console.WriteLine("Hmm {0} - its' good name", nameFriend1);
         Console.Write("How old is he? ");
        int ageFriend = Convert.ToInt32(Console.ReadLine());
        switch (ageFriend)
        {
         default:
          Console.WriteLine("Ohh nice...");
          break;
        }
        Console.WriteLine("OK, I m happy");
        break;
       }
       break;
      case "N":
       Console.WriteLine("Ohh... It's sounds worse...");
       Console.WriteLine("But In future I will can become your friend");
       break;
       }
     break;
    case "Y":
     Console.WriteLine("Nice... Lets start");
     Console.Write("What is your name? ");
     string name = Console.ReadLine();
     Console.Write("Ohh... Nice {0}, my father gimme name - ARTHUR. How old are you? ", name);
     int age = Convert.ToInt32(Console.ReadLine());
     switch (age)
     {
      case 18:
       Console.Write("Ohh... I'm like this... Do you wanna drink with me? xd (Y/N) - ");
       string ansDrink = Console.ReadLine();
       switch (ansDrink)
       {
        case "Y":
        Console.WriteLine("Some sounds...");
         Console.WriteLine("Some sounds again");
         Console.WriteLine("Wife: Ohh ARTHUR what are you doing little sheet? ");
         Console.Write("Bot : Ohh sorry. (Do you wanna sorry Bot (Y/N)");
        string ansWife = Console.ReadLine();
        switch (ansWife)
        {
         case "Y":
          Console.WriteLine("Thank you. You liked me");
          Console.WriteLine("...");
          break;
         case "N" :
          Console.WriteLine("Ok... ,{0}, sorry man again...", name);
          break;
        }

        break;
       case "N":
        Console.WriteLine("It's sounds stupid, but OK...");
        break;
       }

       break;
      default:
       Console.WriteLine("It's sounds good...");
       break;
     }
     Console.Write("Do you have some friends? (Y/N)");
     string andFriend = Console.ReadLine();
     switch (andFriend)
     {
      case "y":
       Console.WriteLine("Its sounds good");
       Console.Write("What is him name? - ");
       string nameFriend1 = Console.ReadLine();
       switch (nameFriend1)
       {
        default:
         Console.WriteLine("Hmm {0} - its' good name", nameFriend1);
         Console.Write("How old is he? ");
         int ageFriend1 = Convert.ToInt32(Console.ReadLine());
         switch (ageFriend1)
         {
          default:
           Console.WriteLine("Ohh nice...");
           break;
         }
         Console.WriteLine("OK, I m happy");
         break;
       }
       break;
      case "n":
       Console.WriteLine("Ohh... It's sounds worse...");
       Console.WriteLine("But In future I will can become your friend");
       break;
    
      case "Y":
       Console.WriteLine("Its sounds good");
          Console.Write("What is him name? - ");
              string nameFriend = Console.ReadLine();
       switch (nameFriend)
       {
        default:
         Console.WriteLine("Hmm {0} - its' good name", nameFriend);
         Console.Write("How old is he? ");
        int ageFriend = Convert.ToInt32(Console.ReadLine());
        switch (ageFriend)
        {
         default:
          Console.WriteLine("Ohh nice...");
          break;
        }
        Console.WriteLine("OK, I m happy");
        break;
       }
       break;
      case "N":
       Console.WriteLine("Ohh... It's sounds worse...");
       Console.WriteLine("But In future I will can become your friend");
       break;
       }
     break;
     }
     
     }
  }
 }
