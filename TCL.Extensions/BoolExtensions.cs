﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCL.Extensions
{
    /// <summary>
    /// Extensions for booleans.
    /// </summary>
    public static class BoolExtensions
    {
        /// <summary>
        /// Turns a boolean into "Yes" or "No"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToYesNo(this bool source)
        {
            return source
                ? "Yes"
                : "No";
        }
    }
}
