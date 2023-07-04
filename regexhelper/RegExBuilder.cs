using System.Text;
using System.Text.RegularExpressions;

namespace RegExHelper
{
    /// <summary>
    /// RegExBuilder Class
    /// </summary>
    public class RegExBuilder
    {
        private StringBuilder _regex;

        /// <summary>
        /// Initializes a new instance of the RegExBuilder class.
        /// </summary>
        public RegExBuilder()
        {
            _regex = new StringBuilder();
        }

        /// <summary>
        /// Adds the start anchor "^" to the regular expression.
        /// This anchors the regular expression to the start of the string.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder Start()
        {
            _regex.Append("^");
            return this;
        }

        /// <summary>
        /// Adds the end anchor "$" to the regular expression.
        /// This anchors the regular expression to the end of the string.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder End()
        {
            _regex.Append("$");
            return this;
        }

        /// <summary>
        /// Adds the specified text to the regular expression.
        /// </summary>
        /// <param name="str">The text to be added.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder Text(string str)
        {
            _regex.Append(str);
            return this;
        }

        /// <summary>
        /// Adds a placeholder for any character to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder AnyChar()
        {
            _regex.Append(".");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a word character to the regular expression.
        /// A word character consists of letters, digits, and underscores.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder Word()
        {
            _regex.Append("\\w");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a non-word character to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NoWord()
        {
            _regex.Append("\\W");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a digit to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder Digit()
        {
            _regex.Append("\\d");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a non-digit character to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NoDigit()
        {
            _regex.Append("\\D");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for whitespace to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder WhiteSpace()
        {
            _regex.Append("\\s");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for non-whitespace character to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NoWhiteSpace()
        {
            _regex.Append("\\S");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for any character that is in the specified character array to the regular expression.
        /// </summary>
        /// <param name="chars">An array of characters to be checked against.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder AnyCharThatIs(char[] chars)
        {
            _regex.Append($"[{string.Concat(chars)}]");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for any character between the specified characters to the regular expression.
        /// </summary>
        /// <param name="char1">The first character of the range.</param>
        /// <param name="char2">The last character of the range.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder AnyCharBetween(char char1, char char2)
        {
            _regex.Append($"[{char1}-{char2}]");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a word boundary to the regular expression.
        /// A word boundary occurs when a word character meets a non-word character or vice versa.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder WordBoundary()
        {
            _regex.Append("\\b");
            return this;
        }

        /// <summary>
        /// Adds a placeholder for a non-word boundary to the regular expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NoWordBoundary()
        {
            _regex.Append("\\B");
            return this;
        }

        /// <summary>
        /// Adds a capturing group to the regular expression.
        /// A capturing group allows retrieving the content captured by this part of the regular expression.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the capturing group.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder CaptureGroup(RegExBuilder regExBuilder)
        {
            _regex.Append($"({regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a non-capturing group to the regular expression.
        /// A non-capturing group is used for groups where the content should not be retrieved.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the non-capturing group.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NonCapturingGroup(RegExBuilder regExBuilder)
        {
            _regex.Append($"(?:{regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a positive lookahead to the regular expression.
        /// A positive lookahead checks if the content after it matches without including it in the result.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the lookahead.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder PositiveLookahead(RegExBuilder regExBuilder)
        {
            _regex.Append($"(?={regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a negative lookahead to the regular expression.
        /// A negative lookahead checks if the content after it does not match without including it in the result.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the lookahead.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NegativeLookahead(RegExBuilder regExBuilder)
        {
            _regex.Append($"(?={regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a positive lookbehind to the regular expression.
        /// A positive lookbehind checks if the content before it matches without including it in the result.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the lookbehind.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder PositiveLookbehind(RegExBuilder regExBuilder)
        {
            _regex.Append($"(?<={regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a negative lookbehind to the regular expression.
        /// A negative lookbehind checks if the content before it does not match without including it in the result.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the content of the lookbehind.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NegativeLookbehind(RegExBuilder regExBuilder)
        {
            _regex.Append($"(?<={regExBuilder})");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for zero or more occurrences of the previous expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder ZeroOrMoreOfLastExpression()
        {
            _regex.Append("*");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for one or more occurrences of the previous expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder OneOrMoreOfLastExpression()
        {
            _regex.Append("+");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for zero or one occurrence of the previous expression.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder ZeroOrOneOfLastExpression()
        {
            _regex.Append("?");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for a specific range of occurrences of the previous expression.
        /// </summary>
        /// <param name="from">The minimum number of occurrences.</param>
        /// <param name="to">The maximum number of occurrences.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NToNOfLastExpression(int from, int to)
        {
            _regex.Append($"{{{from},{to}}}");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for a specific number of occurrences of the previous expression.
        /// </summary>
        /// <param name="n">The exact number of occurrences.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder NOfLastExpression(int n)
        {
            _regex.Append($"{{{n}}}");
            return this;
        }

        /// <summary>
        /// Adds a quantifier for a minimum number of occurrences of the previous expression, matching as few as possible.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder FewAsPossibleOfLastExpression()
        {
            _regex.Append("+?");
            return this;
        }

        /// <summary>
        /// Adds an expression that accepts either the previous or the next expression.
        /// </summary>
        /// <param name="regExBuilder">A RegExBuilder object containing the alternative expression.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder EitherOr(RegExBuilder regExBuilder)
        {
            _regex.Append($"|{regExBuilder}");
            return this;
        }

        /// <summary>
        /// Adds an expression that matches the previous expression zero or more times, matching as few as possible.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder ZeroOrMoreAsFewAsPossibleOfLastExpression()
        {
            _regex.Append("*?");
            return this;
        }

        /// <summary>
        /// Adds an expression that matches the previous expression one or more times, matching as few as possible.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder OneOrMoreAsFewAsPossibleOfLastExpression()
        {
            _regex.Append("+?");
            return this;
        }

        /// <summary>
        /// Adds an expression that matches the previous expression zero or one time, matching as few as possible.
        /// </summary>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder ZeroOrOneAsFewAsPossibleOfLastExpression()
        {
            _regex.Append("??");
            return this;
        }

        /// <summary>
        /// Adds a comment to the regular expression.
        /// </summary>
        /// <param name="comment">The comment text.</param>
        /// <returns>The instance of the RegExBuilder class.</returns>
        public RegExBuilder Comment(string comment)
        {
            _regex.Append($"(?# {comment})");
            return this;
        }

        /// <summary>
        /// Converts the regular expression to a <see cref="Regex"/> object with the specified <see cref="RegexOptions"/>.
        /// </summary>
        /// <param name="options">The <see cref="RegexOptions"/> for the <see cref="Regex"/>.</param>
        /// <returns>A <see cref="Regex"/> object representing the regular expression.</returns>
        public Regex ToRegex(RegexOptions options)
        {
            return new Regex(ToString(), options);
        }

        /// <summary>
        /// Converts the regular expression to a <see cref="Regex"/> object with default options.
        /// </summary>
        /// <returns>A <see cref="Regex"/> object representing the regular expression.</returns>
        public Regex ToRegex()
        {
            return new Regex(ToString());
        }

        /// <summary>
        /// Builds the regular expression string.
        /// </summary>
        /// <returns>The regular expression string.</returns>
        public override string ToString()
        {
            return _regex.ToString();
        }
    }
}