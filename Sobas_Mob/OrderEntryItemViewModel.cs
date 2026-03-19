
using Microsoft.Maui.Controls;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sobas_Mob
{
    public class OrderEntryItemViewModel : INotifyPropertyChanged
    {
        private OrderEntryItemViewModel _currentItem;
        public OrderEntryItemViewModel CurrentItem
        {
            get => _currentItem;
            set { _currentItem = value; OnPropertyChanged(nameof(CurrentItem)); }
        }

        private int _index;
        public int Index
        {
            get => _index;
            set
            {
                if (_index == value) return;
                _index = value;
                OnPropertyChanged();
            }
        }
        private Guid _SalesOrderUid;
        public Guid SalesOrderUid
        {
            get => _SalesOrderUid;
            set { _SalesOrderUid = value; OnPropertyChanged(); }
        }



        private string _itemCode = string.Empty;
        public string ItemCode
        {
            get => _itemCode;
            set { _itemCode = value; OnPropertyChanged(); OnPropertyChanged(nameof(Amount)); }
        }

        private string _itemDescription = string.Empty;
        public string ItemDescription
        {
            get => _itemDescription;
            set { _itemDescription = value; OnPropertyChanged(); }
        }

        private string _partyCode = string.Empty;
        public string PartyCode
        {
            get => _partyCode;
            set { _partyCode = value; OnPropertyChanged(); }
        }

        private string _partyName = string.Empty;
        public string PartyName
        {
            get => _partyName;
            set { _partyName = value; OnPropertyChanged(); }
        }

        private int _quantity = 0;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Amount));
                }
            }
        }

        // Keeping Rate as string to match DTO, but we still recalc Amount safely.
        private decimal _rate = 0;
        public decimal Rate
        {
            get => _rate;
            set
            {
                _rate = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Amount));
            }
        }

        private string _remarks = string.Empty;
        public string Remarks
        {
            get => _remarks;
            set { _remarks = value; OnPropertyChanged(); }
        }

        // 🔥 Auto-calculated
        public decimal Amount
        {
            get
            {
                return (Quantity * Rate);
            }
        }
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

