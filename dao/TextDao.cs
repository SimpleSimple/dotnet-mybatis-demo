using domain;
using IBatisNet.DataMapper;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class TextDao
    {
        public IList<TextInfo> getTextList(int start, int page_size = 10)
        {
            try
            {
                //return Mapper.Instance().QueryForList<TextInfo>("getTextList", new object());                
                //return Mapper.Get().QueryForList<TextInfo>("getTextList",
                //    new PageParameter(start, page_size));
                return Mapper.Get().QueryForList<TextInfo>("getTextList",
                    new { start, page_size });

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
