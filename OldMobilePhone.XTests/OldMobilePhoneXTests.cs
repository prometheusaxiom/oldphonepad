using Microsoft.VisualStudio.TestPlatform.TestHost;

    public class OldMobilePhoneXTests
    {
        [Fact]
        public void ValidTest_ReturnsEOutput()
        {
            string input = "33#";
            string correctOutput = "E";
            string message = OldMobilePhone.OldPhonePad(input);
            Assert.Equal(correctOutput, message);
        }

        [Fact]
        public void ValidTest_ReturnsBOutput()
        {
            string input = "227*#";
            string correctOutput = "B";
            string message = OldMobilePhone.OldPhonePad(input);
            Assert.Equal(correctOutput, message);
        }

        [Fact]
        public void ValidTest_ReturnsHELLOOutput()
        {
            string input = "4433555 555666#";
            string correctOutput = "HELLO";
            string message = OldMobilePhone.OldPhonePad(input);
            Assert.Equal(correctOutput, message);
        }

        [Fact]
        public void ValidTest_ReturnsTURINGOutput()
        {
            string input = "8 88777444666*664#";
            string correctOutput = "TURING";
            string message = OldMobilePhone.OldPhonePad(input);
            Assert.Equal(correctOutput, message);
        }
}