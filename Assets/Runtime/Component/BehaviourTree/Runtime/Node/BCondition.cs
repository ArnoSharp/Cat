﻿/*
 * 条件节点无孩子
 */


namespace BehaviourTreeGeneric
{
    /// <summary>
    /// 条件节点
    /// </summary>
    public class BCondition : BNode
    {
        public BCondition()
            : base()
        {
            name = "Condition";
        }
    }
}