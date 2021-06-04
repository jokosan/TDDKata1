using System;

namespace TDDKata1.Contract
{
    public interface IUserInteraction
    {
        bool ConfirmActions();
        void ResultValue(int value);
        void StartInfo(bool status);
        void StartInfo(string message);
        string UserValueInput();
    }
}