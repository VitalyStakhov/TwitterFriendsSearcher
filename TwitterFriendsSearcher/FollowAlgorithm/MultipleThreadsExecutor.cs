﻿using System;
using System.Threading.Tasks;

namespace TwitterFriendsSearcher.FollowAlgorithm
{
    public class MultipleThreadsExecutor : ISearchExecutor
    {
        public void Execute(Action action)
        {
            action.BeginInvoke(null, null);
        }
    }
}