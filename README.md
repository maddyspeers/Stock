<h1>📊 Stock Candlestick Pattern Recognizer</h1>

This Windows Forms application recognizes and annotates common single and multi-candlestick patterns from stock market data using the principles of abstraction, inheritance, and polymorphism in C#.# Stock

## 💡 Features

- 📈 Supports a variety of candlestick patterns:
  - **Single**: Doji, Hammer, Inverted Hammer, Dragonfly Doji, Gravestone Doji, Marubozu, Spinning Top, etc.
  - **Double/Triple**: Engulfing, Harami, Morning Star, Evening Star, etc.
- 🧠 Uses an **abstract base class** (`Recognizer`) to define pattern logic
- 🧩 Each pattern has its own **concrete recognizer class**
- 🎛️ **ComboBox (runtime-loaded)** for selecting patterns
- 🖍️ Pattern matches are highlighted on a stock chart
- 📂 Works with Yahoo Finance stock data (CSV)

---

## 🛠️ Technologies

- C# (.NET Framework)
- Windows Forms
- Object-Oriented Programming (Abstraction, Inheritance, Polymorphism)
- Custom Chart Annotations

---

## 🧩 How to Use

1. Open `Project 3.sln` in Visual Studio.
2. Run the app.
3. Load a `.csv` stock file from the `Stock Data` folder.
4. Select a pattern from the ComboBox (loaded at runtime).
5. Matches will be annotated on the chart.
   

---


## 🧪 Testing

✅ Confirmed to work with:
- Sample stock files from **Yahoo Finance**
- All patterns selectable from the ComboBox
- Annotations display correctly on the chart



