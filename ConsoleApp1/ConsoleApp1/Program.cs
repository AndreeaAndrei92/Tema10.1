using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List
            GenericList<int> genericList = new GenericList<int>();

            genericList.Add(12);
            genericList.Add(3);
            genericList.Add(6);
            genericList.Add(32);
            genericList.Add(8);

            Console.WriteLine("Generic list ToString(): {0}", genericList);

            int index = 3;
            genericList.RemoveAt(index);

            Console.WriteLine("Generic list after removing element at index [{0}]: {1}", index, genericList);

            int element = 7;
            genericList.InsertAt(index, element);

            Console.WriteLine("Generic list after inserting element {0} at index [{1}]: {2}", element, index, genericList);

            Console.WriteLine("Index of element {0}: {1}", element, genericList.IndexOf(element));

            Console.WriteLine("Generic list count: {0}", genericList.Count);
            Console.WriteLine("Generic list capacity: {0}", genericList.Capacity);

            Console.WriteLine("Min element: {0}", genericList.Min());
            Console.WriteLine("Max element: {0}", genericList.Max());


            //Matrix

            int rows = 3;
            int cols = 3;
            int cellValue = 1;

            Matrix<int> firstMatrix = new Matrix<int>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    firstMatrix[row, col] = cellValue;
                    cellValue++;
                }
            }

            Matrix<int> secondMatrix = new Matrix<int>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    cellValue--;
                    secondMatrix[row, col] = cellValue;

                }
            }

            Console.WriteLine("First matrix:");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("First matrix: {0}\n", firstMatrix ? "non-empty" : "empty");

            Console.WriteLine("Second matrix:");
            Console.WriteLine(secondMatrix);

            Console.WriteLine("First matrix + Second matrix: ");
            Console.WriteLine(firstMatrix + secondMatrix);

            Console.WriteLine("First matrix - Second matrix: ");
            Console.WriteLine(firstMatrix - secondMatrix);

            Console.WriteLine("First matrix * Second matrix: ");
            Console.WriteLine(firstMatrix * secondMatrix);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Columns; col++)
                {
                    firstMatrix[row, col] = 0;
                }
            }

            Console.WriteLine("First matrix: ");
            Console.WriteLine(firstMatrix);

            Console.WriteLine("First matrix: {0}\n", firstMatrix ? "non-empty" : "empty");
        }
    }
}
