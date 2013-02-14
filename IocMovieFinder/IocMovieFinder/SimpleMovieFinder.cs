using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IocMovieFinder
{
    class SimpleMovieFinder : IMovieFinder
    {
        public IList FindAll()
        {
            return new ArrayList();
        }
    }
}
