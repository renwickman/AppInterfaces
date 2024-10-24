using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    public string[] Todos
    { get; private set; }

    public char HeaderSymbol { get; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
      HeaderSymbol = '-';
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

   public void Display(){
    Console.WriteLine("Todos:");
    Console.WriteLine(new String(HeaderSymbol, 12));
    foreach (string todo in Todos){
        Console.WriteLine(todo);
      }
   }

   public void Reset(){
    Todos = new string[5];
    nextOpenIndex = 0;
   }
  }
}