using System;

namespace lw9
{
    class NoSuchBookStatusException : Exception
    {
        public NoSuchBookStatusException(string message) : base(message) { }
    }
}
