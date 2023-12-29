using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;



//*/////////////////////////////////////////////*//
// CSCN72010 F23 Asst 1                          //
// Assignment1  OCT 6, 2023                      //
// Michelle Gordon                               //
//*/////////////////////////////////////////////*//


namespace Assignment1
{
    public class Aclass
    {
        // 1. returns true if x <= y, else returns false 
        public bool Check(int x, int y) // variables for Check are int x and int y 
        {
            if (x <= y)
            {
                return true;  // returns true if x <= y
            }
            else
            {
                return false; // otherwise false
            }

        }

        // 2. returns the largest of (num1, num2, num3)
        public float Max(float x, float y, float z) // variable for Max are float and are x, y, and z          
        {
            if (x > y)
            {
                if (x > z)
                {
                    return x;      // return x if x > y and if x > z 
                }
                else
                {
                    return z;               // else return z
                }
            }
            else if (y > z)
                return y;                // return y if y > z
            else
                return z;               // else return z 
        }

        //3. returns the factorial of x (when x>= 0) else returns -1                  
        public int Fact(int x)  // variable is int x 
        {
            if (x < 0)
            {
                return -1;   // if x is less than 0, return -1
            }
            else 
            {
                int factorial= 1;
                for (int i = 1; i <= x; ++i)   // for loop to calculate the factorial of x
                {
                    factorial *= i;
                }
                return factorial;    // return the factorial value 
            }
        }

        //4. returns the greatest common divisor of x and y where x >= 1 and y >= 1, returns -1 if x < 1 and/or y < 1 a.Ex Gcd(10,6)= 2 , Gcd(18,12)= 6 
        public int Gcd(int x, int y)      // variables for Gcd are int x and int y               
        {
            if (x < 1 ||  y < 1)
            {
                return -1;  // if x or y are < 1, return -1
            }
            else
            { 
                if (x > y)       // calculate the gcd
                    x %= y;   
                else
                    y %= x;
            }
            return x | y;   // return x or y whatever is the gcd
        }

        //5. Returns true if s1 <= s2 <= s3 lexicographically, else returns false 
        public bool Checkasc(String x, String y, String z)    // variables are string and x, y, and z
        {

            int xy = x.CompareTo(y);   // set up comparitor variables
            int xz = x.CompareTo(z);
            int yz = y.CompareTo(z);

            if ((xy < xz) && (xz < yz))     // compare them two ways by order
            {
                return true;  // return true if order correct 
            }
            else
            {
                return false;  // false if not.
            }
        }

        //6.  Returns difference between the lengths of the larger string and the smaller string (returns 0 if both the strings are of the same length) 
        public int Lengthdiff(String x, String y)    // variables are string x and string y 
        {
            if (x.Length > y.Length)           
            {
                return x.Length - y.Length;    // if length of x is bigger than y, return difference
            }
            else if (y.Length > x.Length)     
            {
                return y.Length - x.Length;      // if length of y is bigger than x, return difference
            }
            else
            {
                return 0;            // return 0 if they are same length
            }
        }
        //7.  Returns true if the length of s1 and s2(concatenated) is <=len, else returns false Ex: Concatcomp(“Hello”, “World”, 8) returns false
        public bool Concatcomp(String x, String y, int z)   // variables are x, y, and z
        {
            if ((x + y).Length <= z)      
            {
                return true;   // if length of concatenated string is less than the length of z, return true 
            }
            else
            {
                return false; // else return false
            }
        }
    }
}