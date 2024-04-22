// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.InteropServices;
using System.Text;


        string a = "10110110";
        string b = "101";

        var c = a.Length - b.Length;

        var maxArray = c > 0 ? a : b;

        Char[] aCharArray = new Char[maxArray.Length];
        aCharArray = a.ToCharArray();
        Char[] bCharArray = new Char[maxArray.Length];
        bCharArray = b.ToCharArray();
        Char[] resizedArray = new Char[maxArray.Length];
        Char[] resultArray = new Char[maxArray.Length +1];
        bool carry = false; 

        Array.Copy(c > 0 ? b.ToCharArray() : a.ToCharArray(), 0, resizedArray,Math.Abs(a.Length-b.Length), c > 0 ? b.Length : a.Length);

    for (int i = maxArray.Length -1; i >=0; i--)
        {
            if (resizedArray[i] == '\0') { resizedArray[i] = Convert.ToChar(48);};
        if (resizedArray[i] != (c > 0 ? aCharArray[i] : bCharArray[i]) )
        {
            if (carry ==false) { resultArray[i+ 1] = '1'; carry = false; } else { resultArray[i+1] = '0'; carry = true; };
            if (i == 0 && carry == true) { resultArray[i] = '1'; } 
            continue;
        }

        if (resizedArray[i] == (c > 0 ? aCharArray[i] : bCharArray[i]) & (c > 0 ? aCharArray[i] : bCharArray[i])=='1')
        {
            if (carry == false) { resultArray[i + 1] = '0'; carry = true; } else { resultArray[i +1] = '1'; carry = true; };
            if (i == 0 && carry == true) { resultArray[i] = '1'; } 
            continue;
        }

        if (resizedArray[i] == (c > 0 ? aCharArray[i] : bCharArray[i]) & (c > 0 ? aCharArray[i] : bCharArray[i]) == '0')
        {
            if (carry == false) { resultArray[i+1] = '0'; carry = false; } else { resultArray[i+1] = '1'; carry = false; };
            if (i == 0 && carry == true) { resultArray[i] = '1'; }
            continue;
        }
}
Console.WriteLine((c > 0 ? aCharArray : bCharArray));
Console.WriteLine(resizedArray);
Console.WriteLine("-------------");
Console.WriteLine(resultArray);



