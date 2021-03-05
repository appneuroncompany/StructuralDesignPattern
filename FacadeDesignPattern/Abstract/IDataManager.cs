using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern.Abstract
{
    public interface IDataManager
    {
        void SaveData(string data, string filePath);
        void CheckData(string filePath);
        void DeleteData(string filePath);

    }
}
