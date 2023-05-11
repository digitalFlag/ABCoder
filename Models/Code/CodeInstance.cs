namespace ABCoder.Models.Code
{
    class CodeInstance
    {
        public string? Name { get; set; }

        public int CodeWordLength { get; set; }

        public int InformationPartLength { get; set; }

        public int VerificationPartLength { get; set; }

        public int ErrorDetectionCapability { get; set; }

        public int ErrorCorrectionCapability { get; set; }

        public string? Polynomial { get; set; }

    }
}
