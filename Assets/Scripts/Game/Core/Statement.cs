using System.Collections.Generic;
using UnityEngine;

namespace Game.Core
{
    /// <summary>
    /// Core class 
    /// </summary>
    public class Statement
    {
        
        public string nfr;

        public List<string> variables;

        public string variableFeedback;

        public List<string> value;

        public string valueFeedback;

        public List<string> recomendedValues;

        public string recomendedValuesFeedback;
    }
}