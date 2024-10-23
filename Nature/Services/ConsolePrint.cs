using Microsoft.CodeAnalysis.Text;

namespace Nature.Services
{
    public class ConsolePrint
    {
        /// <summary>
        /// <c>ConsolePrint</c>
        ///  färbt den Text in der Konsole farblich.
        ///  colorNumber kann Black=0, Red=1, Green=2, Blue=3, Yellow =4, Magenta=5, Cyan=6, White=7
        /// </summary>
        /// <param name="colorNumber">Datenyp: int, Bereich: 0-7 </param>
        /// <param name="message">Datentyp: string, Bereich: zu übergebene Nachricht</param>
        /// 
        public static void ConsoleColorMessage(int colorNumber, string message)
        {
            var AltvConsoleColors = Enum
                                    .GetValues(typeof(TextColor))
                                    .Cast<TextColor>()
                                    .Where(a => (int)a == (int)colorNumber)
                                    .Select(a => a.ToString())
                                    .ToList();

            foreach (var consoleColor in AltvConsoleColors)
            {
                switch (consoleColor)
                {
                    case "Black":
                        ColoredMessage BlackColor = new();
                        BlackColor += TextColor.Black;
                        BlackColor += message;
                        Alt.LogColored(BlackColor);
                        break;
                    case "Red":
                        ColoredMessage RedColor = new();
                        RedColor += TextColor.Red;
                        RedColor += message;
                        Alt.LogColored(RedColor);
                        break;
                    case "Green":
                        ColoredMessage GreenColor = new();
                        GreenColor += TextColor.Green;
                        GreenColor += message;
                        Alt.LogColored(GreenColor);
                        break;
                    case "Blue":
                        ColoredMessage BlueColor = new();
                        BlueColor += TextColor.Blue;
                        BlueColor += message;
                        Alt.LogColored(BlueColor);
                        break;
                    case "Yellow":
                        ColoredMessage YellowColor = new();
                        YellowColor += TextColor.Yellow;
                        YellowColor += message;
                        Alt.LogColored(YellowColor);
                        break;
                    case "Magenta":
                        ColoredMessage MagentaColor = new();
                        MagentaColor += TextColor.Magenta;
                        MagentaColor += message;
                        Alt.LogColored(MagentaColor);
                        break;
                    case "Cyan":
                        ColoredMessage CyanColor = new();
                        CyanColor += TextColor.Cyan;
                        CyanColor += message;
                        Alt.LogColored(CyanColor);
                        break;
                    case "White":
                        ColoredMessage WhiteColor = new();
                        WhiteColor += TextColor.White;
                        WhiteColor += message;
                        Alt.LogColored(WhiteColor);
                        break;

                    default:
                        Alt.LogError("Error: Die Farbe ist nicht vorhanden.");
                        break;
                }

            }
        }

        public static void ConsoleColorMessageMulti(int colorNumberOne, string messageOne, int colorNumberTwo, string messageTwo)
        {
            var AltvConsoleColorsOne = Enum
                                    .GetValues(typeof(TextColor))
                                    .Cast<TextColor>()
                                    .Where(a => (int)a == colorNumberOne)
                                    .Select(a => a.ToString())
                                    .ToList();

            var AltvConsoleColorsTwo = Enum
                                   .GetValues(typeof(TextColor))
                                   .Cast<TextColor>()
                                   .Where(a => (int)a == colorNumberTwo)
                                   .Select(a => a.ToString())
                                   .ToList();

            foreach (var consoleColor in AltvConsoleColorsOne)
            {
                ColoredMessage coloredMessageOne = new();
                switch (consoleColor)
                {
                    case "Black":
                        coloredMessageOne += TextColor.Black;
                        break;
                    case "Red":
                        coloredMessageOne += TextColor.Red;
                        break;
                    case "Green":
                        coloredMessageOne += TextColor.Green;
                        break;
                    case "Blue":
                        coloredMessageOne += TextColor.Blue;
                        break;
                    case "Yellow":
                        coloredMessageOne += TextColor.Yellow;
                        break;
                    case "Magenta":
                        coloredMessageOne += TextColor.Magenta;
                        break;
                    case "Cyan":
                        coloredMessageOne += TextColor.Cyan;
                        break;
                    case "White":
                        coloredMessageOne += TextColor.White;
                        break;
                    default:
                        Alt.LogError("Error: Die Farbe ist nicht vorhanden.");
                        return;
                }
              

                foreach (var consoleColorTwo in AltvConsoleColorsTwo)
                {
                    ColoredMessage coloredMessageTwo = new();
                    switch (consoleColorTwo)
                    {
                        case "Black":
                            coloredMessageTwo += TextColor.Black;
                            break;
                        case "Red":
                            coloredMessageTwo += TextColor.Red;
                            break;
                        case "Green":
                            coloredMessageTwo += TextColor.Green;
                            break;
                        case "Blue":
                            coloredMessageTwo += TextColor.Blue;
                            break;
                        case "Yellow":
                            coloredMessageTwo += TextColor.Yellow;
                            break;
                        case "Magenta":
                            coloredMessageTwo += TextColor.Magenta;
                            break;
                        case "Cyan":
                            coloredMessageTwo += TextColor.Cyan;
                            break;
                        case "White":
                            coloredMessageTwo += TextColor.White;
                            break;
                        default:
                            Alt.LogError("Error: Die Farbe ist nicht vorhanden.");
                            return;
                    }
                    coloredMessageOne += messageOne;
                    coloredMessageTwo += messageTwo;
                    Alt.LogColored(coloredMessageOne.ToString() + coloredMessageTwo.ToString());
                }
            }
        }
    }
}
