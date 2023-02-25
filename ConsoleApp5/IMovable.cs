using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IMovable
    {
        void Move(int x);
        void Move(int x, int y);
        void Move(int x, int y, int z);     
	    void MoveTo(int x, int y);
    }
}
