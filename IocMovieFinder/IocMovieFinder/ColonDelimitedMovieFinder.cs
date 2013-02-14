using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace IocMovieFinder
{
    class ColonDelimitedMovieFinder:IMovieFinder
    {
        public ColonDelimitedMovieFinder(FileInfo file)
        {
            MovieFile = file;
        }

        public IList FindAll()
        {
            return new ArrayList();
        }

        public FileInfo MovieFile
        {
            get;
            set;
        }
    }
}
