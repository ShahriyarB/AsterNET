﻿using System.Threading.Tasks;
using AsterSharp.Manager.Action;

namespace AsterSharp.Manager.Response
{
    /// <summary>
    ///     
    /// </summary>
    public class TaskResponseHandler : IResponseHandler
    {
        public TaskResponseHandler(ManagerAction action)
        {
            TaskCompletionSource = new TaskCompletionSource<ManagerResponse>(TaskCreationOptions.RunContinuationsAsynchronously);
            Action = action;
        }

        public TaskCompletionSource<ManagerResponse> TaskCompletionSource { get; }

        public ManagerAction Action { get; }

        public int Hash { get; set; }

        public void HandleResponse(ManagerResponse response)
        {
            TaskCompletionSource.TrySetResult(response);
        }

        public void Free() { }
    }
}
