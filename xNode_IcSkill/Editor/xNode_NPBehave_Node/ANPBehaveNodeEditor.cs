﻿using System.Linq;
using CabinIcarus.IcSkillSystem.Runtime.Nodes;
using NPBehave;
using UnityEngine;

namespace CabinIcarus.IcSkillSystem.Editor.xNode_NPBehave_Node
{
    public abstract class ANPBehaveNodeEditor<T,AT>: ANPNodeEditor<T,AT> where T : ANPBehaveNode<AT> where AT : Node
    {
        protected override void ColorCheck()
        {
            var NPBNodeInputs = TNode.Inputs.Where(x => typeof(Node).IsAssignableFrom(x.ValueType));

            foreach (var nodePort in NPBNodeInputs)
            {
                if (!nodePort.IsConnected)
                {
                    Error = true;
                }
            }
        }
    }
}