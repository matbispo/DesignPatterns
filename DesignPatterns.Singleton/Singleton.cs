using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton Instance = null;

        public static Singleton GetInstance 
        { 
            get
            {
                if (Instance == null)
                    Instance = new Singleton();
                return Instance;
            }               
        }
    }
}
