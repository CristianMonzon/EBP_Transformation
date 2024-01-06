using LibTraitement.Domain;

namespace LibTraitement.Actions
{
    public class Numeration : BaseTransformation
    {

        public const int FORMAT = 5;

        /// <summary>
        /// Get the position of the text in format
        /// Ej : 00001
        /// </summary>
        public Numeration()
        {

        }

        public override void Transform()
        {
            //TODO. Chequear que el numero de filas sea menor a 9999
            if(!string.IsNullOrEmpty(this.OriginalText))
            {
                int numberLine = 1;
                for (int cont = 0; cont < base.OriginalTextList.Count; cont++)
                {
                    string format = numberLine.ToString().PadLeft(FORMAT, '0');
                    base.FinalTextList.Add(format);
                    numberLine++;
                }
            }

        }
    }
}
