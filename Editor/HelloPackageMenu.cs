using UnityEngine;
using UnityEditor;
using Unity.HelloPackage;    

namespace Unity.HelloPackage.Editor
{
    
    public static class HelloPackageMenu 
    {
        [MenuItem("Tools/Hello Package/Log Hello")]

        public static void LogHelloMenu()
        {
            HelloPackage.LogHello();
        }
    }

}

