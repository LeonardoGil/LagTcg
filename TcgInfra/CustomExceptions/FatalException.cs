﻿namespace TcgInfra.CustomExceptions
{
    public class FatalException : Exception
    {
        public FatalException(string message) : base(message)
        {

        }
    }
}
