using LibTraitement.Actions;
using LibTraitement.Business;
using LibTraitement.Domain;
using NUnit.Framework;
using System.Linq;

namespace EBP_Test
{
    public class CountElementsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountElements_ReturnsCountElements()
        {
            //Arrange
            var traitement = new Traitement()
            {
                KeyName = EnumTypeTraitement.CountElments,
                BaseTransformation = new CountElments()
            };

            //act
            var baseTransf = BusinessTransformation.getClass(traitement);
            baseTransf.OriginalText = "ABC";
            baseTransf.Transform();

            string result = baseTransf.FinalTextList.First();
            string exceptedResult = "3";

            //Assert
            Assert.IsTrue(result == exceptedResult);
        }
    }
}