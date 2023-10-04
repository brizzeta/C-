using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09.Tic_Tac_Toe
{
    internal interface IForm
    {
        event EventHandler<EventArgs> OneToOne;
    }
}
