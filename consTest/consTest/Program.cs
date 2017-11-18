using System;

namespace consTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string strLine = Console.ReadLine();
			char[] aryChar = strLine.ToCharArray();
			for(int nNum = aryChar.Length - 1; nNum > -1; nNum--)
			{
				Console.Write(aryChar[nNum]);
			}
		}
	}
}
