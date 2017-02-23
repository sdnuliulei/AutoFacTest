using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoFac.Data
{
    public class SqlRepository:IRepository
    {
        #region IRepository 成员

        public void Get()
        {
            Console.WriteLine("sql数据源");
        }

        #endregion
    }
}
