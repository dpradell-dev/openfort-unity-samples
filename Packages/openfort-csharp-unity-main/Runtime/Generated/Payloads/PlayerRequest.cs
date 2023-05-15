
using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

namespace OpenfortSdk
{
    [Serializable]
    public partial class PlayerRequest
    {
        public string name;
        public string description;

        /// <summary>
        /// Empty constructor is for use in generics with where: new()
        /// </summary>
        public PlayerRequest()
        {
        }

        public PlayerRequest(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson(this);
        }
    }
}
