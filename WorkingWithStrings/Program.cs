using System;

namespace WorkingWithStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			//string myString = "Go to your c:\\ drive";
			//string myString = "my \ "so called\" life";
			//string myString = "What if I need \n a new line?";;

			//string myString = string.Format("{0}!", "Bonzai");
			//string myString = string.Format("make: {0} (model:X (1)") ;

			//string myString = "";

			//for (int i = 0; i < 100; i++)
			//{
			//  myString = myString + "_ _" + i.ToString();

			//}
			/*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i ++)
            {
                myString.Append("- -");
                myString.Append(i);
            }
*/

			//Takes out 14 characters
			string myString = " That summer we took threes across the board ";
			//myString = myString.Substring(5, 14);
			//myString = myString.ToUpper(); 
			//myString = myString.Replace(" ", "--"); 
			myString = String.Format("Length before: {0} -- After: {1}", myString.Length, myString.Trim().Length);
			Console.WriteLine(myString);
			Console.ReadLine();
		}
	}
}
//this is impottant becuase it taeches you all the diffrent ways to make strings
// this will be helpful for the AP exam because its a good skill