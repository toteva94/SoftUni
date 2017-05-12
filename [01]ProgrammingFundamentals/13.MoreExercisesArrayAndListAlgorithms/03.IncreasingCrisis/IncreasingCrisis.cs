namespace _03.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var firstLineToInsertInResultList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>(firstLineToInsertInResultList); 
            List<int> sequenceForInsertInResult = new List<int>();
            int index = 0;

            bool isBreaksIncreasing = false; 

            for (int i = 0; i < number - 1; i++)
            {
                sequenceForInsertInResult.Clear(); 
                index = 0;  
                isBreaksIncreasing = false; 

                var commandLine = Console.ReadLine().Split().Select(int.Parse).ToList();

                sequenceForInsertInResult.Add(commandLine[0]); 
                for (int j = 0; j < commandLine.Count - 1; j++)
                {
                    if (commandLine[j] <= commandLine[j + 1])           
                    {                                                    
                        sequenceForInsertInResult.Add(commandLine[j + 1]);
                        
                    }
                    else
                    {
                        break;                
                    }
                }

                if (isBreaksIncreasing)
                {
                    var startIndex = index + sequenceForInsertInResult.Count;
                    var removeNumberToEndTheList = result.Count - (index + sequenceForInsertInResult.Count);
                    result.RemoveRange(startIndex, removeNumberToEndTheList);
                }

                if (commandLine.Count != sequenceForInsertInResult.Count) 
                {                                                         
                    isBreaksIncreasing = true;                            
                }                                                         
                                                                                                         
                for (int k = 0; k < result.Count; k++)
                {
                    if (result[k] <= sequenceForInsertInResult[0])  
                    {                                                                    
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }

                result.InsertRange(index, sequenceForInsertInResult);  
                if (isBreaksIncreasing) 
                {                                                                                 
                    var startIndex = index + sequenceForInsertInResult.Count;
                    var removeNumberToEndTheList = result.Count - (index + sequenceForInsertInResult.Count);
                    result.RemoveRange(startIndex, removeNumberToEndTheList);
                }
            }

            Console.WriteLine(string.Join(" ", result));
            // var n = int.Parse(Console.ReadLine());
            // var currentList = Console.ReadLine().Split().Select(int.Parse).ToList();
            // var result = new List<int>();
            // result.AddRange(currentList);
            // var numsToInsert = new List<int>();
            // var isBroken = false;
            //
            // for (int i = 0; i < n - 1; i++)
            // {
            //     currentList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //
            //     var theRightMostElement = FindTheRightMostElement(result, currentList[0]);
            //     var valueIndex = result.IndexOf(theRightMostElement);
            //     var indexToInsert = valueIndex + 1;
            //
            //     foreach (var element in currentList)
            //     {
            //         if (element > indexToInsert)
            //         {
            //             numsToInsert.Add(element);
            //         }
            //
            //     }
            //
            //     result.InsertRange(indexToInsert, numsToInsert);
            //
            //     if (numsToInsert.Count == currentList.Count)
            //     {
            //         isBroken = false;
            //     }
            //     else if (!isBroken)
            //     {
            //         var startIndex = indexToInsert + numsToInsert.Count;
            //         var removeNumberToEndTheList = result.Count - (indexToInsert + numsToInsert.Count);
            //         result.RemoveRange(startIndex, removeNumberToEndTheList);
            //     }
            //
            //     numsToInsert.Clear();
            //
            // }
            //
            // Console.WriteLine(string.Join(" ", result));
        }

       //public static int FindTheRightMostElement(List<int> result, int v)
       //{
       //    var theRightMost = 0;
       //
       //    for (int i = result.Count - 1; i > 0; i--)
       //    {
       //        if (result[i] <= v)
       //        {
       //            theRightMost = result[i];
       //            break;
       //        }
       //
       //    }
       //
       //    return theRightMost;
       //}
    }
}


