using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Events;
using Prism.Unity;
using Unity;
using Prism.Services.Dialogs;
using Prism.Commands;
using Reactive.Bindings;
using GitKeeper.Main.ViewModels;

namespace GitKeeper
{
  public class MainWindowViewModel : ViewModelBase
  {
    public ReactiveProperty<string> Title { get; } = new ReactiveProperty<string>();

    public override void Initialize(IUnityContainer unityContainer)
    {
      this.Title.Value = "GitKeeper";
    }

    public override void InitializeRegion(IRegionManager regionManager) 
    { 
    }
  }
}