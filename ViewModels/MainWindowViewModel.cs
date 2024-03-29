﻿using ABCoder.Infrastructure;
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
            ChangeSelectionOfComboBoxCodeTypeCommand = new LambdaCommand(OnChangeSelectionOfComboBoxCodeTypeCommandExecuted, CanChangeSelectionOfComboBoxCodeTypeCommandExecute);

            
            //--------------------------------------INTERFACE--------------------------------------
            ComboBoxModeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxModeCodeContent},
                new Mode() {CoderMode = ComboBoxModeDecodeContent}
            };
            ComboBoxCodeTypeSource = new ObservableCollection<Mode>()
            {
                new Mode() {CoderMode = ComboBoxCodeTypeHamming13913Content},
                new Mode() {CoderMode = ComboBoxCodeTypeHamming151113Content},
                new Mode() {CoderMode = ComboBoxCodeType167139QuadraticResidueContent},
                new Mode() {CoderMode = ComboBoxCodeTypeHamming161113Content},
                new Mode() {CoderMode = ComboBoxCodeTypeHamming171245Content},
                new Mode() {CoderMode = ComboBoxCodeTypeGoley208C75Content},
                new Mode() {CoderMode = ComboBoxCodeTypeGoley2312AE3Content},
                new Mode() {CoderMode = ComboBoxCodeTypeGoley2312C75Content},
            };
            CodeInstanceHamming13913 = new CodeInstance
            {
                Name = ComboBoxCodeTypeHamming13913Content,
                Polynomial = "x\u2074+x+1",
                CodeWordLength = 13,
                InformationPartLength = 9,
                VerificationPartLength = 4,
                ErrorDetectionCapability = 2,
                ErrorCorrectionCapability = 1
            };
            CodeInstanceHamming151113 = new CodeInstance
            {
                Name = ComboBoxCodeTypeHamming151113Content,
                Polynomial = "x\u2074+x+1",
                CodeWordLength = 15,
                InformationPartLength = 11,
                VerificationPartLength = 4,
                ErrorDetectionCapability = 2,
                ErrorCorrectionCapability = 1
            };
            CodeInstance167139QuadraticResidue = new CodeInstance
            {
                Name = ComboBoxCodeType167139QuadraticResidueContent,
                Polynomial = "x⁸+x⁵+x⁴+x³+1",
                CodeWordLength = 16,
                InformationPartLength = 7,
                VerificationPartLength = 9,
                ErrorDetectionCapability = 6,
                ErrorCorrectionCapability = 2
            };
            CodeInstanceHamming161113 = new CodeInstance
            {
                Name = ComboBoxCodeTypeHamming161113Content,
                Polynomial = "x\u2074+x+1",
                CodeWordLength = 16,
                InformationPartLength = 11,
                VerificationPartLength = 5,
                ErrorDetectionCapability = 4,
                ErrorCorrectionCapability = 1
            };
            CodeInstanceHamming171245 = new CodeInstance
            {
                Name = ComboBoxCodeTypeHamming171245Content,
                Polynomial = "x\u2075+x\u00B2+1",
                CodeWordLength = 17,
                InformationPartLength = 12,
                VerificationPartLength = 5,
                ErrorDetectionCapability = 3,
                ErrorCorrectionCapability = 1
            };
            CodeInstanceGoley208C75 = new CodeInstance
            {
                Name = ComboBoxCodeTypeGoley208C75Content,
                Polynomial = "x\u00b9\u00b9+x\u00b9\u2070+x\u2076+x\u2075+x\u2074+x\u00B3+1",
                CodeWordLength = 20,
                InformationPartLength = 8,
                VerificationPartLength = 12,
                ErrorDetectionCapability = 7,
                ErrorCorrectionCapability = 3,
            };
            CodeInstanceGoley2312AE3 = new CodeInstance
            {
                Name = ComboBoxCodeTypeGoley2312AE3Content,
                Polynomial = "x¹¹+x⁹+x⁷+x⁶+x⁵+x+1",
                CodeWordLength = 23,
                InformationPartLength = 12,
                VerificationPartLength = 11,
                ErrorDetectionCapability = 7,
                ErrorCorrectionCapability = 3
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

        }
    }
}
