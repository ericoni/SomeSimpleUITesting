using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationTestiranje.Viewmodel;

namespace WpfApplicationTestiranje.Model
{
	public class AreaModel : ViewModelBase
	{
		private string name;
		bool isCheckedForView;
		private ObservableCollection<AreaModel> subareas;
		public AreaModel()
		{

		}

		public AreaModel(string name)
		{
			this.name = name;
			this.IsCheckedForView = true;
			this.subareas = new ObservableCollection<AreaModel>();
		}
		public string Name
		{
			get { return name; }
			set
			{
				if (name != value)
				{
					name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		public bool IsCheckedForView
		{
			get { return isCheckedForView; }
			set
			{
				//if (isCheckedForView != value)
				//{
				isCheckedForView = value;
				OnPropertyChanged("IsCheckedForView");

				if (this.SubAreas != null)
				{
					foreach (var subarea in this.SubAreas)
					{
						subarea.IsCheckedForView = value;
					}
				}
				//}
			}
		}

		public ObservableCollection<AreaModel> SubAreas
		{
			get { return subareas; }
			set
			{
				//if (areas != value)
				//{
				subareas = value;
					OnPropertyChanged("SubAreas");
				//}
			}
		}
	}
}
