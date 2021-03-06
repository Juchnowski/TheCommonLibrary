﻿using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCL.CommandLine
{
    /// <summary>
    /// Base class for Command Line Options using the Program system. This class show the help menu on the console if arguments are not correct.
    /// </summary>
    public abstract class CommandLineOptions
    {
        [ParserState]
        internal IParserState LastParserState { get; set; }

        [HelpOption]
        internal virtual string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
