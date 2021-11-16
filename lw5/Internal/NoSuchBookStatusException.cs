using System;

namespace lw5
{
    class NoSuchBookStatusException : Exception
    {
        public NoSuchBookStatusException(string message) : base(message) { }
    }
}
