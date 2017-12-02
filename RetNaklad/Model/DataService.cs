using GalaSoft.MvvmLight;
using RetNaklad.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace RetNaklad.Model
{
    public class DataService : IDataService
    {
        public void SaveNaklad()
        {
        }

        public void SaveRetNaklad(ReturnNaklad retNaklad)
        {            
        }

        public void PrintRetNaklad(ReturnNaklad retNaklad)
        {
        }

        public void GetRetNaklad(Action<DataItem, Exception> callback)
        {
        }        
    }
}