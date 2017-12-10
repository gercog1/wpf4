using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class BuisnessLogic
{
    public static bool checkPhoneNumber(string number)
    {
        foreach (char c in number)
        {
            if (c < '0' || c > '9')
                return false;
        }
        if (number.Count() != 10 || number[0] != '0') { return false; }
        return true;
    }
}


