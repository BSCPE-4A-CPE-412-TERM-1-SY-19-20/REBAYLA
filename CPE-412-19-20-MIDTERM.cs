using System;
using System.Collections.Generic;

namespace midterm
{
    class Program
    {
        char []save1;
        string []save2;
        string []save3;
        
        public int splitting(string state_ment)
        {
            //converting string to char array
            char []str = state_ment.ToCharArray();
            //to save the delimiter, make a copy
            char []strdup = state_ment.ToCharArray();
            save1 = state_ment.ToCharArray();

            string[]split = state_ment.Split(new char[] {'=',';'},StringSplitOptions.RemoveEmptyEntries);
            try{
            var str1 = new List <string>();
            int from = 0;
            int testme=0;
            
            
            //hello=num;
            //5
            //
    //        Console.WriteLine("adding on the list");
            foreach(string ch in split)
            {
            
    //            Console.WriteLine("string {0}",ch);
                str1.Add(ch);
    //            Console.WriteLine("inserting {0}",ch);
                from = ch.Length+from;
    //            Console.WriteLine(from);
                str1.Add(str[from+testme].ToString());
                testme++;
                
            }
            //testing the List
            //saving it to public variable
    //        Console.WriteLine("Transferring");
            int cap = str1.Count;
            save2 = new String[cap];
            int count=0;
            foreach(string gh in str1)
            {
    //            Console.WriteLine(gh);
                save2[count] = gh.ToString();
    //            Console.WriteLine(save2[count]);
                count++;
            } 
            }
            catch{
            //    Console.WriteLine("Invalid");
            }
    

            return 1;
        }


        int check_simpleno(string simplenum)
        {
            int state=0;
            int [,]table = new int [,] {
                {1,4,4},
                {1,2,4},
                {3,4,4},
                {3,4,4},
                {4,4,4}
            };
            int input=0;
            int flag = 0;
            
            //test simple number function
            //checking each char if its digits
            foreach (char n in simplenum)
            {
            //    Console.WriteLine(n);
                if(n=='.')
                {
                    input = 1;
        //            Console.WriteLine("state_1");
                }
                else if (char.IsDigit(n))
                {
                    input=0;
        //            Console.WriteLine("state_0");
                }
                else {
                    input=2;
        //            Console.WriteLine("state_2");
                }
                
                state = table[state,input];
                if(state==1)
                {
                    flag=1;
                }
                else if (state==3)
                {
                    flag =1;
                }
                else {
                    flag =0;
                }
            }
            
            if(flag == 1)
            {
//                Console.WriteLine("simplenumber_accepted");
                return 1;
            }
            else
                {
            //    Console.WriteLine("simplenumber_notaccepted");
                return 0;
            }
        }

        
        int check_identifier(string simpleidentifier)
        {
        int state =0;
        int [,] table = new int [,] {
            {1,1,2,2},
            {1,1,1,2},
            {2,2,2,2}
        };
        int input;
        int flag=0;
        
    //    Console.WriteLine("identifier function");
        
        foreach (char m in simpleidentifier)
        {
            if(m=='_')
            {
                input=0;
        //        Console.WriteLine("identifier detects _ ");
            }
            else if (char.IsLetter(m))
            {
                input = 1;
        //        Console.WriteLine("identifier detects letter");
            }
            else if (char.IsDigit(m))
            {
                input = 2;
        //        Console.WriteLine("identifier detects digit");
            }
            else {
                input =3;
        //        Console.WriteLine("?");
            }
            
            state = table [state,input];
            if (state==1)
            {
                flag =1;
            }
            else {
                flag = 0;
            }
        }
    //    Console.WriteLine("identifing");
        
        if(flag==1)
        {
//            Console.WriteLine("identifier");
            return 1;
        }
        else {
//            Console.WriteLine("Not identifier");
            return 0;
        }
        }
