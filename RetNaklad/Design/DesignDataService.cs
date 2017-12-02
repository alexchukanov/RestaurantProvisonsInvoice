using System;
using RetNaklad.Model;
using System.Collections.ObjectModel;
using RetNaklad.ViewModel;
using GalaSoft.MvvmLight;

namespace RetNaklad.Design
{
    public class DesignDataService : IDataService
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
            ObservableCollection<ProductItemViewModel> productItems = new ObservableCollection<ProductItemViewModel>
            {                
                new ProductItemViewModel {Name = "Лосось филе", UnitType="кг", UnitAmount=1.9, Price=123.95},
                new ProductItemViewModel {Name = "Сыр плавленный Виола", UnitType="шт", UnitAmount=2, Price=36.53},
                new ProductItemViewModel {Name = "Соус чили", UnitType="л", UnitAmount=0.1, Price=22.08}
            };

            ReturnNaklad retNaklad = new ReturnNaklad();

            retNaklad.ProductItemList = productItems;
            retNaklad.Comment = "Комментарий1, комментарий2, комментарий3, комментарий4, комментарий5, комментарий6";
            retNaklad.PaymentDelay = 2;
            retNaklad.PaymentType = 2;
            retNaklad.DocN = "ВН12345";
            retNaklad.DocDate = DateTime.Now;
            retNaklad.BranchId = 2;
            retNaklad.AccountId = 1;
            retNaklad.StoreId = 1;
            retNaklad.ProviderId = 3;
            retNaklad.IsPosted = true;

            var item = new DataItem(retNaklad);
            callback(item, null);
        }     
    }
}