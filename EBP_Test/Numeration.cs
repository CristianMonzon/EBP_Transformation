using LibTraitement.Actions;
using LibTraitement.Business;
using LibTraitement.Domain;
using NUnit.Framework;
using System.Linq;

namespace EBP_Test
{
    public class NumerationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumerationText_ReturnsNumerationText()
        {
            //Arrange
            var traitement = new Traitement()
            {
                KeyName = EnumTypeTraitement.Numeration,
                BaseTransformation = new Numeration()
            };

            //act
            var baseTransf = BusinessTransformation.getClass(traitement);
            baseTransf.OriginalText = "ABC";
            baseTransf.Transform();

            string result = baseTransf.FinalTextList.First();
            string exceptedResult = "00001";

            //Assert
            Assert.IsTrue(result == exceptedResult);
        }

        [Test]
        public void NumerationTwoElementsText_ReturnsNumerationTwoElementsText()
        {
            //Arrange
            var traitement = new Traitement()
            {
                KeyName = EnumTypeTraitement.Numeration,
                BaseTransformation = new Numeration()
            };

            //act
            var baseTransf = BusinessTransformation.getClass(traitement);
            baseTransf.OriginalText = string.Concat("ABC","\n","ABC");
            baseTransf.Transform();

            string result1 = baseTransf.FinalTextList.First();
            string exceptedResult1 = "00001";


            string result2 = baseTransf.FinalTextList[1];
            string exceptedResult2 = "00002";

            //Assert
            Assert.IsTrue(result1 == exceptedResult1);
            Assert.IsTrue(result2 == exceptedResult2);
        }
    }
}