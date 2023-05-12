
using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

namespace OpenfortSdk
{
    [Serializable]
    public partial class AccountRequest
    {
        public int chain_id;
        public string player;

        /// <summary>
        /// Empty constructor is for use in generics with where: new()
        /// </summary>
        public AccountRequest()
        {
        }

        public AccountRequest(string player, int chain_id)
        {
            this.chain_id = chain_id;
            this.player = player;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson(this);
        }
    }
}
