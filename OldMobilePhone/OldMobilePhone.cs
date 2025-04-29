
using System.Text;

public class OldMobilePhone
{
    public static string OldPhonePad(string input)
    {
        char[] buttonOne = ['&', '\'', '(' ];
        char[] buttonTwo = ['a', 'b', 'c'];
        char[] buttonThree = ['d', 'e', 'f'];
        char[] buttonFour = ['g', 'h', 'i'];
        char[] buttonFive = ['j', 'k', 'l'];
        char[] buttonSix = ['m', 'n', 'o'];
        char[] buttonSeven = ['p', 'q', 'r', 's'];
        char[] buttonEight = ['t', 'u', 'v'];
        char[] buttonNine = ['w', 'x', 'y', 'z'];
        char[] buttonZero = [' '];

        StringBuilder message = new StringBuilder();
        int consecutiveNumberCount = 0;
        char lastChar = '\0';

        foreach (char character in input)
        {
            if (character == lastChar && character != '*')
            {
                message.Remove(message.Length - 1, 1);
                consecutiveNumberCount++;
            }
            else
            {
                consecutiveNumberCount = 0;
            }

            lastChar = character;

            if(character == '1')
            {
                int characterIndex = consecutiveNumberCount % buttonOne.Length;
                message.Append(buttonOne[characterIndex]);
            }
            else if(character == '2')
            {
                int characterIndex = consecutiveNumberCount % buttonTwo.Length;
                message.Append(buttonTwo[characterIndex]);
            }
            else if(character == '3')
            {
                int characterIndex = consecutiveNumberCount % buttonThree.Length;
                message.Append(buttonThree[characterIndex]);
            }
            else if(character == '4')
            {
                int characterIndex = consecutiveNumberCount % buttonFour.Length;
                message.Append(buttonFour[characterIndex]);
            }
            else if(character == '5')
            {
                int characterIndex = consecutiveNumberCount % buttonFive.Length;
                message.Append(buttonFive[characterIndex]);
            }
            else if(character == '6')
            {
                int characterIndex = consecutiveNumberCount % buttonSix.Length;
                message.Append(buttonSix[characterIndex]);
            }
            else if(character == '7')
            {
                int characterIndex = consecutiveNumberCount % buttonSeven.Length;
                message.Append(buttonSeven[characterIndex]);
            }
            else if(character == '8')
            {
                int characterIndex = consecutiveNumberCount % buttonEight.Length;
                message.Append(buttonEight[characterIndex]);
            }
            else if(character == '9')
            {
                int characterIndex = consecutiveNumberCount % buttonNine.Length;
                message.Append(buttonNine[characterIndex]);
            }
            else if(character == '0')
            {
                message.Append(buttonZero[0]);
            }
            else if(character == '*')
            {
                if (message.Length > 0)
                {
                    message.Remove(message.Length - 1, 1);
                }
            }
        }

        return message.ToString().ToUpper();
    }
}