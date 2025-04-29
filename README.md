# 📱 Old Mobile Phone Keypad Decoder

This project simulates typing text using an old-school mobile phone keypad, where each number corresponds to a group of letters (like on classic Nokia phones). Users input a string of digits representing key presses, and the program converts it into a message.

## 🚀 Features

- Supports key presses from `1` to `9` and `0`
- Handles repeated key presses to cycle through letters
- `*` acts as a backspace
- Returns the decoded message in uppercase

## 🔤 Keypad Mapping

| Key | Letters/Symbols         |
|-----|-------------------------|
| 1   | `&`, `'`, `(`           |
| 2   | `a`, `b`, `c`           |
| 3   | `d`, `e`, `f`           |
| 4   | `g`, `h`, `i`           |
| 5   | `j`, `k`, `l`           |
| 6   | `m`, `n`, `o`           |
| 7   | `p`, `q`, `r`, `s`      |
| 8   | `t`, `u`, `v`           |
| 9   | `w`, `x`, `y`, `z`      |
| 0   | (space)                 |
| *   | Backspace               |

## 🧪 Example Usage

```csharp
string input = "4433555*555666096667775553";
string result = OldMobilePhone.OldPhonePad(input);
Console.WriteLine(result); // Outputs: "HELLO WORLD"
```

## 🛠️ How It Works

- Repeated presses of the same key cycle through the available characters.
- When a different key is pressed, the cycle resets.
- Pressing `*` deletes the last character entered.

## 📄 License

This project is free to use and modify for educational or personal purposes.
