using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_laba
{
    public class DOM : IParse
    {
        XmlDocument doc = new XmlDocument();
        public List<Searching> AnalyzeFile(Searching mySearch, string path)
        {
            doc.Load(path);
            List<List<Searching>> info = new List<List<Searching>>();

            if(mySearch.developer    == null && 
               mySearch.releaseDate  == null && 
               mySearch.mainGenre    == null &&
               mySearch.gameMode     == null &&
               mySearch.engine       == null &&
               mySearch.metascore    == null)
            {
                return ErrorCatch(doc);
            }

            if (mySearch.developer   != null) info.Add(SearchingByFilter("Game", "Developer", mySearch.developer, doc));
            if (mySearch.releaseDate != null) info.Add(SearchingByFilter("Game", "ReleaseDate", mySearch.releaseDate, doc));
            if (mySearch.mainGenre   != null) info.Add(SearchingByFilter("Game", "MainGenre", mySearch.mainGenre, doc));
            if (mySearch.gameMode    != null) info.Add(SearchingByFilter("Game", "GameMode", mySearch.gameMode, doc));
            if (mySearch.engine      != null) info.Add(SearchingByFilter("Game", "Engine", mySearch.engine, doc));
            if (mySearch.metascore   != null) info.Add(SearchingByFilter("Game", "Metascore", mySearch.metascore, doc));

            return Cross(info, mySearch);
        }

        public List<Searching> SearchingByFilter(string nodeName, string filter, string myTemplate, XmlDocument doc)
        {
            List<Searching> find = new List<Searching>();

            if (myTemplate != null)
            {
                XmlNodeList lst = doc.SelectNodes("//" + nodeName + "[@" + filter + "=\"" + myTemplate + "\"]");
                foreach(XmlNode e in lst)
                {
                    find.Add(Info(e));
                }
            }
            return find;
        }

        public List<Searching> ErrorCatch(XmlDocument doc)
        {
            List<Searching> result = new List<Searching>();
            XmlNodeList lst = doc.SelectNodes("//" + "Game");

            foreach(XmlNode e in lst)
            {
                result.Add(Info(e));
            }
            return result;
        }

        public Searching Info(XmlNode node)
        {
            Searching searching = new Searching();

            searching.nameOfTheGame = node.Attributes.GetNamedItem("NameOfTheGame").Value;
            searching.developer     = node.Attributes.GetNamedItem("Developer").Value;
            searching.releaseDate   = node.Attributes.GetNamedItem("ReleaseDate").Value;
            searching.mainGenre     = node.Attributes.GetNamedItem("MainGenre").Value;
            searching.gameMode      = node.Attributes.GetNamedItem("GameMode").Value;
            searching.engine        = node.Attributes.GetNamedItem("Engine").Value;
            searching.metascore     = node.Attributes.GetNamedItem("Metascore").Value;
            return searching;
        }

        public List<Searching> Cross(List<List<Searching>> lst, Searching myTemplate)
        {
            List<Searching> result = new List<Searching>();
            List<Searching> clear = NodeCheck(lst, myTemplate);

            foreach(Searching e in clear)
            {
                bool isIn = false;
                foreach(Searching el in result)
                {
                    if (el.Compare(e))
                    {
                        isIn = true;
                    }
                }
                if (!isIn)
                {
                    result.Add(e);
                }
            }
            return result;
        }

        public List<Searching> NodeCheck(List<List<Searching>> lst, Searching myTemplate)
        {
            List<Searching> newResult = new List<Searching>();
            foreach(List<Searching> e in lst)
            {
                foreach(Searching el in e)
                {
                    if((myTemplate.developer   == el.developer   || myTemplate.developer   == null) &&
                       (myTemplate.releaseDate == el.releaseDate || myTemplate.releaseDate == null) &&
                       (myTemplate.mainGenre   == el.mainGenre   || myTemplate.mainGenre   == null) &&
                       (myTemplate.gameMode    == el.gameMode    || myTemplate.gameMode    == null) &&
                       (myTemplate.engine      == el.engine      || myTemplate.engine      == null) &&
                       (myTemplate.metascore   == el.metascore   || myTemplate.metascore   == null))
                    {
                        newResult.Add(el);
                    }                
                }
            }
            return newResult;
        }
    }
}
