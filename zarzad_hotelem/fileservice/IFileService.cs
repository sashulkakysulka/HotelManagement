using MyLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.fileservice
{
    public interface IFileService<T> 
    {
        List<T> ReadData(string path);
        void SaveData(string path, List<T> lista);
    }
}
