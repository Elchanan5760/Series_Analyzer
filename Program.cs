


using System.Globalization;
using System.IO.Pipelines;

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
                List<int> list = new List<int>{9,1,6,3,6,5,7};
                string input = "";
                while (input != "10")
                {
                    Menu();
                    input = Console.ReadLine();
                    int result;
                    switch (input)
                    {
                        case "1":
                            list = NewSeries();
                            break;
                        case "2":
                            DisplayList(list);
                            break;
                        case "3":
                            list = DisplayReverse(list);
                            DisplayList(list);
                            break;
                        case "4":
                            list = SortedLowHigh(list);
                            DisplayList(list);
                            break;
                        case "5":
                            result = FindMax(list);
                            Console.WriteLine(result);
                            break;
                        case "6":
                            result = FindMin(list);
                            Console.WriteLine(result);
                            break;
                        case "7":
                            result = AverageNum(list);
                            Console.WriteLine(result);
                            break;
                        case "8":
                            result = NumOfElement(list);
                            Console.WriteLine(result);
                            break;
                        case "9":
                            result = SumOfNumbers(list);
                            Console.WriteLine(result);
                            break;
                        default:
                            Console.WriteLine("Value error, please try again.");
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

            // Return the numbers in list in reverse order.
            List<int> DisplayReverse(List<int> myList)
            {
                for (int i = 0;i < myList.Count/2;i++)
                {
                    int temp = myList[i];
                    myList[i] = myList[myList.Count-1-i];
                    myList[myList.Count-1-i] = temp;
                }
                return myList;
            }

            // prints from low to high.
            List<int> SortedLowHigh(List<int> myList)
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
                return myList;
            }

            // Prints maximum value.
            int FindMax(List<int> myList)
            {
                int NumMax = myList[0];
                for (int i = 1; i < myList.Count;i++)
                {
                    if (NumMax < myList[i])
                    {
                        NumMax = myList[i];
                    }
                }
                return NumMax;
            }

            // Prints minimum value.
            int FindMin(List<int> myList)
            {
                int NumMin = myList[0];
                for (int i = 1; i < myList.Count;i++)
                {
                    if (NumMin > myList[i])
                    {
                        NumMin = myList[i];
                    }
                }
                return NumMin;
            }

            // Returns the average of numbers.
            int AverageNum(List<int> myList)
            {
                int sum = SumOfNumbers(myList);
                return sum / myList.Count;
            }

            // Count the element in list.
            int NumOfElement(List<int> myList)
            {
                int count = 0;
                foreach (int num in myList)
                {
                    count++;
                }
                return count;
            }
            
            // Summarize numbrs and return the result.
            int SumOfNumbers(List<int> myList)
            {
                int sum = 0;
                foreach (int num in myList)
                {
                    sum += num;
                }
                return sum;
            }
        }
    }
}