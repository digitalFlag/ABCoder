using ABCoder.ViewModels.Base;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {
        private void SetHamming171245Options()
        {
            if (string.IsNullOrEmpty(CodeInstanceHamming171245.Name))
            {
                LableValueCodeInstanceName = ComboBoxCodeTypeHamming171245Content;
            }
            else
            {
                LableValueCodeInstanceName = CodeInstanceHamming171245.Name;

            }
            if (string.IsNullOrEmpty(CodeInstanceHamming171245.Polynomial))
            {
                LableValueCodeInstancePolynomial = "x\u2075+x\u00B2+1";
            }
            else
            {
                LableValueCodeInstancePolynomial = CodeInstanceHamming171245.Polynomial;
            }
            LableValueCodeWordLength = CodeInstanceHamming171245.CodeWordLength;
            LableValueInformationPartLength = CodeInstanceHamming171245.InformationPartLength;
            LableValueVerificationPartLength = CodeInstanceHamming171245.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstanceHamming171245.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability = CodeInstanceHamming171245.ErrorCorrectionCapability;
        }

    }
}
