using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibTraitement.Domain
{
    public abstract class BaseTransformation : IBaseTransformation
    {
        /// <summary>
        /// Input Text
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// Convert Original Text in a list of element 
        /// </summary>
        protected List<String> OriginalTextList
        {
            get
            {
                if (OriginalText != null)
                {
                    string[] ArrayLines = OriginalText.Split(new string[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
                    return ArrayLines.ToList();
                }
                else
                {
                    return null;
                }
            }
        }


        private List<String> finalTextList;

        /// <summary>
        /// List of Final Texts
        /// </summary>
        public List<String> FinalTextList
        {
            get
            {
                if (finalTextList == null) finalTextList = new List<string>();
                return finalTextList;
            }
            set
            {
                finalTextList = value;
            }
        }

        /// <summary>
        /// Formated result
        /// </summary>
        public virtual string ResultFormatedText
        {
            get
            {
                StringBuilder response = new StringBuilder();
                
                if (FinalTextList != null && FinalTextList.Any()) {
                    int cont = 0;
                    foreach (string item in FinalTextList)
                    {
                        string text = string.Format("{0}->{1}{2}", OriginalTextList[cont], item, Environment.NewLine);
                        response.Append(text);
                        cont++;
                    }
                }
                return response.ToString();
            }
        }

        public abstract void Transform();

    }
}