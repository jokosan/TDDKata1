using System;

namespace TDDKata1
{
    public interface IUserInterface
    {
        bool ConfirmActions();
        void ResultValue(int value);
        void StartInfo(bool status);
        string UserValueInput();
    }
}