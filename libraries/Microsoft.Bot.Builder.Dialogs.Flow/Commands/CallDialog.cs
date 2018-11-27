﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;

namespace Microsoft.Bot.Builder.Dialogs.Flow
{
    /// <summary>
    /// Replace the current Dialog with another dialog as an action
    /// </summary>
    public class CallDialog : IDialogCommand
    {
        public CallDialog() { }

        public CallDialog(string dialogId) { this.DialogId = dialogId; }

        public string DialogId { get; set; }

        public Task<DialogTurnResult> Execute(DialogContext dialogContext, object options, DialogTurnResult result, CancellationToken cancellationToken)
        {
            var state = dialogContext.ActiveDialog.State;
            state["DialogTurnResult"] = result;
            return dialogContext.ReplaceDialogAsync(DialogId, null, cancellationToken);
        }
    }
}
