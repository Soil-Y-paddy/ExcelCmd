﻿using System;

namespace consTest
{
	class Program
	{
		static void Main(string[] args)
		{
            // Visual Stdio から編集
			string strLine = Console.ReadLine(); // 標準入力から1行取得
			char[] aryChar = strLine.ToCharArray(); // 文字配列に変換
			for(int nNum = aryChar.Length - 1; nNum > -1; nNum--) // 逆順ループ
			{
				Console.Write(aryChar[nNum]);//一文字づつ書き出す
			}
		}
	}
}
