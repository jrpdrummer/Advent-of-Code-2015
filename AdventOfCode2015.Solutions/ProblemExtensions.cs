﻿namespace AdventOfCode2015.Solutions
{
    public static class ProblemExtensions
    {

        public static IProblem SendToClipboard(this IProblem problem)
        {
            return new ClipboardDecorator(problem);
        }

        public static IProblem AppendTime(this IProblem problem)
        {
            return new ProblemTimerDecorator(problem);
        }
    }
}
