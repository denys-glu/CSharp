using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplicationTableArray = new int[10, 10];
            for ( int i = 0; i < multiplicationTableArray.GetLength(0); i++ ) 
            {
                for ( int j = 0; j < multiplicationTableArray.GetLength(1); j++ ) 
                {
                    multiplicationTableArray[i, j] = (i + 1) * (j + 1) ;
                }
            }
            System.Console.WriteLine(multiplicationTableArray[0,0]);
            var str = "";
            for (var i = 0; i < 10; i++) {
                str += "[ ";
                for (var j = 0; j < 10; j++){
                    str +=  multiplicationTableArray[i, j] + ", ";
                }
                str += "]\n";
            }
            System.Console.WriteLine(str);
        }
    }
}
