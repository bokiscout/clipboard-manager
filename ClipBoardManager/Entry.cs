using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipBoardManager
{
    interface Entry
    {
        String GetId();

        String GetShortContent();
        
        bool Equals(object obj);

        String ToString();
    }
}
