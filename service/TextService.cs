using dao;
using domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class TextService
    {
        TextDao textDao = new TextDao();

        public IList<TextInfo> getTextList(int start, int page_size = 10)
        {
            return textDao.getTextList(start, page_size);
        }
    }
}
