using System;
namespace Pizzeria.Exceptions
{
    public class MainMenuActionDoesnotExsistException : Exception
    {
        public MainMenuActionDoesnotExsistException()
        {
        }
        public MainMenuActionDoesnotExsistException(string messege)
            : base(messege)
        {
        }
        public MainMenuActionDoesnotExsistException(string messege, Exception inner)
            : base(messege, inner)
        {
        }
    }
}
