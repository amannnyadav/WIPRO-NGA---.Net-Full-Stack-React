// See https://aka.ms/new-console-template for more information
//Comon usecase of colelction ie   Stack and Queue in  reallife scenario are as below :
        //1. Stack : Undo mechanism in text editors , Browser history etc
        //2. Queue : Print spooling , CPU task scheduling , Call center systems etc
        //3. Priority Queue : Emergency room triage ,
        //   Task scheduling with priorities , Network packet scheduling etc
        //4. Deque : Browser history navigation , Undo/Redo functionality in applications , Task scheduling with varying priorities etc
        //5. Concurrent Collections : Real-time data processing , Multi-threaded web servers , Parallel computing tasks etc
        //6. list use cases : Data binding in UI frameworks , Implementing stacks and queues , Storing collections of items for processing etc

        


        //Step1: Define a stack to hold integer values ex.  
        //Step2: Push some values onto the stack
        //Step3: Pop a value from the stack and display it
        //Step4: Peek at the top value of the stack without removing it( All fucntinoality are provided by Stack class in System.Collections.Generic namespace)
        //Step5: Check if the stack contains a specific value( Searching functionality)
        //Step6: Display the current count of items in the stack(Using Count property of Stack class)
        //Step7: Clear the stack of all items(Using Clear method of Stack class)

//general code implementation of Stack collection in C# :
using System.Collections;
Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine("Popped value: " + stack.Pop());
Console.WriteLine("Top value: " + stack.Peek());
Console.WriteLine("Stack contains 20: " + stack.Contains(20));
Console.WriteLine("Current stack count: " + stack.Count);
stack.Clear();
Console.WriteLine("Stack cleared. Current stack count: " + stack.Count);

//non-generic Stack collection implementation in C# :
Stack nonGenericStack = new Stack();
nonGenericStack.Push(10);
nonGenericStack.Push("Hello");  
nonGenericStack.Push(30.5);
Console.WriteLine("Popped value: " + nonGenericStack.Pop());
Console.WriteLine("Top value: " + nonGenericStack.Peek());
Console.WriteLine("Stack contains 'Hello': " + nonGenericStack.Contains("Hello"));
Console.WriteLine("Current stack count: " + nonGenericStack.Count);
nonGenericStack.Clear();
Console.WriteLine("Stack cleared. Current stack count: " + nonGenericStack.Count);
