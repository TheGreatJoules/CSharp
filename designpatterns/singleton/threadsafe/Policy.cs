using System;

namespace Singleton
{
    public class Policy
    {
        private static readonly Policy _instance = new Policy();
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";
        public string GetInsuredName() => Insured;
        public Policy() {}
        public static Policy Instance {
            get {
                return _instance;
            }
        }
    }
}