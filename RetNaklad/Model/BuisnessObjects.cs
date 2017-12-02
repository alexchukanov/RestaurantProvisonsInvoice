using RetNaklad.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetNaklad.Model
{  
    public class ReturnNaklad
    {
        public string DocN { get; set; }
        public string Comment { get; set; }
        public int PaymentDelay { get; set; }
        public int PaymentType { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public int BranchId { get; set; }
        public int AccountId { get; set; }
        public int StoreId { get; set; }
        public int ProviderId { get; set; }
        public bool IsPosted { get; set; }
        public ObservableCollection<ProductItemViewModel> ProductItemList { get; set; }        
    }
   
    public class PaymentTypeList : ObservableCollection<string>
    {
        public PaymentTypeList()
        {
            Add("По факту");
            Add("Отсрочка");
            Add("Частичная");
            Add("Безнал");
        }
    }
    
    public class Branch 
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }

    public class BranchList : ObservableCollection<Branch>
    {
        public BranchList()
        {
            Add(new Branch { Id=0, Name="Севастополь" });
            Add(new Branch { Id = 1, Name = "Алушта" });
            Add(new Branch { Id = 2, Name = "Гаспра" });
            Add(new Branch { Id = 3, Name = "Симфирополь" });
        }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class AccountList : ObservableCollection<Account>
    {
        public AccountList()
        {
            Add(new Account { Id = 0, Name = "Наличный счет филиала" });
            Add(new Account { Id = 1, Name = "Безналичный счет филиала" });
            Add(new Account { Id = 2, Name = "Банковский счет филиала" });
            Add(new Account { Id = 3, Name = "Наличный счет головной" });
        }
    }

    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StoreList : ObservableCollection<Store>
    {
        public StoreList()
        {
            Add(new Store { Id = 0, Name = "Склад Алушта Главный" });
            Add(new Store { Id = 1, Name = "Склад Ялта Портовый" });
            Add(new Store { Id = 2, Name = "Склад Севастополь запасной" });
            Add(new Store { Id = 3, Name = "Склад морозилка Симферополь" });
        }
    }

    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProviderList : ObservableCollection<Provider>
    {
        public ProviderList()
        {
            Add(new Provider { Id = 0, Name = "ООО Василек" });
            Add(new Provider { Id = 1, Name = "ООО Ромашка" });
            Add(new Provider { Id = 2, Name = "ООО Фиалка" });
            Add(new Provider { Id = 3, Name = "ООО Ландыши" });
        }
    }

    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public UnitType UnitType { get; set; }
        double Price { get; set; } 
    }

    public class UnitType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }   
    }

    public class UnitTypeList : ObservableCollection<UnitType>
    {
        public UnitTypeList()
        {
            Add(new UnitType { Id = 0, Name = "шт", FullName = "штук" });
            Add(new UnitType { Id = 1, Name = "л", FullName = "литр" });
            Add(new UnitType { Id = 2, Name = "кг", FullName = "килограмм" });            
        }
    }
}
