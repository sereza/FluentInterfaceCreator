﻿using System;

namespace Engine.Models
{
    [Serializable]
    public class CallableMethodIndicator
    {
        public string Group { get; set; }
        public string Name { get; set; }
        public bool CanCall { get; set; }
        public string Signature { get; set; }
        public string DatatypeSignature { get; set; }

        public CallableMethodIndicator(Method method, bool canCall = false)
        {
            Group = method.Group.ToString();
            Name = method.Name;
            Signature = method.Signature;
            DatatypeSignature = method.DatatypeSignature;
            CanCall = canCall;
        }

        // For serialization
        private CallableMethodIndicator()
        {
        }
    }
}