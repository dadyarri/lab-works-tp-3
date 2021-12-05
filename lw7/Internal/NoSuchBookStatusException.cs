using System;

namespace lw7
{
    class NoSuchBookStatusException : Exception
    {
        public NoSuchBookStatusException(string message) : base(message) { }
    }
}
