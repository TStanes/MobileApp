
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Sobas_Mob
{
    public class OrderEntryViewModel : BindableObject
    {
        // List of scanned/added items
        public ObservableCollection<OrderEntryItemViewModel> AddedItems { get; }

        public ObservableCollection<OrderEntryItemViewModel> OrderHistory { get; }
    = new ObservableCollection<OrderEntryItemViewModel>();

        private readonly HttpClient _httpClient;


        // The "current" entry (bind your entry fields to these props OR to CurrentItem.* consistently)
        private OrderEntryItemViewModel _currentItem;
        public OrderEntryItemViewModel CurrentItem
        {
            get => _currentItem;
            set { _currentItem = value; OnPropertyChanged(); }
        }
     


        private Guid _SalesOrderUid;
        public Guid SalesOrderUid
        {
            get => _SalesOrderUid;
            set { if (_SalesOrderUid == value) return; _SalesOrderUid = value; OnPropertyChanged(nameof(SalesOrderUid)); }
        }

        private string _OrderNo;
        public string OrderNo
        {
            get => _OrderNo; 
            set { if (_OrderNo == value) return; _OrderNo = value; OnPropertyChanged(nameof(OrderNo)); }

        }
        private DateTime? _orderDate = DateTime.Today;
        public DateTime? OrderDate
        {
            get => _orderDate;
            set
            {
                if (_orderDate == value) return;
                _orderDate = value;
                OnPropertyChanged();
            }
        }
        private string? _itemCode;
        public string? ItemCode
        {
            get => _itemCode;
            set { if (_itemCode == value) return; _itemCode = value; OnPropertyChanged(); OnPropertyChanged(nameof(Amount)); }
        }

        private string? _itemDescription;
        public string? ItemDescription
        {
            get => _itemDescription;
            set { if (_itemDescription == value) return; _itemDescription = value; OnPropertyChanged(); }
        }

        private string? _remarks;
        public string? Remarks
        {
            get => _remarks;
            set { if (_remarks == value) return; _remarks = value; OnPropertyChanged(); }
        }

        private string? _partyName;
        public string? PartyName
        {
            get => _partyName;
            set { if (_partyName == value) return; _partyName = value; OnPropertyChanged(); }
        }

        private string? _partyCode;
        public string? PartyCode
        {
            get => _partyCode;
            set { if (_partyCode == value) return; _partyCode = value; OnPropertyChanged(); }
        }

        
        private int _quantity = 0;
        public int Quantity
        {
            get => _quantity;
            set { if (_quantity == value) return; _quantity = value; OnPropertyChanged(); OnPropertyChanged(nameof(Amount)); }
        }

        private decimal _rate = 0;
        public decimal Rate
        {
            get => _rate;
            set { if (_rate == value) return; _rate = value; OnPropertyChanged(); OnPropertyChanged(nameof(Amount)); }
        }

        // ✔ Auto-calculated for the current entry (kept as string to match your UI/DTO).
        public decimal Amount
        {
            get
            {
                var qty = Quantity;
                return (qty * Rate);
            }
        }

        // Commands
        public ICommand AddItemCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SaveItemCommand { get; }
        public ICommand RefreshCommand { get; }

        public OrderEntryViewModel(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            AddedItems = new ObservableCollection<OrderEntryItemViewModel>();

            OrderHistory = new ObservableCollection<OrderEntryItemViewModel>();
            OrderHistory.CollectionChanged += (_, __) => UpdateIndexes();

            CurrentItem = new OrderEntryItemViewModel();

            AddItemCommand = new Command(AddItem);
            DeleteCommand = new Command<OrderEntryItemViewModel>(DeleteItem);
            SaveItemCommand = new Command<OrderEntryViewModel>(SaveItem);
            RefreshCommand = new Command(OnRefresh);
        }

        private void UpdateIndexes()
        {
            for (int i = 0; i < OrderHistory.Count; i++)
            {
                OrderHistory[i].Index = i;
            }
        }
        private void AddToOrderHistory()
        {
            if (string.IsNullOrWhiteSpace(ItemCode)) return;

            var existing = OrderHistory.FirstOrDefault(x => x.ItemCode == ItemCode);
            if (existing == null)
            {
                OrderHistory.Add(new OrderEntryItemViewModel
                {
                    ItemCode = ItemCode ?? string.Empty,
                    ItemDescription = ItemDescription ?? string.Empty,
                    Quantity = Quantity,
                    Rate = Rate,
                    PartyCode = PartyCode ?? string.Empty,
                    PartyName = PartyName ?? string.Empty,
                    Remarks = Remarks ?? string.Empty
                });
            }
            else
            {
                existing.ItemDescription = ItemDescription ?? string.Empty;
                existing.Quantity = Quantity;
                existing.Rate = Rate;
                existing.PartyCode = PartyCode ?? string.Empty;
                existing.PartyName = PartyName ?? string.Empty;
                existing.Remarks = Remarks ?? string.Empty;
            }
        }

        public void LoadFromApi(SaleOrderMobileDto dto)
        {
            CurrentItem = new OrderEntryItemViewModel
            {
                ItemCode = dto.ItemCode,
                ItemDescription = dto.ItemDescription,
                Quantity = dto.Quantity,
                Rate = dto.Rate ?? 0m
            };
            // Also reflect into top-level entry fields if your XAML binds here:
            ItemCode = dto.ItemCode;
            ItemDescription = dto.ItemDescription;
            Quantity = dto.Quantity;
            Rate = dto.Rate ?? 0m;
        }

        private void AddItem()
        {
            if (string.IsNullOrWhiteSpace(ItemCode)) return;

            var existing = AddedItems.FirstOrDefault(x => x.ItemCode == ItemCode);
            if (existing is null)
            {
                AddedItems.Add(new OrderEntryItemViewModel
                {
                    ItemCode = ItemCode ?? string.Empty,
                    ItemDescription = ItemDescription ?? string.Empty,
                    Quantity = Quantity,
                    Rate = Rate,
                    PartyCode = PartyCode ?? string.Empty,
                    PartyName = PartyName ?? string.Empty,
                    Remarks = Remarks ?? string.Empty
                });
            }
            else
            {
                existing.ItemDescription = ItemDescription ?? string.Empty;
                existing.Quantity = Quantity;
                existing.Rate = Rate;
                existing.PartyCode = PartyCode ?? string.Empty;
                existing.PartyName = PartyName ?? string.Empty;
                existing.Remarks = Remarks ?? string.Empty;
            }

            // Reset entry fields
            ItemCode = string.Empty;
            ItemDescription = string.Empty;
            Quantity = 0;
            Rate = 0;
            Remarks = string.Empty;
        }

        private void DeleteItem(OrderEntryItemViewModel item)
        {
            if (item != null)
                AddedItems.Remove(item);
            UpdateIndexes();
        }

        private void SaveItem(OrderEntryViewModel _)
        {
            // Intentionally left for the page to call HTTP; keep ViewModel UI-only.
            // If you want full MVVM with services, we can inject an IOrderService and move HTTP here.
        }

        private void OnRefresh()
        {
            if (string.IsNullOrWhiteSpace(ItemCode))
                return;

            var existingItem = AddedItems.FirstOrDefault(x => x.ItemCode == ItemCode);
            if (existingItem != null)
            {
                existingItem.ItemDescription = ItemDescription;
                existingItem.Quantity = Quantity;
                existingItem.Rate = Rate;
            }
            else
            {
                var newItem = new OrderEntryItemViewModel
                {
                    ItemCode = ItemCode,
                    ItemDescription = ItemDescription,
                    Quantity = Quantity,
                    Rate = Rate
                };
                AddedItems.Add(newItem);
                CurrentItem = newItem;
            }
        }
        public bool IsRemarksPopupReturn { get; set; }

    }
}
