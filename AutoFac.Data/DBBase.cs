using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoFac.Data
{
    public class DBBase
    {
        private IRepository _iRepository;

        public DBBase(IRepository iRepository)
        {
            _iRepository = iRepository;
        }

        public void Search(string commandText)
        {
            _iRepository.Get();
        }
    }
}
