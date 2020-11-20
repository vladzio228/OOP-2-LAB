using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_laba
{
    public class SAX : IParse
    {
        private List<Searching> lastResult = null;
        public List<Searching> AnalyzeFile(Searching mySearch, string path)
        {
            XmlReader reader = XmlReader.Create(path);
            List<Searching> result = new List<Searching>();
            Searching find = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Game")
                        {
                            find = new Searching();
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.Name == "NameOfTheGame")
                                {
                                    find.nameOfTheGame = reader.Value;
                                }
                                if (reader.Name == "Developer")
                                {
                                    find.developer = reader.Value;
                                }
                                if (reader.Name == "ReleaseDate")
                                {
                                    find.releaseDate = reader.Value;
                                }
                                if (reader.Name == "MainGenre")
                                {
                                    find.mainGenre = reader.Value;
                                }
                                if (reader.Name == "GameMode")
                                {
                                    find.gameMode = reader.Value;
                                }
                                if (reader.Name == "Engine")
                                {
                                    find.engine = reader.Value;
                                }
                                if (reader.Name == "Metascore")
                                {
                                    find.metascore = reader.Value;
                                }
                            }
                            result.Add(find);
                        }
                        break;
                }
            }
            lastResult = Filter(result, mySearch);
            return lastResult;
        }

        private List<Searching> Filter(List<Searching> allRes, Searching myTemplate)
        {
            List<Searching> newResult = new List<Searching>();
            if(allRes != null)
            {
                foreach(Searching e in allRes)
                {
                    if((myTemplate.developer    == e.developer   || myTemplate.developer == null) &&
                       (myTemplate.releaseDate  == e.releaseDate || myTemplate.releaseDate == null) &&
                       (myTemplate.mainGenre    == e.mainGenre   || myTemplate.mainGenre == null) &&
                       (myTemplate.gameMode     == e.gameMode    || myTemplate.gameMode == null) &&
                       (myTemplate.engine       == e.engine      || myTemplate.engine == null) &&
                       (myTemplate.metascore    == e.metascore   || myTemplate.metascore == null))
                    {
                        newResult.Add(e);
                    }
                }
            }
            return newResult;
        }
    }
}
