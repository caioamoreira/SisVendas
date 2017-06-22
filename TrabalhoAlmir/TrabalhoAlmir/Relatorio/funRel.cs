using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoAlmir.Relatorio
{
    public class funRel
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\RelTrabalhoAlmir";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }


    }
}
