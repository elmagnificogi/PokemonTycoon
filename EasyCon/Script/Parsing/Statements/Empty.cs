﻿using EasyCon.Script.Assembly;
using EasyCon.Script.Parsing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCon.Script.Parsing.Statements
{
    class Empty : Statement
    {
        public static readonly IStatementParser Parser = new StatementParser(Parse);
        public readonly string Text;

        public Empty(string text = "")
        {
            Text = text;
        }

        public static Statement Parse(ParserArgument args)
        {
            if (args.Text.Length == 0)
                return new Empty();
            return null;
        }

        protected override string _GetString(Formats.Formatter formatter)
        {
            return Text;
        }

        public override void Exec(Processor processor)
        { }

        public override void Assemble(Assembler assembler)
        { }
    }
}
