using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using RetNaklad.Model;
using System;
using RetNaklad.Messages;

namespace RetNaklad.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ProductItemViewModel : ViewModelBase
    {
        public ProductItemViewModel()
        {
        }       

        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string UnitType { get; set; }        
       
        #region
        public const string SummaPropertyName = "Summa";       
        public double Summa
        {
            get
            {
                return Math.Round(UnitAmount * Price, 2); 
            }           
        }
        #endregion

        #region
        public const string PricePropertyName = "Price";
        private double price = 0;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price == value)
                {
                    return;
                }
                price = value;
                RaisePropertyChanged(PricePropertyName);
                RaisePropertyChanged(SummaPropertyName);
                Messenger.Default.Send(new SummaMessage());
            }
        }
        #endregion

        #region
        public const string UnitAmountPropertyName = "UnitAmount";
        private double unitAmount = 0;
        public double UnitAmount
        {
            get
            {
                return unitAmount;
            }
            set
            {
                if (unitAmount == value)
                {
                    return;
                }
                unitAmount = value;
                RaisePropertyChanged(UnitAmountPropertyName);
                RaisePropertyChanged(SummaPropertyName);
                Messenger.Default.Send(new SummaMessage());
            }
        }
        #endregion

    }
}