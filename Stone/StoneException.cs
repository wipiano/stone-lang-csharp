using System;

namespace Stone
{
    public class StoneException : Exception
    {
        public StoneException(string message)
            : base(message)
        {
        }
        
        // TODO: support ASTree
    }
}