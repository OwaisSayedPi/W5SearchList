using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5SearchList
{
    public class SearchableViewModel<T>: BaseViewModel
    {
        public SearchableViewModel(List<T> list)
        {
            MainList = new ObservableCollection<T>();
            foreach (var item in list)
            {
                MainList.Add(item);
            }
            InitialisingDisplayList(null);
        }
        private string _searchValue;
        public string SearchValue
        {
            get
            {
                return _searchValue;
            }
            set
            {
                InitialisingDisplayList(value);
                _searchValue = value;
            }
        }
        public void InitialisingDisplayList(string search)
        {
            DisplayList = new ObservableCollection<string>();
            if (string.IsNullOrEmpty(search))
            {
                foreach (var item in MainList)
                {
                    foreach (var item1 in item.GetType().GetProperties())
                    {
                        if ((item1.PropertyType == typeof(string)))
                        {

                        }
                    }
                    
                    DisplayList.Add(item);
                }
            }
            else
            {
                foreach (var item in MainList)
                {
                    if (item.ToLower().Contains(search.ToLower()))
                    {
                        DisplayList.Add(item);
                    }
                }
            }
            OnPropertyChanged(nameof(DisplayList));
        }
        public ObservableCollection<string> DisplayList { get; set; }
        public ObservableCollection<T> MainList { get; set; }
    }
}
