using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string strLine = Console.ReadLine();
			char[] aryChar = strLine.ToArray();
			for(int nNum = aryChar.Length - 1; nNum > -1; nNum--)
			{
				Console.Write(aryChar[nNum]);
			}
			Console.WriteLine();
		}
	}
}
