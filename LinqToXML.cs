using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml_laba
{
    public class LinqToXML : IParse
    {
        private List<Searching> find = null;
        XDocument doc = new XDocument();

        public List<Searching> AnalyzeFile(Searching mySearch,string path)
        {
            doc = XDocument.Load(@path);
            find = new List<Searching>();
            List<XElement> matches = (from e in doc.Descendants("Game")
                                      where ((mySearch.developer   == null || mySearch.developer   == e.Attribute("Developer").Value) &&
                                             (mySearch.releaseDate == null || mySearch.releaseDate == e.Attribute("ReleaseDate").Value) &&
                                             (mySearch.mainGenre   == null || mySearch.mainGenre   == e.Attribute("MainGenre").Value) &&
                                             (mySearch.gameMode    == null || mySearch.gameMode    == e.Attribute("GameMode").Value) &&
                                             (mySearch.engine      == null || mySearch.engine      == e.Attribute("Engine").Value) &&
                                             (mySearch.metascore   == null || mySearch.metascore   == e.Attribute("Metascore").Value)
                                            )
                                      select e).ToList();

            foreach(XElement match in matches)
            {
                Searching res = new Searching();
                res.nameOfTheGame = match.Attribute("NameOfTheGame").Value;
                res.developer     = match.Attribute("Developer").Value;
                res.releaseDate   = match.Attribute("ReleaseDate").Value;
                res.mainGenre     = match.Attribute("MainGenre").Value;
                res.gameMode      = match.Attribute("GameMode").Value;
                res.engine        = match.Attribute("Engine").Value;
                res.metascore     = match.Attribute("Metascore").Value;
                find.Add(res);
            }
            return find;
        }
    }
}
