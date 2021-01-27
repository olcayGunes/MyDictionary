using System;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
			myDictionary.Add(1, "Olcay Güneş");
			myDictionary.Add(2, "Engin Demiroğ");
			myDictionary.Add(3, "Kodlama.io");

			myDictionary.ShowAll();
		}
	}
}
