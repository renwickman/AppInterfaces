using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public char HeaderSymbol { get; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
      HeaderSymbol = '-';
    }

    public void Display()
    {
      Console.WriteLine("Password:");
      Console.WriteLine(new String(HeaderSymbol, 12));
      if (Hidden == false){
        Console.WriteLine($"{Password}");
      } else {
        Console.WriteLine("*********");
        Console.WriteLine("");
        Console.WriteLine("");
      }
    }

    public void Reset(){
      Password = "";
      Hidden = false;
   }
  }
}