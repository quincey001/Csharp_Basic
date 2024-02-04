# 2.Primitive Data Type

## Primitive data type:

### 1. Integer:   (default is int)

**signed byte, signed short, signed int, signed long** 

**sbyte, short, int, long**

![Untitled](2%20Primitive%20Data%20Type%2013f90bc20f4b446faee3a65be62c347b/Untitled.png)

```csharp
using System;

public class HelloWorld
{
	public static void Main(string[] args)
	{
		sbyte a = -0b1111;
    short b = -0x334;
    int c = -0b10101;
    long d = -0x3;
    
    Console.WriteLine($"this is a signed byte: {a}");
    Console.WriteLine($"this is a signed short: {b}");
    Console.WriteLine($"this is a signed int: {c}");
    Console.WriteLine($"this is a signed long: {d}");
	}
}
>>>this is a signed byte: -15
		this is a signed short: -820
		this is a signed int: -21
		this is a signed long: -3
```

### Binary, Octal, Decimal, Hexadecimal number

```csharp
using System;

class Program
{
	public static void Main(string[] args)
	{
		int binaryNumber = 0b101100;
		int decimalNumber = 45;
		int octalNumber = Convert.ToInt32("75",8);// convert octal string to int
		// "75" cannot be 88
		int hexadecimalNumber = 0x2a;

		Console.WriteLine($"Binary : {binaryNumber}");
		Console.WriteLine($"Decimal: {decimalNumber}");
    Console.WriteLine($"Octal: {octalNumber}");
    Console.WriteLine($"Hexadecimal: {hexadecimalNumber}");
	}
}
>>>Binary: 44
Decimal: 42
Octal: 61
Hexadecimal: 42
```

**unsigned byte, unsigned short, unsigned int, unsigned long**

**byte, ushort, uint, ulong** 

Unsigned integer

![Untitled](2%20Primitive%20Data%20Type%2013f90bc20f4b446faee3a65be62c347b/Untitled%201.png)

```csharp
using System;

class Program
{
    static void Main()
    {
        
        byte A = -1;// compiling error
        byte B = 1;
        ushort C = 343;
        uint D = 3;
        ulong E = 33;
        Console.WriteLine($"this is a unsigned byte: {B}");
        Console.WriteLine($"this is a unsigned short: {C}");
        Console.WriteLine($"this is a unsigned int: {D}");
        Console.WriteLine($"this is a unsigned long: {E}");
    }
}
>>>this is a unsigned byte: 1
this is a unsigned short: 343
this is a unsigned int: 3
this is a unsigned long: 33
```

### 2. Floating point:

![Untitled](2%20Primitive%20Data%20Type%2013f90bc20f4b446faee3a65be62c347b/Untitled%202.png)

**float, double**

**Float:** it is 32-bit single-precision floating point type. it has 7 digit precision. To initialize a float variable, use the suffix f or F. if the suffix F or f will not use then it is treated as double.

**Double:** it is 64-bit double-precision floating point type. It has 14-15 digit precision.

```csharp
using System;

class Program
{
	public static void Main(string[] args)
	{
		float a = 23;
		float num1 = 343.6;// compiling error: type double cannot be implicitly convert
												// to type float
		double num2 = 343.4;

	}
}
```

# 3. Decimal Types:

![Untitled](2%20Primitive%20Data%20Type%2013f90bc20f4b446faee3a65be62c347b/Untitled%203.png)

the decimal type is a 128-bit/ 16 bytes data type suitable for financial and monetary calculations, 

it has 28-29 digit precision.

if the suffix m or M will not use then it is treated as double.

```csharp
decimal x = 2332.3m;
```

## 4. Character Type

the character types represent a UTF-16 code unit or represents the 16-bit Unicode character.

char type has 2 bytes.

```csharp
char a = "a";
```

## 5. Boolean Type

```csharp
bool check = true;

```