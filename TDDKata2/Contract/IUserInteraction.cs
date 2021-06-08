using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata2.Contract
{
    public interface IUserInteraction
    {
        void Info(string message);
        string UserValueInput();
    }
}
