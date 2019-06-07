using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Viewmodel
{
	public class SecondViewModel : ViewModelBase
	{
		string testString = null;
		public SecondViewModel()
		{
			testString = "testiranje";
		}
		public string TestString
		{
			get { return testString; }
			set
			{
				if (testString != value)
				{
					testString = value;
					OnPropertyChanged("TestString");
				}
			}
		}
	}
}
