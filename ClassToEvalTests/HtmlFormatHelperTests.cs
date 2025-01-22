using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassToEval;


namespace ClassToEvalTests
{

    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormat_WithString_ReturnStringBold()
        {
            var newHtmlFormat = new HtmlFormatHelper();

            var stringToBold = "Bonjour";

            var formatText = newHtmlFormat.GetBoldFormat(stringToBold);
        }

        [TestMethod]
        public void GetItalicFormat_WithString_ReturnStringItalic()
        {
            var newHtmlFormat = new HtmlFormatHelper();

            var stringToItalic = "Bonjour";

            var formatText = newHtmlFormat.GetItalicFormat(stringToItalic);
        }
    }
}
