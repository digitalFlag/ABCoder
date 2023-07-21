using ABCoder.ViewModels.Base;

namespace ABCoder.ViewModels
{
    internal partial class MainWindowViewModel : ViewModel
    {

        private void SetGoley2312C75Options()
        {
            LableValueCodeInstanceName = CodeInstanceGoley2312C75.Name;
            LableValueCodeInstancePolynomial = CodeInstanceGoley2312C75.Polynomial;
            LableValueCodeWordLength = CodeInstanceGoley2312C75.CodeWordLength;
            LableValueInformationPartLength = CodeInstanceGoley2312C75.InformationPartLength;
            LableValueVerificationPartLength = CodeInstanceGoley2312C75.VerificationPartLength;
            LableValueErrorDetectionCapability = CodeInstanceGoley2312C75.ErrorDetectionCapability;
            LableValueErrorCorrectionCapability =   CodeInstanceGoley2312C75.ErrorCorrectionCapability;
        }
    }
}
