using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/CoreModule/AudioType Value")]
    public partial class AudioTypeValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.AudioType _value;

        public override Type ValueType { get; } = typeof(UnityEngine.AudioType);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}