using System;

namespace lw8
{
    class NoSuchBookStatusException : Exception
    {
        public NoSuchBookStatusException(string message) : base(message) { }
    }
}
