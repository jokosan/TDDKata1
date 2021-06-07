using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata1.Contract;

namespace TDDKata1
{
    public class ConsoleWrappersInterface
    {
        private readonly IUserInteraction _userInterface;

        public ConsoleWrappersInterface(IUserInteraction userInterface)
        {
            _userInterface = userInterface;
        }

        public ConsoleWrappersInterface()
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

        public bool Write(string message, bool isValid)
        {
            bool success = false;

            if (isValid)
            {
                _userInterface.StartInfo(message);
                success = true;
            }

            return success;

        }

        public bool ValidateMessage(string message)
        {
            if (message == ClassConstant.MessageStart)
            {
                return Write(message, true);
            }
            else if (message == ClassConstant.MessageChoiceOfAction)
            {
                return Write(message, true);
            }
            else
            {
                return false;          
            }
        }

    }
}
