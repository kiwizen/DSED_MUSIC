using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailApp.ViewModels
{
    public class OwnerInfoViewModel
    {
        private int _primarykey;
        public int ID { get => _primarykey; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OwnerInfoViewModel() {}

        public static OwnerInfoViewModel FromItem(OwnerInfo item)
        {
            var viewModel = new OwnerInfoViewModel();

            viewModel._primarykey= item.ID;
            viewModel.FirstName = item.FirstName;
            viewModel.LastName = item.LastName;
        }
    }
}
