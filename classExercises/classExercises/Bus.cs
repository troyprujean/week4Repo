using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExercises
{
    class Bus
    {
        string colour;
        string rego;
        int doors;
        int seats;

        public string GetColour()
        {
            return colour;
        }
        public void SetColour(string col)
        {
            colour = col;
        }

        public string GetRego()
        {
            return rego;
        }
        public void SetRego(string reg)
        {
            rego = reg; 
        }

        public int GetDoors()
        {
            return doors;
        }
        public void SetDoors(int door)
        {
            doors = door;
        }

        public int GetSeats()
        {
            return seats;
        }
        public void SetSeats(int _seats)
        {
            seats = _seats;
        }
    }
}
