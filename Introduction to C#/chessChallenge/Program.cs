using System;

namespace chessChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string _c;
            
            for(int counter = 0; counter < 8; counter++)
            {
                if( (counter % 2) == 0)
                {
                    _c = "X";
                }
                else{
                    _c = "O";
                }

                Console.Write(_c);
            }


        }
    }
}
