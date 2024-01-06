using LibTraitement.Domain;
using System.Linq;

namespace LibTraitement.Actions
{
    /// <summary>
    /// Invert the text
    /// </summary>
    public class Invertion : BaseTransformation
    {
        public Invertion()
        {

        }

        public override void Transform()
        {
            if (!string.IsNullOrEmpty(this.OriginalText))
            {
                for (int cont = 0; cont < base.OriginalTextList.Count; cont++)
                {
                    string stringReverse = new string(OriginalTextList[cont].ToString().ToCharArray().Reverse().ToArray());
                    base.FinalTextList.Add(stringReverse);
                }
            }
        }
    }
}
