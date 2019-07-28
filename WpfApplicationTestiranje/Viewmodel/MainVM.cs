using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplicationTestiranje.Model;

namespace WpfApplicationTestiranje.Viewmodel
{
	public class MainVM : ViewModelBase
	{
		private AreaModel a1 = null;
		private AreaModel a2 = null;
		private AreaModel a3 = null;
		private AreaModel a4 = null;
		private AreaModel a5 = null;
		private AreaModel a6 = null;
		private AreaModel a7 = null;

		private ObservableCollection<AreaModel> areas = null;
		public MainVM()
		{
			a1 = new AreaModel("a1");
			a2 = new AreaModel("a2");
			a3 = new AreaModel("a3");
			a4 = new AreaModel("a4");

			a5 = new AreaModel("a5");
			a6 = new AreaModel("a6");

			a7 = new AreaModel("a7");


			a1.SubAreas.Add(a2);
			a1.SubAreas.Add(a3);

			a3.SubAreas.Add(a4);
			a3.SubAreas.Add(a7);	// kraj prva grana

			a5.SubAreas.Add(a6);
			a5.SubAreas.Add(a7);	// kraj druga grana

			var areasTemp = new List<AreaModel>();
			areasTemp.Add(a1);
			areasTemp.Add(a2);
			areasTemp.Add(a3);
			areasTemp.Add(a4);

			areasTemp.Add(a5);
			areasTemp.Add(a6);

			areasTemp.Add(a7);

			areasTemp = FilterTopAreaAors(areasTemp);//to do sada je without filter
			Areas = new ObservableCollection<AreaModel>(areasTemp);
		}

		public ObservableCollection<AreaModel> Areas
		{
			get { return areas; }
			set
			{
				//if (area != value)
				//{
				areas = value;
				OnPropertyChanged("Areas");
				//}
			}
		}

		#region Private Methods
		private List<AreaModel> FilterTopAreaAors(List<AreaModel> areas)
		{
			var tempSubAreas = new List<AreaModel>();
			var tempSubs = new List<string>(areas.Count);

			foreach (var area in areas)
			{
				foreach (var sub in area.SubAreas)
				{
					tempSubs.Add(sub.Name);
				}
			}

			return areas.Where(a => !tempSubs.Contains(a.Name)).ToList();
		}
		#endregion
	}
}
