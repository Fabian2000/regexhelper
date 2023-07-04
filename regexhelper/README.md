# RegexHelper

RegexHelper is a C# library that helps developers create regular expressions (RegEx) with ease. It provides a clear and intuitive syntax for building RegEx patterns, along with preconfigured RegEx codes for commonly used scenarios.

## Features

- Fluent RegEx Builder: Use the `RegexBuilder` class to create RegEx patterns in a simple and readable manner.
- Preconfigured RegEx Codes: The `RegExPrepared` class contains a collection of predefined RegEx codes for typical use cases.
- Easy Installation: The project is based on .NET7 (C# 11) and can be installed via NuGet.
- Cross-Platform: The library is platform-independent and can be used in .NET applications on various operating systems.

## Usage

Use the `RegexBuilder` class to create RegEx patterns. Here's a simple example:

```csharp
var regex = new RegExBuilder()
    .Start()
    .Text("Hello")
    .WhiteSpace()
    .OneOrMoreOfLastExpression()
    .Text("World")
    .End()
    .ToRegex();

string input = "Hello     World";
bool isMatch = regex.IsMatch(input);

Console.WriteLine($"Input: {input}");
Console.WriteLine($"Is Match: {isMatch}");
Console.ReadKey(true);
```

For more examples and detailed information, please refer to the [documentation](https://github.com/Fabian2000/regexhelper).

## License

This project is licensed under the MIT License. For more information, see the [license file](https://github.com/Fabian2000/regexhelper/blob/main/LICENSE).
