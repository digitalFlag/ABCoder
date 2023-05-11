using ABCoder.Infrastructure;
using ABCoder.Models.ComboBox;
using ABCoder.ViewModels.Base;
using System.Collections.ObjectModel;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            //--------------------------------------COMMANDS--------------------------------------

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeSelectionOfComboBoxModeCommand = new LambdaCommand(OnChangeSelectionOfComboBoxModeCommandExecuted, CanChangeSelectionOfComboBoxModeCommandExecute);
            ExecuteButtonCommand = new LambdaCommand(OnExecuteButtonCommandExecuted, CanExecuteButtonCommandExecute);
            SelectMainMenuHelpAboutCommand = new LambdaCommand(OnSelectMainMenuHelpAboutCommandExecuted, CanSelectMainMenuHelpAboutCommandExecute);

            //--------------------------------------INTERFACE--------------------------------------
            ComboBoxModeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxModeCodeContent},
                new Mode() {CoderMode = ComboBoxModeDecodeContent}
            };
            ComboBoxCodeTypeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxCodeTypeGoley2312C75Content},
            };
        }
    }
}
