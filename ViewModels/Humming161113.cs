using ABCoder.ViewModels.Base;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {

    private void SetHumming161113Options()
        {
            LableValueCodeInstanceName = CodeInstanceHamming161113.Name;
            LableValueCodeInstancePolynomial = CodeInstanceHamming161113.Polynomial;
            LableValueCodeWordLength = CodeInstanceHamming161113.CodeWordLength;
            LableValueInformationPartLength = CodeInstanceHamming161113.InformationPartLength;
            LableValueVerificationPartLength = CodeInstanceHamming161113.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstanceHamming161113.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability = CodeInstanceHamming161113.ErrorCorrectionCapability;
        }
    }
}
