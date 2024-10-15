using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core
{
    public interface IGameDataProvider
    {
        public List<Statement> GetStatements();
    }
}