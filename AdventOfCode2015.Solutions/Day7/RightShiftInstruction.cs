﻿using System.Collections.Generic;

namespace AdventOfCode2015.Solutions.Day7
{
    internal class RightShiftInstruction : Instruction
    {
        private readonly string _wireId;
        private readonly int _shift;

        public RightShiftInstruction(string wireId, int shift)
        {
            _wireId = wireId;
            _shift = shift;
        }

        protected override ushort Resolve(IDictionary<string, Instruction> wires)
        {
            return (ushort)(wires[_wireId].GetValue(wires) >> _shift);
        }
    }
}