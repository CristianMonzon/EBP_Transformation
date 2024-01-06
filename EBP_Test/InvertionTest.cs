using LibTraitement.Actions;
using LibTraitement.Business;
using LibTraitement.Domain;
using NUnit.Framework;
using System.Linq;

namespace EBP_Test
{
    public class InvertionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InvertText_ReturnsInvertionText()
        {
            //Arrange
            var traitement = new Traitement()
            {
                KeyName = EnumTypeTraitement.Invertion,
                BaseTransformation = new Invertion()
            };

            //act
            var baseTransf = BusinessTransformation.getClass(traitement);
            baseTransf.OriginalText = "ABC";
            baseTransf.Transform();

            string result = baseTransf.FinalTextList.First();
            string exceptedResult = "CBA";

            //Assert
            Assert.IsTrue(result == exceptedResult);
        }
    }
}