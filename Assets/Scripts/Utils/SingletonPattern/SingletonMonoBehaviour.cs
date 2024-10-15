using Sirenix.Utilities;
using System.Linq;
using UnityEngine;

namespace Utils.SingletonPattern
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    var instances = FindObjectsByType<T>(FindObjectsSortMode.None);

                    if (instances.Length >= 1)
                    {
                        instances.Skip(1).ForEach(x => Destroy(x));
                        instance = instances.First();
                    }


                    if (instance == null)
                    {
                        GameObject obj = new GameObject();
                        obj.name = typeof(T).Name;
                        instance = obj.AddComponent<T>();
                    }
                }
                return instance;
            }
        }


    }
}