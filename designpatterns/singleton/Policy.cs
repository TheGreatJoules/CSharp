using System;

namespace Singleton
{
    public class Policy
    {
        private static Policy _instance;
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";
        public string GetInsuredName() => Insured;
        
        public Policy() {}
        public static Policy Instance
        {
            get {
                if (_instance == null)
                    _instance = new Policy();
                return _instance;
            }
        }
    }
}