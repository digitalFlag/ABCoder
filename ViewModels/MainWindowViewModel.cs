using ABCoder.Infrastructure;
using ABCoder.Models.Code;
using ABCoder.Models.ComboBox;
using ABCoder.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        public MainWindowViewModel()
        {
            //--------------------------------------COMMANDS--------------------------------------

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeSelectionOfComboBoxModeCommand = new LambdaCommand(OnChangeSelectionOfComboBoxModeCommandExecuted, CanChangeSelectionOfComboBoxModeCommandExecute);
            SelectMainMenuHelpAboutCommand = new LambdaCommand(OnSelectMainMenuHelpAboutCommandExecuted, CanSelectMainMenuHelpAboutCommandExecute);
            TextBoxInformationBitsTextChangedCommand = new LambdaCommand(OnTextBoxInformationBitsTextChangedCommandExecuted, CanTextBoxInformationBitsTextChangedCommandExecute);
            TextBoxCodeWordTextChangedCommand = new LambdaCommand(OnTextBoxCodeWordTextChangedCommandExecuted, CanTextBoxCodeWordTextChangedCommandExecute);
            PressButtonInformationBitsInformationCommand = new LambdaCommand(OnPressButtonInformationBitsInformationCommandExecuted, CanPressButtonInformationBitsInformationCommandExecute);
            PressPressButtonOpenInformationBitsCommand = new LambdaCommand(OnPressPressButtonOpenInformationBitsCommandExecuted, CanPressPressButtonOpenInformationBitsCommandExecute);
            PressPressButtonCopyInformationBitsCommand = new LambdaCommand(OnPressPressButtonCopyInformationBitsCommandExecuted, CanPressPressButtonCopyInformationBitsCommandExecute);
            PressPressButtonClearInformationBitsCommand = new LambdaCommand(OnPressPressButtonClearInformationBitsCommandExecuted, CanPressPressButtonClearInformationBitsCommandExecute);
            PressButtonInformationCodeCombinationCommand = new LambdaCommand(OnPressButtonInformationCodeCombinationCommandExecuted, CanPressButtonInformationCodeCombinationCommandExecute);
            PressButtonOpenCodeCombinationCommand = new LambdaCommand(OnPressButtonOpenCodeCombinationCommandExecuted, CanPressButtonOpenCodeCombinationCommandExecute);
            PressButtonCopyCodeCombinationCommand = new LambdaCommand(OnPressButtonCopyCodeCombinationCommandExecuted, CanPressButtonCopyCodeCombinationCommandExecute);
            PressButtonClearCodeCombinationCommand = new LambdaCommand(OnPressButtonClearCodeCombinationCommandExecuted, CanPressButtonClearCodeCombinationCommandExecute);
            TextBoxCodeCombinationTextChangedCommand = new LambdaCommand(OnTextBoxCodeCombinationTextChangedCommandExecuted, CanTextBoxCodeCombinationTextChangedCommandExecute);
            SelectMainMenuHelpFeedbackCommand = new LambdaCommand(OnSelectMainMenuHelpFeedbackCommandExecuted, CanSelectMainMenuHelpFeedbackCommandExecute);

            
            //--------------------------------------INTERFACE--------------------------------------
            ComboBoxModeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxModeCodeContent},
                new Mode() {CoderMode = ComboBoxModeDecodeContent}
            };
            ComboBoxCodeTypeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxCodeTypeGoley2312C75Content},
                new Mode() {CoderMode = ComboBoxCodeTypeHamming161113Content},
            };
            CodeInstanceGoley2312C75 = new CodeInstance
            {
                Name = ComboBoxCodeTypeGoley2312C75Content,
                Polynomial = "x\u00b9\u00b9+x\u00b9\u2070+x\u2076+x\u2075+x\u2074+x\u00B2+1",
                CodeWordLength = 23,
                InformationPartLength = 12,
                VerificationPartLength = 11,
                ErrorDetectionCapability = 7,
                ErrorCorrectionCapability = 3
            };
            CodeInstanceHamming161113 = new CodeInstance
            {
                Name = ComboBoxCodeTypeGoley2312C75Content,
                Polynomial = "x\u2074+x+1",
                CodeWordLength = 16,
                InformationPartLength = 11,
                VerificationPartLength = 5,
                ErrorDetectionCapability = 2,
                ErrorCorrectionCapability = 2
            };


            RichTextBox rtbErrorBits = new RichTextBox();

        }
    }
}
