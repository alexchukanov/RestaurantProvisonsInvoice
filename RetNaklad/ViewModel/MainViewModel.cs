using GalaSoft.MvvmLight;
using RetNaklad.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using GalaSoft.MvvmLight.Command;
using RetNaklad.View;
using GalaSoft.MvvmLight.Messaging;
using RetNaklad.Messages;
using System.Windows.Controls;
using System.Windows;
//using ExtendedGrid.Microsoft.Windows.Controls;

namespace RetNaklad.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ProductItemViewModel pv;
        private readonly IDataService _dataService;

        public BranchList branchList = new BranchList();
        public AccountList accountList = new AccountList();
        public StoreList storeList = new StoreList();
        public ProviderList providerList = new ProviderList();
        //public ProductList productList = new ProductList();
      
        public ObservableCollection<string> PaymentTypeList
        {
            get
            {
                return new PaymentTypeList(); 
            }           
        }

        #region
        public const string IsPostedPropertyName = "IsPosted";
        private bool isPosted = false;
        public bool IsPosted
        {
            get
            {
                return isPosted;
            }
            set
            {
                if (isPosted == value)
                {
                    return;
                }
                isPosted = value;
                RaisePropertyChanged(IsPostedPropertyName);
            }
        }
        #endregion 

        #region
        public const string ProviderNamePropertyName = "ProviderName";
        private string providerName = "";
        public string ProviderName
        {
            get
            {
                return providerName;
            }
            set
            {
                if (providerName == value)
                {
                    return;
                }
                providerName = value;
                RaisePropertyChanged(ProviderNamePropertyName);
            }
        }
        #endregion 

        #region
        public const string ProviderPropertyName = "Provider";
        private Provider provider = null;
        public Provider Provider
        {
            get
            {
                return provider;
            }
            set
            {
                if (provider == value)
                {
                    return;
                }
                provider = value;
                ProviderName = provider.Name;
                RaisePropertyChanged(ProviderPropertyName);
            }
        }
        #endregion 

        

        #region
        public const string StoreNamePropertyName = "StoreName";
        private string storeName = "";
        public string StoreName
        {
            get
            {
                return storeName;
            }
            set
            {
                if (storeName == value)
                {
                    return;
                }
                storeName = value;
                RaisePropertyChanged(StoreNamePropertyName);
            }
        }
        #endregion 

        #region
        public const string StorePropertyName = "Store";
        private Store store = null;
        public Store Store
        {
            get
            {
                return store;
            }
            set
            {
                if (store == value)
                {
                    return;
                }
                store = value;
                StoreName = store.Name;
                RaisePropertyChanged(StorePropertyName);
            }
        }
        #endregion 

        #region
        public const string AccountNamePropertyName = "AccountName";
        private string accountName = "";
        public string AccountName
        {
            get
            {
                return accountName;
            }
            set
            {
                if (accountName == value)
                {
                    return;
                }
                accountName = value;
                RaisePropertyChanged(AccountNamePropertyName);
            }
        }
        #endregion 
  
        #region
        public const string AccountPropertyName = "Account";
        private Account account = null;
        public Account Account
        {
            get
            {
                return account;
            }
            set
            {
                if (account == value)
                {
                    return;
                }
                account = value;
                AccountName = account.Name;
                RaisePropertyChanged(AccountPropertyName);
            }
        }
        #endregion 

        #region
        public const string BranchNamePropertyName = "BranchName";
        private string branchName = "";
        public string BranchName
        {
            get
            {
                return branchName;
            }
            set
            {
                if (branchName == value)
                {
                    return;
                }
                branchName = value;                
                RaisePropertyChanged(BranchNamePropertyName);
            }
        }
        #endregion  
 
        #region
        public const string BranchPropertyName = "Branch";
        private Branch branch = null;
        public Branch Branch
        {
            get
            {
                return branch;
            }
            set
            {
                if (branch == value)
                {
                    return;
                }
                branch = value;
                BranchName = branch.Name;
                RaisePropertyChanged(BranchPropertyName);
            }
        }
        #endregion  
        
        #region
        public const string DocTimePropertyName = "DocTime";
        private DateTime docTime = DateTime.Now;
        public DateTime DocTime
        {
            get
            {
                return docTime;
            }
            set
            {
                if (docTime == value)
                {
                    return;
                }
                docTime = value;
                RaisePropertyChanged(DocTimePropertyName);
            }
        }
        #endregion   
        

        #region
        public const string DocDatePropertyName = "DocDate";
        private DateTime docDate = DateTime.Today;
        public DateTime DocDate
        {
            get
            {
                return docDate;
            }
            set
            {
                if (docDate == value)
                {
                    return;
                }
                docDate = value;
                RaisePropertyChanged(DocDatePropertyName);
            }
        }
        #endregion   

        #region
        public const string DocNPropertyName = "DocN";
        private string docN = "";
        public string DocN
        {
            get
            {
                return docN;
            }
            set
            {
                if (docN == value)
                {
                    return;
                }
                docN = value;
                RaisePropertyChanged(DocNPropertyName);
            }
        }
        #endregion   

        #region
        public const string PaymentTypePropertyName = "PaymentType";
        private int paymentType = 0;
        public int PaymentType
        {
            get
            {
                return paymentType;
            }
            set
            {
                if (paymentType == value)
                {
                    return;
                }
                paymentType = value;
                RaisePropertyChanged(PaymentTypePropertyName);
            }
        }
        #endregion   

        #region
        public const string PaymentDelayPropertyName = "PaymentDelay";
        private int paymentDelay = 0;
        public int PaymentDelay
        {
            get
            {
                return paymentDelay;
            }
            set
            {
                if (paymentDelay == value)
                {
                    return;
                }
                paymentDelay = value;
                RaisePropertyChanged(PaymentDelayPropertyName);
            }
        }
        #endregion 
       
        #region        
        public const string CommentPropertyName = "Comment";
        private string comment = "";
        public string Comment
        {
            get
            {
                return comment;
            }
            set
            {
                if (comment == value)
                {
                    return;
                }
                comment = value;
                RaisePropertyChanged(CommentPropertyName);                
            }
        }
        #endregion

        #region  
        public const string ProductItemViewModelListPropertyName = "ProductItemViewModelList";
        private ObservableCollection<ProductItemViewModel> productItemViewModelList;
        public ObservableCollection<ProductItemViewModel> ProductItemViewModelList
        {
            get
            {
                return productItemViewModelList;
            }
            set
            {
                if (productItemViewModelList== value)
                {
                    return;
                }

                productItemViewModelList = value;
                RaisePropertyChanged(ProductItemViewModelListPropertyName);               
            }
        }
        #endregion    

        #region  
        public ReturnNaklad ReturnNaklad
        {
            get
            {
                return new ReturnNaklad 
                {
                    DocN = docN,
                    Comment = Comment,
                    PaymentDelay = PaymentDelay,
                    PaymentType = PaymentType,
                    DocDate = DocDate,
                    DocTime = DocTime,
                    //BranchId = BranchId,
                    //AccountId = AccountId, 
                    //StoreId = StoreId, 
                    //ProviderId = ProviderId, 
                    //IsPosted = IsPosted
                    ProductItemList = ProductItemViewModelList
                };
            }           
        }
        #endregion

        #region
        public const string TotalPricePropertyName = "TotalPrice";
        public double totalPrice = 0;
        public double TotalPrice
        {
            get
            {                
                return ProductItemViewModelList.Sum(p => p.Summa);              
            }
            set
            {
                if (totalPrice == value)
                {
                    return;
                }
                totalPrice = value;
                RaisePropertyChanged(TotalPricePropertyName);
            }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {           
            _dataService = dataService;

            _dataService.GetRetNaklad(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    ProductItemViewModelList = item.Naklad.ProductItemList;
                    Comment = item.Naklad.Comment;
                    PaymentDelay = item.Naklad.PaymentDelay;
                    PaymentType = item.Naklad.PaymentType;
                    DocN = item.Naklad.DocN;
                    DocDate = item.Naklad.DocDate;
                    DocTime = item.Naklad.DocDate;
                    Branch = branchList.First(b => b.Id == item.Naklad.BranchId);
                    Account = accountList.First(b => b.Id == item.Naklad.AccountId);                   
                    Store = storeList.First(b => b.Id == item.Naklad.StoreId);
                    Provider = providerList.First(b => b.Id == item.Naklad.ProviderId);
                    IsPosted = item.Naklad.IsPosted;
                });

            SaveRetNakladCommand = new RelayCommand(
                () => _dataService.SaveRetNaklad(ReturnNaklad));

            PrintCommand = new RelayCommand(
                () => _dataService.PrintRetNaklad(ReturnNaklad));
           
            GetBranchListCommand = new RelayCommand(GetBranchList);
            GetStoreListCommand = new RelayCommand(GetStoreList);
            GetAccountListCommand = new RelayCommand(GetAccountList);
            GetProviderListCommand = new RelayCommand(GetProviderList);
            //DeleteProductCommand = new RelayCommand<object>((s) => DeleteProduct(s)); 
            DeleteProductCommand = new RelayCommand(DeleteProduct);
            AddProductCommand = new RelayCommand(AddProduct);
            OpenProductCommand = new RelayCommand(OpenProduct);
            SaveRetNakladCommand = new RelayCommand(SaveRetNaklad);
            PrintRetNakladCommand = new RelayCommand(PrintRetNaklad);           
            SelectedCellCommand = new RelayCommand<SelectedCellsChangedEventArgs>(GetProducts);
            //CloseCommand = new RelayCommand<object>(o => ((Window)o).Close());
            CloseCommand = new RelayCommand<object>(CloseNaklad);

            Messenger.Default.Register<SummaMessage>
            (
              this,
              (action) => ReceiveMessage(action)
            );          
        }

        public RelayCommand <object> CloseCommand
        {
            get;
            private set;
        }

        public void CloseNaklad(Object o)
        {          
            if (MessageBox.Show("Закрыть окно?",
                      "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ((Window)o).Close();
            }
            else
            {
                return;
            }
        }

        public RelayCommand CloseRetNakladCommand
        {
            get;
            private set;
        }

        public RelayCommand PrintRetNakladCommand
        {
            get;
            private set;
        }

        public void PrintRetNaklad()
        {
            MessageBox.Show(String.Format("Печать накладной N{0} ... !", DocN));
        }

        public RelayCommand SaveRetNakladCommand
        {
            get;
            private set;
        }

        public void SaveRetNaklad()
        {
            MessageBox.Show(String.Format("Накладная {0} сохранена!", DocN));
        }

        public RelayCommand OpenProductCommand
        {
            get;
            private set;
        }

        public void OpenProduct()
        {
            ProductWindow pw = new ProductWindow();
            pw.Show();
        }

        public RelayCommand AddProductCommand
        {
            get;
            private set;
        }

        public void AddProduct()
        {
            ProductItemViewModel pv = new ProductItemViewModel();
            ProductItemViewModelList.Add(pv);            
        }

        public void DeleteProduct()
        {
            ProductItemViewModelList.Remove(pv);            
        }

        public RelayCommand DeleteProductCommand
        {
            get;
            private set;
        }

        public void GetProducts(SelectedCellsChangedEventArgs cell)
        {
            if (cell.AddedCells.Count==0)
                return;

            pv = (ProductItemViewModel)cell.AddedCells[0].Item;

            if (cell.AddedCells[0].Column.DisplayIndex != 1)
                return;

            ProductsWindow pw = new ProductsWindow();
            pw.Show();
        }

        public RelayCommand<SelectedCellsChangedEventArgs> SelectedCellCommand
        {
            get;
            private set;
        }       

        public void Close()
        {           
        }

        public void GetBranchList()
        {
            BranchesWindow bw = new BranchesWindow();
            bw.Show();
        }

        public void GetStoreList()
        {
            StoresWindow sw = new StoresWindow();
            sw.Show();
        }

        public void GetProviderList()
        {
            ProvidersWindow pw = new ProvidersWindow();
            pw.Show();
        }

        public void GetAccountList()
        {
            AccountsWindow aw = new AccountsWindow();
            aw.Show();
        }

        

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
       
        public RelayCommand PrintCommand
        {
            get;
            private set;
        }

       

        public RelayCommand GetBranchListCommand
        {
            get;
            private set;
        }

        public RelayCommand GetStoreListCommand
        {
            get;
            private set;
        }

        public RelayCommand GetProviderListCommand
        {
            get;
            private set;
        }

        public RelayCommand GetAccountListCommand
        {
            get;
            private set;
        }

        public RelayCommand GetProductListCommand
        {
            get;
            private set;
        }
        
        private object ReceiveMessage(SummaMessage action )
        {
           RaisePropertyChanged(TotalPricePropertyName);
           return null;
        }

    }
}