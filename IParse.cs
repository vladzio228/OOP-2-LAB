using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_laba
{
    public interface IParse
    {
        List<Searching> AnalyzeFile(Searching mySearch, string path);
    }
}
