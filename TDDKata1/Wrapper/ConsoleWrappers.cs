using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata1.Wrapper
{
    public class ConsoleWrappers
    {
        private readonly IUserInterface _userInterface;

        public ConsoleWrappers(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public ConsoleWrappers()
        {
        }

        public bool ConfirmActions()
            => _userInterface.ConfirmActions();

        public string UserValueInput()
            => _userInterface.UserValueInput();

        public void ResultValue(int value)
        {
            _userInterface.ResultValue(value);
        }

        public void StartInfo(bool value)
        {
            _userInterface.StartInfo(value);
        }
    }
}
