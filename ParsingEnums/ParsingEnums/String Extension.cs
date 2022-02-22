﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParsingEnums
{
    public static class String_Extension
    {
        public static string FirstCharToLowerCase(this string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str[0]))
                return str;

            return char.ToLower(str[0]) + str.Substring(1);
        }
    }
}
