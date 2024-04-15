using NUnit.Framework;

namespace logic_traning_lib._0000
{
    public class Parentesis
    {
        private Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

        private bool isOpen(char character)
        {
            return pairs.ContainsKey(character);
        }

        private bool Match(char open, char close)
        {
            return close == pairs[open];
        }

        public bool Valid(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var character in text.ToCharArray())
            {
                if (isOpen(character))
                {
                    stack.Push(character);
                }
                else
                {
                    var closeCharacter = character;
                    var openCharacter = stack.Pop();
                    if (!Match(openCharacter, closeCharacter))
                        return false;
                }
            }
            return stack.Count == 0;
        }


    }
}
