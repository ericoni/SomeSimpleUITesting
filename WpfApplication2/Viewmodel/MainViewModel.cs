using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Viewmodel
{
	/// <summary>
	/// ovo je main vm
	/// </summary>
	public class MainViewModel
	{
		SecondViewModel myNewViewModel = null;
		public MainViewModel()
		{
			myNewViewModel = new SecondViewModel();
		}
		public SecondViewModel MyNewViewModel
		{
			get { return myNewViewModel; }
		}	
	}
}
