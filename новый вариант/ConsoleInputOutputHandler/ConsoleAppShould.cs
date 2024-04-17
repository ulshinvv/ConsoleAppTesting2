using ConsoleAppTesting;
namespace ConsoleInputOutputHandler
{
    [TestClass]
    public class ConsoleAppShould
    {
        [TestMethod]
        public void ReturnEmptyStringConst()
        {
            int input = 0;
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input.ToString()));
            Console.SetOut(output);

            // Act
            ConsoleAppTesting.Program.Main(new string[] { });

            // Assert
            Assert.AreEqual(expectedOutput, output.ToString());

        }

        [TestMethod]
        public void ReturnNegativeStringConst()
        {
            int x = -3;
            int y = -4;
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader($"{x}\n{y}\n"));
            Console.SetOut(output); 

            // Act
            ConsoleAppTesting.Program.Main(new string[] { });

            // Assert
            Assert.AreEqual(expectedOutput, output.ToString());

        }

        [TestMethod]
        public void ReturnSymbolsStringConst()
        {
            string input = "abc";
            string expectedOutput = "некорректный ввод" + Environment.NewLine;
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader(input.ToString()));
            Console.SetOut(output);

            // Act
            ConsoleAppTesting.Program.Main(new string[] { });

            // Assert
            Assert.AreEqual(expectedOutput, output.ToString());

        }

        [TestMethod]
        public void ReturnStringItselfWhenNotEmpty()
        {
            //Arrange
            int x = 3;
            int y = 4;
            string expectedOutput =  Environment.NewLine +
                                    "1 2 3 4 " + Environment.NewLine +
                                    "2 4 6 8 " + Environment.NewLine +
                                    "3 6 9 12 ";
            StringWriter output = new StringWriter();
            Console.SetIn(new StringReader($"{x}\n{y}\n"));
            Console.SetOut(output);

            ConsoleAppTesting.Program.Main(new string[] { });

            Assert.AreEqual(expectedOutput, output.ToString());

        }
    }
}