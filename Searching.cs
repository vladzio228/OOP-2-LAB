using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_laba
{
    public class Searching
    {
        public string nameOfTheGame = null;
        public string developer     = null;
        public string releaseDate   = null;
        public string mainGenre     = null;
        public string gameMode      = null;
        public string engine        = null;
        public string metascore     = null;
        public Searching(){}
        public Searching(string[] data)
        {
            developer   = data[0];
            releaseDate = data[1];
            mainGenre   = data[2];
            gameMode    = data[3];
            engine      = data[4];
            metascore   = data[5];
        }
        public bool Compare(Searching obj)
        {
            if((this.nameOfTheGame == obj.nameOfTheGame)&&
               (this.developer     == obj.developer)&&
               (this.releaseDate   == obj.releaseDate)&&
               (this.mainGenre     == obj.mainGenre)&&
               (this.gameMode      == obj.gameMode)&&
               (this.engine        == obj.engine)&&
               (this.metascore     == obj.metascore))
            { 
                 return true;
            }
            else return false;           
        }
    }
}
