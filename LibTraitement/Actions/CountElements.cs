using LibTraitement.Domain;

namespace LibTraitement.Actions
{
    /// <summary>
    /// Count number of caracters
    /// </summary>
    public class CountElments : BaseTransformation
    {
        public CountElments()
        {

        }

        public override void Transform()
        {
            if (!string.IsNullOrEmpty(this.OriginalText))
            {
                for (int cont = 0; cont < base.OriginalTextList.Count; cont++)
                {
                    string countElements = base.OriginalTextList[cont].Length.ToString();
                    base.FinalTextList.Add(countElements);
                }
            }
        }
    }
}