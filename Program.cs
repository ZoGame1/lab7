using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7

{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Cau A */
			Console.WriteLine("Binh Phuong Cua Cac So lon hon 4 ");
			List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };
			var kq = nums.Where(x=> x > 4).Select(x=> x * x);
			foreach (var num in kq)
			{
				Console.WriteLine(num + " ");
			}
			/* Cau B */
			Console.WriteLine("----------------------------------------------------------");
			Console.OutputEncoding = Encoding.UTF8;										
			Console.WriteLine("xuất ra màn hình lần lượt số lần xuất hiện của từng chữ");
			string str1 = "chao mung den voi binh nguyen vo tan ";							
			var charFrequyency = str1.GroupBy(c => c)
									.Select(g => new { Key = g.Key, count = g.Count() });
			foreach (var bul in charFrequyency)
			{
				Console.WriteLine(bul + " ");
			}
			Console.WriteLine("----------------------------------------------------------");


			/* Cau C */
			string strc = " CHAO mung DEN Voi binh nguyen vo tan";
			var words = strc.Split(' ');
			var resultc = from word in words
						  where word.Equals(word.ToUpper())
						  select word;
			foreach (var BL in resultc)
			{
				Console.WriteLine(BL + " ");	
			}


		}
	}
}

