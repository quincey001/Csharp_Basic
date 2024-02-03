using System;
namespace Csharp_Basics
{
	public class EmptyClass
	{
		 
		public static void PrimitiveData()
		{
            // integer: default is int
            sbyte a = -0b111;
            short b = -0x334;
            int c = -0b101010;
            long d = -0x3;
            Console.WriteLine($"this is a signed byte: {a}");
            Console.WriteLine($"this is a signed short: {b}");
            Console.WriteLine($"this is a signed int: {c}");
            Console.WriteLine($"this is a signed long: {d}");
        }
	}
}

