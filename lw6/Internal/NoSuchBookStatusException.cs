using System;

namespace lw6
{
    class NoSuchBookStatusException : Exception
    {
        public NoSuchBookStatusException(string message) : base(message) { }
    }
}
