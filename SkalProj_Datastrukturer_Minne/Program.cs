using System;
using System.Collections;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

           


            
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            List<string> theList = new List<string>();

            do
            {
                Console.WriteLine("Enter + to add or - to delete a name");
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':

                        theList.Add(value);

                        Console.WriteLine(theList.Count);
                        Console.WriteLine(theList.Capacity);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);

                        }

                        //Console.WriteLine("You entered +");
                        break;
                    case '-':
                      

                        theList.Remove(value);
                        Console.WriteLine(theList.Count);
                        Console.WriteLine(theList.Capacity);
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);

                        }
                        break;
                    case 'Q':

                        break;
                    default:
                        Console.WriteLine("You can only use + or -");
                        break;

                }
            }
            while (true);


            //2. Listans kapacitet ökar när count är i samma storlek som capacity.
            //3. Den ökar till dubbels så mycket. Så om den började på 4 så ökar den med 4 och kapaciteten blir 8 när count har kommit upp till 4.
            //4. Varför ökar inte listans kapacitet i samma takt som elementen läggs till?
            //5. nej, kapaciteten minksar inte när man tar bort element från listan
            //6. När man vet exakt hur många element det är i listan 


        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue queue = new Queue();
            
            do
            {
                Console.WriteLine("Add or remove person from the queue");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "+":
                        
                        string name = Console.ReadLine();
                        queue.Enqueue(name);
                        Console.WriteLine("People on the queue is: ");
                        foreach (var item in queue)
                        {
                            
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Number of persons in the queue: " + queue.Count);
                        
                        break;
                    case "-":
                        Console.WriteLine($"{queue.Peek()} is done and gone, left in line is: ");
                        queue.Dequeue();
                        foreach (var item in queue)
                        {

                            Console.WriteLine(item);
                        }
                        
                        Console.WriteLine("Number of persons in the queue: " + queue.Count);
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {

            //1. Det är inte så bra att göra en stack med en ica Kö eftersom först in sist ut, vilket skulle innebära att den som kommer till kön först inte får jälp förens alla andra i kön fått hjälp. 
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack<string> newStack = new Stack<string>();
            //List<string> stackList = new List<string>();

            do
            {
                Console.WriteLine("Add a name with + or delete with -");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "+":

                        string name = Console.ReadLine();

                        newStack.Push(name);

                        Console.WriteLine("Current stack: ");
                        foreach (var item in newStack)
                        {

                            Console.WriteLine(item);
                        }
                        newStack = ReverseText(newStack);
                        ////while (newStack.Count != 0)
                        ////{
                        ////    revStack.Push(newStack.Pop());
                        ////}
                        Console.WriteLine("Reversed stack: ");
                        foreach (var item in newStack)
                        {
                            Console.WriteLine(item);
                        }

                        break;
                    case "-":
                        if (newStack.Count < 1)
                        {
                            Console.WriteLine("The queue is already empty");
                           
                           
                        } else
                        {
                            newStack.Pop();
                            foreach (var item in newStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                   
                        break;
                    default:
                        Console.WriteLine("You must print + or -");
                        break;


                }

                Console.WriteLine(newStack);


            } while (true);







            static Stack<string> ReverseText(Stack<string> newStack)
            {
                Stack<string> revStack = new Stack<string>();
                while (newStack.Count > 0)
                {
                    revStack.Push(newStack.Pop());
                }
                return revStack;

                //        //if (newStack.Count == 0)
                //        //{
                //        //    return;
                //        //    //Console.Write(newStack.Pop());
                //        //    //revStack.Push(newStack.Pop());
                //        //}
                //        //var element = newStack.Pop();
                //        //ReverseText(newStack);
                //        //if (newStack.Count == 0)
                //        //{
                //        //    newStack.Push(element);
                //        //}
                //        //else
                //        //{
                //        //    var temp = newStack.Pop();
                //        //    newStack.Push(temp);
                //        //}


                //        //Console.WriteLine("Reversed stack: ");
                //        //foreach (var item in revStack)
                //        //{
                //        //    Console.WriteLine(item);
                //        //}
                //    }
            }
        }

       

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

