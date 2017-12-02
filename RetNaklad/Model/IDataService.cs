using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetNaklad.Model
{
    public interface IDataService
    {
        void GetRetNaklad(Action<DataItem, Exception> callback);
        void SaveRetNaklad(ReturnNaklad model);
        void PrintRetNaklad(ReturnNaklad retNaklad);
    }
}
