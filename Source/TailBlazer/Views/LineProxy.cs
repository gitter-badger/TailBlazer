using System;
using TailBlazer.Domain.FileHandling;

namespace TailBlazer.Views
{
    public class LineProxy
    {
        private readonly Line _line;

        public LineProxy(Line line, DateTime? dateTime)
        {
            _line = line;
        }

        public int Number => _line.Number;
        public string Text => _line.Text;

    }
}