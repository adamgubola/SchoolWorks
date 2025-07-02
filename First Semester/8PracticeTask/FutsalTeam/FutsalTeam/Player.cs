using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam
{
    internal class Player
    {
        string name;
        public string Name { get; }

        Position pos;
        public Position position {
            get { return this.pos; }
        }

        public Player(string name, Position position) 
        {
            this.name = name;
            this.pos = position;
        }
        public override string ToString() {
            return $"{this.name} {this.pos}";
        }

        
    }
}

enum Position { Goalkeeper=0, Forward=1, Winger=2, Defender }
