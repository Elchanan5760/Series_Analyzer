


namespace Example
{
    class program()
    {
        static void Main()
        {
            MenuSelection();
            // Select an operation.
            void MenuSelection()
            {
                List<int> list = new List<int>{1,6,3,6,5};
                string input = "";
                while (input != "10")
                {
                    Menu();
                    input = Console.ReadLine();
                    
                    switch (input)
                    {
                        case "1":
                            list = NewSeries();
                            break;
                        case "2":
                            DisplayList(list);
                            break;
                        case "3":
                            DisplayReverse(list);
                            break;
                        case "4":
                            SortedLowHigh(list);
                            break;
                    }
                }
                
            }
            
            // Text of menu.
            void Menu()
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Input a new Series press 1");
                Console.WriteLine("Display the series in the order it was entered press 2");
                Console.WriteLine("Display the series in the reversed order it was entered press 3");
                Console.WriteLine("Display the series in sorted order from low to high press 4");
                Console.WriteLine("Display the Max value of the series press 5");
                Console.WriteLine("Display the Min value of the series press 6");
                Console.WriteLine("Display the Average of the series press 7");
                Console.WriteLine("Display the Number of elements in the series press 8");
                Console.WriteLine("Display the Sum of the series press 9");
                Console.WriteLine("Exit press 10");
            }
            
            // creat a new list.
            List<int> NewSeries()
            {
                Console.WriteLine("Please enter the numbers");
                string input = Console.ReadLine();
                string[] arr = input.Split(" ");
                List<int> newlist = new List<int>();
                foreach (string num in arr)
                {
                    int integer = Convert.ToInt32(num);
                    newlist.Add(integer);
                }
                return newlist;
            }
            
            // print numbers in the list.
            void DisplayList(List<int> myList)
            {
                for (int i = 0;i< myList.Count;i++)
                {
                    if (i == myList.Count-1)
                    {
                        Console.WriteLine(myList[i]);
                    }
                    else
                    {
                        Console.Write(myList[i] + " ");
                    } 
                }
            }

            // print the numbers in list in reverse order.
            void DisplayReverse(List<int> myList)
            {
                for (int i = myList.Count-1; i > -1; i--)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(myList[i]);
                    }
                    else
                    {
                        Console.Write(myList[i] + " ");
                    } 
                }
            }

            // prints from low to high.
            void SortedLowHigh(List<int> myList)
            {
                for (int i = 0; i < myList.Count-1;i++)
                {
                    int MinIndex = i;
                    for (int j = i+1; j < myList.Count;j++)
                    {
                        
                        if (myList[j] < myList[MinIndex])
                        {
                            MinIndex = j;   
                        }
                    }
                    int temp = myList[i];
                    myList[i] = myList[MinIndex];
                    myList[MinIndex] = temp;
                }
                DisplayList(myList);
            }
        }
    }
}