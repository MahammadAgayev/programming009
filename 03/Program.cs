using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hometask#1
            //int a = 123456;

            //int a1 = a / 100_000;
            //int a2 = a / 10_000 % 10;
            //int a3 = a / 1_000 % 10;
            //int a4 = a / 100 % 10;
            //int a5 = a / 10 % 10;
            //int a6 = a % 10;

            //int sum = a1 + a2 + a3 + a4 + a5 + a6;
            //Console.WriteLine(sum);

            //+,-,*,/,%
            // ++, --

            //int a = 5;
            //a = a + 1; a++;
            //a = a - 1; a--;
            //a = a + 1;
            //a++;

            //a = a - 1;
            //a--;

            //Console.WriteLine(a);

            //bool b = (5 == 5);
            //Console.WriteLine(b);

            //int a = 6;
            //int b = 6;
            //bool l1 = a == b;

            //bool l2 = a > b;
            //bool l3 = a < b;

            //bool l4 = a >= b;
            //bool l5 = a <= b;

            //bool l6 = a != b;

            //Console.WriteLine(l1);
            //Console.WriteLine(l2);  
            //Console.WriteLine(l3);
            //Console.WriteLine(l4);
            //Console.WriteLine(l5);
            //Console.WriteLine(l6);
            //int a = 6;
            //int b = 9;
            //int c = 7;
            //int d = 8;

            //bool r1 = a > d;
            //bool r2 = c < b;
            //bool r3 = b > d;
            //bool r4 = d >= c;

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);

            //7 5 9 
            //5 < 7 < 9

            //logical and
            //5 < 7 and 7 < 9
            //5 < 7 or 7 < 9
            //5 < 7 !and 9 < 7
            //! -> logical not
            //and -> &&
            //or -> ||

            //        true  and   true -> true

            //true or true -> true
            //true or false -> true
            //false or true -> true

            //true and true -> true
            //true and false -> false

            //not true -> false
            //not false -> true

            //true || true -> true
            //false || true -> true
            //true || false -> true

            //true && true -> true
            //false && true -> false
            //true && false -> false

            //!true -> false
            //!false -> true

            //int a = 5;
            //int b = 9;
            //int c = 7;
            //int d = 5;

            //bool r1 = a < b && c < b; //true
            //bool r2 = b > c && a < c; //true
            //bool r3 = b < a && c > a && a < b; //false
            //bool r4 = a < b && c > a && a == d; //true

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);

            //int a = 5;
            //int b = 9;
            //int c = 7;
            //int d = 5;

            //bool r1 = a < b || c < b; //true
            //bool r2 = b > c || a < c; //true
            //bool r3 = b < a || c > a || a < b; //true
            //bool r4 = a < b || c > a || a == d; //true
            //bool r6 = !(a < b || c > a || a == d); //false

            //bool r5 = !(a < b);//false

            //bool r7 = a < b && c > a && !(a == d); //false
            //bool r8 = !(a == d) && a < b && c > a; //false

            //Console.WriteLine(r7);
            //Console.WriteLine(r8);

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);
            //Console.WriteLine(r5);
            //Console.WriteLine(r6);


            //&&, || logical operators
            //&, | bit operators,
            //bitwise operators, binary operators


            //bool r = 3 && 5;
            //int bitOp = 3 & 5;

            //3 -> 11
            //5 -> 101
            //101
            //011
            //-----
            //001

            //int bitResult = 3 & 5;
            //Console.WriteLine(bitResult);

            //int a = 6;
            //int b = 7;

            //a -> 110
            //b -> 111

            //&
            //110
            //111
            //----
            //110

            //|
            //110
            //111
            //----
            //111

            //int bitAnd = a & b;
            //int bitOr = a | b;

            //Console.WriteLine(bitAnd);
            //Console.WriteLine(bitOr);

            //int a = 432;
            //int b = 543;

            //1 2 4 8 16 32 64 128 256 512

            //432
            //result: 110110000
            //432 - 256 = 176
            //176 - 128 = 48
            //64
            //48 - 32 = 16
            //16 - 16 = 0
            //8
            //4
            //2
            //1


            //543
            //result: 1000011111
            //1 2 4 8 16 32 64 128 256 512
            //543 - 512 = 31
            //256
            //128
            //64
            //32
            //31 - 16 = 15
            //15 - 8 = 7
            //7 - 4 = 3
            //3 - 2 = 1
            //1 - 1 = 0

            //int bitAnd = a & b;
            //int bitOr = a | b;

            // 0110110000  - 432
            // 1000011111  - 543
            //&----------
            // 0000010000
            //     160000

            // 0110110000  - 432
            // 1000011111  - 543
            //|----------
            // 1110111111
            // 1 + 2 + 4 + 8 + 16 + 32 + 0 + 128 + 256 + 512
            // = 959

            //XOR -> exclusive OR
            //true ^ true = false
            //false ^ false = false

            //false ^ true = true
            //true ^ false = true

            // 0110110000  - 432
            // 1000011111  - 543
            //^----------
            // 1110101111
            //

            //int bitXor = a ^ b;

            //Console.WriteLine(bitAnd);
            //Console.WriteLine(bitOr);
            //Console.WriteLine(bitXor);

            //bool b1 = true;
            //bool b2 = false;
            //bool b3 = true;

            //bool bResult = b1 & b2;

            //bool bResult2 = b1 & b3 & b2;   //false
            //bool bReuslt3 = b1 && b3 && b2; //false

            //bool bResult4 = b1 & b2 & b3; //false
            //bool bResult5 = b1 && b2 && b3; //false

            //Console.WriteLine(bResult2);
            //Console.WriteLine(bReuslt3);

            //Console.WriteLine(bResult4);
            //Console.WriteLine(bResult5);

            //int a = 5;

            ////binary shift 
            //a = a >> 2;//right shift
            ////___101___ -> 5
            ////    |
            ////___001___ -> 1

            //Console.WriteLine(a);



            //int a = 14;

            ////binary shift 
            //a = a >> 2;//right shift
            ////___1110___ - 14
            ////    |
            ////___0011___ -  3

            //Console.WriteLine(a);

            //int a = 14;

            ////binary shift 
            //a = a << 2;//left shift
            ////__1110__ - 14
            ////    |
            ////__111000_ - 56

            //Console.WriteLine(a);

            //int a = 1;
            //a = a << 10;
            //Console.WriteLine(a);

            //int a = 232;
            //a = a << 1;
            //Console.WriteLine(a);
            //embedded systems

            //menimsetme operatorlari
            //assign operators

            int a = 6;
            //= is assign operator

            a = a + 1;
            a++;

            a = a + 2;
            a += 2;

            a = a - 2;
            a -= 2;

            a = a * 4;
            a *= 4;

            a = a / 6;
            a /= 6;

            a = a % 3;
            a %= 3;
        }
    }
}
