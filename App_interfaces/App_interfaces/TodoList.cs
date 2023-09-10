using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public string HeaderSymbol
        { get; }

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            HeaderSymbol = "-";
        }

        public void Add(string todo)
        {
            if (nextOpenIndex > 4)
            {
                Console.WriteLine("No more Space for a new todo!");
            }
            else
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }

        public void Display()
        {
            Console.WriteLine("Todos");
            for (int i = 0; i < 5; i++)
                Console.Write(HeaderSymbol);
            Console.WriteLine("");
            foreach (string item in Todos)
            {
                if (String.IsNullOrEmpty(item))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
