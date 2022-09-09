using ExampleApp.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ExampleApp.ViewModels
{
  public class SettingsViewModel : BaseViewModel
  {
    public SettingsViewModel()
    {
      Title = "Browse";
    }

    private string settingValue;
    public string SettingValue
    {
      get => this.settingValue;
      set
      {
        this.settingValue = value;
        this.OnPropertyChanged();
      }
    }
  }
}