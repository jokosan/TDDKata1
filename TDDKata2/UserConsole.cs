using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDKata1;
using TDDKata2.Constants;
using TDDKata2.Contract;

namespace TDDKata2
{
    public class UserConsole
    {
        private readonly StringCalculator _stringCalculator;
        private readonly IUserInteraction _userInteraction;

        public UserConsole(
            StringCalculator stringCalculator,
            IUserInteraction userInteraction)
        {
            _stringCalculator = stringCalculator;
            _userInteraction = userInteraction;
        }

        public void Start()
        {
            _userInteraction.Info(MessageUsers.MessageStart);

            string UserString = _userInteraction.UserValueInput();
            _userInteraction.Info($"{MessageUsers.MessageResult} {_stringCalculator.Add(UserString)}");

            while (true)
            {
                _userInteraction.Info(MessageUsers.MessageChoiceOfAction);
                UserString = _userInteraction.UserValueInput();
                
                if (UserString == "") break;
               
                _userInteraction.Info($"{MessageUsers.MessageResult} { _stringCalculator.Add(UserString)}");
            }
        }
    }
}

