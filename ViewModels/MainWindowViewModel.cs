using ABCoder.Infrastructure;
using ABCoder.Models.Code;
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
            TextBoxInformationBitsTextChangedCommand = new LambdaCommand(OnTextBoxInformationBitsTextChangedCommandExecuted, CanTextBoxInformationBitsTextChangedCommandExecute);
            TextBoxCodeWordTextChangedCommand = new LambdaCommand(OnTextBoxCodeWordTextChangedCommandExecuted, CanTextBoxCodeWordTextChangedCommandExecute);

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
            CodeInstanceGoley2312C75 = new CodeInstance();
            CodeInstanceGoley2312C75.Name = ComboBoxCodeTypeGoley2312C75Content;
            CodeInstanceGoley2312C75.CodeWordLength = 23;
            CodeInstanceGoley2312C75.InformationPartLength = 12;
            CodeInstanceGoley2312C75.VerificationPartLength = 11;
            CodeInstanceGoley2312C75.ErrorDetectionCapability = 7;
            CodeInstanceGoley2312C75.ErrorDetectionCapability = 3;
            CodeInstanceGoley2312C75.Polynomial = "x\u00b9\u00b9+x\u00b9\u2070+x\u2076+x\u2075+x\u2074+x\u00B2+1";
        }
    }
}
