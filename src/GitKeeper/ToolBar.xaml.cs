using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using Prism.Ioc;
using Prism.Unity;
using Unity;

namespace GitKeeper
{
  /// <summary>
  /// ToolBar.xaml の相互作用ロジック
  /// </summary>
  public partial class ToolBar : UserControl
  {
    public ToolBar()
    {
      InitializeComponent();
    }
  }
}