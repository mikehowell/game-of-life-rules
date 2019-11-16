using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL.Models
{
    class Cell
    {
        private enum State
        {
            Dead,
            Alive
        }

        public Cell()
        {
            CurrentState = State.Dead;
        }

        private State CurrentState { get; set; }

    }
}
