using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Game.Core
{
    public class CsvFileGameDataProvider : MonoBehaviour, IGameDataProvider
    {

        public string filePath;

        public List<Statement> GetStatements()
        {
            //1. Set the path when using the editor or the build in the web
#if UNITY_EDITOR
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/gamedata.csv";
#else
            filePath = Path.Combine(Application.dataPath, "..", "/gamedata.csv");
#endif
            //2. Check if the file exist
            if (File.Exists(filePath) == false)
            {
                //Copy from the resources a backup file
                
            }
                

            //3. Read the file
            using var fr = new StreamReader(filePath);

            while (fr.EndOfStream)
            {

            }

            return null;
        }


    }


}