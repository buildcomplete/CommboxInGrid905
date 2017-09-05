using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommboxInGrid905
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
		{
			if (PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
			}

		}
		public ObservableCollection<WeaponViewModel> Weapons = new ObservableCollection<WeaponViewModel>();

		private WeaponViewModel _selectedWeapon;
		public WeaponViewModel SelectedWeapon
		{
			get
			{
				return _selectedWeapon;
			}
			set
			{

				// check to prevent stack overflow.
				if (_selectedWeapon != value)
				{
					_selectedWeapon = value;
					OnPropertyChanged();
				}
			}
		}
		public ObservableCollection<string> WeaponCountRange = new ObservableCollection<string>();

		private string _weaponCount;
		public string WeaponCount
		{
			get
			{
				return _weaponCount;
			}
			set
			{
				// check to prevent stack overflow.
				if (_weaponCount != value)
				{
					_weaponCount = value;
					OnPropertyChanged();
				}
			}
		}
		public MainViewModel()
		{
			Weapons.Add(new WeaponViewModel { ImageFile = "http://www.desktopwallpaperhd.net/wallpapers/8/7/xiaogoukuanping-animal-tupian-85399.jpg", Name = "liusong" });
			Weapons.Add(new WeaponViewModel { ImageFile = "http://www.desktopwallpaperhd.net/wallpapers/8/7/xiaogoukuanping-animal-tupian-85399.jpg", Name = "zhuzhu" });
			Weapons.Add(new WeaponViewModel { ImageFile = "http://www.desktopwallpaperhd.net/wallpapers/8/7/xiaogoukuanping-animal-tupian-85399.jpg", Name = "berry" });
			Weapons.Add(new WeaponViewModel { ImageFile = "http://www.desktopwallpaperhd.net/wallpapers/8/7/xiaogoukuanping-animal-tupian-85399.jpg", Name = "sunteen" });
			_selectedWeapon = Weapons.First<WeaponViewModel>();

			for (var i = 0; i < Weapons.Count; i++)
			{
				WeaponCountRange.Add(i.ToString());
			}
			_weaponCount = WeaponCountRange.Last<string>();
		}
	}
	public class WeaponViewModel
	{
		public string ImageFile { get; set; }
		public string Name { get; set; }

	}
}
