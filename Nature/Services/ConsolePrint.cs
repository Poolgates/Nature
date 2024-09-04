using AltV.Net;
using AltV.Net.ColoredConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
