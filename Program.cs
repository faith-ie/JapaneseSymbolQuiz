internal class Program
{
    private static int cAns = 0, wAns = 0;

    private static void Main()
    {
        Console.WriteLine("Welcome to the Japanese Symbol Quiz!");
        Console.WriteLine("Choose a mode:");
        Console.WriteLine("1. Hiragana");
        Console.WriteLine("2. Katakana");
        Console.WriteLine("3. Hiragana Syllables");
        Console.WriteLine("4. Katakana Syllables");
        QuizMode mode;
        while (!Enum.TryParse(Console.ReadLine(), out mode) || !Enum.IsDefined(typeof(QuizMode), mode))
        {
            Console.WriteLine("Invalid input. Choose a mode by entering one of the numbers listed above.");
        }

        Dictionary<string, string> symbols;
        string modeName;
        switch (mode)
        {
            case QuizMode.Hiragana:
                symbols = new Dictionary<string, string>()
                {
                    ["あ"] = "a",
                    ["い"] = "i",
                    ["う"] = "u",
                    ["え"] = "e",
                    ["お"] = "o",
                    ["か"] = "ka",
                    ["き"] = "ki",
                    ["く"] = "ku",
                    ["け"] = "ke",
                    ["こ"] = "ko",
                    ["さ"] = "sa",
                    ["し"] = "shi",
                    ["す"] = "su",
                    ["せ"] = "se",
                    ["そ"] = "so",
                    ["た"] = "ta",
                    ["ち"] = "chi",
                    ["つ"] = "tsu",
                    ["て"] = "te",
                    ["と"] = "to",
                    ["な"] = "na",
                    ["に"] = "ni",
                    ["ぬ"] = "nu",
                    ["ね"] = "ne",
                    ["の"] = "no",
                    ["は"] = "ha",
                    ["ひ"] = "hi",
                    ["ふ"] = "fu",
                    ["へ"] = "he",
                    ["ほ"] = "ho",
                    ["ま"] = "ma",
                    ["み"] = "mi",
                    ["む"] = "mu",
                    ["め"] = "me",
                    ["も"] = "mo",
                    ["や"] = "ya",
                    ["ゆ"] = "yu",
                    ["よ"] = "yo",
                    ["ら"] = "ra",
                    ["り"] = "ri",
                    ["る"] = "ru",
                    ["れ"] = "re",
                    ["ろ"] = "ro",
                    ["わ"] = "wa",
                    ["を"] = "wo",
                    ["ん"] = "n",
                    ["が"] = "ga",
                    ["ぎ"] = "gi",
                    ["ぐ"] = "gu",
                    ["げ"] = "ge",
                    ["ご"] = "go",
                    ["ざ"] = "za",
                    ["じ"] = "ji",
                    ["ず"] = "zu",
                    ["ぜ"] = "ze",
                    ["ぞ"] = "zo",
                    ["だ"] = "da",
                    ["ぢ"] = "ji",
                    ["づ"] = "zu",
                    ["で"] = "de",
                    ["ど"] = "do",
                    ["ば"] = "ba",
                    ["び"] = "bi",
                    ["ぶ"] = "bu",
                    ["べ"] = "be",
                    ["ぼ"] = "bo",
                    ["ぱ"] = "pa",
                    ["ぴ"] = "pi",
                    ["ぷ"] = "pu",
                    ["ぺ"] = "pe",
                    ["ぽ"] = "po"
                };
                modeName = "Hiragana";
                break;

            case QuizMode.Katakana:
                symbols = new Dictionary<string, string>()
                {
                    ["ア"] = "a",
                    ["イ"] = "i",
                    ["ウ"] = "u",
                    ["エ"] = "e",
                    ["オ"] = "o",
                    ["カ"] = "ka",
                    ["キ"] = "ki",
                    ["ク"] = "ku",
                    ["ケ"] = "ke",
                    ["コ"] = "ko",
                    ["サ"] = "sa",
                    ["シ"] = "shi",
                    ["ス"] = "su",
                    ["セ"] = "se",
                    ["ソ"] = "so",
                    ["タ"] = "ta",
                    ["チ"] = "chi",
                    ["ツ"] = "tsu",
                    ["テ"] = "te",
                    ["ト"] = "to",
                    ["ナ"] = "na",
                    ["ニ"] = "ni",
                    ["ヌ"] = "nu",
                    ["ネ"] = "ne",
                    ["ノ"] = "no",
                    ["ハ"] = "ha",
                    ["ヒ"] = "hi",
                    ["フ"] = "fu",
                    ["ヘ"] = "he",
                    ["ホ"] = "ho",
                    ["マ"] = "ma",
                    ["ミ"] = "mi",
                    ["ム"] = "mu",
                    ["メ"] = "me",
                    ["モ"] = "mo",
                    ["ヤ"] = "ya",
                    ["ユ"] = "yu",
                    ["ヨ"] = "yo",
                    ["ラ"] = "ra",
                    ["リ"] = "ri",
                    ["ル"] = "ru",
                    ["レ"] = "re",
                    ["ロ"] = "ro",
                    ["ワ"] = "wa",
                    ["ヲ"] = "wo",
                    ["ン"] = "n",
                    ["ガ"] = "ga",
                    ["ギ"] = "gi",
                    ["グ"] = "gu",
                    ["ゲ"] = "ge",
                    ["ゴ"] = "go",
                    ["ザ"] = "za",
                    ["ジ"] = "ji",
                    ["ズ"] = "zu",
                    ["ゼ"] = "ze",
                    ["ゾ"] = "zo",
                    ["ダ"] = "da",
                    ["ヂ"] = "ji",
                    ["ヅ"] = "zu",
                    ["デ"] = "de",
                    ["ド"] = "do",
                    ["バ"] = "ba",
                    ["ビ"] = "bi",
                    ["ブ"] = "bu",
                    ["ベ"] = "be",
                    ["ボ"] = "bo",
                    ["パ"] = "pa",
                    ["ピ"] = "pi",
                    ["プ"] = "pu",
                    ["ペ"] = "pe",
                    ["ポ"] = "po"
                };
                modeName = "Katakana";
                break;

            case QuizMode.HiraganaSyllables:
                symbols = new Dictionary<string, string>()
                {
                    ["きゃ"] = "kya",
                    ["きゅ"] = "kyu",
                    ["きょ"] = "kyo",
                    ["しゃ"] = "sha",
                    ["しゅ"] = "shu",
                    ["しょ"] = "sho",
                    ["ちゃ"] = "cha",
                    ["ちゅ"] = "chu",
                    ["ちょ"] = "cho",
                    ["にゃ"] = "nya",
                    ["にゅ"] = "nyu",
                    ["にょ"] = "nyo",
                    ["ひゃ"] = "hya",
                    ["ひゅ"] = "hyu",
                    ["ひょ"] = "hyo",
                    ["みゃ"] = "mya",
                    ["みゅ"] = "myu",
                    ["みょ"] = "myo",
                    ["りゃ"] = "rya",
                    ["りゅ"] = "ryu",
                    ["りょ"] = "ryo",
                    ["ぎゃ"] = "gya",
                    ["ぎゅ"] = "gyu",
                    ["ぎょ"] = "gyo",
                    ["じゃ"] = "ja",
                    ["じゅ"] = "ju",
                    ["じょ"] = "jo",
                    ["びゃ"] = "bya",
                    ["びゅ"] = "byu",
                    ["びょ"] = "byo",
                    ["ぴゃ"] = "pya",
                    ["ぴゅ"] = "pyu",
                    ["ぴょ"] = "pyo",
                    ["ぢゃ"] = "ja",
                    ["ぢゅ"] = "ju",
                    ["ぢょ"] = "jo",
                    ["ぢぃ"] = "ji",
                    ["ぢぇ"] = "je",
                    ["ふぁ"] = "fa",
                    ["ふぃ"] = "fi",
                    ["ふぇ"] = "fe",
                    ["ふぉ"] = "fo",
                    ["でゃ"] = "dya",
                    ["でぃ"] = "di",
                    ["でゅ"] = "dyu",
                    ["でょ"] = "dyo",
                    ["うぃ"] = "wi",
                    ["うぇ"] = "we",
                    ["うぉ"] = "wo",
                };
                modeName = "Hiragana Syllables";
                break;

            case QuizMode.KatakanaSyllables:
                symbols = new Dictionary<string, string>()
                {
                    ["キャ"] = "kya",
                    ["キュ"] = "kyu",
                    ["キョ"] = "kyo",
                    ["シャ"] = "sha",
                    ["シュ"] = "shu",
                    ["ショ"] = "sho",
                    ["チャ"] = "cha",
                    ["チュ"] = "chu",
                    ["チョ"] = "cho",
                    ["ニャ"] = "nya",
                    ["ニュ"] = "nyu",
                    ["ニョ"] = "nyo",
                    ["ヒャ"] = "hya",
                    ["ヒュ"] = "hyu",
                    ["ヒョ"] = "hyo",
                    ["ミャ"] = "mya",
                    ["ミュ"] = "myu",
                    ["ミョ"] = "myo",
                    ["リャ"] = "rya",
                    ["リュ"] = "ryu",
                    ["リョ"] = "ryo",
                    ["ギャ"] = "gya",
                    ["ギュ"] = "gyu",
                    ["ギョ"] = "gyo",
                    ["ジャ"] = "ja",
                    ["ジュ"] = "ju",
                    ["ジョ"] = "jo",
                    ["ビャ"] = "bya",
                    ["ビュ"] = "byu",
                    ["ビョ"] = "byo",
                    ["ピャ"] = "pya",
                    ["ピュ"] = "pyu",
                    ["ピョ"] = "pyo",
                    ["ヂャ"] = "ja",
                    ["ヂュ"] = "ju",
                    ["ヂョ"] = "jo",
                    ["ヂィ"] = "ji",
                    ["ヂェ"] = "je",
                    ["ファ"] = "fa",
                    ["フィ"] = "fi",
                    ["フェ"] = "fe",
                    ["フォ"] = "fo",
                    ["デャ"] = "dya",
                    ["ディ"] = "di",
                    ["デュ"] = "dyu",
                    ["デョ"] = "dyo",
                    ["ウィ"] = "wi",
                    ["ウェ"] = "we",
                    ["ウォ"] = "wo",
                };
                modeName = "Katakana Syllables";
                break;

            default:
                Console.WriteLine("Invalid mode. Please choose a valid mode.");
                return;
        }

        Console.WriteLine($"You have chosen {modeName} mode.");
        Console.WriteLine("Enter 'quit' to exit the quiz.");
        Random random = new();
        while (true)
        {
            var randomIndex = random.Next(symbols.Count);
            var symbol = symbols.Keys.ToArray()[randomIndex];
            var expectedAnswer = symbols[symbol];

            Console.WriteLine($"What is the romanized form of this symbol: {symbol}");
            var userAnswer = Console.ReadLine();

            if (userAnswer?.ToLower() == "quit")
            {
                Console.WriteLine("Quiz ended. Goodbye!");
                ShowScore();
                break;
            }

            if (userAnswer?.ToLower() == expectedAnswer)
            {
                Console.WriteLine("Correct!");
                cAns++;
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct answer is {expectedAnswer}.");
                wAns++;
            }

            Console.WriteLine();
        }
    }

    private static void ShowScore()
    {
        int totalQuestions = cAns + wAns;
        float totalScore = cAns / (float)totalQuestions;
        Console.WriteLine($"Correct Answers: {cAns}");
        Console.WriteLine($"Wrong Answers: {wAns}");
        Console.WriteLine($"Total Questions: {totalQuestions}");
        Console.WriteLine($"Percent Correct: {totalScore * 100}%");
    }
}

internal enum QuizMode
{
    Hiragana = 1,
    Katakana = 2,
    HiraganaSyllables = 3,
    KatakanaSyllables = 4
}